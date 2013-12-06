using HealthInformaticSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInformationManagementSystem
{
    public partial class EnterDaignosis : Form
    {
        
        public EnterDaignosis()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> dictionary = null;
            DatabaseConnector dc = null;
            dc = new DatabaseConnector();
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@name", txt_DiagnosisName.Text);
            dictionary.Add("@description ", txt_DiagnosisDescription.Text);

            bool result = dc.putdata("EnterDiagnosis", dictionary);
            if (result == true)
            {
                MessageBox.Show("Record Saved Successfully");
                txt_DiagnosisName.Text = "";
                txt_DiagnosisDescription.Text = "";
                txt_DiagnosisName.Focus();
            }
            else
            {
                MessageBox.Show("Failed to save record ");
            }
        }

        private void btn_entermedication_Click(object sender, EventArgs e)
        {
            EnterMedication em = new EnterMedication();
            this.Hide();
            em.Show();
        }
    }
}
