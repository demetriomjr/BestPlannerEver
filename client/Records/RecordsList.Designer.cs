namespace client.Records
{
    partial class RecordsList
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
            SearchGroupBox = new GroupBox();
            panel11 = new Panel();
            ClearFiltersButton = new Button();
            SearchCategoryBox = new ComboBox();
            label11 = new Label();
            SearchEntryTypeBox = new ComboBox();
            label9 = new Label();
            panel10 = new Panel();
            label5 = new Label();
            SearchFromDateBox = new DateTimePicker();
            label8 = new Label();
            SearchToDateBox = new DateTimePicker();
            SearchBox = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            DeleteRecordButton = new Button();
            panel12 = new Panel();
            EditRecordButton = new Button();
            panel2 = new Panel();
            CloseButton = new Button();
            NewRecordButton = new Button();
            groupBox3 = new GroupBox();
            RecordsDatagrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            DetailsGroupBox = new GroupBox();
            panel8 = new Panel();
            ObservationsBox = new TextBox();
            label6 = new Label();
            panel9 = new Panel();
            panel6 = new Panel();
            DetailSaveButton = new Button();
            panel7 = new Panel();
            DetailsCancelButton = new Button();
            panel4 = new Panel();
            label3 = new Label();
            ValueBox = new TextBox();
            DescriptionBox = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            EntryCategoryTypeBox = new ComboBox();
            label10 = new Label();
            EntryEntryTypeBox = new ComboBox();
            label2 = new Label();
            EntryDateBox = new DateTimePicker();
            label1 = new Label();
            SearchGroupBox.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RecordsDatagrid).BeginInit();
            panel1.SuspendLayout();
            DetailsGroupBox.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(panel11);
            SearchGroupBox.Controls.Add(panel10);
            SearchGroupBox.Dock = DockStyle.Top;
            SearchGroupBox.Location = new Point(15, 5);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(1046, 97);
            SearchGroupBox.TabIndex = 0;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Pesquisa";
            // 
            // panel11
            // 
            panel11.Controls.Add(ClearFiltersButton);
            panel11.Controls.Add(SearchCategoryBox);
            panel11.Controls.Add(label11);
            panel11.Controls.Add(SearchEntryTypeBox);
            panel11.Controls.Add(label9);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(3, 43);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 5, 20, 3);
            panel11.Size = new Size(1040, 37);
            panel11.TabIndex = 7;
            // 
            // ClearFiltersButton
            // 
            ClearFiltersButton.Dock = DockStyle.Right;
            ClearFiltersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ClearFiltersButton.Image = Properties.Resources.clearFiltersIcon;
            ClearFiltersButton.ImageAlign = ContentAlignment.TopLeft;
            ClearFiltersButton.Location = new Point(898, 5);
            ClearFiltersButton.Name = "ClearFiltersButton";
            ClearFiltersButton.Padding = new Padding(10, 0, 0, 5);
            ClearFiltersButton.Size = new Size(122, 29);
            ClearFiltersButton.TabIndex = 9;
            ClearFiltersButton.Text = "Limpar Filtros";
            ClearFiltersButton.TextAlign = ContentAlignment.BottomLeft;
            ClearFiltersButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ClearFiltersButton.UseVisualStyleBackColor = true;
            ClearFiltersButton.Click += ClearFiltersButton_Click;
            // 
            // SearchCategoryBox
            // 
            SearchCategoryBox.Dock = DockStyle.Left;
            SearchCategoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchCategoryBox.FormattingEnabled = true;
            SearchCategoryBox.Location = new Point(324, 5);
            SearchCategoryBox.Name = "SearchCategoryBox";
            SearchCategoryBox.Size = new Size(158, 23);
            SearchCategoryBox.TabIndex = 7;
            SearchCategoryBox.DropDownClosed += FilterAction;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Left;
            label11.Location = new Point(240, 5);
            label11.Name = "label11";
            label11.Size = new Size(84, 29);
            label11.TabIndex = 6;
            label11.Text = "Categoria";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SearchEntryTypeBox
            // 
            SearchEntryTypeBox.Dock = DockStyle.Left;
            SearchEntryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchEntryTypeBox.FormattingEnabled = true;
            SearchEntryTypeBox.Location = new Point(110, 5);
            SearchEntryTypeBox.Name = "SearchEntryTypeBox";
            SearchEntryTypeBox.Size = new Size(130, 23);
            SearchEntryTypeBox.TabIndex = 4;
            SearchEntryTypeBox.DropDownClosed += FilterAction;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Left;
            label9.Location = new Point(20, 5);
            label9.Name = "label9";
            label9.Size = new Size(90, 29);
            label9.TabIndex = 2;
            label9.Text = "Tipo Transação";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Controls.Add(SearchFromDateBox);
            panel10.Controls.Add(label8);
            panel10.Controls.Add(SearchToDateBox);
            panel10.Controls.Add(SearchBox);
            panel10.Controls.Add(label7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(3, 19);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 0, 20, 0);
            panel10.Size = new Size(1040, 24);
            panel10.TabIndex = 6;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.Location = new Point(752, 0);
            label5.Name = "label5";
            label5.Size = new Size(33, 24);
            label5.TabIndex = 6;
            label5.Text = "De";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SearchFromDateBox
            // 
            SearchFromDateBox.Dock = DockStyle.Right;
            SearchFromDateBox.Format = DateTimePickerFormat.Short;
            SearchFromDateBox.Location = new Point(785, 0);
            SearchFromDateBox.Name = "SearchFromDateBox";
            SearchFromDateBox.Size = new Size(102, 23);
            SearchFromDateBox.TabIndex = 5;
            SearchFromDateBox.ValueChanged += FilterAction;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(887, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 24);
            label8.TabIndex = 4;
            label8.Text = "até ";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SearchToDateBox
            // 
            SearchToDateBox.Dock = DockStyle.Right;
            SearchToDateBox.Format = DateTimePickerFormat.Short;
            SearchToDateBox.Location = new Point(918, 0);
            SearchToDateBox.Name = "SearchToDateBox";
            SearchToDateBox.Size = new Size(102, 23);
            SearchToDateBox.TabIndex = 3;
            SearchToDateBox.ValueChanged += FilterAction;
            // 
            // SearchBox
            // 
            SearchBox.Dock = DockStyle.Left;
            SearchBox.Location = new Point(110, 0);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(642, 23);
            SearchBox.TabIndex = 1;
            SearchBox.TextChanged += FilterAction;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(20, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 24);
            label7.TabIndex = 0;
            label7.Text = "Buscar";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DeleteRecordButton);
            groupBox2.Controls.Add(panel12);
            groupBox2.Controls.Add(EditRecordButton);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(CloseButton);
            groupBox2.Controls.Add(NewRecordButton);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(906, 102);
            groupBox2.Margin = new Padding(8, 3, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 15, 10, 10);
            groupBox2.Size = new Size(155, 541);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Funções";
            // 
            // DeleteRecordButton
            // 
            DeleteRecordButton.Dock = DockStyle.Top;
            DeleteRecordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeleteRecordButton.Image = Properties.Resources.deleteItemIcon;
            DeleteRecordButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteRecordButton.Location = new Point(10, 107);
            DeleteRecordButton.Name = "DeleteRecordButton";
            DeleteRecordButton.Padding = new Padding(10, 0, 0, 0);
            DeleteRecordButton.Size = new Size(135, 30);
            DeleteRecordButton.TabIndex = 6;
            DeleteRecordButton.Text = "Exluir";
            DeleteRecordButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteRecordButton.UseVisualStyleBackColor = true;
            DeleteRecordButton.Click += DeleteRecordButton_Click;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(10, 99);
            panel12.Name = "panel12";
            panel12.Size = new Size(135, 8);
            panel12.TabIndex = 5;
            // 
            // EditRecordButton
            // 
            EditRecordButton.Dock = DockStyle.Top;
            EditRecordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EditRecordButton.Image = Properties.Resources.editItemIcon;
            EditRecordButton.ImageAlign = ContentAlignment.MiddleLeft;
            EditRecordButton.Location = new Point(10, 69);
            EditRecordButton.Name = "EditRecordButton";
            EditRecordButton.Padding = new Padding(10, 0, 0, 0);
            EditRecordButton.Size = new Size(135, 30);
            EditRecordButton.TabIndex = 4;
            EditRecordButton.Text = "Editar";
            EditRecordButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditRecordButton.UseVisualStyleBackColor = true;
            EditRecordButton.Click += EditRecordButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(135, 8);
            panel2.TabIndex = 3;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Bottom;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CloseButton.Image = Properties.Resources.closeIcon;
            CloseButton.ImageAlign = ContentAlignment.MiddleLeft;
            CloseButton.Location = new Point(10, 501);
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new Padding(10, 0, 0, 0);
            CloseButton.Size = new Size(135, 30);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Fechar";
            CloseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // NewRecordButton
            // 
            NewRecordButton.Dock = DockStyle.Top;
            NewRecordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NewRecordButton.Image = Properties.Resources.newItemIcon;
            NewRecordButton.ImageAlign = ContentAlignment.MiddleLeft;
            NewRecordButton.Location = new Point(10, 31);
            NewRecordButton.Name = "NewRecordButton";
            NewRecordButton.Padding = new Padding(10, 0, 0, 0);
            NewRecordButton.Size = new Size(135, 30);
            NewRecordButton.TabIndex = 1;
            NewRecordButton.Text = "Novo Registro";
            NewRecordButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            NewRecordButton.UseVisualStyleBackColor = true;
            NewRecordButton.Click += NewRecordButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(RecordsDatagrid);
            groupBox3.Location = new Point(5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(876, 379);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista";
            // 
            // RecordsDatagrid
            // 
            RecordsDatagrid.AllowUserToAddRows = false;
            RecordsDatagrid.AllowUserToDeleteRows = false;
            RecordsDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecordsDatagrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            RecordsDatagrid.Dock = DockStyle.Fill;
            RecordsDatagrid.Location = new Point(5, 21);
            RecordsDatagrid.Name = "RecordsDatagrid";
            RecordsDatagrid.ReadOnly = true;
            RecordsDatagrid.RowHeadersWidth = 5;
            RecordsDatagrid.ScrollBars = ScrollBars.Vertical;
            RecordsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecordsDatagrid.Size = new Size(866, 353);
            RecordsDatagrid.TabIndex = 0;
            RecordsDatagrid.SelectionChanged += RecordsDatagrid_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Data";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo Transação";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Descrição";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Valor";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(DetailsGroupBox);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(15, 102);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 5, 0);
            panel1.Size = new Size(891, 541);
            panel1.TabIndex = 3;
            // 
            // DetailsGroupBox
            // 
            DetailsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DetailsGroupBox.Controls.Add(panel8);
            DetailsGroupBox.Controls.Add(panel9);
            DetailsGroupBox.Controls.Add(panel6);
            DetailsGroupBox.Controls.Add(panel4);
            DetailsGroupBox.Controls.Add(panel5);
            DetailsGroupBox.Controls.Add(panel3);
            DetailsGroupBox.Location = new Point(7, 384);
            DetailsGroupBox.Name = "DetailsGroupBox";
            DetailsGroupBox.Padding = new Padding(8, 5, 8, 5);
            DetailsGroupBox.Size = new Size(872, 157);
            DetailsGroupBox.TabIndex = 3;
            DetailsGroupBox.TabStop = false;
            DetailsGroupBox.Text = "Detalhes";
            // 
            // panel8
            // 
            panel8.Controls.Add(ObservationsBox);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(8, 83);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(35, 0, 35, 0);
            panel8.Size = new Size(856, 24);
            panel8.TabIndex = 9;
            // 
            // ObservationsBox
            // 
            ObservationsBox.Dock = DockStyle.Left;
            ObservationsBox.Location = new Point(111, 0);
            ObservationsBox.Name = "ObservationsBox";
            ObservationsBox.Size = new Size(710, 23);
            ObservationsBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(35, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 0;
            label6.Text = "Observações";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(8, 78);
            panel9.Name = "panel9";
            panel9.Size = new Size(856, 5);
            panel9.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(DetailSaveButton);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(DetailsCancelButton);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(8, 112);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(856, 40);
            panel6.TabIndex = 6;
            // 
            // DetailSaveButton
            // 
            DetailSaveButton.Dock = DockStyle.Right;
            DetailSaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DetailSaveButton.Image = Properties.Resources.saveItemIcon;
            DetailSaveButton.ImageAlign = ContentAlignment.MiddleLeft;
            DetailSaveButton.Location = new Point(639, 5);
            DetailSaveButton.Name = "DetailSaveButton";
            DetailSaveButton.Padding = new Padding(10, 0, 0, 0);
            DetailSaveButton.Size = new Size(101, 30);
            DetailSaveButton.TabIndex = 5;
            DetailSaveButton.Text = "Salvar";
            DetailSaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DetailSaveButton.UseVisualStyleBackColor = true;
            DetailSaveButton.Click += DetailSaveButton_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(740, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 30);
            panel7.TabIndex = 4;
            // 
            // DetailsCancelButton
            // 
            DetailsCancelButton.Dock = DockStyle.Right;
            DetailsCancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DetailsCancelButton.Image = Properties.Resources.undoItemIcon;
            DetailsCancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            DetailsCancelButton.Location = new Point(750, 5);
            DetailsCancelButton.Name = "DetailsCancelButton";
            DetailsCancelButton.Padding = new Padding(10, 0, 0, 0);
            DetailsCancelButton.Size = new Size(101, 30);
            DetailsCancelButton.TabIndex = 2;
            DetailsCancelButton.Text = "Cancelar";
            DetailsCancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DetailsCancelButton.UseVisualStyleBackColor = true;
            DetailsCancelButton.Click += DetailsCancelButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ValueBox);
            panel4.Controls.Add(DescriptionBox);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(8, 54);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(35, 0, 35, 0);
            panel4.Size = new Size(856, 24);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(687, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 24);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ValueBox
            // 
            ValueBox.Dock = DockStyle.Right;
            ValueBox.Location = new Point(727, 0);
            ValueBox.Name = "ValueBox";
            ValueBox.Size = new Size(94, 23);
            ValueBox.TabIndex = 3;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Dock = DockStyle.Left;
            DescriptionBox.Location = new Point(111, 0);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(570, 23);
            DescriptionBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(35, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 24);
            label4.TabIndex = 0;
            label4.Text = "Descrição";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(8, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(856, 5);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(EntryCategoryTypeBox);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(EntryEntryTypeBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(EntryDateBox);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(8, 21);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(35, 5, 35, 0);
            panel3.Size = new Size(856, 28);
            panel3.TabIndex = 0;
            // 
            // EntryCategoryTypeBox
            // 
            EntryCategoryTypeBox.Dock = DockStyle.Left;
            EntryCategoryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EntryCategoryTypeBox.FormattingEnabled = true;
            EntryCategoryTypeBox.Location = new Point(506, 5);
            EntryCategoryTypeBox.Name = "EntryCategoryTypeBox";
            EntryCategoryTypeBox.Size = new Size(175, 23);
            EntryCategoryTypeBox.TabIndex = 5;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Left;
            label10.Location = new Point(439, 5);
            label10.Name = "label10";
            label10.Size = new Size(67, 23);
            label10.TabIndex = 4;
            label10.Text = "Categoria";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EntryEntryTypeBox
            // 
            EntryEntryTypeBox.Dock = DockStyle.Left;
            EntryEntryTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EntryEntryTypeBox.FormattingEnabled = true;
            EntryEntryTypeBox.Location = new Point(309, 5);
            EntryEntryTypeBox.Name = "EntryEntryTypeBox";
            EntryEntryTypeBox.Size = new Size(130, 23);
            EntryEntryTypeBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(213, 5);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 2;
            label2.Text = "Tipo Transação";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EntryDateBox
            // 
            EntryDateBox.Dock = DockStyle.Left;
            EntryDateBox.Format = DateTimePickerFormat.Short;
            EntryDateBox.Location = new Point(111, 5);
            EntryDateBox.Name = "EntryDateBox";
            EntryDateBox.Size = new Size(102, 23);
            EntryDateBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(35, 5);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "Data";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RecordsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(SearchGroupBox);
            Name = "RecordsList";
            Padding = new Padding(15, 5, 15, 5);
            Size = new Size(1076, 648);
            Load += RecordsList_Load;
            SearchGroupBox.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RecordsDatagrid).EndInit();
            panel1.ResumeLayout(false);
            DetailsGroupBox.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SearchGroupBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView RecordsDatagrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel1;
        private Button NewRecordButton;
        private Button CloseButton;
        private Button EditRecordButton;
        private Panel panel2;
        private GroupBox DetailsGroupBox;
        private Panel panel3;
        private Label label2;
        private DateTimePicker EntryDateBox;
        private Label label1;
        private Panel panel5;
        private ComboBox EntryEntryTypeBox;
        private Panel panel4;
        private Label label3;
        private TextBox ValueBox;
        private TextBox DescriptionBox;
        private Label label4;
        private Panel panel6;
        private Button DetailSaveButton;
        private Panel panel7;
        private Button DetailsCancelButton;
        private Panel panel8;
        private TextBox ObservationsBox;
        private Label label6;
        private Panel panel9;
        private Panel panel11;
        private Label label9;
        private Panel panel10;
        private Label label5;
        private DateTimePicker SearchFromDateBox;
        private Label label8;
        private DateTimePicker SearchToDateBox;
        private TextBox SearchBox;
        private Label label7;
        private ComboBox EntryCategoryTypeBox;
        private Label label10;
        private ComboBox SearchCategoryBox;
        private Label label11;
        private ComboBox SearchEntryTypeBox;
        private Button ClearFiltersButton;
        private Button DeleteRecordButton;
        private Panel panel12;
    }
}
