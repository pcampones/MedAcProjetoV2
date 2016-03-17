using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhysiologicParametersDll;
using BOT.Properties;
using BOT.ServiceReference1;

namespace BOT
{
    public partial class Form1 : Form
    {
        private Service1Client serv;
        PhysiologicParametersDll.PhysiologicParametersDll dll =  null;
        PhysiologicParametersDll.PhysiologicParametersDll dllC = null;
        PhysiologicParametersDll.PhysiologicParametersDll dllH = null;

        enum DataType { Normal, Alerts };


        public Form1()
        {
            InitializeComponent();
            serv = new Service1Client();
            panelPrincipal.Visible = true;
            panelMedicalDictionary.Visible = false;
            panelDataAcquisition.Visible = false;
            panelMe.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //listBox1.DataSource = serv.GetListaUtentes().Select(i=>i.name);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dll != null)
            {
                if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, true, false, false);
                }
              /*  else
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, false, false, false);
                }*/
                if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Unchecked)
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, false, false, false);
                }
            }
            else
            {
                dll = new PhysiologicParametersDll.PhysiologicParametersDll();
            }


            if (dllC != null)
            {

                if (checkedListBox1.SelectedItem.Equals("Oxigen Saturation") && (checkedListBox1.GetItemCheckState(1) == CheckState.Checked))
                {
                    dllC.Initialize(OxigenSature, Settings.Default.Delay, false, true, false);

                }
                if (checkedListBox1.SelectedItem.Equals("Oxigen Saturation") && checkedListBox1.GetItemCheckState(1) == CheckState.Unchecked)
                {
                    dllC.Initialize(OxigenSature, Settings.Default.Delay, false, false, false);

                }
            }
            else
            {
                dllC = new PhysiologicParametersDll.PhysiologicParametersDll();
            }



            if (dllH != null)
            {


                if (checkedListBox1.SelectedItem.Equals("Heart Rate") && (checkedListBox1.GetItemCheckState(2) == CheckState.Checked))
                {
                    dllH.Initialize(HeartRate, Settings.Default.Delay, false, false, true);

                }
                if (checkedListBox1.SelectedItem.Equals("Heart Rate") && (checkedListBox1.GetItemCheckState(2) == CheckState.Unchecked))
                {
                    dllH.Initialize(HeartRate, Settings.Default.Delay, false, false, false);
                }
            }
            else
            {
                dllH = new PhysiologicParametersDll.PhysiologicParametersDll();
            }
            
               

        }
        public void BloodPressure(string str)
        {

            char[] delimiters = { ';' };
            string[] palavras = str.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);
            List<string> heartRate = new List<string>();
            heartRate.Add(palavras[1].ToString());
            this.BeginInvoke((MethodInvoker)delegate
            {
                 

                textBox1.Text = heartRate.LastOrDefault() ;
            });
        }

        public void OxigenSature(string str)
        {
            char[] delimiters = { ';' };
            string[] palavras = str.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);
            List<string> heartRate = new List<string>();
            heartRate.Add(palavras[1].ToString());
            this.BeginInvoke((MethodInvoker)delegate
            {

                textBox2.Text = heartRate.LastOrDefault() ;
            });
        }

        public void HeartRate(string str)
        {
            char[] delimiters = { ';' };
            
            string[] palavras = str.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);

            List<string> heartRate = new List<string>();
            heartRate.Add(palavras[1].ToString());
            this.BeginInvoke((MethodInvoker)delegate
            {
                textBox3.Text = heartRate.LastOrDefault();
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelDataAcquisition.Visible = false;
            panelMe.Visible = true;
            panelPrincipal.Visible = false;
            panelMedicalDictionary.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panelDataAcquisition.Visible = true;
            panelMe.Visible = false;
            panelPrincipal.Visible = false;
            panelMedicalDictionary.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelMedicalDictionary.Visible = true;
            panelDataAcquisition.Visible = false;
            panelMe.Visible = false;
            panelPrincipal.Visible = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            formConfigs frm = new formConfigs();
            frm.Show();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        public static string Age( DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age))
                age--;

            return age.ToString();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SNS = int.Parse(toolStripTextBox1.Text);
            UtenteWeb u = serv.GetUtenteBySNS(int.Parse(toolStripTextBox1.Text));
            if (u != null)
            {              
                tsLbl_welcome.Text = "Bem-Vindo:" + " " + u.name;
                lbl_name.Text = u.name;
                lbl_surname.Text = u.surname;
                lbl_birthdate.Text = u.birthdate.ToString();
                lbl_sns.Text = u.sns.ToString();
                lbl_age.Text = Age(u.birthdate);
            }
            else
            {
                MessageBox.Show("Tem de introduzir um SNS válido!", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
      
    


