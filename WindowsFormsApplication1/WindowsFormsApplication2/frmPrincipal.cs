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
        string gender;
        string ative;
        public frmPrincipal()
        {
            InitializeComponent();

            serv = new Service1Client();



        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ative = "Ative";
            }
            else
            {
                ative = "Inative";

            }
         
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           gender = "Male";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ut = new UtenteWeb();

            ut.name = txb_nome.Text;
            ut.surname = txb_sobrenome.Text;
            ut.sns = Int32.Parse(txb_SNS.Text);
            ut.mail = txb_email.Text;
            ut.bi = Convert.ToInt32(txb_BI.Text);
            ut.gender = gender;
            ut.ative = ative;
            ut.address = txb_morada.Text;
            ut.birthdate = dtP_Nascimento.Value;
            ut.alergies = rich_alergies.Text;
            ut.weight = Convert.ToInt32(numericUpDown1.Value);
            ut.height = Convert.ToInt32(numericUpDown2.Value);
            ut.nexOfKinContact = Convert.ToInt32(txb_pContato.Text);
            ut.phone = Convert.ToInt32(txb_phone.Text);
            

           DialogResult result =  MessageBox.Show("Are you sure you want add the user with the " + txb_nome.Text + " ?", "Information",
               MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                serv.AddUtente(ut);
                MessageBox.Show("User successfully added", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
           
        }
    }
}
