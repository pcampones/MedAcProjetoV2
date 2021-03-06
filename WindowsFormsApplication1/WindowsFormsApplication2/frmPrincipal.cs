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
using System.Windows.Forms.DataVisualization.Charting;

namespace ClinicalAlert
{
    public partial class frmPrincipal : Form
    {


        private Service1Client serv;//ahagag
        UtenteWeb ut;
        ValoresWeb val;
        string gender;
        string ative = "Inative";
        int sns;
        int item2;

        DateTime dataMax = DateTime.Now;
        DateTime dataMin = DateTime.Now.AddDays(-2);


        public frmPrincipal()
        {
            InitializeComponent();

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the start position of the form to the center of the screen. ajahag
            this.StartPosition = FormStartPosition.CenterScreen;

            serv = new Service1Client();

            panel_relatorios.Visible = false;
            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = true;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            ativeCheckBox.Checked = true;
            panelDiarioValores.Visible = false;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView_ative_alerts.View = View.Details;
            listView_ative_alerts.FullRowSelect = true;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            List<UtenteWeb> listaUtente = serv.GetListaUtentes().ToList();

            foreach (UtenteWeb item in listaUtente)

            {

                ListViewItem linha = new ListViewItem(item.sns.ToString(), 0);
                linha.SubItems.Add(item.name + " " + item.surname);
                listView1.Items.Add(linha);
            }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = true;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = false;
            panel_Reports.Visible = false;

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            panelPrincipal.Visible = false;
            panel_Adicionar.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = false;
            panel_Reports.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ut = new UtenteWeb();
            bool a = false;
            a = verificaCampos();

            if (a == true && maleRb.Checked || femaleRb.Checked)
            {

                ut.gender = gender;

                ut.name = txb_name.Text;
                ut.surname = txb_surname.Text;
                ut.sns = Int32.Parse(txb_sns.Text);
                ut.mail = txb_email.Text;
                ut.bi = Convert.ToInt32(txb_bi.Text);


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
            }


            else
            {
                MessageBox.Show("Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String.IsNullOrEmpty(rtxb_alergies.Text) || String.IsNullOrWhiteSpace(rtxb_alergies.Text)
                 )
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
                ativeCheckBox.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown3.Enabled = false;
                richTextBox1.Enabled = false;
                button2.Text = "Edit";
                MessageBox.Show("Successfully edited data!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ativeCheckBox.Enabled = true;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelPrincipal.Visible = true;
            panel_Adicionar.Visible = false;
            panelGraficos.Visible = false;
            panelAlerts.Visible = false;
            panelDiarioValores.Visible = false;
            panel_Reports.Visible = false;

            listView1.Items.Clear();

            List<UtenteWeb> listaUtente = serv.GetListaUtentes().ToList();

            foreach (UtenteWeb item in listaUtente)

            {

                ListViewItem linha = new ListViewItem(item.sns.ToString(), 0);
                linha.SubItems.Add(item.name + " " + item.surname);

                listView1.Items.Add(linha);
            }


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
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;

                if (u.gender == "Male")
                {
                    radioButton1.Checked = true;

                }
                else
                {
                    radioButton2.Checked = true;
                }
                numericUpDown4.Value = u.weight;
                numericUpDown4.Enabled = false;
                numericUpDown3.Value = u.height;
                numericUpDown3.Enabled = false;
                richTextBox1.Text = u.alergies;
                richTextBox1.Enabled = false;

                if (ative == "Ative")
                {
                    ativeCheckBox.Checked = true;
                }




            }
        }


        //Graficos

        private void listView2_DoubleClick(object sender, EventArgs e)
        {

            string tipo = listView2.SelectedItems[0].SubItems[2].Text;
            string type = listView2.SelectedItems[0].SubItems[4].Text;
            DateTime data = Convert.ToDateTime(listView2.SelectedItems[0].SubItems[3].Text);
            List<ValoresWeb> lista = serv.GetValuesAlerts(item2, type, tipo, data).ToList();

            if (lista != null)
            {

                chartAlert frmChart = new chartAlert(lista);
                frmChart.ShowDialog();

            }



        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = true;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = false;
            panel_Reports.Visible = false;

            
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;

            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Height = 250;
            chart1.Width = 650;

            chart1.Titles.Add("Chart Values");

            //Construção da àrea do gráfico
            chart1.ChartAreas.Add("area");

            dtp_begin.Value = dataMin;
            dtp_end.Value = dataMax;
            //dataMin = dtp_begin.Value;
            //6dataMax = dtp_end.Value;
            chart1.ChartAreas["area"].AxisX.Minimum = dataMin.ToOADate();
            chart1.ChartAreas["area"].AxisX.Maximum = dataMax.ToOADate();
            chart1.ChartAreas["area"].AxisX.Interval = 1;
            chart1.ChartAreas["area"].AxisY.Minimum = 0;
            chart1.ChartAreas["area"].AxisY.Interval = 10;

            chart1.ChartAreas["area"].AxisX.Title = "Date";
            chart1.ChartAreas["area"].AxisY.Title = "Values";

            chart1.Series.Add("Blood Pressure Diastolic");

            chart1.Series.Add("Blood Pressure Systolic");
            chart1.Series.Add("Heart Rate");
            chart1.Series.Add("Oxygen Saturation");

            //definição da cor de cada série
            chart1.Series["Blood Pressure Diastolic"].Color = Color.Red;
            chart1.Series["Heart Rate"].Color = Color.Blue;
            chart1.Series["Oxygen Saturation"].Color = Color.Green;
            chart1.Series["Blood Pressure Systolic"].Color = Color.Yellow;

            chart1.Series["Blood Pressure Diastolic"].Points.AddXY(dataMin, 0);
            chart1.Series["Heart Rate"].Points.AddXY(dataMax, 0);
            chart1.Series["Oxygen Saturation"].Points.AddXY(dataMax, 0);
            chart1.Series["Blood Pressure Systolic"].Points.AddXY(dataMax, 0);
            //a
            chart1.ChartAreas["area"].BackColor = Color.White;
            chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
            chart1.ChartAreas["area"].BackGradientStyle =
            System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

            chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
            chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

            chart1.Series["Blood Pressure Diastolic"].IsValueShownAsLabel = true;
            chart1.Series["Heart Rate"].IsValueShownAsLabel = true;
            chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = true;
            chart1.Series["Blood Pressure Systolic"].IsValueShownAsLabel = true;



        }

        private void cb_hr_CheckedChanged(object sender, EventArgs e)
        {
            if (verifySns(sns) == false)
            {

                if (cb_hr.Checked == true)
                {
                    checkBox2.Checked = false;
                    cb_bp.Checked = false;
                    cb_OS.Checked = false;

                    limpaGraficos(chart1);
                    limpaGraficos(chart2);
                    limpaGraficos(chart3);
                    limpaGraficos(chart4);

                    painelVisivelFalse(chart2);
                    painelVisivelFalse(chart3);
                    painelVisivelFalse(chart4);

                    chart1.Height = 250;
                    chart1.Width = 650;

                    chart1.ChartAreas.Add("area");
                    chart1.Series.Add("Heart Rate");


                    chart1.ChartAreas["area"].AxisX.Minimum = dataMin.ToOADate();
                    chart1.ChartAreas["area"].AxisX.Maximum = dataMax.ToOADate();

                    chart1.ChartAreas["area"].AxisX.Interval = 1;
                    chart1.ChartAreas["area"].AxisY.Minimum = 0;
                    chart1.ChartAreas["area"].AxisY.Interval = 10;

                    chart1.ChartAreas["area"].AxisX.Title = "Date";
                    chart1.ChartAreas["area"].AxisY.Title = "Values";

                    chart1.Series["Heart Rate"].Color = Color.Yellow;

                    chart1.Series["Heart Rate"].Points.AddXY(dataMin, 0);
                    chart1.Series["Heart Rate"].Points.AddXY(dataMax, 0);



                    chart1.ChartAreas["area"].BackColor = Color.White;
                    chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
                    chart1.ChartAreas["area"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart1.Series["Heart Rate"].IsValueShownAsLabel = true;
                    List<ValoresWeb> v = getValuesGraphs(sns, dataMax, dataMin).ToList();

                    foreach (var item in v)
                    {
                        if (item.type == "HR")
                        {
                            chart1.Series["Heart Rate"].Points.AddXY(item.dataOfReposit.ToOADate(), item.valueR);
                        }

                    }

                }
            
            }
            else
            {
                cb_hr.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_OS_CheckedChanged(object sender, EventArgs e)
        {
            if (verifySns(sns) == false)
            {
                if (cb_OS.Checked == true)
                {
                    checkBox2.Checked = false;
                    cb_bp.Checked = false;
                    cb_hr.Checked = false;
                    limpaGraficos(chart1);
                    limpaGraficos(chart2);
                    limpaGraficos(chart3);
                    limpaGraficos(chart4);

                    painelVisivelFalse(chart2);
                    painelVisivelFalse(chart3);
                    painelVisivelFalse(chart4);

                    chart1.Height = 250;
                    chart1.Width = 650;

                    chart1.ChartAreas.Add("area");
                    chart1.Series.Add("Oxygen Saturation");


                    chart1.ChartAreas["area"].AxisX.Minimum = dataMin.ToOADate();
                    chart1.ChartAreas["area"].AxisX.Maximum = dataMax.ToOADate();

                    chart1.ChartAreas["area"].AxisX.Interval = 1;
                    chart1.ChartAreas["area"].AxisY.Minimum = 0;
                    chart1.ChartAreas["area"].AxisY.Interval = 10;

                    chart1.ChartAreas["area"].AxisX.Title = "Date";
                    chart1.ChartAreas["area"].AxisY.Title = "Values";

                    chart1.Series["Oxygen Saturation"].Color = Color.Yellow;

                    chart1.Series["Oxygen Saturation"].Points.AddXY(dataMin, 0);
                    chart1.Series["Oxygen Saturation"].Points.AddXY(dataMax, 0);



                    chart1.ChartAreas["area"].BackColor = Color.White;
                    chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
                    chart1.ChartAreas["area"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = true;

                    List<ValoresWeb> v = getValuesGraphs(sns, dataMax, dataMin).ToList();

                    foreach (ValoresWeb item in v)
                    {
                        if (item.type == "SPO2")
                        {
                            chart1.Series["Oxygen Saturation"].Points.AddXY(item.dataOfReposit.ToOADate(), item.valueR);
                        }

                    }

                }
               /* else
                {
                    chart1.Series["Oxygen Saturation"].Points.Clear();

                }
                */
            }

            else
            {
                cb_OS.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        
            limpaGraficos(chart1);
            limpaGraficos(chart2);
            limpaGraficos(chart3);
            limpaGraficos(chart4);

            painelVisivel(chart1);
            painelVisivel(chart2);
            painelVisivel(chart3);
            painelVisivel(chart4);

            
           
            if (verifySns(sns) == false)
            {

                if (checkBox2.Checked == true)
                {
                    cb_bp.Checked = false;
                    cb_hr.Checked = false;
                    cb_OS.Checked = false;


                    chart1.Height = 126;
                    chart1.Width = 300;

                    chart1.ChartAreas.Add("bpD");
                    chart2.ChartAreas.Add("bpS");
                    chart3.ChartAreas.Add("hr");
                    chart4.ChartAreas.Add("ox");

                    chart1.ChartAreas["bpD"].AxisX.Minimum = dataMin.ToOADate();
                    chart1.ChartAreas["bpD"].AxisX.Maximum = dataMax.ToOADate();

                    chart1.ChartAreas["bpD"].AxisX.Interval = 1;
                    chart1.ChartAreas["bpD"].AxisY.Minimum = 0;
                    chart1.ChartAreas["bpD"].AxisY.Interval = 10;

                    chart1.ChartAreas["bpD"].AxisX.Title = "Date";
                    chart1.ChartAreas["bpD"].AxisY.Title = "Values";

                    chart1.Series.Add("Blood Pressure Diastolic");

                    chart1.Series["Blood Pressure Diastolic"].Color = Color.Red;

                    chart1.Series["Blood Pressure Diastolic"].Points.AddXY(dataMin, 0);
                    chart1.Series["Blood Pressure Diastolic"].Points.AddXY(dataMax, 0);

                    chart1.ChartAreas["bpD"].BackColor = Color.White;
                    chart1.ChartAreas["bpD"].BackSecondaryColor = Color.LightBlue;
                    chart1.ChartAreas["bpD"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart1.ChartAreas["bpD"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart1.ChartAreas["bpD"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart1.Series["Blood Pressure Diastolic"].IsValueShownAsLabel = true;

                    ////////////////////////////////////
                    chart2.ChartAreas["bpS"].AxisX.Minimum = dataMin.ToOADate();
                    chart2.ChartAreas["bpS"].AxisX.Maximum = dataMax.ToOADate();

                    chart2.ChartAreas["bpS"].AxisX.Interval = 1;
                    chart2.ChartAreas["bpS"].AxisY.Minimum = 0;
                    chart2.ChartAreas["bpS"].AxisY.Interval = 10;

                    chart2.ChartAreas["bpS"].AxisX.Title = "Date";
                    chart2.ChartAreas["bpS"].AxisY.Title = "Values";

                    chart2.Series.Add("Blood Pressure Systolic");

                    chart2.Series["Blood Pressure Systolic"].Color = Color.Red;

                    chart2.Series["Blood Pressure Systolic"].Points.AddXY(dataMin, 0);
                    chart2.Series["Blood Pressure Systolic"].Points.AddXY(dataMax, 0);

                    chart2.ChartAreas["bpS"].BackColor = Color.White;
                    chart2.ChartAreas["bpS"].BackSecondaryColor = Color.LightBlue;
                    chart2.ChartAreas["bpS"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart2.ChartAreas["bpS"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart2.ChartAreas["bpS"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart2.Series["Blood Pressure Systolic"].IsValueShownAsLabel = true;

                    ////////////////////////////////////////

                    chart3.ChartAreas["hr"].AxisX.Minimum = dataMin.ToOADate();
                    chart3.ChartAreas["hr"].AxisX.Maximum = dataMax.ToOADate();

                    chart3.ChartAreas["hr"].AxisX.Interval = 1;
                    chart3.ChartAreas["hr"].AxisY.Minimum = 0;
                    chart3.ChartAreas["hr"].AxisY.Interval = 10;

                    chart3.ChartAreas["hr"].AxisX.Title = "Date";
                    chart3.ChartAreas["hr"].AxisY.Title = "Values";

                    chart3.Series.Add("Heart Rate");

                    chart3.Series["Heart Rate"].Color = Color.Red;

                    chart3.Series["Heart Rate"].Points.AddXY(dataMin, 0);
                    chart3.Series["Heart Rate"].Points.AddXY(dataMax, 0);

                    chart3.ChartAreas["hr"].BackColor = Color.White;
                    chart3.ChartAreas["hr"].BackSecondaryColor = Color.LightBlue;
                    chart3.ChartAreas["hr"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart3.ChartAreas["hr"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart3.ChartAreas["hr"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart3.Series["Heart Rate"].IsValueShownAsLabel = true;

                    ////////////////////////////////////////7

                    chart4.ChartAreas["ox"].AxisX.Minimum = dataMin.ToOADate();
                    chart4.ChartAreas["ox"].AxisX.Maximum = dataMax.ToOADate();

                    chart4.ChartAreas["ox"].AxisX.Interval = 1;
                    chart4.ChartAreas["ox"].AxisY.Minimum = 0;
                    chart4.ChartAreas["ox"].AxisY.Interval = 10;

                    chart4.ChartAreas["ox"].AxisX.Title = "Date";
                    chart4.ChartAreas["ox"].AxisY.Title = "Values";

                    chart4.Series.Add("Oxygen Saturation");

                    chart4.Series["Oxygen Saturation"].Color = Color.Red;

                    chart4.Series["Oxygen Saturation"].Points.AddXY(dataMin, 0);
                    chart4.Series["Oxygen Saturation"].Points.AddXY(dataMax, 0);

                    chart4.ChartAreas["ox"].BackColor = Color.White;
                    chart4.ChartAreas["ox"].BackSecondaryColor = Color.LightBlue;
                    chart4.ChartAreas["ox"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart4.ChartAreas["ox"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart4.ChartAreas["ox"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart4.Series["Oxygen Saturation"].IsValueShownAsLabel = true;


                    List<ValoresWeb> v = getValuesGraphs(sns, dataMax, dataMin).ToList();

                    foreach (ValoresWeb item in v)
                    {   if (item.type == "BP")
                        {

                            string[] bp = item.valueR.Split('-');

                            chart2.Series["Blood Pressure Systolic"].Points.AddXY(item.dataOfReposit.ToOADate(), bp[0]);
                            chart1.Series["Blood Pressure Diastolic"].Points.AddXY(item.dataOfReposit.ToOADate(), bp[1]);
                            
                        }
                        else if (item.type == "HR")
                        {
                            chart3.Series["Heart Rate"].Points.AddXY(item.dataOfReposit.ToOADate(),item.valueR);
                        }
                        else if (item.type == "SPO2")
                        {

                            chart4.Series["Oxygen Saturation"].Points.AddXY(item.dataOfReposit.ToOADate(), item.valueR);

                        }

                    }

                }
               // else
             /*   {
                 //   chart1.Series["Blood Pressure Diastolic"].Points.Clear();
                    chart2.Series["Blood Pressure Systolic"].Points.Clear();
                    chart3.Series["Heart Rate"].Points.Clear();
                    chart4.Series["Oxygen Saturation"].Points.Clear();


                }*/
            }
            else
            {
                checkBox2.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void cb_bp_CheckedChanged(object sender, EventArgs e)
        {
            if (verifySns(sns) == false)
            {

                if (cb_bp.Checked == true)
                {
                    checkBox2.Checked = false;
                    cb_hr.Checked = false;
                    cb_OS.Checked = false;


                    limpaGraficos(chart1);
                    limpaGraficos(chart2);
                    limpaGraficos(chart3);
                    limpaGraficos(chart4);

                    painelVisivelFalse(chart2);
                    painelVisivelFalse(chart3);
                    painelVisivelFalse(chart4);

                    chart1.Height = 250;
                    chart1.Width = 650;

                    chart1.ChartAreas.Add("area");
                    chart1.Series.Add("Blood Pressure Systolic");
                    chart1.Series.Add("Blood Pressure Diastolic");

                    
                    chart1.ChartAreas["area"].AxisX.Minimum = dataMin.ToOADate();
                    chart1.ChartAreas["area"].AxisX.Maximum = dataMax.ToOADate();

                    chart1.ChartAreas["area"].AxisX.Interval = 1;
                    chart1.ChartAreas["area"].AxisY.Minimum = 0;
                    chart1.ChartAreas["area"].AxisY.Interval = 10;

                    chart1.ChartAreas["area"].AxisX.Title = "Date";
                    chart1.ChartAreas["area"].AxisY.Title = "Values";

                    
                    chart1.Series["Blood Pressure Diastolic"].Color = Color.Red;
                    chart1.Series["Blood Pressure Systolic"].Color = Color.Yellow;

                    chart1.Series["Blood Pressure Diastolic"].Points.AddXY(dataMin, 0);
                    chart1.Series["Blood Pressure Systolic"].Points.AddXY(dataMax, 0);



                    chart1.ChartAreas["area"].BackColor = Color.White;
                    chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
                    chart1.ChartAreas["area"].BackGradientStyle =
                    System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                    chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                    chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                    chart1.Series["Blood Pressure Diastolic"].IsValueShownAsLabel = true;

                    chart1.Series["Blood Pressure Systolic"].IsValueShownAsLabel = true;
                    
                    List<ValoresWeb> v = getValuesGraphs(sns, dataMax, dataMin).ToList();

                    foreach (ValoresWeb item in v)
                    {
                        
                 
                        string[] bp = item.valueR.Split('-');

                        if (item.type == "BP")
                        {
                            chart1.Series["Blood Pressure Systolic"].Points.AddXY(item.dataOfReposit.ToOADate(), bp[0]);
                            chart1.Series["Blood Pressure Diastolic"].Points.AddXY(item.dataOfReposit.ToOADate(),bp[1]);
                        }

                    }

                }
                //else
                //{
                //    chart1.Series["Blood Pressure Diastolic"].Points.Clear();
                //    chart1.Series["Blood Pressure Systolic"].Points.Clear();

                //}
            }
            else
            {
                cb_bp.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cb_collumns_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == false)
            {

                if (cb_collumns.Checked == true)
                {

                    cb_bars.Checked = false;
                    cb_lines.Checked = false;


                    foreach (Series item in chart1.Series)
                    {
                        item.ChartType = SeriesChartType.Column;
                    }
                }
            }
            else
            {
                cb_bars.Checked = false;
                cb_lines.Checked = false;
                chart2.Series["Blood Pressure Systolic"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["Blood Pressure Diastolic"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                chart4.Series["Oxygen Saturation"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart3.Series["Heart Rate"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }


        }

        private void cb_lines_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == false)
            {

                if (cb_lines.Checked == true)
                {

                    cb_collumns.Checked = false;
                    cb_bars.Checked = false;


                    foreach (Series item in chart1.Series)
                    {
                        item.ChartType = SeriesChartType.Line; 
                    }
                }
            }
            else
            {
                cb_collumns.Checked = false;
                cb_bars.Checked = false;

                chart2.Series["Blood Pressure Systolic"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Blood Pressure Diastolic"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chart4.Series["Oxygen Saturation"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart3.Series["Heart Rate"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
        }

        private void cb_bars_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == false)
            {

                if (cb_bars.Checked == true)
                {
                    cb_collumns.Checked = false;
                    cb_lines.Checked = false;
                    //definição do tipo de gráficosss

                    foreach (Series item in chart1.Series)
                    {
                        item.ChartType = SeriesChartType.Bar;
                    }
                }
            }
            else
            {
                cb_collumns.Checked = false;
                cb_lines.Checked = false;

                chart2.Series["Blood Pressure Systolic"].ChartType =
             System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series["Blood Pressure Diastolic"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

                chart4.Series["Oxygen Saturation"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart3.Series["Heart Rate"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DateTime dataMin = dtp_begin.Value;
            DateTime dataMax = dtp_end.Value;
            if (checkBox2.Checked == false)
            {

                limpaGraficos(chart1);

                limpaGraficos(chart2);
                limpaGraficos(chart3);
                limpaGraficos(chart4);

                painelVisivelFalse(chart2);
                painelVisivelFalse(chart3);
                painelVisivelFalse(chart4);

                //Titulo do gráfico
                chart1.Titles.Add("Chart Values");
                chart1.Series.Add("Blood Pressure Systolic");
                chart1.Series.Add("Blood Pressure Diastolic");
                chart1.Series.Add("Heart Rate");
                chart1.Series.Add("Oxygen Saturation");


                chart1.Height = 250;
                chart1.Width = 650;

                //Construção da àrea do gráfico
                chart1.ChartAreas.Add("area");

                List<ValoresWeb> valores = null;
    
                if (verifySns(sns) == false)
                {

                    if (dataMin < dataMax)
                    {
                        valores = getValuesGraphs(sns, dataMax, dataMin).ToList();
                        if (valores.Count != 0)
                        {

                            foreach (var item in valores)
                            {
                                if (cb_hr.Checked == true)
                                {
                                    if (item.type == "HR")
                                    {
                                        chart1.Series["Heart Rate"].Points.AddXY(item.dataOfReposit, item.valueR);

                                    }
                                }
                                if (cb_bp.Checked == true)
                                {
                                    if (item.type == "BP")
                                    {
                                        string[] bp = item.valueR.Split('-');
                                        chart1.Series["Blood Pressure Systolic"].Points.AddXY(item.dataOfReposit, bp[0]);
                                        chart1.Series["Blood Pressure Diastolic"].Points.AddXY(item.dataOfReposit, bp[1]);

                                    }

                                }

                                if (cb_OS.Checked == true)
                                {
                                    if (item.type == "SPO2")
                                    {
                                        chart1.Series["Oxygen Saturation"].Points.AddXY(item.dataOfReposit, item.valueR);

                                    }
                                }

                            }

                            chart1.ChartAreas["area"].AxisX.Minimum = dataMin.ToOADate();
                            chart1.ChartAreas["area"].AxisX.Maximum = dataMax.ToOADate();
                            chart1.ChartAreas["area"].AxisX.Interval = 1;
                            chart1.ChartAreas["area"].AxisY.Minimum = 0;
                            chart1.ChartAreas["area"].AxisY.Interval = 10;

                            chart1.ChartAreas["area"].AxisX.Title = "Date";
                            chart1.ChartAreas["area"].AxisY.Title = "Values";


                            //definição da cor de cada série
                            chart1.Series["Blood Pressure Diastolic"].Color = Color.Red;
                            chart1.Series["Blood Pressure Systolic"].Color = Color.Yellow;
                            chart1.Series["Heart Rate"].Color = Color.Blue;
                            chart1.Series["Oxygen Saturation"].Color = Color.Green;


                            chart1.ChartAreas["area"].BackColor = Color.White;
                            chart1.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
                            chart1.ChartAreas["area"].BackGradientStyle =
                            System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                            chart1.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                            chart1.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;


                            chart1.Series["Blood Pressure Systolic"].IsValueShownAsLabel = true;

                            chart1.Series["Blood Pressure Diastolic"].IsValueShownAsLabel = true;
                            chart1.Series["Heart Rate"].IsValueShownAsLabel = true;
                            chart1.Series["Oxygen Saturation"].IsValueShownAsLabel = true;
                        }
                        else
                        {
                            MessageBox.Show("For the dates choosen doesn't have values associated!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("The start date can not be bigger than the end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {


                if (verifySns(sns) == false)
                {

                    limpaGraficos(chart1);
                    limpaGraficos(chart2);
                    limpaGraficos(chart3);
                    limpaGraficos(chart4);
                    painelVisivel(chart2);
                    painelVisivel(chart3);
                    painelVisivel(chart4);
                    cb_bp.Checked = false;
                        cb_hr.Checked = false;
                        cb_OS.Checked = false;


                        chart1.Height = 126;
                        chart1.Width = 300;

                        chart1.ChartAreas.Add("bpD");
                        chart2.ChartAreas.Add("bpS");
                        chart3.ChartAreas.Add("hr");
                        chart4.ChartAreas.Add("ox");

                        chart1.ChartAreas["bpD"].AxisX.Minimum = dataMin.ToOADate();
                        chart1.ChartAreas["bpD"].AxisX.Maximum = dataMax.ToOADate();

                        chart1.ChartAreas["bpD"].AxisX.Interval = 1;
                        chart1.ChartAreas["bpD"].AxisY.Minimum = 0;
                        chart1.ChartAreas["bpD"].AxisY.Interval = 10;

                        chart1.ChartAreas["bpD"].AxisX.Title = "Date";
                        chart1.ChartAreas["bpD"].AxisY.Title = "Values";

                        chart1.Series.Add("Blood Pressure Diastolic");

                        chart1.Series["Blood Pressure Diastolic"].Color = Color.Red;

                        chart1.Series["Blood Pressure Diastolic"].Points.AddXY(dataMin, 0);
                        chart1.Series["Blood Pressure Diastolic"].Points.AddXY(dataMax, 0);

                        chart1.ChartAreas["bpD"].BackColor = Color.White;
                        chart1.ChartAreas["bpD"].BackSecondaryColor = Color.LightBlue;
                        chart1.ChartAreas["bpD"].BackGradientStyle =
                        System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                        chart1.ChartAreas["bpD"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                        chart1.ChartAreas["bpD"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                        chart1.Series["Blood Pressure Diastolic"].IsValueShownAsLabel = true;

                        ////////////////////////////////////
                        chart2.ChartAreas["bpS"].AxisX.Minimum = dataMin.ToOADate();
                        chart2.ChartAreas["bpS"].AxisX.Maximum = dataMax.ToOADate();

                        chart2.ChartAreas["bpS"].AxisX.Interval = 1;
                        chart2.ChartAreas["bpS"].AxisY.Minimum = 0;
                        chart2.ChartAreas["bpS"].AxisY.Interval = 10;

                        chart2.ChartAreas["bpS"].AxisX.Title = "Date";
                        chart2.ChartAreas["bpS"].AxisY.Title = "Values";

                        chart2.Series.Add("Blood Pressure Systolic");

                        chart2.Series["Blood Pressure Systolic"].Color = Color.Red;

                        chart2.Series["Blood Pressure Systolic"].Points.AddXY(dataMin, 0);
                        chart2.Series["Blood Pressure Systolic"].Points.AddXY(dataMax, 0);

                        chart2.ChartAreas["bpS"].BackColor = Color.White;
                        chart2.ChartAreas["bpS"].BackSecondaryColor = Color.LightBlue;
                        chart2.ChartAreas["bpS"].BackGradientStyle =
                        System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                        chart2.ChartAreas["bpS"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                        chart2.ChartAreas["bpS"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                        chart2.Series["Blood Pressure Systolic"].IsValueShownAsLabel = true;

                        ////////////////////////////////////////

                        chart3.ChartAreas["hr"].AxisX.Minimum = dataMin.ToOADate();
                        chart3.ChartAreas["hr"].AxisX.Maximum = dataMax.ToOADate();

                        chart3.ChartAreas["hr"].AxisX.Interval = 1;
                        chart3.ChartAreas["hr"].AxisY.Minimum = 0;
                        chart3.ChartAreas["hr"].AxisY.Interval = 10;

                        chart3.ChartAreas["hr"].AxisX.Title = "Date";
                        chart3.ChartAreas["hr"].AxisY.Title = "Values";

                        chart3.Series.Add("Heart Rate");

                        chart3.Series["Heart Rate"].Color = Color.Red;

                        chart3.Series["Heart Rate"].Points.AddXY(dataMin, 0);
                        chart3.Series["Heart Rate"].Points.AddXY(dataMax, 0);

                        chart3.ChartAreas["hr"].BackColor = Color.White;
                        chart3.ChartAreas["hr"].BackSecondaryColor = Color.LightBlue;
                        chart3.ChartAreas["hr"].BackGradientStyle =
                        System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                        chart3.ChartAreas["hr"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                        chart3.ChartAreas["hr"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                        chart3.Series["Heart Rate"].IsValueShownAsLabel = true;

                        ////////////////////////////////////////7

                        chart4.ChartAreas["ox"].AxisX.Minimum = dataMin.ToOADate();
                        chart4.ChartAreas["ox"].AxisX.Maximum = dataMax.ToOADate();

                        chart4.ChartAreas["ox"].AxisX.Interval = 1;
                        chart4.ChartAreas["ox"].AxisY.Minimum = 0;
                        chart4.ChartAreas["ox"].AxisY.Interval = 10;

                        chart4.ChartAreas["ox"].AxisX.Title = "Date";
                        chart4.ChartAreas["ox"].AxisY.Title = "Values";

                        chart4.Series.Add("Oxygen Saturation");

                        chart4.Series["Oxygen Saturation"].Color = Color.Red;

                        chart4.Series["Oxygen Saturation"].Points.AddXY(dataMin, 0);
                        chart4.Series["Oxygen Saturation"].Points.AddXY(dataMax, 0);

                        chart4.ChartAreas["ox"].BackColor = Color.White;
                        chart4.ChartAreas["ox"].BackSecondaryColor = Color.LightBlue;
                        chart4.ChartAreas["ox"].BackGradientStyle =
                        System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

                        chart4.ChartAreas["ox"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
                        chart4.ChartAreas["ox"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

                        chart4.Series["Oxygen Saturation"].IsValueShownAsLabel = true;


                        List<ValoresWeb> v = getValuesGraphs(sns, dataMax, dataMin).ToList();

                        foreach (ValoresWeb item in v)
                        {
                            if (item.type == "BP")
                            {

                                string[] bp = item.valueR.Split('-');

                                chart2.Series["Blood Pressure Systolic"].Points.AddXY(item.dataOfReposit.ToOADate(), bp[0]);
                                chart1.Series["Blood Pressure Diastolic"].Points.AddXY(item.dataOfReposit.ToOADate(), bp[1]);

                            }
                            else if (item.type == "HR")
                            {
                                chart3.Series["Heart Rate"].Points.AddXY(item.dataOfReposit.ToOADate(), item.valueR);
                            }
                            else if (item.type == "SPO2")
                            {

                                chart4.Series["Oxygen Saturation"].Points.AddXY(item.dataOfReposit.ToOADate(), item.valueR);

                            }

                        }

                    }
                
                else
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }


        // Alertas

        private void Alerts_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = true;
            panel_Reports.Visible = false;

            listView2.Items.Clear();
            listView_ative_alerts.Items.Clear();

            List<UtenteWeb> listUtente = serv.GetUtentesNotRead().ToList();

            foreach (UtenteWeb item in listUtente)
            {
                ListViewItem linha = new ListViewItem(item.sns.ToString(), 0);
                linha.SubItems.Add(item.name + " " + item.surname);
                listView_ative_alerts.Items.Add(linha);
            }
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_ative_alerts_SelectedIndexChanged(object sender, EventArgs e)
        {
             item2 = Convert.ToInt32(listView_ative_alerts.Items[listView_ative_alerts.FocusedItem.Index].SubItems[0].Text);

            DateTime start = DateTime.MinValue;
            DateTime end = DateTime.MaxValue;


            List<AlertasWeb> listaWeb = serv.GetAlertsNotReadDate(start, end, item2).ToList();

            foreach (AlertasWeb item in listaWeb)
            {
                if (item.read.Equals("Not Read"))
                {
                    ListViewItem linha = new ListViewItem(item.sns.ToString(), 0);
                    linha.SubItems.Add(item.read);
                    linha.SubItems.Add(item.tipo);
                    linha.SubItems.Add(item.dataAlerta.ToString());
                    linha.SubItems.Add(item.parametro);

                    if (item.tipo.Equals("Aviso Interminente") || item.tipo.Equals("Aviso Continuo"))
                    {
                        linha.BackColor = Color.Yellow;
                    }
                    else if (item.tipo.Equals("Critico Interminente") || item.tipo.Equals("Critico Continuo"))
                    {
                        linha.BackColor = Color.Red;
                    }
                    else
                    {
                        linha.BackColor = Color.Orange;
                    }

                    listView2.Items.Add(linha);

                    
                }
            
            }

        }


        private void bt_read_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                AlertasWeb al = new AlertasWeb();

                ListViewItem item = listView2.SelectedItems[0];
                if (listView2.SelectedItems[0].SubItems[1].Text.Equals("Not Read"))
                {
                    int id = Convert.ToInt32(listView2.SelectedItems[0].Text);
                    al.read = "Read";
                    serv.marcarComoLido(al, id);
                    listView2.SelectedItems[0].Remove();
                    listView2.Refresh();
                    MessageBox.Show("Alert Marked as read!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }


        }




        //Diario de Valores

        private void Reports_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = true;
            panelAlerts.Visible = false;
            panel_Reports.Visible = false;

            limpaDataGrid(Data_diarioValores);

            DateTime dateMin = DateTime.MinValue;
            DateTime dateMax = DateTime.MaxValue;

            List<ValoresWeb> lista = serv.GetValuesbySNS(sns, dateMax, dateMin).ToList();
            ValoresWeb valor = new ValoresWeb();


            foreach (ValoresWeb item in lista)
            {
                valor.valueR = item.valueR;
                valor.dataOfReposit = item.dataOfReposit;
                valor.type = item.type;


                Data_diarioValores.Rows.Add(valor.dataOfReposit, valor.type, valor.valueR);
                Data_diarioValores.Sort(this.Data_diarioValores.Columns[0], ListSortDirection.Ascending);


            }

        }

        // Estatisticas
        // Cemas
        private void diarioValores_Click(object sender, EventArgs e)
        {
            panel_Adicionar.Visible = false;
            panelPrincipal.Visible = false;
            panelEdit.Visible = false;
            panelGraficos.Visible = false;
            panelDiarioValores.Visible = false;
            panelAlerts.Visible = false;
            panel_Reports.Visible = true;


        }



        private void checkBoxHR_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dataMax = DateTime.Now;
            DateTime dataMin = DateTime.Now.AddDays(-7);

            limpaDataGrid(data_reports);

            if (verifySns(sns) == false)
            {
                if (checkBoxHR.Checked == true)
                {
                    checkBoxBP.Checked = false;
                    checkBoxOS.Checked = false;
                    EstatisticasWeb esta = getEstatisticas(sns, dataMin, dataMax, "HR");
                    if (esta != null)
                    {
                        data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);

                    }
                    else
                    {

                        MessageBox.Show(" The option you choose doesn't have default values in previous 7 days!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                checkBoxHR.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBoxOS_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dataMax = DateTime.Now;
            DateTime dataMin = DateTime.Now.AddDays(-7);

            limpaDataGrid(data_reports);

            if (verifySns(sns) == false)
            {

                if (checkBoxOS.Checked == true)
                {
                    checkBoxHR.Checked = false;
                    checkBoxBP.Checked = false;

                    EstatisticasWeb esta = getEstatisticas(sns, dataMin, dataMax, "SPO2");
                    if (esta != null)
                    {
                        data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);

                    }
                    else
                    {

                        MessageBox.Show(" The option you choose doesn't have default values in previous 7 days!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
            else
            {
                checkBoxOS.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxBP_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dataMax = DateTime.Now;
            DateTime dataMin = DateTime.Now.AddDays(-7);

            limpaDataGrid(data_reports);
            if (verifySns(sns) == false)
            {

                if (checkBoxBP.Checked == true)
                {
                    checkBoxHR.Checked = false;
                    checkBoxOS.Checked = false;

                    EstatisticasWeb esta = getEstatisticas(sns, dataMin, dataMax, "BP");
                    if (esta != null)
                    {
                        data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);

                    }
                    else
                    {

                        MessageBox.Show(" The option you choose doesn't have default values in previous 7 days!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            else
            {
                checkBoxBP.Checked = false;
                MessageBox.Show("Please Select the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp_start_reports.Value;
            DateTime endDate = dtp_end_reports.Value;

            EstatisticasWeb esta = null;
            limpaDataGrid(data_reports);


            if (verifySns(sns) == false)
            {
                if (startDate <= endDate)
                {
                    if (checkBoxBP.Checked == false && checkBoxHR.Checked == false && checkBoxOS.Checked == false)
                    {
                        MessageBox.Show("Please select checkbox!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (checkBoxBP.Checked == true)
                        {
                            esta = getEstatisticas(sns, dataMin, dataMax, "BP");
                            if (esta != null)
                            {
                                data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);
                            }
                            else
                            {
                                MessageBox.Show("For the dates selected doesn't have values associated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }

                        if (checkBoxOS.Checked == true)
                        {

                            esta = getEstatisticas(sns, dataMin, dataMax, "SPO2");
                            if (esta != null)
                            {
                                data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);
                            }
                            else
                            {
                                MessageBox.Show("For the dates selected doesn't have values associated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            // data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);
                        }

                        if (checkBoxHR.Checked == true)
                        {
                            esta = getEstatisticas(sns, startDate, endDate, "HR");

                            if (esta != null)
                            {
                                data_reports.Rows.Add(esta.valorMed, esta.valorMax, esta.valorMin, esta.tipo, esta.startDate, esta.endDate);
                            }
                            else
                            {
                                MessageBox.Show("For the dates selected doesn't have values associated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }

                    }

                }
                else
                {

                    MessageBox.Show("Start Date can not be bigger than End Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Please Select the Patient!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Metodos Auxiliares
        private bool verifySns(int sns)
        {
            if (sns == 0)
            {

                return true;
            }
            return false;
        }
        private void limpaDataGrid(DataGridView data)
        {
            data.Rows.Clear();
            data.Refresh();
        }

        private List<ValoresWeb> getValuesGraphs(int sns, DateTime startDate, DateTime endDate)
        {
            List<ValoresWeb> lista = serv.GetRegistofGrahp(sns, startDate, endDate).ToList();
            List<ValoresWeb> listaW = new List<ValoresWeb>();

            if (lista.Count != 0)
            {


                foreach (ValoresWeb item in lista)
                {
                    ValoresWeb v = new ValoresWeb();

                    v.valueR = item.valueR;
                    v.type = item.type;
                    v.dataOfReposit = item.dataOfReposit;

                    listaW.Add(v);

                }
                return listaW;

            }
            return null;
        }

        private EstatisticasWeb getEstatisticas(int sns, DateTime start, DateTime end, string type)
        {
            List<EstatisticasWeb> lista = serv.GetReportsHRbySNS(sns, start, end, type).ToList();


            if (lista.Count != 0)
            {
                EstatisticasWeb esta = new EstatisticasWeb();

                foreach (EstatisticasWeb item in lista)
                {
                    esta.valorMax = item.valorMax;
                    esta.valorMed = item.valorMed;
                    esta.valorMin = item.valorMin;
                    esta.startDate = item.startDate;
                    esta.tipo = item.tipo;
                    esta.endDate = item.endDate;

                    return esta;
                }

            }
            return null;
        }


        private void limpaGraficos(Chart area )
        {
            area.Series.Clear();
            area.Titles.Clear();
            area.ChartAreas.Clear();
        }

       
        private void painelVisivel(Chart area)
        {
            area.Visible = true;
        }

        private void painelVisivelFalse(Chart area)
        {
            area.Visible = false;
        }


    }
}
