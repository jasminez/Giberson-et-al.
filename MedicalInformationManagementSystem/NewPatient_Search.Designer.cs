namespace HealthInformaticSystem
{
    partial class NewPatient_Search
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
            this.btn_CreatePatient = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.cm_Options = new System.Windows.Forms.ComboBox();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreatePatient
            // 
            this.btn_CreatePatient.Enabled = false;
            this.btn_CreatePatient.Location = new System.Drawing.Point(503, 141);
            this.btn_CreatePatient.Name = "btn_CreatePatient";
            this.btn_CreatePatient.Size = new System.Drawing.Size(117, 23);
            this.btn_CreatePatient.TabIndex = 16;
            this.btn_CreatePatient.Text = "Create New Patient";
            this.btn_CreatePatient.UseVisualStyleBackColor = true;
            this.btn_CreatePatient.Click += new System.EventHandler(this.btn_CreatePatient_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(533, 96);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Enabled = false;
            this.lbl_Date.ForeColor = System.Drawing.Color.Red;
            this.lbl_Date.Location = new System.Drawing.Point(296, 117);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(83, 13);
            this.lbl_Date.TabIndex = 14;
            this.lbl_Date.Text = "Eg : 2013-10-12";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(65, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(418, 89);
            this.dataGridView2.TabIndex = 13;
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(299, 94);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(121, 20);
            this.txt_Output.TabIndex = 12;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(62, 96);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(56, 13);
            this.lbl_Search.TabIndex = 11;
            this.lbl_Search.Text = "Search By";
            // 
            // cm_Options
            // 
            this.cm_Options.FormattingEnabled = true;
            this.cm_Options.Items.AddRange(new object[] {
            "id",
            "name",
            "dob"});
            this.cm_Options.Location = new System.Drawing.Point(162, 93);
            this.cm_Options.Name = "cm_Options";
            this.cm_Options.Size = new System.Drawing.Size(121, 21);
            this.cm_Options.TabIndex = 10;
            this.cm_Options.SelectedIndexChanged += new System.EventHandler(this.cm_Options_SelectedIndexChanged);
            this.cm_Options.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cm_Options_KeyPress);
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.Location = new System.Drawing.Point(437, 96);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchPatient.TabIndex = 9;
            this.btn_SearchPatient.Text = "Search";
            this.btn_SearchPatient.UseVisualStyleBackColor = true;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Person";
            // 
            // NewPatient_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 377);
            this.Controls.Add(this.btn_CreatePatient);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.cm_Options);
            this.Controls.Add(this.btn_SearchPatient);
            this.Name = "NewPatient_Search";
            this.Text = "NewPatient_Search";
            this.Load += new System.EventHandler(this.NewPatient_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreatePatient;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ComboBox cm_Options;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}