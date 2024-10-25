namespace client.Records
{
    public partial class ImportEntriesViaText : UserControl
    {
        public ImportEntriesViaText()
        {
            InitializeComponent();
        }

        private void ImportEntriesViaText_Load(object sender, EventArgs e)
        {
            FlowTabControl.Appearance = TabAppearance.FlatButtons;
            FlowTabControl.ItemSize = new Size(0, 1);
            FlowTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void NextTabButton_Click(object sender, EventArgs e)
        {
            try
            {
                var list = Controller.BankEntries.TryConvertFromText(InputBox.Text, out _);

                if (list is null)
                    return;

                ImportedItemsDatagrid.DataSource = new BindingSource() { DataSource = list };
                FlowTabControl.SelectedIndex += 1;
            }
            catch (Exception)
            {
                if (Debugger.IsAttached)
                    throw;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Parent!.Controls[0].Visible = true;
            Parent.Controls.Remove(this);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            FlowTabControl.SelectedIndex -= 1;
        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            if (!DialogController.ClearData())
                return;

            InputBox.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!DialogController.ConfirmImport())
                return;

            var result = new List<BankEntry>();

            var bindingSource = ImportedItemsDatagrid?.DataSource as BindingSource;
            if (bindingSource != null && bindingSource.DataSource is List<BankEntry> importedItems)
            {
                try
                {
                    var dateList = importedItems.Select(x => x.EntryDate).Distinct().ToList();
                    var dbList = Controller.BankEntries.GetList(x => dateList.Contains(x.EntryDate), out string error);

                    foreach(var item in importedItems)
                    {
                        var dbMatch = dbList.FirstOrDefault(x => x.EntryDate.Equals(item.EntryDate));
                        if (dbMatch is null && !dbMatch!.CurrencyValue.Equals(item.CurrencyValue))
                            result.Add(item);
                        else continue;
                    }

                    if(Controller.BankEntries.Save(result, out string saveError))
                    {
                        MessageBox.Show(saveError);
                        return;
                    }

                    MessageBox.Show("Itens Salvos!");
                    ClearTextButton_Click(sender, e);
                    FlowTabControl.SelectedIndex = 0;
                    CancelButton_Click(sender, e);
                }
                catch (Exception)
                {
                    if(Debugger.IsAttached)
                        throw;
                }
            }

        }
    }
}
