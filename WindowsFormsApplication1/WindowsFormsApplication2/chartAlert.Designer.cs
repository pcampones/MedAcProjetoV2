namespace ClinicalAlert
{
    partial class chartAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAltertes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartAltertes)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAltertes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAltertes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAltertes.Legends.Add(legend1);
            this.chartAltertes.Location = new System.Drawing.Point(12, 12);
            this.chartAltertes.Name = "chartAltertes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAltertes.Series.Add(series1);
            this.chartAltertes.Size = new System.Drawing.Size(555, 375);
            this.chartAltertes.TabIndex = 0;
            this.chartAltertes.Text = "chart1";
            // 
            // chartAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 399);
            this.Controls.Add(this.chartAltertes);
            this.Name = "chartAlert";
            this.Text = "chartAlert";
            this.Load += new System.EventHandler(this.chartAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAltertes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAltertes;
    }
}