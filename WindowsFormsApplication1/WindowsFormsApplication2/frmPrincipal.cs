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

            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = true;



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

            ut.name = txb_name.Text;
            ut.surname = txb_surname.Text;
            ut.sns = Int32.Parse(txb_sns.Text);
            ut.mail = txb_email.Text;
            ut.bi = Convert.ToInt32(txb_bi.Text);
            ut.gender = gender;
            ut.ative = ative;
            ut.address = txb_morada.Text;
            ut.birthdate = dtp_utente.Value;
            ut.alergies = rtxb_alergies.Text;
            ut.weight = Convert.ToInt32(txb_weigth);
            ut.height = Convert.ToInt32(txb_heigth);
            ut.nexOfKinContact = Convert.ToInt32(txb_nextkindofcontact);
            ut.phone = Convert.ToInt32(txb_phone.Text);
            

           DialogResult result =  MessageBox.Show("Are you sure you want add the user with the " + txb_name.Text + " ?", "Information",
               MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                serv.AddUtente(ut);
                MessageBox.Show("User successfully added", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
            //    frmPrincipal form = new frmPrincipal();
                
            }
           
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = true;
            panelPrincipal.Visible = false;
        }
    }
}
