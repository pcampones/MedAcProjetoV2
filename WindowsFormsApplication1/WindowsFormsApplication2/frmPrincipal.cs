﻿using System;
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

        //ap
        private Service1Client serv;
        UtenteWeb ut;
        ValoresWeb val;
        string gender;
        string ative = "Inative";
        int sns;

        public frmPrincipal()
        {
            InitializeComponent();

            serv = new Service1Client();

            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = true;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            ativeCheckBox.Checked = true;
            panelDiarioValores.Visible = false;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;


            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            List<UtenteWeb> listaUtente = serv.GetListaUtentes().ToList();

            foreach (UtenteWeb item in listaUtente)
            {
                ListViewItem linha = new ListViewItem(item.sns.ToString(), 0);
                linha.SubItems.Add(item.name + " " + item.surname);
                listView1.Items.Add(linha);

            }
            // listBox_utentes.DisplayMember = "Name";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = true;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;

            panelAlerts.Visible = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            panelPrincipal.Visible = false;
            panel_Adicionar.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ut = new UtenteWeb();
            bool a = false;
            a = verificaCampos();

            if (a == true)
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
                String.IsNullOrEmpty(txb_email.Text) || String.IsNullOrWhiteSpace(txb_email.Text) &&
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

        private void txb_phone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txb_name.Text, " ^[0-9]"))
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelPrincipal.Visible = false;
            panel_Adicionar.Visible = false;
            panelGraficos.Visible = true;
            panelDiarioValores.Visible = false;

            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.Titles.Clear();

            List<ValoresWeb> valores = serv.GetRegistofGrahp(sns).ToList();

            foreach (ValoresWeb item in valores)
            {
                ValoresWeb valoresWeb = new ValoresWeb();

                item.bloodPressureMax = valoresWeb.bloodPressureMax;
                item.bloodPressureMin = valoresWeb.bloodPressureMin;
                item.heartRate = valoresWeb.heartRate;
                item.oxigenSat = valoresWeb.oxigenSat;
                item.dataOfReposit = valoresWeb.dataOfReposit;
            }

            //Titulo do gráfico
            chart1.Titles.Add("Chart Values");

            //Construção da àrea do gráfico
            chart1.ChartAreas.Add("area");

            DateTime dataMax = DateTime.Now;
            DateTime dataMin = DateTime.Now.AddDays(-2);

            chart1.ChartAreas["area"].AxisX.Minimum = dataMin.ToOADate();
            chart1.ChartAreas["area"].AxisX.Maximum = dataMax.ToOADate();
            chart1.ChartAreas["area"].AxisX.Interval = 1;
            chart1.ChartAreas["area"].AxisY.Minimum = 0;
            chart1.ChartAreas["area"].AxisY.Interval = 10;

            chart1.ChartAreas["area"].AxisX.Title = "Date";
            chart1.ChartAreas["area"].AxisY.Title = "Values";

            chart1.Series.Add("Blood Pressure");
            chart1.Series.Add("Heart Rate");
            chart1.Series.Add("Oxygen Saturation");

            //definição da cor de cada série
            chart1.Series["Blood Pressure"].Color = Color.Red;
            chart1.Series["Heart Rate"].Color = Color.Blue;
            chart1.Series["Oxygen Saturation"].Color = Color.Green;

            //Pontos a aparecer no gráfico
            chart1.Series["Blood Pressure"].Points.AddXY(dataMin, 10);
            chart1.Series["Heart Rate"].Points.AddXY(dataMax, 10);
            chart1.Series["Oxygen Saturation"].Points.AddXY(dataMax, 10);

            chart1.ChartAreas["area"].BackColor = Color.White;
            chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
            chart1.ChartAreas["area"].BackGradientStyle =
            System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

            chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
            chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

            chart1.Series["Blood Pressure"].IsValueShownAsLabel = true;
            chart1.Series["Heart Rate"].IsValueShownAsLabel = true;
            chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = true;
        }

        private void diarioValores_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelPrincipal.Visible = false;
            panel_Adicionar.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = true;
            panelAlerts.Visible = false;

            List<ValoresWeb> valor = serv.GetValuesbySNS(sns).ToList();

            foreach (ValoresWeb item in valor)
            {

                dataGridView1.Rows.Add(item.bloodPressureMax.ToString(), item.bloodPressureMin.ToString()
                    , item.heartRate.ToString(), item.oxigenSat.ToString(), item.dataOfReposit.ToString());
                dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Ascending);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Save"))
            {
                textBox8.Enabled = false;
                textBox4.Enabled = false;
                textBox7.Enabled = false;
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox1.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown3.Enabled = false;
                richTextBox1.Enabled = false;
                button2.Text = "Edit";
                MessageBox.Show("Successfully edited data!", "Confirmation", MessageBoxButtons.OK);
            }
            else if (button2.Text.Equals("Edit"))
            {
                button2.Text = "Save";
                textBox8.Enabled = true;
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                textBox3.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox2.Enabled = true;
                dateTimePicker1.Enabled = true;
                textBox1.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                numericUpDown4.Enabled = true;
                numericUpDown3.Enabled = true;
                richTextBox1.Enabled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_utentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelPrincipal.Visible = true;
            panel_Adicionar.Visible = false;
            panelGraficos.Visible = false;
            panelAlerts.Visible = false;
            panelDiarioValores.Visible = false;
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sns = Convert.ToInt32(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text);

            UtenteWeb u = serv.GetUtenteBySNS(sns);

            if (u != null)
            {
                tsl_nameUtente.Text = "Patient selected:" + " " + u.name;

                textBox8.Text = u.name;
                textBox8.Enabled = false;
                textBox4.Text = u.surname;
                textBox4.Enabled = false;
                textBox7.Text = u.phone.ToString();
                textBox7.Enabled = false;
                textBox3.Text = u.nexOfKinContact.ToString();
                textBox3.Enabled = false;
                textBox5.Text = u.address;
                textBox5.Enabled = false;
                textBox6.Text = u.bi.ToString();
                textBox6.Enabled = false;
                textBox2.Text = u.mail;
                textBox2.Enabled = false;
                dateTimePicker1.Text = u.birthdate.ToString();
                dateTimePicker1.Enabled = false;
                textBox1.Text = u.sns.ToString();
                textBox1.Enabled = false;

                if (u.gender == "Male")
                {
                    radioButton1.Text = u.gender;
                    radioButton1.Enabled = false;
                }
                else
                {
                    radioButton2.Text = u.gender;
                    radioButton2.Enabled = false;
                }
                numericUpDown4.Value = u.weight;
                numericUpDown4.Enabled = false;
                numericUpDown3.Value = u.height;
                numericUpDown3.Enabled = false;
                richTextBox1.Text = u.alergies;
                richTextBox1.Enabled = false;


            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //aaaaa

        }

        private void Alerts_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = true;
            List<AlertasWeb> valor = serv.GetValuesAlertsbySns(sns).ToList();

            foreach (AlertasWeb item in valor)
            {

                if (item.read.Equals("Not Read"))
                {
                    dataGridView2.Rows.Add(item.dataAlerta,
                        item.tipo, item.read);

                }


            }

            List<ValoresWeb> u = serv.GetAlertNotRead(sns).ToList();

            foreach (ValoresWeb item in u)
            {
                ListViewItem linha = new ListViewItem(item.sns.ToString(), 0);
                linha.SubItems.Add(item.nomeUtente + " " + item.sUtente); // name + surname

                listView2.Items.Add(linha);
            }


            /*  List<ValoresWeb> valor2 = serv.GetAlertNotRead (sns).ToList();



              foreach (ValoresWeb item in valor2)
              {
                  ListViewItem linha = new ListViewItem(item..sns.ToString(), 0);
                  linha.SubItems.Add(item.name + " " + item.surname);

                  listView2.Items.Add(linha);
              }*/
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sns = Convert.ToInt32(listView2.Items[listView2.FocusedItem.Index].SubItems[0].Text);


        }


        private void button3_Click(object sender, EventArgs e)
        {

            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.Titles.Clear();

            //Titulo do gráfico
            chart1.Titles.Add("Chart Values");

            //Construção da àrea do gráfico
            chart1.ChartAreas.Add("area");

            lsb_parameters.Items.Clear();
            lsb_parameters.ClearSelected();
            lsb_tipos.Items.Clear();
            lsb_tipos.ClearSelected();


            DateTime dataMin = dtp_begin.Value;
            DateTime dataMax = dtp_end.Value;

            if (dataMin <= dataMax)
            {
               List<ValoresWeb> valores = serv.GetRegistofGrahp(sns).ToList();

                foreach (ValoresWeb item in valores)
                {
                    ValoresWeb valoresWeb = new ValoresWeb();

                    item.bloodPressureMax = valoresWeb.bloodPressureMax;
                    item.bloodPressureMin = valoresWeb.bloodPressureMin;
                    item.heartRate = valoresWeb.heartRate;
                    item.oxigenSat = valoresWeb.oxigenSat;
                    item.dataOfReposit = valoresWeb.dataOfReposit;
                }

                chart1.ChartAreas["area"].AxisX.Minimum = dataMin.Day;
                chart1.ChartAreas["area"].AxisX.Maximum = dataMax.Day;
                chart1.ChartAreas["area"].AxisX.Interval = 1;
                chart1.ChartAreas["area"].AxisY.Minimum = 0;
                chart1.ChartAreas["area"].AxisY.Interval = 10;

                chart1.ChartAreas["area"].AxisX.Title = "Date";
                chart1.ChartAreas["area"].AxisY.Title = "Values";

                chart1.Series.Add("Blood Pressure");
                chart1.Series.Add("Heart Rate");
                chart1.Series.Add("Oxygen Saturation");

                //definição da cor de cada série
                chart1.Series["Blood Pressure"].Color = Color.Red;
                chart1.Series["Heart Rate"].Color = Color.Blue;
                chart1.Series["Oxygen Saturation"].Color = Color.Green;

                //Pontos a aparecer no gráfico         
                chart1.Series["Blood Pressure"].Points.AddXY(dataMin, 10);   
                chart1.Series["Heart Rate"].Points.AddXY(dataMax, 10);
                chart1.Series["Oxygen Saturation"].Points.AddXY(dataMax, 10);

                chart1.ChartAreas["area"].BackColor = Color.White;
                chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
                chart1.ChartAreas["area"].BackGradientStyle =
                System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                chart1.Series["Blood Pressure"].IsValueShownAsLabel = true;
                chart1.Series["Heart Rate"].IsValueShownAsLabel = true;
                chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = true;
            }
            else
            {
                MessageBox.Show("The start date can not be bigher than the end date", "Confirmation", MessageBoxButtons.OK);
            }


        }

        private void lsb_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_tipos.Equals("Bars"))
            {
                //definição do tipo de gráficosss
                chart1.Series["Blood Pressure"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series["Oxygen Saturation"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series["Heart Rate"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            } else if (lsb_tipos.Equals("Collumns"))
            {
                chart1.Series["Blood Pressure"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["Oxygen Saturation"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["Heart Rate"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            } else if (lsb_tipos.Equals("Lines"))
            {
                chart1.Series["Blood Pressure"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Oxygen Saturation"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Heart Rate"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
        }

        private void lsb_parameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ValoresWeb> regGraficos = serv.GetRegistofGrahp(sns).ToList();

            foreach (ValoresWeb item in regGraficos)
            {
                if (lsb_parameters.SelectedItem.Equals("Blood Pressure") && (lsb_parameters.GetItemCheckState(0) == CheckState.Checked))
                {
                    chart1.Series["Blood Pressure"].Points.AddXY(item.dataOfReposit.ToOADate(), item.bloodPressureMax);
                    chart1.Series["Blood Pressure"].Points.AddXY(item.dataOfReposit.ToOADate(), item.bloodPressureMin);
                }
                if (lsb_parameters.SelectedItem.Equals("Blood Pressure") && (lsb_parameters.GetItemCheckState(0) == CheckState.Unchecked))
                {
                    chart1.Series["Blood Pressure"].Points.Clear();
                }

                if (lsb_parameters.SelectedItem.Equals("Heart Rate") && (lsb_parameters.GetItemCheckState(1) == CheckState.Checked))
                {
                    chart1.Series["Heart Rate"].Points.AddXY(item.dataOfReposit.ToOADate(), item.heartRate);
                }
                if (lsb_parameters.SelectedItem.Equals("Heart Rate") && (lsb_parameters.GetItemCheckState(1) == CheckState.Unchecked))
                {
                    chart1.Series["Heart Rate"].Points.Clear();
                }

                if (lsb_parameters.SelectedItem.Equals("Oxygen Saturation") && (lsb_parameters.GetItemCheckState(2) == CheckState.Checked))
                {
                    chart1.Series["Oxygen Saturation"].Points.AddXY(item.dataOfReposit.ToOADate(), item.oxigenSat);
                }
                if (lsb_parameters.SelectedItem.Equals("Oxygen Saturation") && (lsb_parameters.GetItemCheckState(2) == CheckState.Unchecked))
                {
                    chart1.Series["Oxygen Saturation"].Points.Clear();
                }
            }
        }
    }
}
