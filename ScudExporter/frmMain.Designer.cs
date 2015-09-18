namespace ScudExporter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dist_pathLabel;
            System.Windows.Forms.Label end_DateLabel;
            System.Windows.Forms.Label start_DateLabel;
            System.Windows.Forms.Label label1;
            this.btnEvensRep = new System.Windows.Forms.Button();
            this.btnDstDirectory = new System.Windows.Forms.Button();
            this.dist_pathTextBox = new System.Windows.Forms.TextBox();
            this.end_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doorZonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divisionDataGridView = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DivName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbCleanSearch = new System.Windows.Forms.Button();
            this.labelSelected = new System.Windows.Forms.Label();
            dist_pathLabel = new System.Windows.Forms.Label();
            end_DateLabel = new System.Windows.Forms.Label();
            start_DateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doorZonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dist_pathLabel
            // 
            dist_pathLabel.AutoSize = true;
            dist_pathLabel.Location = new System.Drawing.Point(13, 47);
            dist_pathLabel.Name = "dist_pathLabel";
            dist_pathLabel.Size = new System.Drawing.Size(102, 13);
            dist_pathLabel.TabIndex = 22;
            dist_pathLabel.Text = "Каталог выгрузки:";
            // 
            // end_DateLabel
            // 
            end_DateLabel.AutoSize = true;
            end_DateLabel.Location = new System.Drawing.Point(23, 101);
            end_DateLabel.Name = "end_DateLabel";
            end_DateLabel.Size = new System.Drawing.Size(92, 13);
            end_DateLabel.TabIndex = 24;
            end_DateLabel.Text = "Дата окончания:";
            // 
            // start_DateLabel
            // 
            start_DateLabel.AutoSize = true;
            start_DateLabel.Location = new System.Drawing.Point(41, 75);
            start_DateLabel.Name = "start_DateLabel";
            start_DateLabel.Size = new System.Drawing.Size(74, 13);
            start_DateLabel.TabIndex = 26;
            start_DateLabel.Text = "Дата начала:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(355, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 13);
            label1.TabIndex = 22;
            label1.Text = "Поиск:";
            // 
            // btnEvensRep
            // 
            this.btnEvensRep.Location = new System.Drawing.Point(273, 120);
            this.btnEvensRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvensRep.Name = "btnEvensRep";
            this.btnEvensRep.Size = new System.Drawing.Size(56, 24);
            this.btnEvensRep.TabIndex = 0;
            this.btnEvensRep.Text = "Старт";
            this.btnEvensRep.UseVisualStyleBackColor = true;
            this.btnEvensRep.Click += new System.EventHandler(this.btnEvensRep_Click_1);
            // 
            // btnDstDirectory
            // 
            this.btnDstDirectory.Location = new System.Drawing.Point(290, 43);
            this.btnDstDirectory.Name = "btnDstDirectory";
            this.btnDstDirectory.Size = new System.Drawing.Size(29, 24);
            this.btnDstDirectory.TabIndex = 28;
            this.btnDstDirectory.Text = "...";
            this.btnDstDirectory.UseVisualStyleBackColor = true;
            this.btnDstDirectory.Click += new System.EventHandler(this.btnDstDirectory_Click);
            // 
            // dist_pathTextBox
            // 
            this.dist_pathTextBox.Location = new System.Drawing.Point(119, 45);
            this.dist_pathTextBox.Name = "dist_pathTextBox";
            this.dist_pathTextBox.Size = new System.Drawing.Size(165, 20);
            this.dist_pathTextBox.TabIndex = 23;
            // 
            // end_DateDateTimePicker
            // 
            this.end_DateDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.end_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_DateDateTimePicker.Location = new System.Drawing.Point(119, 97);
            this.end_DateDateTimePicker.Name = "end_DateDateTimePicker";
            this.end_DateDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.end_DateDateTimePicker.TabIndex = 25;
            // 
            // start_DateDateTimePicker
            // 
            this.start_DateDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.start_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_DateDateTimePicker.Location = new System.Drawing.Point(119, 71);
            this.start_DateDateTimePicker.Name = "start_DateDateTimePicker";
            this.start_DateDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.start_DateDateTimePicker.TabIndex = 27;
            // 
            // doorZonesBindingSource
            // 
            this.doorZonesBindingSource.DataMember = "DoorZones";
            this.doorZonesBindingSource.DataSource = this.settingsBindingSource;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(ScudExporter.BL.Settings);
            // 
            // divisionDataGridView
            // 
            this.divisionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.divisionDataGridView.AutoGenerateColumns = false;
            this.divisionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divisionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.dataGridViewTextBoxColumn2});
            this.divisionDataGridView.DataSource = this.divisionBindingSource;
            this.divisionDataGridView.Location = new System.Drawing.Point(22, 159);
            this.divisionDataGridView.Name = "divisionDataGridView";
            this.divisionDataGridView.Size = new System.Drawing.Size(320, 284);
            this.divisionDataGridView.TabIndex = 30;
            this.divisionDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.divisionDataGridView_CellValueChanged);
            // 
            // Chk
            // 
            this.Chk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Chk.DataPropertyName = "Chk";
            this.Chk.HeaderText = "";
            this.Chk.Name = "Chk";
            this.Chk.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Подразделение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // divisionBindingSource
            // 
            this.divisionBindingSource.AllowNew = false;
            this.divisionBindingSource.DataSource = typeof(ScudExporter.BL.Division);
            // 
            // empDataGridView
            // 
            this.empDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empDataGridView.AutoGenerateColumns = false;
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.nameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.midNameDataGridViewTextBoxColumn,
            this.tabNumberDataGridViewTextBoxColumn,
            this.DivName});
            this.empDataGridView.DataSource = this.empBindingSource;
            this.empDataGridView.Location = new System.Drawing.Point(347, 50);
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.Size = new System.Drawing.Size(673, 394);
            this.empDataGridView.TabIndex = 31;
            this.empDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDataGridView_CellValueChanged);
            // 
            // Checked
            // 
            this.Checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Checked.DataPropertyName = "Chk";
            this.Checked.HeaderText = "";
            this.Checked.Name = "Checked";
            this.Checked.Width = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 81;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 54;
            // 
            // midNameDataGridViewTextBoxColumn
            // 
            this.midNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.midNameDataGridViewTextBoxColumn.DataPropertyName = "MidName";
            this.midNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.midNameDataGridViewTextBoxColumn.Name = "midNameDataGridViewTextBoxColumn";
            this.midNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // tabNumberDataGridViewTextBoxColumn
            // 
            this.tabNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tabNumberDataGridViewTextBoxColumn.DataPropertyName = "TabNumber";
            this.tabNumberDataGridViewTextBoxColumn.HeaderText = "Таб. номер";
            this.tabNumberDataGridViewTextBoxColumn.Name = "tabNumberDataGridViewTextBoxColumn";
            this.tabNumberDataGridViewTextBoxColumn.Width = 89;
            // 
            // DivName
            // 
            this.DivName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DivName.DataPropertyName = "DivName";
            this.DivName.HeaderText = "Подразделение";
            this.DivName.Name = "DivName";
            this.DivName.ReadOnly = true;
            // 
            // empBindingSource
            // 
            this.empBindingSource.AllowNew = false;
            this.empBindingSource.DataSource = typeof(ScudExporter.BL.Emp);
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Location = new System.Drawing.Point(119, 122);
            this.comboBoxReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(146, 21);
            this.comboBoxReports.TabIndex = 32;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(398, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(193, 20);
            this.tbSearch.TabIndex = 23;
            // 
            // tbCleanSearch
            // 
            this.tbCleanSearch.Location = new System.Drawing.Point(593, 18);
            this.tbCleanSearch.Name = "tbCleanSearch";
            this.tbCleanSearch.Size = new System.Drawing.Size(21, 21);
            this.tbCleanSearch.TabIndex = 33;
            this.tbCleanSearch.Text = "X";
            this.tbCleanSearch.UseVisualStyleBackColor = true;
            this.tbCleanSearch.Click += new System.EventHandler(this.tbCleanSearch_Click);
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(355, 451);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(64, 13);
            this.labelSelected.TabIndex = 34;
            this.labelSelected.Text = "Выбрано: 0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 470);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.tbCleanSearch);
            this.Controls.Add(this.comboBoxReports);
            this.Controls.Add(this.empDataGridView);
            this.Controls.Add(this.divisionDataGridView);
            this.Controls.Add(this.btnDstDirectory);
            this.Controls.Add(label1);
            this.Controls.Add(dist_pathLabel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dist_pathTextBox);
            this.Controls.Add(end_DateLabel);
            this.Controls.Add(this.end_DateDateTimePicker);
            this.Controls.Add(start_DateLabel);
            this.Controls.Add(this.start_DateDateTimePicker);
            this.Controls.Add(this.btnEvensRep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Информация из СКУД";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doorZonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvensRep;
        private System.Windows.Forms.Button btnDstDirectory;
        private System.Windows.Forms.TextBox dist_pathTextBox;
        private System.Windows.Forms.DateTimePicker end_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker start_DateDateTimePicker;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.BindingSource doorZonesBindingSource;
        private System.Windows.Forms.BindingSource empBindingSource;
        private System.Windows.Forms.BindingSource divisionBindingSource;
        private System.Windows.Forms.DataGridView divisionDataGridView;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DivName;
        private System.Windows.Forms.Button tbCleanSearch;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}