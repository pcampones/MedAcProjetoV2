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
using System.Speech.Recognition;
using System.Xml;
using System.Web;
using System.Net;

namespace BOT
{
    public partial class Form1 : Form
    {

        //dssdskfdn nkekj
        private Service1Client serv;
        PhysiologicParametersDll.PhysiologicParametersDll dll = null;
        PhysiologicParametersDll.PhysiologicParametersDll dllC = null;
        PhysiologicParametersDll.PhysiologicParametersDll dllH = null;

        private UtenteWeb u;

        enum DataType { Normal, Alerts };

        private int sns;

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
             sns = Settings.Default.SNS;

            toolStripTextBox1.Text = sns.ToString();
            //Settings.Default.SNS = int.Parse( toolStrip1.Text);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dll != null)
            {
                if (checkedListBox1.SelectedItem.Equals("Blood Pressure") && checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
                {
                    dll.Initialize(BloodPressure, Settings.Default.Delay, true, false, false);
                    serv.AddValues(Settings.Default.SNS, int.Parse(textBox1.Text), 0, 0, DateTime.Now);
                }
            
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
                 

                textBox1.Text = heartRate.LastOrDefault();
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

                textBox2.Text = heartRate.LastOrDefault();
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

            if (u == null)
            {
                lbl_name.Text = "N.D";
                lbl_age.Text = "N.D";
                lbl_birthdate.Text = "N.D";
                lbl_sns.Text = "N.D";
                lbl_surname.Text = "N.D";
            }
          


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



        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //dsdsj n nsd sds
            Properties.Settings.Default.SNS = int.Parse(toolStripTextBox1.Text);
            Properties.Settings.Default.Save();
            
             u = serv.GetUtenteBySNS(int.Parse(toolStripTextBox1.Text));
            if (u != null)
            {
              
                toolStripLabel2.Text = "Welcome " + u.name;

                MessageBox.Show("SNS valid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("");
                sns = u.sns;
                lbl_sns.Text = sns.ToString();
                lbl_name.Text = u.name;
                lbl_surname.Text = u.surname;
                lbl_age.Text = u.age.ToString();
                lbl_birthdate.Text = u.birthdate.ToShortDateString();
                lbl_age.Text = u.age.ToString();
    
                

            }
            else
            {
                MessageBox.Show("SNS not valid! Please, try other!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_name.Text = "N.D";
                lbl_age.Text = "N.D";
                lbl_birthdate.Text = "N.D";
                lbl_sns.Text = "N.D";
                lbl_surname.Text = "N.D";
                toolStripLabel2.Text = "N.D";
                

            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void panelMe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(toolStripTextBox1.Text, "  ^ [0-9]"))
            {
                toolStripTextBox1.Text = " ";
            }

        }

        private void FillListView(List<SearchTerm> results)
        {
            foreach (SearchTerm result in results)
            {
                ListViewItem item1 = new ListViewItem(result.Rank.ToString());
                item1.SubItems.Add(result.Title);
                item1.SubItems.Add(result.OrganizationName);

                String a = "";

                foreach (String altTitle in result.AltTitles)
                {
                    a = a + "\t" + altTitle;
    }

                item1.SubItems.Add(a);
                item1.SubItems.Add(result.FullSummary);
                listView1.Items.Add(item1);
}
        }

        private void bt_procurar_Click(object sender, EventArgs e)
        {
            string url = Properties.Settings.Default.Medline;
            int retmax = Properties.Settings.Default.Retmax;
            string term = txb_palavra.Text;
            string urlComp = url + term + "&retmax=" + retmax;

            MessageBox.Show(url);
            var client = new WebClient();
            client.DownloadStringAsync(new Uri(urlComp));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;

        //    serv = new Service1Client();

            

            

            

            //SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

            //List<String> options = new List<String>(new String[] { "search" });

            //Choices choicesOptions = new Choices(options.ToArray());

            //GrammarBuilder gb = new GrammarBuilder();
            //gb.Append(choicesOptions);

            //Grammar g = new Grammar(gb);
            //g.Name = "services grammar";
            ////groupBox1.Name = g.Name;
            //recognizer.LoadGrammar(g);

            //recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

            //recognizer.SetInputToDefaultAudioDevice();

            //recognizer.RecognizeAsync(RecognizeMode.Multiple);     
            //}

            // void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            //{
            //    if (e.Result.Text.Equals("search"))
            //    {
            //        listView1.Items.Clear();

            listView1.Columns.Add("Rank", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Title", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Organization Name", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Alternative Names", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Full Summary", 200, HorizontalAlignment.Left);


      
            }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string content = e.Result;
            MessageBox.Show(content);

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(content);
            doc.Save("temp.xml");

            List<SearchTerm> results = new List<SearchTerm>();

            XmlNodeList documentsNode = doc.SelectNodes("nlmSearchResult/list/document");

            foreach (XmlNode xmlNode in documentsNode)
            {
                SearchTerm searchTerm = new SearchTerm();
                searchTerm.Rank = Convert.ToInt32(xmlNode.SelectSingleNode("./@rank").InnerText);
                searchTerm.Title = xmlNode.SelectSingleNode("./content[@name='title']").InnerText;
                searchTerm.OrganizationName = xmlNode.SelectSingleNode("./content[@name='organizationName']").InnerText;

                XmlNodeList altList = xmlNode.SelectNodes("./content[@name='altTitle']");

                foreach (XmlNode alttitle in altList)
                {
                    searchTerm.AltTitles.Add(alttitle.InnerText);
                }

                searchTerm.FullSummary = xmlNode.SelectSingleNode("./content[@name='FullSummary']").InnerText;

                results.Add(searchTerm);
            }
            FillListView(results);

        }

        ////private void listView1_DoubleClick(object sender, EventArgs e)
        ////{
        ////    String a = listView1.SelectedItems[0].SubItems[4].Text;
        ////    InfoForm form = new InfoForm(a);
        ////    form.Show();
        ////}
    }

    }

      
    


