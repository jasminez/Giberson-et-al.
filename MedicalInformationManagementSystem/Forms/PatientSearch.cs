using MIMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformaticSystem
{
    public partial class PatientSearch : Form
    {


        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;
       
        public String _mySearchId;

        public PatientSearch()
        {
            InitializeComponent();
        }
        public string mySearchId
        {
            get { return _mySearchId; }
            set { _mySearchId = value; }
        }
        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {

            dictionary = new Dictionary<string, string>();
            dc = new DatabaseConnector();

            if (txt_Output.Text != "")
            {
                bool temp = false;
                int temp1;
                try
                {
                    temp1 = Convert.ToInt32(txt_Output.Text);
                    temp = true;
                }
                catch (Exception ex)
                {
                    temp = false;
                }
                if (cm_Options.SelectedIndex == 1 && temp == true)
                {
                    dictionary.Add("@patientId", txt_Output.Text);
                    dtPatient = dc.getData("CheckPatientExists", dictionary);
                    if (dtPatient.Rows.Count != 0)
                    {
                        dataGridView2.Hide();
                        dataGridView1.Show();
                        this.getPatientByIdTableAdapter.Fill(searchPatientByIdDataSet.GetPatientById, txt_Output.Text);
                    }
                    else
                    {
                        MessageBox.Show("Patient does not exist.");
                        DialogResult result = MessageBox.Show("Create New Patient Demography?", "New Demography", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            CreateDemForm create = new CreateDemForm();

                            create.Show();

                        }

                    }

                }
                else if (cm_Options.SelectedIndex == 2)
                {
                    dictionary.Add("@patientName", txt_Output.Text);
                    dtPatient = dc.getData("CheckPatientExistsByName", dictionary);
                    if (dtPatient.Rows.Count != 0)
                    {
                        dataGridView1.Hide();
                        dataGridView2.Show();
                        this.getPatientByNameTableAdapter.Fill(searchPatientByNameDataSet.GetPatientByName, txt_Output.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Patient does not exist.");
                        DialogResult result = MessageBox.Show("Create New Patient Demography?", "New Demography", MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            CreateDemForm create = new CreateDemForm();
                            create.Show();

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Please proper search text!");
                    txt_Output.Focus();
                }
            }
        }
               

        private void PatientSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            btn_SearchPatient.Enabled = false;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cm_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_Options.SelectedIndex == 1 || cm_Options.SelectedIndex == 2)
            {
                btn_SearchPatient.Enabled = true;
                txt_Output.Text = "";
                txt_Output.Focus();
                
            }
            else
            {
                btn_SearchPatient.Enabled = false;
                txt_Output.Text = "";
                DialogResult result = MessageBox.Show("Create New Patient Demography?", "New Demography", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
