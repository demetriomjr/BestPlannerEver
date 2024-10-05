namespace client
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            ExportButton = new Button();
            panel12 = new Panel();
            SettingsButton = new Button();
            panel4 = new Panel();
            ExitButton = new Button();
            panel2 = new Panel();
            ImportButton = new Button();
            panel3 = new Panel();
            RecordsButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ContainerPanel = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 96);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(ExportButton);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(200, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(100, 96);
            panel5.TabIndex = 12;
            // 
            // ExportButton
            // 
            ExportButton.BackColor = SystemColors.ButtonFace;
            ExportButton.Dock = DockStyle.Fill;
            ExportButton.Image = Properties.Resources.exportItemIcon;
            ExportButton.Location = new Point(5, 5);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(90, 86);
            ExportButton.TabIndex = 0;
            ExportButton.Text = "Exportar";
            ExportButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ExportButton.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(SettingsButton);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(1017, 0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(5);
            panel12.Size = new Size(126, 96);
            panel12.TabIndex = 11;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = SystemColors.ButtonFace;
            SettingsButton.Dock = DockStyle.Fill;
            SettingsButton.Image = Properties.Resources.settingsIcon;
            SettingsButton.Location = new Point(5, 5);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(116, 86);
            SettingsButton.TabIndex = 0;
            SettingsButton.Text = "Configurações";
            SettingsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(ExitButton);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1143, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 5, 10, 5);
            panel4.Size = new Size(119, 96);
            panel4.TabIndex = 3;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.ButtonFace;
            ExitButton.Dock = DockStyle.Fill;
            ExitButton.Image = Properties.Resources.exitIcon;
            ExitButton.Location = new Point(5, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(104, 86);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Sair";
            ExitButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ImportButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(100, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(100, 96);
            panel2.TabIndex = 2;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = SystemColors.ButtonFace;
            ImportButton.Dock = DockStyle.Fill;
            ImportButton.Image = Properties.Resources.inportItemIcon;
            ImportButton.Location = new Point(5, 5);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(90, 86);
            ImportButton.TabIndex = 0;
            ImportButton.Text = "Importar";
            ImportButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ImportButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(RecordsButton);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 5, 5, 5);
            panel3.Size = new Size(100, 96);
            panel3.TabIndex = 1;
            // 
            // RecordsButton
            // 
            RecordsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RecordsButton.BackColor = SystemColors.ButtonFace;
            RecordsButton.Dock = DockStyle.Fill;
            RecordsButton.Image = Properties.Resources.recordsIcon;
            RecordsButton.ImageAlign = ContentAlignment.TopCenter;
            RecordsButton.Location = new Point(10, 5);
            RecordsButton.Name = "RecordsButton";
            RecordsButton.Size = new Size(85, 86);
            RecordsButton.TabIndex = 0;
            RecordsButton.Text = "Registros";
            RecordsButton.TextAlign = ContentAlignment.BottomCenter;
            RecordsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RecordsButton.UseVisualStyleBackColor = false;
            RecordsButton.Click += RecordsButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 96);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1262, 3);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ContainerPanel
            // 
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(0, 99);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(1262, 557);
            ContainerPanel.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1262, 656);
            Controls.Add(ContainerPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Best Planner Ever";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ImportButton;
        private Panel panel3;
        private Button RecordsButton;
        private Panel panel12;
        private Button SettingsButton;
        private Panel panel4;
        private Button ExitButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel ContainerPanel;
        private Panel panel5;
        private Button ExportButton;
    }
}
