namespace client.Records
{
    public partial class BankEntriesList : UserControl
    {
        private record Settings()
        {
            public bool IsViewMode { get; set; } = true;
            public bool IsSingleOrNone { get; set; } = true;
        }

        private Settings localSettings = new();
        private BindingSource recordsBs = new();
        private List<BankEntry> records = new();
        private BankEntry originalState = null!;
        private Control[] stateControls;
        public BankEntriesList()
        {
            InitializeComponent();
            stateControls = [EditRecordButton, RecordsDatagrid, SearchGroupBox, DetailsGroupBox,
                        RecordsDatagrid, NewRecordButton, DeleteRecordButton];
        }

        private void ReloadData()
        {
            var list = Controller.BankEntries.GetList(null, out _);
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

            var categoryList = Controller.BankEntries.Categories.GetList(null, true, out _);
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

            UpdateStateControls();
        }

        private void BindControl(Control[] controls, object datasource, string[] controlProperties, string[] objectProperties)
        {
            var count = Math.Min(controls.Count(), objectProperties.Count());
            for (int i = 0; i < count; i++)
            {
                var property = objectProperties[i] ?? objectProperties.Last();
                var control = controls[i] ?? controls.Last();

                foreach (var cProperty in controlProperties)
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

        private void UpdateStateControls()
        {
            foreach (var control in stateControls)
            {
                if (control.Name.Equals(EditRecordButton.Name))
                    control.Enabled = localSettings.IsSingleOrNone;
                else if (control.Name.Equals(DetailsGroupBox.Name))
                    control.Enabled = !localSettings.IsViewMode;
                else control.Enabled = localSettings.IsViewMode;
                control.Refresh();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Parent?.Controls.Remove(this);
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
            originalState = ((RecordsDatagrid.CurrentRow.DataBoundItem! as BankEntry)!.Clone() as BankEntry)!;
            (localSettings as Settings)!.IsViewMode = true;
            UpdateStateControls();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (RecordsDatagrid.RowCount is 0 || !DialogController.ConfirmDelete("Registro")) return;

            var item = RecordsDatagrid.CurrentRow!.DataBoundItem as BankEntry;

            if (!Controller.BankEntries.DeleteItem(item!.Id, out var error))
            {
                MessageBox.Show(error);
                return;
            }

            records.Remove(item);
            UpdateStateControls();
            Filter();
        }

        private void RecordsDatagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (localSettings is null || (localSettings as Settings)!.IsViewMode) return;

            (localSettings as Settings)!.IsSingleOrNone = RecordsDatagrid.SelectedRows.Count > 1;

            UpdateStateControls();
        }

        private void DetailSaveButton_Click(object sender, EventArgs e)
        {
            var item = RecordsDatagrid.CurrentRow!.DataBoundItem as BankEntry;
            if (!Controller.BankEntries.Save(item!, out string error))
            {
                MessageBox.Show(error);
                return;
            }

            (localSettings as Settings)!.IsViewMode = false;
            UpdateStateControls();
        }

        private void DetailsCancelButton_Click(object sender, EventArgs e)
        {
            if (RecordsDatagrid.CurrentRow is null) return;
            var item = (RecordsDatagrid.CurrentRow!.DataBoundItem as BankEntry)!;
            records[records.IndexOf(item)] = originalState;
            Filter();
            (localSettings as Settings)!.IsViewMode = false;
            UpdateStateControls();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            if(Parent is Panel parentPanel)
                if(parentPanel.Parent is Home parent)
                    parent.OpenControl(parent.userControls[nameof(ImportEntriesViaText)]);
        }
    }
}
