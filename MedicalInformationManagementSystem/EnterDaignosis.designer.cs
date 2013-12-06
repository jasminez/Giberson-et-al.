namespace MedicalInformationManagementSystem
{
    partial class EnterDaignosis
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
            this.txt_DiagnosisDescription = new System.Windows.Forms.TextBox();
            this.txt_DiagnosisName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_entermedication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_DiagnosisDescription
            // 
            this.txt_DiagnosisDescription.Location = new System.Drawing.Point(163, 69);
            this.txt_DiagnosisDescription.Multiline = true;
            this.txt_DiagnosisDescription.Name = "txt_DiagnosisDescription";
            this.txt_DiagnosisDescription.Size = new System.Drawing.Size(203, 87);
            this.txt_DiagnosisDescription.TabIndex = 20;
            // 
            // txt_DiagnosisName
            // 
            this.txt_DiagnosisName.Location = new System.Drawing.Point(163, 26);
            this.txt_DiagnosisName.Name = "txt_DiagnosisName";
            this.txt_DiagnosisName.Size = new System.Drawing.Size(203, 20);
            this.txt_DiagnosisName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Diagnosis Description ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Diagnosis  Name";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(163, 173);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(87, 37);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_entermedication
            // 
            this.btn_entermedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entermedication.Location = new System.Drawing.Point(279, 176);
            this.btn_entermedication.Name = "btn_entermedication";
            this.btn_entermedication.Size = new System.Drawing.Size(87, 34);
            this.btn_entermedication.TabIndex = 21;
            this.btn_entermedication.Text = "Enter Medication ";
            this.btn_entermedication.UseVisualStyleBackColor = true;
            this.btn_entermedication.Click += new System.EventHandler(this.btn_entermedication_Click);
            // 
            // EnterDaignosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 230);
            this.Controls.Add(this.btn_entermedication);
            this.Controls.Add(this.txt_DiagnosisDescription);
            this.Controls.Add(this.txt_DiagnosisName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Save);
            this.Name = "EnterDaignosis";
            this.Text = "EnterDaignosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DiagnosisDescription;
        private System.Windows.Forms.TextBox txt_DiagnosisName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_entermedication;
    }
}