namespace MedicalInformationManagementSystem
{
    partial class EnterMedication
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
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_MediName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_enterDaignosis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(177, 73);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(241, 119);
            this.txt_Description.TabIndex = 13;
            // 
            // txt_MediName
            // 
            this.txt_MediName.Location = new System.Drawing.Point(177, 21);
            this.txt_MediName.Name = "txt_MediName";
            this.txt_MediName.Size = new System.Drawing.Size(241, 20);
            this.txt_MediName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medication Description ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Medication Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(177, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_enterDaignosis
            // 
            this.btn_enterDaignosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterDaignosis.Location = new System.Drawing.Point(325, 198);
            this.btn_enterDaignosis.Name = "btn_enterDaignosis";
            this.btn_enterDaignosis.Size = new System.Drawing.Size(93, 35);
            this.btn_enterDaignosis.TabIndex = 14;
            this.btn_enterDaignosis.Text = "Create Orders";
            this.btn_enterDaignosis.UseVisualStyleBackColor = true;
            this.btn_enterDaignosis.Click += new System.EventHandler(this.btn_enterDaignosis_Click);
            // 
            // EnterMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(this.btn_enterDaignosis);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_MediName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Name = "EnterMedication";
            this.Text = "EnterMedication";
            this.Load += new System.EventHandler(this.Enter_Medication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_MediName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_enterDaignosis;
    }
}