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
using System.IO;
using System.Speech.Synthesis;

namespace BOT
{
    public partial class Form1 : Form
    {

        private Service1Client serv;
        private UtenteWeb u;
        private int sns;
        enum DataType { Normal, Alerts };
        //hahahaha
        bool BLOODPRESSSURE = true;
        bool HEARTRATE = true;
        bool OXIGENSATURATION = true;

        PhysiologicParametersDll.PhysiologicParametersDll dll = null;

        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        List<SearchTerm> listSearchTerm = new List<SearchTerm>();

        BackgroundWorker bw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            serv = new Service1Client();

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;         
            bw.DoWork += new DoWorkEventHandler(doWork);

            panelDataAcquisition.Visible = false;
            panelMe.Visible = false;
            panel1.Visible = false;
            panelPrincipal.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sns = Settings.Default.SNS;
            bloodPreCheckBox.Checked = false;
            heartRateCheckBox.Checked = false;
            oxigenPressurecheckBox.Checked = false;
            toolStripTextBox1.Text = sns.ToString();
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
            panel1.Visible = false;

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
            panel1.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
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
            Properties.Settings.Default.SNS = int.Parse(toolStripTextBox1.Text);
            Properties.Settings.Default.Save();

            u = serv.GetUtenteBySNS(int.Parse(toolStripTextBox1.Text));
            if (u != null)
            {
                toolStripLabel2.Text = "Welcome " + u.name;

                MessageBox.Show("SNS valid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                String a = "";

                foreach (String altTitle in result.AltTitles)
                {
                    a = a + "\t" + altTitle;
                }

                item1.SubItems.Add(a);
                item1.SubItems.Add(result.FullSummary);
            }
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

        private void panelDataAcquisition_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            dll.Stop();

        }

        private void initDLL_Click(object sender, EventArgs e)
        {

            dll = new PhysiologicParametersDll.PhysiologicParametersDll();


            bw.RunWorkerAsync();
        }

        private void bloodPreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bloodPreCheckBox.Checked)
            {
                BLOODPRESSSURE = true;

            }
            else
            {
                BLOODPRESSSURE = false;
            }
        }

        private void oxigenPressurecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oxigenPressurecheckBox.Checked)
            {
                OXIGENSATURATION = true;
            }
            else
            {
                OXIGENSATURATION = false;
            }
        }

        private void heartRateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (heartRateCheckBox.Checked)
            {
                HEARTRATE = true;
            }
            else
            {
                HEARTRATE = false;
            }
        }

        private void launchAlertsButton_Click(object sender, EventArgs e)
        {
            dll = new PhysiologicParametersDll.PhysiologicParametersDll();

            bw.RunWorkerAsync(DataType.Alerts);
        }
        public void NewSensorValueFunction(string str)
        {

            string[] valor = str.Split(';', '-');


            this.BeginInvoke((MethodInvoker)delegate
            {
                if (valor[0].Equals("BP"))
                {
                    bloodPressureMinLbl.Text = valor[2];
                    bloodPressureMaxLbl.Text = valor[1];

                    label16.Text = valor[3];

                    serv.AddValues(Settings.Default.SNS, "BP", bloodPressureMaxLbl.Text , DateTime.Parse(label16.Text));

                }
                else if (valor[0].Equals("HR"))
                {
                    heartRateLbl.Text = valor[1];
                    label15.Text = valor[2];

                    serv.AddValues(Settings.Default.SNS, "HR", heartRateLbl.Text, DateTime.Parse(label15.Text));

                }
                else if (valor[0].Equals("SPO2"))
                {
                    oxigenPressureLbl.Text = valor[1];
                    label17.Text = valor[2];

                    serv.AddValues(Settings.Default.SNS, "SPO2", oxigenPressureLbl.Text, Convert.ToDateTime(label17.Text));
                }
            });
        }
        public void doWork(object sender, DoWorkEventArgs e)
        {
            dll.Initialize(NewSensorValueFunction, Settings.Default.Delay, BLOODPRESSSURE, OXIGENSATURATION, HEARTRATE);

            // dll.InitializeWithAlerts(NewSensorValueFunction, Settings.Default.Delay, BLOODPRESSSURE, OXIGENSATURATION, HEARTRATE);

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string conteudo;
            string url = Properties.Settings.Default.Medline;
            int retmax = Properties.Settings.Default.Retmax;
            string term = txb_search.Text;
            string urlComp = url + term + "&retmax=" + retmax;

            var client = new WebClient();
            client.DownloadStringAsync(new Uri(urlComp));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;

            HttpWebRequest request = WebRequest.Create(urlComp) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                conteudo = reader.ReadToEnd();

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(conteudo);
                string refRank = "";
                XmlNodeList r = doc.SelectNodes("//document/@rank");
                SearchTerm d = null;

                foreach (XmlNode nodeR in r)
                {
                    List<string> listAt = new List<string>();
                    refRank = nodeR.InnerText;
                    XmlNodeList t = doc.SelectNodes("//document[@rank='" + refRank + "']//content[@name='title']");
                    XmlNodeList o = doc.SelectNodes("//document[@rank='" + refRank + "']//content[@name='organizationName']");
                    XmlNodeList s = doc.SelectNodes("//document[@rank='" + refRank + "']//content[@name='FullSummary']");
                    XmlNodeList at = doc.SelectNodes("//document[@rank='" + refRank + "']//content[@name='altTitle']");

                    foreach (XmlNode nodeT in t)
                    {
                        foreach (XmlNode nodeO in o)
                        {
                            foreach (XmlNode nodeS in s)
                            {
                                foreach (XmlNode nodeAt in at)
                                {
                                    listAt.Add(nodeAt.InnerText);
                                }
                                d = new SearchTerm(int.Parse(nodeR.InnerText), nodeT.InnerText, nodeO.InnerText, listAt, nodeS.InnerText);
                                listSearchTerm.Add(d);
                                break;
                            }
                            break;
                        }
                    }
                }

                foreach (SearchTerm item in listSearchTerm)
                {

                    dataGridView1.Rows.Add(item.Rank, item.Title, item.AltTitles, item.FullSummary, item.OrganizationName);
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {          
            int x = dataGridView1.CurrentCell.RowIndex;

            txb_title.Text = dataGridView1[1, x].Value.ToString();
            txb_alternative.Text = dataGridView1[2, x].Value.ToString();
            webBrowser1.DocumentText = dataGridView1[3, x].Value.ToString();
            txb_organization.Text = dataGridView1[4, x].Value.ToString();

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txb_search.Clear();   
            txb_title.Clear();
            txb_organization.Clear();
            txb_alternative.Clear();
            webBrowser1.Navigate("about:blank");
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        void LoadGrammar()
        {
            Choices sLists = new Choices();
            sLists.Add(new string[] { "asthma", "search", "clear", "exit", "configuration", "ok"});
            Grammar gr = new Grammar(new GrammarBuilder(sLists));
            try
            {
                recognizer.RequestRecognizerUpdate();//recognizer is	the	SpeechRecognitionEngine
                recognizer.LoadGrammar(gr);
                recognizer.SpeechRecognized += sRecognize_SpeechRecognized;
                recognizer.SetInputToDefaultAudioDevice();	//wich	microfone	to	use
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Equals("asthma"))
            {
                txb_search.AppendText("asthma" + Environment.NewLine);
            }
            else if (e.Result.Text.Equals("search"))
            {
                bt_search_Click(this, e);
            }
            else if (e.Result.Text.Equals("exit"))
            {
                this.Close();
            }
            else if (e.Result.Text.Equals("configuration"))
            {
                formConfigs frm = new formConfigs();
                frm.ShowDialog();
            }
            else if (e.Result.Text.Equals("clear"))
            {
                bt_clear_Click(this, e);
            }
        }
    }

}

      
    


