using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.ServiceReference1;

namespace WindowsFormsApplication2
{
    public partial class frmPrincipal : Form
    {


        private Service1Client serv;
        UtenteWeb ut;     
        public frmPrincipal()
        {
            InitializeComponent();

            serv = new Service1Client();
            ut = new UtenteWeb();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ut.ative = true;
            }
            else
            {
                ut.ative = false;

            }
         
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ut.gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ut.gender = "Female";
        }
    }
}
