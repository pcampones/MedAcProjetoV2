using ClinicalAlert.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalAlert
{
    public partial class chartAlert : Form
    {
        private Service1Client serv;

        public chartAlert()
        {
            InitializeComponent();

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void chartAlert_Load(object sender, EventArgs e)
        {

            chartAltertes.ChartAreas.Clear();
            chartAltertes.Series.Clear();
            chartAltertes.Titles.Clear();

            chartAltertes.Titles.Add("Chart Values");

            //Construção da àrea do gráfico
            chartAltertes.ChartAreas.Add("area");


            chartAltertes.ChartAreas["area"].AxisX.Interval = 1;
            chartAltertes.ChartAreas["area"].AxisY.Minimum = 0;
            chartAltertes.ChartAreas["area"].AxisY.Interval = 10;

            chartAltertes.ChartAreas["area"].AxisX.Title = "Date";
            chartAltertes.ChartAreas["area"].AxisY.Title = "Values";

            chartAltertes.Series.Add("Blood Pressure");
            chartAltertes.Series.Add("Heart Rate");
            chartAltertes.Series.Add("Oxygen Saturation");

            //definição da cor de cada série
            chartAltertes.Series["Blood Pressure"].Color = Color.Red;
            chartAltertes.Series["Heart Rate"].Color = Color.Blue;
            chartAltertes.Series["Oxygen Saturation"].Color = Color.Green;

            chartAltertes.ChartAreas["area"].BackColor = Color.White;
            chartAltertes.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
            chartAltertes.ChartAreas["area"].BackGradientStyle =
            System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

            chartAltertes.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
            chartAltertes.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

            chartAltertes.Series["Blood Pressure"].IsValueShownAsLabel = true;
            chartAltertes.Series["Heart Rate"].IsValueShownAsLabel = true;
            chartAltertes.Series["Oxygen Saturation"].IsValueShownAsLabel = true;






        }
    }
}
