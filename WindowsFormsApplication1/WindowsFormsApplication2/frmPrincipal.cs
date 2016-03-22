using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicalAlert.ServiceReference1;

namespace ClinicalAlert
{
    public partial class frmPrincipal : Form
    {


        private Service1Client serv;
        UtenteWeb ut;
        string gender;
        string ative = "Inative";
        public frmPrincipal()
        {
            InitializeComponent();

            serv = new Service1Client();

            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = true;
            ativeCheckBox.Checked = true;
           

        }


 

     

        private void Add_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = true;
            panelPrincipal.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ut = new UtenteWeb();
            bool a = false;
            a = verificaCampos();

            if (a== true)
            {
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
                ut.weight = Convert.ToInt32(numericUpDown1.Value);
                ut.height = Convert.ToInt32(numericUpDown2.Value);
                ut.nexOfKinContact = Convert.ToInt32(txb_nextkindofcontact.Text);
                ut.phone = Convert.ToInt32(txb_phone.Text);
                ut.age = Convert.ToInt32(Age(dtp_utente.Value));



                DialogResult result = MessageBox.Show("Are you sure you want add the user with the " + txb_name.Text + " ?", "Information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    serv.AddUtente(ut);
                    MessageBox.Show("User successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //    frmPrincipal form = new frmPrincipal();

                }
            }
            else
            {
                MessageBox.Show("Campos por preencher");
            }
         
        }

        private void ativeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ativeCheckBox.Checked)
            {
                ative = "Ative";
            }
            else 
            {
                ative = "Inative";

            }
        }

        private void maleRb_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void femaleRb_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }


        public static string Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
        }


        public bool verificaCampos()
        {
            if (String.IsNullOrEmpty(txb_name.Text) || String.IsNullOrWhiteSpace(txb_name.Text) && 
                String.IsNullOrEmpty(txb_surname.Text) || String.IsNullOrWhiteSpace(txb_surname.Text) && 
                String.IsNullOrEmpty(txb_morada.Text) || String.IsNullOrWhiteSpace(txb_morada.Text) &&
                String.IsNullOrEmpty(txb_bi.Text) || String.IsNullOrWhiteSpace(txb_bi.Text) &&
                String.IsNullOrEmpty(txb_email.Text) || String.IsNullOrWhiteSpace(txb_email.Text)&& 
                String.IsNullOrEmpty(txb_nextkindofcontact.Text) || String.IsNullOrWhiteSpace(txb_nextkindofcontact.Text) &&
                String.IsNullOrEmpty(txb_sns.Text) || String.IsNullOrWhiteSpace(txb_sns.Text) && 
                String.IsNullOrEmpty(txb_phone.Text) || String.IsNullOrWhiteSpace(txb_phone.Text) &&
                String.IsNullOrEmpty(numericUpDown1.Value.ToString()) || String.IsNullOrWhiteSpace(numericUpDown1.Value.ToString()) && 
                String.IsNullOrEmpty(numericUpDown2.Value.ToString()) || String.IsNullOrWhiteSpace(numericUpDown2.Value.ToString()) && 
                String.IsNullOrEmpty(gender) || String.IsNullOrWhiteSpace(gender) && 
                String.IsNullOrEmpty(rtxb_alergies.Text) || String.IsNullOrWhiteSpace(rtxb_alergies.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {

          
        }

       private void txb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }*/
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txb_phone_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txb_name.Text," ^[0-9]"))
            {
                txb_name.Text = "";
            }
        }

        private void txb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txb_nextkindofcontact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txb_name.Text, " ^[0-9]"))
            {
                txb_nextkindofcontact.Text = "";
            }

        }

        private void txb_nextkindofcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txb_bi_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txb_name.Text, " ^[0-9]"))
            {
                txb_bi.Text = "";
            }
        }

        private void txb_bi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txb_sns_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txb_name.Text, " ^[0-9]"))
            {
                txb_sns.Text = "";
            }
        }

        private void txb_sns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
