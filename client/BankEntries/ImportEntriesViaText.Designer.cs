namespace client.Records
{
    partial class ImportEntriesViaText
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            FlowTabControl = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            RawTextBox = new RichTextBox();
            groupBox2 = new GroupBox();
            CancelButton = new Button();
            panel4 = new Panel();
            ClearTextButton = new Button();
            panel1 = new Panel();
            NextTabButton = new Button();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            Cancel2Button = new Button();
            panel3 = new Panel();
            PreviousButton = new Button();
            panel2 = new Panel();
            SaveButton = new Button();
            FlowTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // FlowTabControl
            // 
            FlowTabControl.Controls.Add(tabPage1);
            FlowTabControl.Controls.Add(tabPage2);
            FlowTabControl.Dock = DockStyle.Fill;
            FlowTabControl.Location = new Point(0, 0);
            FlowTabControl.Name = "FlowTabControl";
            FlowTabControl.SelectedIndex = 0;
            FlowTabControl.Size = new Size(1281, 628);
            FlowTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1273, 600);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RawTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1267, 533);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Texto original";
            // 
            // RawTextBox
            // 
            RawTextBox.Dock = DockStyle.Fill;
            RawTextBox.Location = new Point(3, 19);
            RawTextBox.Name = "RawTextBox";
            RawTextBox.Size = new Size(1261, 511);
            RawTextBox.TabIndex = 0;
            RawTextBox.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CancelButton);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(ClearTextButton);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(NextTabButton);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 536);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(25, 3, 10, 10);
            groupBox2.Size = new Size(1267, 61);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Right;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.Image = Properties.Resources.closeIcon;
            CancelButton.ImageAlign = ContentAlignment.TopLeft;
            CancelButton.Location = new Point(871, 19);
            CancelButton.Name = "CancelButton";
            CancelButton.Padding = new Padding(10, 0, 0, 5);
            CancelButton.Size = new Size(122, 32);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancelar";
            CancelButton.TextAlign = ContentAlignment.BottomLeft;
            CancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(993, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 32);
            panel4.TabIndex = 15;
            // 
            // ClearTextButton
            // 
            ClearTextButton.Dock = DockStyle.Right;
            ClearTextButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ClearTextButton.Image = Properties.Resources.clearFiltersIcon;
            ClearTextButton.ImageAlign = ContentAlignment.TopLeft;
            ClearTextButton.Location = new Point(1003, 19);
            ClearTextButton.Name = "ClearTextButton";
            ClearTextButton.Padding = new Padding(10, 0, 0, 5);
            ClearTextButton.Size = new Size(122, 32);
            ClearTextButton.TabIndex = 12;
            ClearTextButton.Text = "Limpar Texto";
            ClearTextButton.TextAlign = ContentAlignment.BottomLeft;
            ClearTextButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ClearTextButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1125, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 32);
            panel1.TabIndex = 11;
            // 
            // NextTabButton
            // 
            NextTabButton.Dock = DockStyle.Right;
            NextTabButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NextTabButton.Image = Properties.Resources.nextPageIcon2;
            NextTabButton.ImageAlign = ContentAlignment.TopLeft;
            NextTabButton.Location = new Point(1135, 19);
            NextTabButton.Name = "NextTabButton";
            NextTabButton.Padding = new Padding(10, 0, 0, 5);
            NextTabButton.Size = new Size(122, 32);
            NextTabButton.TabIndex = 10;
            NextTabButton.Text = "Converter";
            NextTabButton.TextAlign = ContentAlignment.BottomLeft;
            NextTabButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NextTabButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1273, 600);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1267, 533);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Item convertidos do texto";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 5;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1261, 511);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Data";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 400;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Observações";
            Column5.Name = "Column5";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Cancel2Button);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(PreviousButton);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(SaveButton);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 536);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(25, 3, 10, 10);
            groupBox3.Size = new Size(1267, 61);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // Cancel2Button
            // 
            Cancel2Button.Dock = DockStyle.Right;
            Cancel2Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Cancel2Button.Image = Properties.Resources.closeIcon;
            Cancel2Button.ImageAlign = ContentAlignment.TopLeft;
            Cancel2Button.Location = new Point(871, 19);
            Cancel2Button.Name = "Cancel2Button";
            Cancel2Button.Padding = new Padding(10, 0, 0, 5);
            Cancel2Button.Size = new Size(122, 32);
            Cancel2Button.TabIndex = 14;
            Cancel2Button.Text = "Cancelar";
            Cancel2Button.TextAlign = ContentAlignment.BottomLeft;
            Cancel2Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Cancel2Button.UseVisualStyleBackColor = true;
            Cancel2Button.Click += CancelButton_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(993, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 32);
            panel3.TabIndex = 13;
            // 
            // PreviousButton
            // 
            PreviousButton.Dock = DockStyle.Right;
            PreviousButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PreviousButton.Image = Properties.Resources.previousPageIcon2;
            PreviousButton.ImageAlign = ContentAlignment.TopLeft;
            PreviousButton.Location = new Point(1003, 19);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new Padding(10, 0, 0, 5);
            PreviousButton.Size = new Size(122, 32);
            PreviousButton.TabIndex = 12;
            PreviousButton.Text = "Voltar";
            PreviousButton.TextAlign = ContentAlignment.BottomLeft;
            PreviousButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1125, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 32);
            panel2.TabIndex = 11;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Right;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Image = Properties.Resources.saveItemIcon;
            SaveButton.ImageAlign = ContentAlignment.TopLeft;
            SaveButton.Location = new Point(1135, 19);
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new Padding(10, 0, 0, 5);
            SaveButton.Size = new Size(122, 32);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Salvar";
            SaveButton.TextAlign = ContentAlignment.BottomCenter;
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // ImportEntriesViaText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowTabControl);
            Name = "ImportEntriesViaText";
            Size = new Size(1281, 628);
            Load += ImportEntriesViaText_Load;
            FlowTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl FlowTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private RichTextBox RawTextBox;
        private GroupBox groupBox2;
        private Button ClearTextButton;
        private Panel panel1;
        private Button NextTabButton;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button PreviousButton;
        private Panel panel2;
        private Button SaveButton;
        private Button CancelButton;
        private Panel panel4;
        private Button Cancel2Button;
        private Panel panel3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
