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

            FlowTabControl.SelectedIndex += 1;
        }
    }
}
