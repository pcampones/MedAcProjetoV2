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

        public chartAlert(List<ValoresWeb> valores)
        {
            InitializeComponent();

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadGraphs(valores);  
            
        }

        private void chartAlert_Load(object sender, EventArgs e)
        {

            
        }

        private void LoadGraphs(List<ValoresWeb> valores)
        {
            chartAltertes.ChartAreas.Clear();
            chartAltertes.Series.Clear();
            chartAltertes.Titles.Clear();

            chartAltertes.Titles.Add("Chart Values");

            //Construção da àrea do gráfico
            chartAltertes.ChartAreas.Add("area");
            chartAltertes.Series.Add("Heart Rate");
            chartAltertes.Series.Add("Oxygen Saturation");
            chartAltertes.Series.Add("Blood Pressure Systolic");
            chartAltertes.Series.Add("Blood Pressure Diastolic");



            chartAltertes.ChartAreas["area"].AxisX.Interval = 1;
            chartAltertes.ChartAreas["area"].AxisY.Minimum = 0;
            chartAltertes.ChartAreas["area"].AxisY.Interval = 20;

            chartAltertes.ChartAreas["area"].AxisX.Title = "Date";
            chartAltertes.ChartAreas["area"].AxisY.Title = "Values";

           
            chartAltertes.ChartAreas["area"].BackColor = Color.White;
            chartAltertes.ChartAreas["area"].BackSecondaryColor = Color.LightBlue;
            chartAltertes.ChartAreas["area"].BackGradientStyle =
            System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;

            chartAltertes.Series["Heart Rate"].Color = Color.Blue;
            chartAltertes.Series["Heart Rate"].IsValueShownAsLabel = true;
            chartAltertes.Series["Oxygen Saturation"].Color = Color.Green;
            chartAltertes.Series["Oxygen Saturation"].IsValueShownAsLabel = true;
            chartAltertes.Series["Blood Pressure Systolic"].Color = Color.Red;
            chartAltertes.Series["Blood Pressure Systolic"].IsValueShownAsLabel = true;

            chartAltertes.Series["Blood Pressure Diastolic"].Color = Color.Yellow;
            chartAltertes.Series["Blood Pressure Diastolic"].IsValueShownAsLabel = true;




            chartAltertes.ChartAreas["area"].AxisX.MajorGrid.LineColor = Color.LightSlateGray;
            chartAltertes.ChartAreas["area"].AxisY.MajorGrid.LineColor = Color.LightSteelBlue;

           
            foreach  (ValoresWeb item in valores)
            {

                if (item.type.Equals("HR"))
                {
                        chartAltertes.Series["Heart Rate"].Points.AddXY(item.dataOfReposit.ToString(), item.valueR);
                        
                }
                else if (item.type.Equals("SPO2"))
                {
                        chartAltertes.Series["Oxygen Saturation"].Points.AddXY(item.dataOfReposit.ToString(), item.valueR);
                    
                    
                }
                else if (item.type.Equals("BP"))
                    
                {
                    string[] bp = item.valueR.Split('-');
                  
                        chartAltertes.Series["Blood Pressure Systolic"].Points.AddXY(item.dataOfReposit.ToString(), bp[0]);
                        chartAltertes.Series["Blood Pressure Diastolic"].Points.AddXY(item.dataOfReposit.ToString(), bp[1]);


                    
                }
            }

        }

        private void chartAltertes_Click(object sender, EventArgs e)
        {

        }
    }
}
