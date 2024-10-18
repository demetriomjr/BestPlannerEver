using client.LocalControllers;
using client.LocalModels;
using controllers;
using models.Entries;
using System.Windows.Forms;

namespace client.Records
{
    public partial class RecordsList : UserControl
    {
        private BindingSource recordsBs = new(), localSettings = new()
        {
            DataSource = new UISettings()
        };
        private List<Entry> records = new();
        private Entry originalState = null!;

        public RecordsList()
        {
            InitializeComponent();
            string a = "";
        }

        private void ReloadData()
        {
            var list = Controller.Records.GetList(null, out _);
            if (list is not null) records = list;
            Filter();
        }

        private void ResetSearch()
        {
            if (records is null) return;
            if (records.Count is 0) return;

            SearchBox.Text = string.Empty;
            SearchFromDateBox.Value = records.MinBy(x => x.Date)?.Date ?? DateTime.Today;
            SearchFromDateBox.Value = records.MaxBy(x => x.Date)?.Date ?? DateTime.Today;
            SearchCategoryBox.SelectedIndex = 0;
            SearchEntryTypeBox.SelectedIndex = 0;
            ReloadData();
        }

        private void Filter()
        {
            if (records is null) return;

            var filteredList = records.Where(x => x.Date!.Value.Date >= SearchFromDateBox.Value.Date && x.Date <= SearchToDateBox.Value.Date);
            string searchString = SearchBox.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                filteredList = filteredList.Where(x => (x.Description ?? "").Contains(searchString)
                                                    || (x.Observations ?? "").Contains(searchString)).ToList();
            }

            if (SearchCategoryBox.SelectedIndex > 0)
            {
                var category = (SearchCategoryBox.SelectedItem as EntryCategory)!;
                filteredList = filteredList.Where(x => x.Category.Equals(category.Id)).ToList();
            }

            if (SearchEntryTypeBox.SelectedIndex > 0)
            {
                var entryType = (SearchEntryTypeBox.SelectedItem as EntryType)!;
                filteredList = filteredList.Where(x => x.EntryType.Equals(entryType.Id)).ToList();
            }

            recordsBs.DataSource = filteredList.ToList();
        }

        private void RecordsList_Load(object sender, EventArgs e)
        {
            ReloadData();
            RecordsDatagrid.DataSource = recordsBs;

            BindControl([EditRecordButton, RecordsDatagrid, SearchGroupBox, SearchGroupBox, DetailsGroupBox, RecordsDatagrid, NewRecordButton,
                         DeleteRecordButton], localSettings, ["Enabled"], ["IsSingleOrNone", "IsViewMode"]);
            
            /*SearchGroupBox.DataBindings.Add("Enabled", localSettings, "IsViewMode", false, DataSourceUpdateMode.OnPropertyChanged);
            DetailsGroupBox.DataBindings.Add("Enabled", localSettings, "IsViewMode", false, DataSourceUpdateMode.OnPropertyChanged);

            RecordsDatagrid.DataBindings.Add("Enabled", localSettings, "IsViewMode", false, DataSourceUpdateMode.OnPropertyChanged);

            NewRecordButton.DataBindings.Add("Enabled", localSettings, "IsViewMode", false, DataSourceUpdateMode.OnPropertyChanged);
            EditRecordButton.DataBindings.Add("Enabled", localSettings, "IsSingleOrNone", false, DataSourceUpdateMode.OnPropertyChanged);
            DeleteRecordButton.DataBindings.Add("Enabled", localSettings, "IsViewMode", false, DataSourceUpdateMode.OnPropertyChanged);*/
            
            var categoryList = Controller.Records.Categories.GetList(null, true, out _);
            SearchCategoryBox.DataSource = categoryList;
            EntryCategoryTypeBox.DataSource = categoryList;
            SearchCategoryBox.DisplayMember = EntryCategoryTypeBox.DisplayMember = "Name";
            SearchCategoryBox.ValueMember = EntryCategoryTypeBox.ValueMember = "Id";

            var entryTypeList = Controller.Resources.EntryTypes(true);
            SearchEntryTypeBox.DataSource = entryTypeList;
            EntryEntryTypeBox.DataSource = entryTypeList;
            SearchEntryTypeBox.DisplayMember = EntryEntryTypeBox.DisplayMember = "Name";
            SearchEntryTypeBox.ValueMember = EntryEntryTypeBox.ValueMember = "Id";

            BindControl([EntryDateBox, EntryEntryTypeBox, EntryCategoryTypeBox, DescriptionBox,
                         ValueBox, ObservationsBox], recordsBs, ["Value", "SelectedValue", "Text"], ["Date", "EntryType", "Category",
                                                                 "Description", "Value", "Observations"]);
            /*EntryDateBox.DataBindings.Add("Value", recordsBs, "Date");
            EntryEntryTypeBox.DataBindings.Add("SelectedValue", recordsBs, "EntryType");
            EntryCategoryTypeBox.DataBindings.Add("SelectedValue", recordsBs, "Category");
            DescriptionBox.DataBindings.Add("Text", recordsBs, "Description");
            ValueBox.DataBindings.Add("Text", recordsBs, "Value", true);
            ObservationsBox.DataBindings.Add("Text", recordsBs, "Observations");*/
        }

        private void BindControl(Control[] controls, object datasource, string[] controlProperties, string[] objectProperties)
        {
            var count = Math.Min(controls.Count(), objectProperties.Count());
            for(int i = 0; i < count; i++)
            {
                var property = objectProperties[i] ?? objectProperties.Last();
                var control = controls[i] ?? controls.Last();
                
                foreach(var cProperty in controlProperties)
                {
                    var info = control.GetType().GetProperty(cProperty);

                    if (info is not null)
                    {
                        control.DataBindings.Add(cProperty, datasource, property, false, DataSourceUpdateMode.OnPropertyChanged);
                        break;
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Parent?.Controls.Clear();
            ResetSearch();
        }

        private void ClearFiltersButton_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void FilterAction(object sender, EventArgs e)
        {
            Filter();
        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            records.Add(new());
            RecordsDatagrid.ClearSelection();
            RecordsDatagrid[0, RecordsDatagrid.RowCount - 1].Selected = true;
            EditRecordButton_Click(sender, e);
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            if (RecordsDatagrid.CurrentRow is null) return;
            originalState = ((RecordsDatagrid.CurrentRow.DataBoundItem! as Entry)!.Clone() as Entry)!;
            (localSettings.DataSource as UISettings)!.IsViewMode = true;
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (RecordsDatagrid.RowCount is 0 || !DialogController.ConfirmDelete("Registro")) return;

            var item = RecordsDatagrid.CurrentRow!.DataBoundItem as Entry;

            if(!Controller.Records.DeleteItem(item!.Id, out var error))
            {
                MessageBox.Show(error);
                return;
            }

            records.Remove(item);
            Filter();
        }

        private void RecordsDatagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (localSettings.DataSource is null || (localSettings.DataSource as UISettings)!.IsViewMode) return;

            (localSettings.DataSource as UISettings)!.IsSingleOrNone = RecordsDatagrid.SelectedRows.Count > 1;
        }

        private void DetailSaveButton_Click(object sender, EventArgs e)
        {
            var item = RecordsDatagrid.CurrentRow!.DataBoundItem as Entry;
            if(!Controller.Records.Save(item!, out string error))
            {
                MessageBox.Show(error);
                return;
            }

            (localSettings.DataSource as UISettings)!.IsViewMode = false;
        }

        private void DetailsCancelButton_Click(object sender, EventArgs e)
        {
            var item = (RecordsDatagrid.CurrentRow!.DataBoundItem as Entry)!;
            records[records.IndexOf(item)] = originalState;
            Filter();
            (localSettings.DataSource as UISettings)!.IsViewMode = false;
        }
    }
}
