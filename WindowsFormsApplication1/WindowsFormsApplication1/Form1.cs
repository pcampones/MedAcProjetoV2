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

namespace BOT
{
    public partial class Form1 : Form
    {
        PhysiologicParametersDll.PhysiologicParametersDll dll = new PhysiologicParametersDll.PhysiologicParametersDll();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                //MessageBox.Show("Blood Pressure");
                dll.InitializeWithAlerts(null, Settings.Default.Delay, true, false, false);
            }
            if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Unchecked)
            {
                dll.InitializeWithAlerts(null, Settings.Default.Delay, false, false, false);
                //MessageBox.Show("Blood Pressure desative");
            }
            if (checkedListBox1.SelectedItem.Equals("Oxigen Saturation") && (checkedListBox1.GetItemCheckState(1) == CheckState.Checked))
            {
                dll.InitializeWithAlerts(null, Settings.Default.Delay, false, true, false);
                //MessageBox.Show("Oxigen Saturation");
            }
            if (checkedListBox1.SelectedItem.Equals("Oxigen Saturation") && checkedListBox1.GetItemCheckState(1) == CheckState.Unchecked)
            {
                dll.InitializeWithAlerts(null, Settings.Default.Delay, false, false, false);
                //MessageBox.Show("Oxigen Saturation desative");
            }
            if (checkedListBox1.SelectedItem.Equals("Heart Rate") && (checkedListBox1.GetItemCheckState(2) == CheckState.Checked))
            {
                dll.InitializeWithAlerts(null, Settings.Default.Delay, false, false, true);
                //  MessageBox.Show("Heart Rate");
            }
            if (checkedListBox1.SelectedItem.Equals("Heart Rate") && (checkedListBox1.GetItemCheckState(2) == CheckState.Unchecked))
            {
                dll.InitializeWithAlerts(null, Settings.Default.Delay, false, false, false);
                // MessageBox.Show("Heart Rate desative");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            PhysiologicParametersDll.PhysiologicParametersDll dll = new PhysiologicParametersDll.PhysiologicParametersDll();
            dll.DoWork();

        }


    }
}
      
    


