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
using WindowsFormsApplication1.Properties;
using WindowsFormsApplication1.ServiceReference1;

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

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.DataSource = serv.GetListaUtentes();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dll != null)
            {
                if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, true, false, false);
                }
                else
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, false, false, false);
                }
               /* if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Unchecked)
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, false, false, false);
                }*/
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
    }
}
      
    


