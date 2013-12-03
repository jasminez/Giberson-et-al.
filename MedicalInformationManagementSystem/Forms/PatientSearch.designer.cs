namespace HealthInformaticSystem
{
    partial class PatientSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.cm_Options = new System.Windows.Forms.ComboBox();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giveMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchPatientByIdDataSet = new HealthInformaticSystem.SearchPatientByIdDataSet();
            this.getPatientByIdTableAdapter = new HealthInformaticSystem.SearchPatientByIdDataSetTableAdapters.GetPatientByIdTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giveMiddleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientByNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchPatientByNameDataSet = new HealthInformaticSystem.SearchPatientByNameDataSet();
            this.getPatientByNameTableAdapter = new HealthInformaticSystem.SearchPatientByNameDataSetTableAdapters.GetPatientByNameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientByIdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientByNameDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(496, 40);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Enabled = false;
            this.lbl_Date.ForeColor = System.Drawing.Color.Red;
            this.lbl_Date.Location = new System.Drawing.Point(259, 61);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(83, 13);
            this.lbl_Date.TabIndex = 13;
            this.lbl_Date.Text = "Eg : 2013-10-12";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(262, 38);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(121, 20);
            this.txt_Output.TabIndex = 12;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(25, 40);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(65, 13);
            this.lbl_Search.TabIndex = 11;
            this.lbl_Search.Text = "Search By";
            // 
            // cm_Options
            // 
            this.cm_Options.FormattingEnabled = true;
            this.cm_Options.Items.AddRange(new object[] {
            "",
            "ID ",
            "NAME"});
            this.cm_Options.Location = new System.Drawing.Point(125, 37);
            this.cm_Options.Name = "cm_Options";
            this.cm_Options.Size = new System.Drawing.Size(121, 21);
            this.cm_Options.TabIndex = 10;
            this.cm_Options.SelectedIndexChanged += new System.EventHandler(this.cm_Options_SelectedIndexChanged);
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.Enabled = false;
            this.btn_SearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchPatient.Location = new System.Drawing.Point(400, 40);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchPatient.TabIndex = 9;
            this.btn_SearchPatient.Text = "Search";
            this.btn_SearchPatient.UseVisualStyleBackColor = true;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.giveMiddleNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getPatientByIdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(666, 342);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giveMiddleNameDataGridViewTextBoxColumn
            // 
            this.giveMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "giveMiddleName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveMiddleNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.giveMiddleNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.giveMiddleNameDataGridViewTextBoxColumn.Name = "giveMiddleNameDataGridViewTextBoxColumn";
            this.giveMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getPatientByIdBindingSource
            // 
            this.getPatientByIdBindingSource.DataMember = "GetPatientById";
            this.getPatientByIdBindingSource.DataSource = this.searchPatientByIdDataSet;
            // 
            // searchPatientByIdDataSet
            // 
            this.searchPatientByIdDataSet.DataSetName = "SearchPatientByIdDataSet";
            this.searchPatientByIdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientByIdTableAdapter
            // 
            this.getPatientByIdTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.giveMiddleNameDataGridViewTextBoxColumn1,
            this.dateOfBirthDataGridViewTextBoxColumn1,
            this.genderDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.getPatientByNameBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Location = new System.Drawing.Point(12, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(666, 306);
            this.dataGridView2.TabIndex = 17;
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            this.patientIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // giveMiddleNameDataGridViewTextBoxColumn1
            // 
            this.giveMiddleNameDataGridViewTextBoxColumn1.DataPropertyName = "giveMiddleName";
            this.giveMiddleNameDataGridViewTextBoxColumn1.HeaderText = "First Name ";
            this.giveMiddleNameDataGridViewTextBoxColumn1.Name = "giveMiddleNameDataGridViewTextBoxColumn1";
            this.giveMiddleNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn1
            // 
            this.dateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn1.HeaderText = "DOB";
            this.dateOfBirthDataGridViewTextBoxColumn1.Name = "dateOfBirthDataGridViewTextBoxColumn1";
            this.dateOfBirthDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // getPatientByNameBindingSource
            // 
            this.getPatientByNameBindingSource.DataMember = "GetPatientByName";
            this.getPatientByNameBindingSource.DataSource = this.searchPatientByNameDataSet;
            // 
            // searchPatientByNameDataSet
            // 
            this.searchPatientByNameDataSet.DataSetName = "SearchPatientByNameDataSet";
            this.searchPatientByNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientByNameTableAdapter
            // 
            this.getPatientByNameTableAdapter.ClearBeforeFill = true;
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 499);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.cm_Options);
            this.Controls.Add(this.btn_SearchPatient);
            this.Name = "PatientSearch";
            this.Text = "PatientSearch";
            this.Load += new System.EventHandler(this.PatientSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientByIdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientByNameDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ComboBox cm_Options;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getPatientByIdBindingSource;
        private SearchPatientByIdDataSet searchPatientByIdDataSet;
        private SearchPatientByIdDataSetTableAdapters.GetPatientByIdTableAdapter getPatientByIdTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource getPatientByNameBindingSource;
        private SearchPatientByNameDataSet searchPatientByNameDataSet;
        private SearchPatientByNameDataSetTableAdapters.GetPatientByNameTableAdapter getPatientByNameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giveMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giveMiddleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
    }
}