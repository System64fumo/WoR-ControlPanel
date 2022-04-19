
namespace WoRCP.Tabs
{
    partial class Performance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.roundedPanel5 = new WoRCP.UI.RoundedPanel();
            this.WriteChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WriteUsage = new System.Windows.Forms.Label();
            this.WriteLabel = new System.Windows.Forms.Label();
            this.roundedPanel4 = new WoRCP.UI.RoundedPanel();
            this.ReadUsage = new System.Windows.Forms.Label();
            this.ReadLabel = new System.Windows.Forms.Label();
            this.ReadChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundedPanel3 = new WoRCP.UI.RoundedPanel();
            this.TempratureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TempratureValue = new System.Windows.Forms.Label();
            this.TempratureLabel = new System.Windows.Forms.Label();
            this.roundedPanel2 = new WoRCP.UI.RoundedPanel();
            this.MemoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryUsage = new System.Windows.Forms.Label();
            this.roundedPanel1 = new WoRCP.UI.RoundedPanel();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WriteChart)).BeginInit();
            this.roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadChart)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryChart)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel5.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel5.Controls.Add(this.WriteChart);
            this.roundedPanel5.Controls.Add(this.WriteUsage);
            this.roundedPanel5.Controls.Add(this.WriteLabel);
            this.roundedPanel5.Location = new System.Drawing.Point(335, 340);
            this.roundedPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.rounding = 5;
            this.roundedPanel5.Size = new System.Drawing.Size(315, 120);
            this.roundedPanel5.TabIndex = 34;
            // 
            // WriteChart
            // 
            this.WriteChart.BackColor = System.Drawing.Color.Transparent;
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
            this.WriteChart.ChartAreas.Add(chartArea1);
            this.WriteChart.Location = new System.Drawing.Point(0, 41);
            this.WriteChart.Margin = new System.Windows.Forms.Padding(0);
            this.WriteChart.Name = "WriteChart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series1.Name = "Series1";
            this.WriteChart.Series.Add(series1);
            this.WriteChart.Size = new System.Drawing.Size(315, 79);
            this.WriteChart.TabIndex = 4;
            // 
            // WriteUsage
            // 
            this.WriteUsage.BackColor = System.Drawing.Color.Transparent;
            this.WriteUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.WriteUsage.Location = new System.Drawing.Point(148, 10);
            this.WriteUsage.Margin = new System.Windows.Forms.Padding(0);
            this.WriteUsage.Name = "WriteUsage";
            this.WriteUsage.Size = new System.Drawing.Size(157, 21);
            this.WriteUsage.TabIndex = 29;
            this.WriteUsage.Text = "0 MB/s";
            this.WriteUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WriteLabel
            // 
            this.WriteLabel.AutoSize = true;
            this.WriteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteLabel.Location = new System.Drawing.Point(10, 10);
            this.WriteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WriteLabel.Name = "WriteLabel";
            this.WriteLabel.Size = new System.Drawing.Size(48, 21);
            this.WriteLabel.TabIndex = 25;
            this.WriteLabel.Text = "Write";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel4.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel4.Controls.Add(this.ReadUsage);
            this.roundedPanel4.Controls.Add(this.ReadLabel);
            this.roundedPanel4.Controls.Add(this.ReadChart);
            this.roundedPanel4.Location = new System.Drawing.Point(10, 340);
            this.roundedPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.rounding = 5;
            this.roundedPanel4.Size = new System.Drawing.Size(315, 120);
            this.roundedPanel4.TabIndex = 33;
            // 
            // ReadUsage
            // 
            this.ReadUsage.BackColor = System.Drawing.Color.Transparent;
            this.ReadUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ReadUsage.Location = new System.Drawing.Point(151, 10);
            this.ReadUsage.Margin = new System.Windows.Forms.Padding(0);
            this.ReadUsage.Name = "ReadUsage";
            this.ReadUsage.Size = new System.Drawing.Size(154, 21);
            this.ReadUsage.TabIndex = 30;
            this.ReadUsage.Text = "0 MB/s";
            this.ReadUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReadLabel
            // 
            this.ReadLabel.AutoSize = true;
            this.ReadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadLabel.Location = new System.Drawing.Point(10, 10);
            this.ReadLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ReadLabel.Name = "ReadLabel";
            this.ReadLabel.Size = new System.Drawing.Size(45, 21);
            this.ReadLabel.TabIndex = 23;
            this.ReadLabel.Text = "Read";
            // 
            // ReadChart
            // 
            this.ReadChart.BackColor = System.Drawing.Color.Transparent;
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
            this.ReadChart.ChartAreas.Add(chartArea2);
            this.ReadChart.Location = new System.Drawing.Point(0, 41);
            this.ReadChart.Margin = new System.Windows.Forms.Padding(0);
            this.ReadChart.Name = "ReadChart";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series2.Name = "Series1";
            this.ReadChart.Series.Add(series2);
            this.ReadChart.Size = new System.Drawing.Size(315, 79);
            this.ReadChart.TabIndex = 3;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel3.Controls.Add(this.TempratureChart);
            this.roundedPanel3.Controls.Add(this.TempratureValue);
            this.roundedPanel3.Controls.Add(this.TempratureLabel);
            this.roundedPanel3.Location = new System.Drawing.Point(10, 210);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.rounding = 5;
            this.roundedPanel3.Size = new System.Drawing.Size(640, 120);
            this.roundedPanel3.TabIndex = 33;
            // 
            // TempratureChart
            // 
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
            this.TempratureChart.Size = new System.Drawing.Size(640, 79);
            this.TempratureChart.TabIndex = 2;
            // 
            // TempratureValue
            // 
            this.TempratureValue.BackColor = System.Drawing.Color.Transparent;
            this.TempratureValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempratureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TempratureValue.Location = new System.Drawing.Point(540, 10);
            this.TempratureValue.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureValue.Name = "TempratureValue";
            this.TempratureValue.Size = new System.Drawing.Size(90, 21);
            this.TempratureValue.TabIndex = 28;
            this.TempratureValue.Text = "0°";
            this.TempratureValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TempratureLabel
            // 
            this.TempratureLabel.AutoSize = true;
            this.TempratureLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempratureLabel.Location = new System.Drawing.Point(10, 10);
            this.TempratureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureLabel.Name = "TempratureLabel";
            this.TempratureLabel.Size = new System.Drawing.Size(97, 21);
            this.TempratureLabel.TabIndex = 22;
            this.TempratureLabel.Text = "Temperature";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel2.Controls.Add(this.MemoryChart);
            this.roundedPanel2.Controls.Add(this.MemoryLabel);
            this.roundedPanel2.Controls.Add(this.MemoryUsage);
            this.roundedPanel2.Location = new System.Drawing.Point(335, 10);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.rounding = 5;
            this.roundedPanel2.Size = new System.Drawing.Size(315, 190);
            this.roundedPanel2.TabIndex = 33;
            // 
            // MemoryChart
            // 
            this.MemoryChart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea4.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.Maximum = 10D;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.Maximum = 105D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderWidth = 0;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 100F;
            chartArea4.InnerPlotPosition.Width = 100F;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 100F;
            this.MemoryChart.ChartAreas.Add(chartArea4);
            this.MemoryChart.Location = new System.Drawing.Point(0, 41);
            this.MemoryChart.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryChart.Name = "MemoryChart";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series4.Name = "Series1";
            this.MemoryChart.Series.Add(series4);
            this.MemoryChart.Size = new System.Drawing.Size(315, 149);
            this.MemoryChart.TabIndex = 1;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(10, 10);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(69, 21);
            this.MemoryLabel.TabIndex = 24;
            this.MemoryLabel.Text = "Memory";
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.BackColor = System.Drawing.Color.Transparent;
            this.MemoryUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MemoryUsage.Location = new System.Drawing.Point(175, 10);
            this.MemoryUsage.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryUsage.Name = "MemoryUsage";
            this.MemoryUsage.Size = new System.Drawing.Size(130, 21);
            this.MemoryUsage.TabIndex = 27;
            this.MemoryUsage.Text = "0/0 GB";
            this.MemoryUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel1.Controls.Add(this.CPULabel);
            this.roundedPanel1.Controls.Add(this.CPUChart);
            this.roundedPanel1.Controls.Add(this.CPUUsage);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 5;
            this.roundedPanel1.Size = new System.Drawing.Size(315, 190);
            this.roundedPanel1.TabIndex = 32;
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.Location = new System.Drawing.Point(10, 10);
            this.CPULabel.Margin = new System.Windows.Forms.Padding(0);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(78, 21);
            this.CPULabel.TabIndex = 21;
            this.CPULabel.Text = "Processor";
            // 
            // CPUChart
            // 
            this.CPUChart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea5.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea5.AxisX.IsMarginVisible = false;
            chartArea5.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX.Maximum = 10D;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.AxisY.Maximum = 105D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BorderWidth = 0;
            chartArea5.InnerPlotPosition.Auto = false;
            chartArea5.InnerPlotPosition.Height = 100F;
            chartArea5.InnerPlotPosition.Width = 100F;
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 100F;
            chartArea5.Position.Width = 100F;
            this.CPUChart.ChartAreas.Add(chartArea5);
            this.CPUChart.Location = new System.Drawing.Point(0, 41);
            this.CPUChart.Margin = new System.Windows.Forms.Padding(0);
            this.CPUChart.Name = "CPUChart";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series5.Name = "Series1";
            this.CPUChart.Series.Add(series5);
            this.CPUChart.Size = new System.Drawing.Size(315, 149);
            this.CPUChart.TabIndex = 31;
            // 
            // CPUUsage
            // 
            this.CPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.CPUUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CPUUsage.Location = new System.Drawing.Point(230, 10);
            this.CPUUsage.Margin = new System.Windows.Forms.Padding(0);
            this.CPUUsage.Name = "CPUUsage";
            this.CPUUsage.Size = new System.Drawing.Size(75, 21);
            this.CPUUsage.TabIndex = 26;
            this.CPUUsage.Text = "0%";
            this.CPUUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Performance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Performance";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.Performance_Load);
            this.VisibleChanged += new System.EventHandler(this.Performance_VisibleChanged);
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WriteChart)).EndInit();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadChart)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryChart)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart MemoryChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempratureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReadChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WriteChart;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label TempratureLabel;
        private System.Windows.Forms.Label ReadLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label WriteLabel;
        private System.Windows.Forms.Label CPUUsage;
        private System.Windows.Forms.Label MemoryUsage;
        private System.Windows.Forms.Label TempratureValue;
        private System.Windows.Forms.Label WriteUsage;
        private System.Windows.Forms.Label ReadUsage;
        private System.Windows.Forms.DataVisualization.Charting.Chart CPUChart;
        private WoRCP.UI.RoundedPanel roundedPanel1;
        private WoRCP.UI.RoundedPanel roundedPanel2;
        private WoRCP.UI.RoundedPanel roundedPanel3;
        private WoRCP.UI.RoundedPanel roundedPanel4;
        private WoRCP.UI.RoundedPanel roundedPanel5;
    }
}
