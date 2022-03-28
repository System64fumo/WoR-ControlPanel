
namespace WoRCP
{
    partial class OverlayWindow
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CPUPanel = new WoRCP.UI.RoundedPanel();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.CPUChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MemPanel = new WoRCP.UI.RoundedPanel();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MemoryUsage = new System.Windows.Forms.Label();
            this.TempPanel = new WoRCP.UI.RoundedPanel();
            this.TempratureLabel = new System.Windows.Forms.Label();
            this.TempratureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TempratureValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.CPUPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).BeginInit();
            this.MemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryChart)).BeginInit();
            this.TempPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CPUPanel);
            this.flowLayoutPanel1.Controls.Add(this.MemPanel);
            this.flowLayoutPanel1.Controls.Add(this.TempPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 395);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // CPUPanel
            // 
            this.CPUPanel.BackColor = System.Drawing.Color.Transparent;
            this.CPUPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.CPUPanel.Controls.Add(this.CPULabel);
            this.CPUPanel.Controls.Add(this.CPUUsage);
            this.CPUPanel.Controls.Add(this.CPUChart);
            this.CPUPanel.Location = new System.Drawing.Point(5, 5);
            this.CPUPanel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.CPUPanel.Name = "CPUPanel";
            this.CPUPanel.rounding = 5;
            this.CPUPanel.Size = new System.Drawing.Size(200, 125);
            this.CPUPanel.TabIndex = 37;
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.ForeColor = System.Drawing.Color.White;
            this.CPULabel.Location = new System.Drawing.Point(10, 10);
            this.CPULabel.Margin = new System.Windows.Forms.Padding(0);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(40, 21);
            this.CPULabel.TabIndex = 21;
            this.CPULabel.Text = "CPU";
            // 
            // CPUUsage
            // 
            this.CPUUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.CPUUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CPUUsage.Location = new System.Drawing.Point(115, 10);
            this.CPUUsage.Margin = new System.Windows.Forms.Padding(0);
            this.CPUUsage.Name = "CPUUsage";
            this.CPUUsage.Size = new System.Drawing.Size(75, 21);
            this.CPUUsage.TabIndex = 26;
            this.CPUUsage.Text = "0%";
            this.CPUUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUChart
            // 
            this.CPUChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUChart.BackColor = System.Drawing.Color.Transparent;
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
            this.CPUChart.ChartAreas.Add(chartArea1);
            this.CPUChart.Location = new System.Drawing.Point(0, 41);
            this.CPUChart.Margin = new System.Windows.Forms.Padding(0);
            this.CPUChart.Name = "CPUChart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series1.Name = "Series1";
            this.CPUChart.Series.Add(series1);
            this.CPUChart.Size = new System.Drawing.Size(201, 84);
            this.CPUChart.TabIndex = 31;
            // 
            // MemPanel
            // 
            this.MemPanel.BackColor = System.Drawing.Color.Transparent;
            this.MemPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.MemPanel.Controls.Add(this.MemoryLabel);
            this.MemPanel.Controls.Add(this.MemoryChart);
            this.MemPanel.Controls.Add(this.MemoryUsage);
            this.MemPanel.Location = new System.Drawing.Point(5, 135);
            this.MemPanel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MemPanel.Name = "MemPanel";
            this.MemPanel.rounding = 5;
            this.MemPanel.Size = new System.Drawing.Size(200, 125);
            this.MemPanel.TabIndex = 38;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.ForeColor = System.Drawing.Color.White;
            this.MemoryLabel.Location = new System.Drawing.Point(10, 10);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(46, 21);
            this.MemoryLabel.TabIndex = 24;
            this.MemoryLabel.Text = "Mem";
            // 
            // MemoryChart
            // 
            this.MemoryChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.Maximum = 10D;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 105D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 0;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 100F;
            chartArea2.InnerPlotPosition.Width = 100F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.MemoryChart.ChartAreas.Add(chartArea2);
            this.MemoryChart.Location = new System.Drawing.Point(0, 41);
            this.MemoryChart.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryChart.Name = "MemoryChart";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series2.Name = "Series1";
            this.MemoryChart.Series.Add(series2);
            this.MemoryChart.Size = new System.Drawing.Size(201, 84);
            this.MemoryChart.TabIndex = 1;
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryUsage.BackColor = System.Drawing.Color.Transparent;
            this.MemoryUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MemoryUsage.Location = new System.Drawing.Point(115, 10);
            this.MemoryUsage.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryUsage.Name = "MemoryUsage";
            this.MemoryUsage.Size = new System.Drawing.Size(75, 21);
            this.MemoryUsage.TabIndex = 27;
            this.MemoryUsage.Text = "0/0GB";
            this.MemoryUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TempPanel
            // 
            this.TempPanel.BackColor = System.Drawing.Color.Transparent;
            this.TempPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.TempPanel.Controls.Add(this.TempratureLabel);
            this.TempPanel.Controls.Add(this.TempratureChart);
            this.TempPanel.Controls.Add(this.TempratureValue);
            this.TempPanel.Location = new System.Drawing.Point(5, 265);
            this.TempPanel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TempPanel.Name = "TempPanel";
            this.TempPanel.rounding = 5;
            this.TempPanel.Size = new System.Drawing.Size(200, 125);
            this.TempPanel.TabIndex = 36;
            // 
            // TempratureLabel
            // 
            this.TempratureLabel.AutoSize = true;
            this.TempratureLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempratureLabel.ForeColor = System.Drawing.Color.White;
            this.TempratureLabel.Location = new System.Drawing.Point(10, 10);
            this.TempratureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureLabel.Name = "TempratureLabel";
            this.TempratureLabel.Size = new System.Drawing.Size(47, 21);
            this.TempratureLabel.TabIndex = 22;
            this.TempratureLabel.Text = "Temp";
            // 
            // TempratureChart
            // 
            this.TempratureChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TempratureChart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.Maximum = 10D;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Maximum = 105D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderWidth = 0;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 100F;
            chartArea3.InnerPlotPosition.Width = 100F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 100F;
            this.TempratureChart.ChartAreas.Add(chartArea3);
            this.TempratureChart.Location = new System.Drawing.Point(0, 41);
            this.TempratureChart.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureChart.Name = "TempratureChart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series3.Name = "Series1";
            this.TempratureChart.Series.Add(series3);
            this.TempratureChart.Size = new System.Drawing.Size(201, 84);
            this.TempratureChart.TabIndex = 2;
            // 
            // TempratureValue
            // 
            this.TempratureValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TempratureValue.BackColor = System.Drawing.Color.Transparent;
            this.TempratureValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempratureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TempratureValue.Location = new System.Drawing.Point(119, 10);
            this.TempratureValue.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureValue.Name = "TempratureValue";
            this.TempratureValue.Size = new System.Drawing.Size(71, 21);
            this.TempratureValue.TabIndex = 28;
            this.TempratureValue.Text = "0°";
            this.TempratureValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OverlayWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(210, 395);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverlayWindow";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Overlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OverlayWindow_Load);
            this.EnabledChanged += new System.EventHandler(this.OverlayWindow_EnabledChanged);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.CPUPanel.ResumeLayout(false);
            this.CPUPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).EndInit();
            this.MemPanel.ResumeLayout(false);
            this.MemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryChart)).EndInit();
            this.TempPanel.ResumeLayout(false);
            this.TempPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WoRCP.UI.RoundedPanel TempPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempratureChart;
        private System.Windows.Forms.Label TempratureValue;
        private System.Windows.Forms.Label TempratureLabel;
        private WoRCP.UI.RoundedPanel MemPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MemoryChart;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label MemoryUsage;
        private WoRCP.UI.RoundedPanel CPUPanel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart CPUChart;
        private System.Windows.Forms.Label CPUUsage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}