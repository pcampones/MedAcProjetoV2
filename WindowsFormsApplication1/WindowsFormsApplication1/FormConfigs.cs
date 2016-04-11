using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOT
{
    public partial class formConfigs : Form
    {
        //caac shjbsjb
        public formConfigs()
        {
            InitializeComponent();

            if (!Properties.Settings.Default.Delay.Equals(null))
            {
                txb_delaydll.Text = Properties.Settings.Default.Delay.ToString();
            }
            if (Properties.Settings.Default.Medline != "")
            {
                txb_medline.Text = Properties.Settings.Default.Medline;
            }
            if (!Properties.Settings.Default.Retmax.Equals(null))
            {
                txb_retmax.Text = Properties.Settings.Default.Retmax.ToString();
            }
            if (Properties.Settings.Default.LocalUrl != "")
            {
                txb_local.Text = Properties.Settings.Default.LocalUrl;
            }


        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            

            if (txb_delaydll.Text != null)
            {
                Properties.Settings.Default.Delay =int.Parse(txb_delaydll.Text);
            }
            if (txb_local.Text != "")
            {
                Properties.Settings.Default.LocalUrl = txb_local.Text;
            }
            if (txb_medline.Text != "")
            {
                Properties.Settings.Default.Medline = txb_medline.Text;
            }
            if (txb_retmax.Text != null)
            {
                Properties.Settings.Default.Retmax = int.Parse(txb_retmax.Text);
            }

            DialogResult result = MessageBox.Show("Do you want to save the changes made??", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void bt_default_Click(object sender, EventArgs e)
        {
            txb_medline.Text = Properties.Settings.Default.Medline;
            txb_local.Text = Properties.Settings.Default.LocalUrl;
            txb_retmax.Text = Properties.Settings.Default.Retmax.ToString();
            txb_delaydll.Text = Properties.Settings.Default.Delay.ToString();
           
        }
    }
}
