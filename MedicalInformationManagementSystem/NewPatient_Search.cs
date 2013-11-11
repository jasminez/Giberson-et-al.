using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformaticSystem
{
    public partial class NewPatient_Search : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        string constring;
        int flag;
        public NewPatient_Search()
        {
            InitializeComponent();
        }

        private void NewPatient_Search_Load(object sender, EventArgs e)
        {
            this.personTableAdapter.Fill(this.GibersonDataSet.Person);
        }

        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {
            string query = "";
            if (flag == 0)
            {
                query = "select p1.patientID,p.lastName,p.dateOfBirth from person p,patient p1 where p.personID = p1.patientID and p1.patientID = '" + txt_Output.Text + "'";
            }
            else if (flag == 1)
            {
                query = "select p1.patientID,p.lastName,p.dateOfBirth from person p,patient p1 where lastName = '" + txt_Output.Text + "' and p.personID = p1.patientID";
            }
            else if (flag == 2)
            {
                query = "select p1.patientID,p.lastName,p.dateOfBirth from person p,patient p1 where dateOfBirth = '" + txt_Output.Text + "' and p.personID = p1.patientID";
            }



            constring = @"Data Source=BARKAT-PC;Initial Catalog=Giberson;Integrated Security=True";
            conn = new SqlConnection();
            conn.ConnectionString = constring;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView2.DataSource = dt;

            }
            else
            {
                btn_CreatePatient.Enabled = true;
                MessageBox.Show("Patient Doesnot Exist. Please Create a new Patient");
            }
            conn.Close();
        }

        private void cm_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_Output.Text = this.cm_Options.Text;
            if (cm_Options.SelectedIndex == 0)
            {
                flag = 0;
            }
            else if (cm_Options.SelectedIndex == 1)
            {
                flag = 1;
            }
            else if (cm_Options.SelectedIndex == 2)
            {
                flag = 2;
                lbl_Date.Enabled = false;
            }
        }

        private void cm_Options_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.txt_Output.Text = this.cm_Options.Text;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CreatePatient_Click(object sender, EventArgs e)
        {

            //Form2 from2 = new Form2();//to go to create ne patient 
            // from2.tag = this;
            // from2.Show(this);
            // Hide();
        }
    }
}
