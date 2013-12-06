using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthInformaticSystem;

namespace MedicalInformationManagementSystem
{
    public partial class EnterMedication : Form
    {
       

        public EnterMedication()
        {
            InitializeComponent();
        }

        private void Enter_Medication_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> dictionary = null;
            DatabaseConnector dc = null;
            dc = new DatabaseConnector();
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@name", txt_MediName.Text);
            dictionary.Add("@description ", txt_Description.Text);

            bool result = dc.putdata("EnterMedication", dictionary);
            if (result == true)
            {
                MessageBox.Show("Record Saved Successfully");
                txt_Description.Text = "";
                txt_MediName.Text = "";
                txt_MediName.Focus();
            }
            else
            {
                MessageBox.Show("Failed to save record ");
            }
        }

        private void btn_enterDaignosis_Click(object sender, EventArgs e)
        {

        }
    }
}
