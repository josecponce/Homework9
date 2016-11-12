namespace Homework9
{
    partial class GraphGameProgressControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GameProgressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GameProgressChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GameProgressChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GameProgressChart.ChartAreas.Add(chartArea1);
            this.GameProgressChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.GameProgressChart.Legends.Add(legend1);
            this.GameProgressChart.Location = new System.Drawing.Point(0, 0);
            this.GameProgressChart.Name = "GameProgressChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero";
            series1.Legend = "Legend1";
            series1.Name = "GamePointsInTime";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.GameProgressChart.Series.Add(series1);
            this.GameProgressChart.Size = new System.Drawing.Size(635, 199);
            this.GameProgressChart.TabIndex = 0;
            this.GameProgressChart.Text = "Game Progress";
            // 
            // GameProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameProgressChart);
            this.Name = "GameProgressControl";
            this.Size = new System.Drawing.Size(635, 199);
            ((System.ComponentModel.ISupportInitialize)(this.GameProgressChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GameProgressChart;
    }
}
