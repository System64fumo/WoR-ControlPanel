namespace WoRCP.Tabs
{
    partial class ArgonOneFan
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ControlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.FanSpeedPanelPanel = new WoRCP.UI.CollapsiblePanel();
            this.FanSpeedLabel = new System.Windows.Forms.Label();
            this.FanSpeedSlider = new WoRCP.UI.Slider();
            this.TempratureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.ControlContainer.SuspendLayout();
            this.FanSpeedPanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.Controls.Add(this.FanSpeedPanelPanel);
            this.ControlContainer.Location = new System.Drawing.Point(8, 8);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(660, 470);
            this.ControlContainer.TabIndex = 2;
            this.ControlContainer.Visible = false;
            // 
            // FanSpeedPanelPanel
            // 
            this.FanSpeedPanelPanel.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedPanelPanel.Collapsed = false;
            this.FanSpeedPanelPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.FanSpeedPanelPanel.Controls.Add(this.TemperatureLabel);
            this.FanSpeedPanelPanel.Controls.Add(this.TempratureChart);
            this.FanSpeedPanelPanel.Controls.Add(this.FanSpeedLabel);
            this.FanSpeedPanelPanel.Controls.Add(this.FanSpeedSlider);
            this.FanSpeedPanelPanel.Icon = "";
            this.FanSpeedPanelPanel.LeftContent = new string[] {
        "Fan Speed",
        "Temperature"};
            this.FanSpeedPanelPanel.Location = new System.Drawing.Point(10, 0);
            this.FanSpeedPanelPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.FanSpeedPanelPanel.Name = "FanSpeedPanelPanel";
            this.FanSpeedPanelPanel.RightContent = new string[0];
            this.FanSpeedPanelPanel.Rounding = 5;
            this.FanSpeedPanelPanel.Size = new System.Drawing.Size(640, 162);
            this.FanSpeedPanelPanel.TabIndex = 62;
            this.FanSpeedPanelPanel.Title = "Argon One Fan Control";
            // 
            // FanSpeedLabel
            // 
            this.FanSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FanSpeedLabel.Location = new System.Drawing.Point(277, 62);
            this.FanSpeedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FanSpeedLabel.Name = "FanSpeedLabel";
            this.FanSpeedLabel.Size = new System.Drawing.Size(150, 50);
            this.FanSpeedLabel.TabIndex = 37;
            this.FanSpeedLabel.Text = "Off";
            this.FanSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FanSpeedSlider
            // 
            this.FanSpeedSlider.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedSlider.Double = false;
            this.FanSpeedSlider.Location = new System.Drawing.Point(430, 71);
            this.FanSpeedSlider.Margin = new System.Windows.Forms.Padding(0);
            this.FanSpeedSlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.FanSpeedSlider.MaxValue = 100D;
            this.FanSpeedSlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.FanSpeedSlider.MinValue = 0D;
            this.FanSpeedSlider.Name = "FanSpeedSlider";
            this.FanSpeedSlider.Size = new System.Drawing.Size(200, 30);
            this.FanSpeedSlider.TabIndex = 17;
            this.FanSpeedSlider.Value = 0D;
            this.FanSpeedSlider.ValueP = 0D;
            this.FanSpeedSlider.Selecting += new System.EventHandler(this.FanSpeedSlider_Selecting);
            this.FanSpeedSlider.Selected += new System.EventHandler(this.FanSpeedSlider_Selected);
            // 
            // TempratureChart
            // 
            this.TempratureChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 105D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.TempratureChart.ChartAreas.Add(chartArea1);
            this.TempratureChart.Location = new System.Drawing.Point(430, 112);
            this.TempratureChart.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureChart.Name = "TempratureChart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series1.Name = "Series1";
            this.TempratureChart.Series.Add(series1);
            this.TempratureChart.Size = new System.Drawing.Size(210, 50);
            this.TempratureChart.TabIndex = 38;
            this.TempratureChart.TabStop = false;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TemperatureLabel.Location = new System.Drawing.Point(277, 112);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(150, 50);
            this.TemperatureLabel.TabIndex = 39;
            this.TemperatureLabel.Text = "0";
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArgonOneFan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ControlContainer);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ArgonOneFan";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.ArgonOneFan_Load);
            this.VisibleChanged += new System.EventHandler(this.ArgonOneFan_VisibleChanged);
            this.ControlContainer.ResumeLayout(false);
            this.FanSpeedPanelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ControlContainer;
        private UI.CollapsiblePanel FanSpeedPanelPanel;
        private System.Windows.Forms.Label FanSpeedLabel;
        private UI.Slider FanSpeedSlider;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempratureChart;
        private System.Windows.Forms.Label TemperatureLabel;
    }
}
