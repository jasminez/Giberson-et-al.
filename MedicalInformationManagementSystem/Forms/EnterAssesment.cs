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


namespace HealthInformaticSystem
{
    public partial class frm_Assesment : Form
    {
        Dictionary<String, String> dictionary = null;
        DatabaseConnector dc = null;
        public int patId=1;
        public int docId = 1;
        DataTable dtPatient = null;
        DataTable dtEMR = null;
       // public String viewEMRPatientId="1";
        public frm_Assesment()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dc = new DatabaseConnector();
            DateTime d = DateTime.Today;

            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patId.ToString());
            dictionary.Add("@doctorId", docId.ToString());
            dictionary.Add("@timestamp", d.ToShortDateString());// if you need date time please convert d.ToString()            
            //dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@blooppressure", txt_Bp.Text);
            dictionary.Add("@respiratoryrate", txt_Rr.Text);
            dictionary.Add("@pulserate ", txt_Pr.Text);
            dictionary.Add("@temperature", txt_temp.Text);
            dictionary.Add("@height", txt_Height.Text);
            dictionary.Add("@weight", txt_Weight.Text);
            dictionary.Add("@painscale", txt_PainScale.Text);
            dictionary.Add("@clinicalimpression", txt_Clinical.Text);
            dictionary.Add("@chiefcomplaint", txt_cheifcomplaint.Text);
            bool result = dc.putdata("EnterAssesment", dictionary);
            if (result == true)
            {
                MessageBox.Show("Record Saved Successfully");
            }
            else
            {
                MessageBox.Show("Failed to save record please check if the patient is already been assessed");
            }
        }

        private void frm_Assesment_Load(object sender, EventArgs e)
        {
            dc = new DatabaseConnector();
            dictionary = new Dictionary<string, string>();
           // patId = int.Parse();
            dictionary.Add("@patientId", patId.ToString());
            dtPatient = dc.getData("GetPatient", dictionary);
            label11.Text = dtPatient.Rows[0][0].ToString();
            label13.Text = dtPatient.Rows[0][1].ToString();
            label5.Text = dtPatient.Rows[0][2].ToString();
            label4.Text = dtPatient.Rows[0][3].ToString();
            label8.Text = dtPatient.Rows[0][4].ToString();
            label9.Text = dtPatient.Rows[0][5].ToString(); 
            label1.Text = patId.ToString();
            
            
            
        }

        private void lbl_CC_Click(object sender, EventArgs e)
        {

        }

        private void lbl_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_P_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PS_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientDetails_Enter(object sender, EventArgs e)
        {

        }

    }


}
