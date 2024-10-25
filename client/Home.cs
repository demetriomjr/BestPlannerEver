using client.Records;

namespace client
{
    public partial class Home : Form
    {
        public Dictionary<string, UserControl> userControls = new Dictionary<string, UserControl>();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            userControls.Add(nameof(BankEntriesList), new BankEntriesList());
            userControls.Add(nameof(ImportEntriesViaText), new ImportEntriesViaText());

            foreach (var control in userControls.Values)
            {
                control.BackColor = SystemColors.Control;
                control.Dock = DockStyle.Fill;
            }

        }

        public void OpenControl(UserControl control)
        {
            control.Visible = !control.Visible;
            ContainerPanel.Controls.Add(control);
            control.Visible = !control.Visible;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }
        private void BankEntriesButton_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            OpenControl(userControls[nameof(BankEntriesList)]);
        }
    }
}
