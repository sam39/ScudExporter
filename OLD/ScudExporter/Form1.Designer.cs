namespace ScudExporter
{
    partial class Form1
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label start_DateLabel;
            System.Windows.Forms.Label excludedLabel;
            System.Windows.Forms.Label password_UsrLabel;
            this.ExportEventsBtn = new System.Windows.Forms.Button();
            this.ExportEmpBtn = new System.Windows.Forms.Button();
            this.dist_pathTextBox = new System.Windows.Forms.TextBox();
            this.end_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.start_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDstDirectory = new System.Windows.Forms.Button();
            this.excludedTextBox = new System.Windows.Forms.TextBox();
            this.doorZonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doorZonesDataGridView = new System.Windows.Forms.DataGridView();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.password_UsrTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dist_pathLabel = new System.Windows.Forms.Label();
            end_DateLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            start_DateLabel = new System.Windows.Forms.Label();
            excludedLabel = new System.Windows.Forms.Label();
            password_UsrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doorZonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorZonesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dist_pathLabel
            // 
            dist_pathLabel.AutoSize = true;
            dist_pathLabel.Location = new System.Drawing.Point(18, 32);
            dist_pathLabel.Name = "dist_pathLabel";
            dist_pathLabel.Size = new System.Drawing.Size(102, 13);
            dist_pathLabel.TabIndex = 3;
            dist_pathLabel.Text = "Каталог выгрузки:";
            // 
            // end_DateLabel
            // 
            end_DateLabel.AutoSize = true;
            end_DateLabel.Location = new System.Drawing.Point(28, 87);
            end_DateLabel.Name = "end_DateLabel";
            end_DateLabel.Size = new System.Drawing.Size(92, 13);
            end_DateLabel.TabIndex = 5;
            end_DateLabel.Text = "Дата окончания:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(72, 112);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(48, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Пароль:";
            // 
            // start_DateLabel
            // 
            start_DateLabel.AutoSize = true;
            start_DateLabel.Location = new System.Drawing.Point(46, 61);
            start_DateLabel.Name = "start_DateLabel";
            start_DateLabel.Size = new System.Drawing.Size(74, 13);
            start_DateLabel.TabIndex = 9;
            start_DateLabel.Text = "Дата начала:";
            // 
            // excludedLabel
            // 
            excludedLabel.AutoSize = true;
            excludedLabel.Location = new System.Drawing.Point(47, 161);
            excludedLabel.Name = "excludedLabel";
            excludedLabel.Size = new System.Drawing.Size(73, 13);
            excludedLabel.TabIndex = 12;
            excludedLabel.Text = "Исключения:";
            // 
            // ExportEventsBtn
            // 
            this.ExportEventsBtn.Location = new System.Drawing.Point(165, 346);
            this.ExportEventsBtn.Name = "ExportEventsBtn";
            this.ExportEventsBtn.Size = new System.Drawing.Size(98, 37);
            this.ExportEventsBtn.TabIndex = 0;
            this.ExportEventsBtn.Text = "выгрузка событий";
            this.ExportEventsBtn.UseVisualStyleBackColor = true;
            this.ExportEventsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportEmpBtn
            // 
            this.ExportEmpBtn.Location = new System.Drawing.Point(37, 346);
            this.ExportEmpBtn.Name = "ExportEmpBtn";
            this.ExportEmpBtn.Size = new System.Drawing.Size(109, 37);
            this.ExportEmpBtn.TabIndex = 1;
            this.ExportEmpBtn.Text = "выгрузка сотрудников";
            this.ExportEmpBtn.UseVisualStyleBackColor = true;
            this.ExportEmpBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dist_pathTextBox
            // 
            this.dist_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Dist_path", true));
            this.dist_pathTextBox.Location = new System.Drawing.Point(124, 29);
            this.dist_pathTextBox.Name = "dist_pathTextBox";
            this.dist_pathTextBox.Size = new System.Drawing.Size(200, 20);
            this.dist_pathTextBox.TabIndex = 4;
            // 
            // end_DateDateTimePicker
            // 
            this.end_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsBindingSource, "End_Date", true));
            this.end_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_DateDateTimePicker.Location = new System.Drawing.Point(124, 83);
            this.end_DateDateTimePicker.Name = "end_DateDateTimePicker";
            this.end_DateDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.end_DateDateTimePicker.TabIndex = 6;
            this.end_DateDateTimePicker.Leave += new System.EventHandler(this.end_DateDateTimePicker_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(124, 109);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // start_DateDateTimePicker
            // 
            this.start_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsBindingSource, "Start_Date", true));
            this.start_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_DateDateTimePicker.Location = new System.Drawing.Point(124, 57);
            this.start_DateDateTimePicker.Name = "start_DateDateTimePicker";
            this.start_DateDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.start_DateDateTimePicker.TabIndex = 10;
            this.start_DateDateTimePicker.Leave += new System.EventHandler(this.start_DateDateTimePicker_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDstDirectory
            // 
            this.btnDstDirectory.Location = new System.Drawing.Point(329, 27);
            this.btnDstDirectory.Name = "btnDstDirectory";
            this.btnDstDirectory.Size = new System.Drawing.Size(29, 24);
            this.btnDstDirectory.TabIndex = 12;
            this.btnDstDirectory.Text = "...";
            this.btnDstDirectory.UseVisualStyleBackColor = true;
            this.btnDstDirectory.Click += new System.EventHandler(this.btnDstDirectory_Click);
            // 
            // excludedTextBox
            // 
            this.excludedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Excluded", true));
            this.excludedTextBox.Location = new System.Drawing.Point(124, 158);
            this.excludedTextBox.Name = "excludedTextBox";
            this.excludedTextBox.Size = new System.Drawing.Size(200, 20);
            this.excludedTextBox.TabIndex = 13;
            // 
            // doorZonesBindingSource
            // 
            this.doorZonesBindingSource.DataMember = "DoorZones";
            this.doorZonesBindingSource.DataSource = this.settingsBindingSource;
            // 
            // doorZonesDataGridView
            // 
            this.doorZonesDataGridView.AutoGenerateColumns = false;
            this.doorZonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doorZonesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.doorZonesDataGridView.DataSource = this.doorZonesBindingSource;
            this.doorZonesDataGridView.Location = new System.Drawing.Point(106, 185);
            this.doorZonesDataGridView.Name = "doorZonesDataGridView";
            this.doorZonesDataGridView.Size = new System.Drawing.Size(247, 140);
            this.doorZonesDataGridView.TabIndex = 14;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(ScudExporter.BL.Settings);
            // 
            // password_UsrLabel
            // 
            password_UsrLabel.AutoSize = true;
            password_UsrLabel.Location = new System.Drawing.Point(43, 136);
            password_UsrLabel.Name = "password_UsrLabel";
            password_UsrLabel.Size = new System.Drawing.Size(75, 13);
            password_UsrLabel.TabIndex = 15;
            password_UsrLabel.Text = "Password Usr:";
            // 
            // password_UsrTextBox
            // 
            this.password_UsrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Password_Usr", true));
            this.password_UsrTextBox.Location = new System.Drawing.Point(124, 133);
            this.password_UsrTextBox.Name = "password_UsrTextBox";
            this.password_UsrTextBox.Size = new System.Drawing.Size(200, 20);
            this.password_UsrTextBox.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Door_Index";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идекс двери";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Zone_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Индекс зоны";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 403);
            this.Controls.Add(password_UsrLabel);
            this.Controls.Add(this.password_UsrTextBox);
            this.Controls.Add(this.doorZonesDataGridView);
            this.Controls.Add(excludedLabel);
            this.Controls.Add(this.excludedTextBox);
            this.Controls.Add(this.btnDstDirectory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(dist_pathLabel);
            this.Controls.Add(this.dist_pathTextBox);
            this.Controls.Add(end_DateLabel);
            this.Controls.Add(this.end_DateDateTimePicker);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(start_DateLabel);
            this.Controls.Add(this.start_DateDateTimePicker);
            this.Controls.Add(this.ExportEmpBtn);
            this.Controls.Add(this.ExportEventsBtn);
            this.Name = "Form1";
            this.Text = "Выгрузка из СКУД";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doorZonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorZonesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportEventsBtn;
        private System.Windows.Forms.Button ExportEmpBtn;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.TextBox dist_pathTextBox;
        private System.Windows.Forms.DateTimePicker end_DateDateTimePicker;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DateTimePicker start_DateDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDstDirectory;
        private System.Windows.Forms.TextBox excludedTextBox;
        private System.Windows.Forms.BindingSource doorZonesBindingSource;
        private System.Windows.Forms.DataGridView doorZonesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox password_UsrTextBox;
    }
}

