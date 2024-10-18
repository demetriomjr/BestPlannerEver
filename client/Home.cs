using client.Records;

namespace client
{
    public partial class Home : Form
    {
        private Dictionary<string, UserControl> controls = new Dictionary<string, UserControl>();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            controls.Add(nameof(BankEntriesList), new BankEntriesList());

            foreach (var control in controls.Values)
            {
                control.BackColor = SystemColors.Control;
                control.Dock = DockStyle.Fill;
            }

        }

        private void OpenControl(UserControl control)
        {
            ContainerPanel.Controls.Clear();
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
            OpenControl(controls[nameof(BankEntriesList)]);
        }
    }
}
