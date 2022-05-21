
namespace WoRCP.Tabs
{
    partial class Peripherals
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ControlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.GPIOPinsPanel = new WoRCP.UI.RoundedPanel();
            this.SelectedPinLabel = new System.Windows.Forms.Label();
            this.GPIOLabel = new System.Windows.Forms.Label();
            this.PinArray = new System.Windows.Forms.FlowLayoutPanel();
            this.GPIOCollapsablePanel = new WoRCP.UI.CollapsiblePanel();
            this.PinModeState = new System.Windows.Forms.Label();
            this.PinModeToggle = new WoRCP.UI.Toggle();
            this.PinModeLabel = new System.Windows.Forms.Label();
            this.PinStateState = new System.Windows.Forms.Label();
            this.PinStateToggle = new WoRCP.UI.Toggle();
            this.FanSpeedPanelPanel = new WoRCP.UI.CollapsiblePanel();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.TempratureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FanSpeedLabel = new System.Windows.Forms.Label();
            this.FanSpeedSlider = new WoRCP.UI.Slider();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.ControlContainer.SuspendLayout();
            this.GPIOPinsPanel.SuspendLayout();
            this.GPIOCollapsablePanel.SuspendLayout();
            this.FanSpeedPanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.Controls.Add(this.GPIOPinsPanel);
            this.ControlContainer.Controls.Add(this.GPIOCollapsablePanel);
            this.ControlContainer.Controls.Add(this.FanSpeedPanelPanel);
            this.ControlContainer.Location = new System.Drawing.Point(0, 0);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(660, 470);
            this.ControlContainer.TabIndex = 1;
            this.ControlContainer.Visible = false;
            // 
            // GPIOPinsPanel
            // 
            this.GPIOPinsPanel.BackColor = System.Drawing.Color.Transparent;
            this.GPIOPinsPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.GPIOPinsPanel.Controls.Add(this.SelectedPinLabel);
            this.GPIOPinsPanel.Controls.Add(this.GPIOLabel);
            this.GPIOPinsPanel.Controls.Add(this.PinArray);
            this.GPIOPinsPanel.Location = new System.Drawing.Point(10, 10);
            this.GPIOPinsPanel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.GPIOPinsPanel.Name = "GPIOPinsPanel";
            this.GPIOPinsPanel.rounding = 10;
            this.GPIOPinsPanel.Size = new System.Drawing.Size(640, 120);
            this.GPIOPinsPanel.TabIndex = 0;
            // 
            // SelectedPinLabel
            // 
            this.SelectedPinLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SelectedPinLabel.Location = new System.Drawing.Point(506, 10);
            this.SelectedPinLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedPinLabel.Name = "SelectedPinLabel";
            this.SelectedPinLabel.Size = new System.Drawing.Size(124, 21);
            this.SelectedPinLabel.TabIndex = 40;
            this.SelectedPinLabel.Text = "No pin selected";
            this.SelectedPinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPIOLabel
            // 
            this.GPIOLabel.AutoSize = true;
            this.GPIOLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPIOLabel.ForeColor = System.Drawing.Color.White;
            this.GPIOLabel.Location = new System.Drawing.Point(10, 10);
            this.GPIOLabel.Name = "GPIOLabel";
            this.GPIOLabel.Size = new System.Drawing.Size(80, 21);
            this.GPIOLabel.TabIndex = 39;
            this.GPIOLabel.Text = "GPIO Pins";
            // 
            // PinArray
            // 
            this.PinArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PinArray.Location = new System.Drawing.Point(10, 48);
            this.PinArray.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PinArray.Name = "PinArray";
            this.PinArray.Size = new System.Drawing.Size(620, 62);
            this.PinArray.TabIndex = 2;
            // 
            // GPIOCollapsablePanel
            // 
            this.GPIOCollapsablePanel.BackColor = System.Drawing.Color.Transparent;
            this.GPIOCollapsablePanel.Collapsed = false;
            this.GPIOCollapsablePanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.GPIOCollapsablePanel.Controls.Add(this.PinModeState);
            this.GPIOCollapsablePanel.Controls.Add(this.PinModeToggle);
            this.GPIOCollapsablePanel.Controls.Add(this.PinModeLabel);
            this.GPIOCollapsablePanel.Controls.Add(this.PinStateState);
            this.GPIOCollapsablePanel.Controls.Add(this.PinStateToggle);
            this.GPIOCollapsablePanel.Icon = "";
            this.GPIOCollapsablePanel.LeftContent = new string[] {
        "Pin State"};
            this.GPIOCollapsablePanel.Location = new System.Drawing.Point(10, 140);
            this.GPIOCollapsablePanel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.GPIOCollapsablePanel.Name = "GPIOCollapsablePanel";
            this.GPIOCollapsablePanel.RightContent = new string[0];
            this.GPIOCollapsablePanel.Rounding = 5;
            this.GPIOCollapsablePanel.Size = new System.Drawing.Size(640, 111);
            this.GPIOCollapsablePanel.TabIndex = 1;
            this.GPIOCollapsablePanel.Title = "GPIO Controls";
            this.GPIOCollapsablePanel.CollapsedChanged += new System.EventHandler(this.GPIOCollapsablePanel_CollapsedChanged);
            // 
            // PinModeState
            // 
            this.PinModeState.BackColor = System.Drawing.Color.Transparent;
            this.PinModeState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinModeState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.PinModeState.Location = new System.Drawing.Point(414, 112);
            this.PinModeState.Margin = new System.Windows.Forms.Padding(0);
            this.PinModeState.Name = "PinModeState";
            this.PinModeState.Size = new System.Drawing.Size(150, 49);
            this.PinModeState.TabIndex = 32;
            this.PinModeState.Text = "Input";
            this.PinModeState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PinModeToggle
            // 
            this.PinModeToggle.BackColor = System.Drawing.Color.Transparent;
            this.PinModeToggle.Location = new System.Drawing.Point(574, 128);
            this.PinModeToggle.Margin = new System.Windows.Forms.Padding(0);
            this.PinModeToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.PinModeToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.PinModeToggle.Name = "PinModeToggle";
            this.PinModeToggle.Size = new System.Drawing.Size(40, 20);
            this.PinModeToggle.TabIndex = 31;
            this.PinModeToggle.Toggled = false;
            this.PinModeToggle.ToggledEvent += new System.EventHandler(this.PinModeToggle_ToggledEvent);
            // 
            // PinModeLabel
            // 
            this.PinModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PinModeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinModeLabel.Location = new System.Drawing.Point(45, 111);
            this.PinModeLabel.Name = "PinModeLabel";
            this.PinModeLabel.Size = new System.Drawing.Size(179, 50);
            this.PinModeLabel.TabIndex = 30;
            this.PinModeLabel.Text = "Pin Mode";
            this.PinModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PinStateState
            // 
            this.PinStateState.BackColor = System.Drawing.Color.Transparent;
            this.PinStateState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinStateState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.PinStateState.Location = new System.Drawing.Point(414, 62);
            this.PinStateState.Margin = new System.Windows.Forms.Padding(0);
            this.PinStateState.Name = "PinStateState";
            this.PinStateState.Size = new System.Drawing.Size(150, 49);
            this.PinStateState.TabIndex = 29;
            this.PinStateState.Text = "Low";
            this.PinStateState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PinStateToggle
            // 
            this.PinStateToggle.BackColor = System.Drawing.Color.Transparent;
            this.PinStateToggle.Location = new System.Drawing.Point(574, 78);
            this.PinStateToggle.Margin = new System.Windows.Forms.Padding(0);
            this.PinStateToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.PinStateToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.PinStateToggle.Name = "PinStateToggle";
            this.PinStateToggle.Size = new System.Drawing.Size(40, 20);
            this.PinStateToggle.TabIndex = 28;
            this.PinStateToggle.Toggled = false;
            this.PinStateToggle.ToggledEvent += new System.EventHandler(this.PinStateToggle_ToggledEvent);
            // 
            // FanSpeedPanelPanel
            // 
            this.FanSpeedPanelPanel.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedPanelPanel.Collapsed = true;
            this.FanSpeedPanelPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.FanSpeedPanelPanel.Controls.Add(this.TemperatureLabel);
            this.FanSpeedPanelPanel.Controls.Add(this.TempratureChart);
            this.FanSpeedPanelPanel.Controls.Add(this.FanSpeedLabel);
            this.FanSpeedPanelPanel.Controls.Add(this.FanSpeedSlider);
            this.FanSpeedPanelPanel.Icon = "";
            this.FanSpeedPanelPanel.LeftContent = new string[] {
        "Fan Speed",
        "Temperature"};
            this.FanSpeedPanelPanel.Location = new System.Drawing.Point(10, 251);
            this.FanSpeedPanelPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.FanSpeedPanelPanel.Name = "FanSpeedPanelPanel";
            this.FanSpeedPanelPanel.RightContent = new string[0];
            this.FanSpeedPanelPanel.Rounding = 5;
            this.FanSpeedPanelPanel.Size = new System.Drawing.Size(640, 60);
            this.FanSpeedPanelPanel.TabIndex = 63;
            this.FanSpeedPanelPanel.Title = "Argon One Fan Control";
            this.FanSpeedPanelPanel.CollapsedChanged += new System.EventHandler(this.FanSpeedPanelPanel_CollapsedChanged);
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
            // TempratureChart
            // 
            this.TempratureChart.BackColor = System.Drawing.Color.Transparent;
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
            this.TempratureChart.ChartAreas.Add(chartArea2);
            this.TempratureChart.Location = new System.Drawing.Point(430, 112);
            this.TempratureChart.Margin = new System.Windows.Forms.Padding(0);
            this.TempratureChart.Name = "TempratureChart";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            series2.Name = "Series1";
            this.TempratureChart.Series.Add(series2);
            this.TempratureChart.Size = new System.Drawing.Size(210, 50);
            this.TempratureChart.TabIndex = 38;
            this.TempratureChart.TabStop = false;
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
            // WarningLabel
            // 
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.Location = new System.Drawing.Point(0, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(660, 470);
            this.WarningLabel.TabIndex = 1;
            this.WarningLabel.Text = "This tab has been disabled.\r\nGPIO Functionality is only available on Raspberry Pi" +
    "\'s";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Peripherals
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ControlContainer);
            this.Controls.Add(this.WarningLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Peripherals";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.Peripherals_Load);
            this.VisibleChanged += new System.EventHandler(this.Peripherals_VisibleChanged);
            this.ControlContainer.ResumeLayout(false);
            this.GPIOPinsPanel.ResumeLayout(false);
            this.GPIOPinsPanel.PerformLayout();
            this.GPIOCollapsablePanel.ResumeLayout(false);
            this.FanSpeedPanelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TempratureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WoRCP.UI.RoundedPanel GPIOPinsPanel;
        private System.Windows.Forms.FlowLayoutPanel ControlContainer;
        private System.Windows.Forms.Label GPIOLabel;
        private System.Windows.Forms.Label SelectedPinLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.FlowLayoutPanel PinArray;
        private WoRCP.UI.CollapsiblePanel GPIOCollapsablePanel;
        private System.Windows.Forms.Label PinStateState;
        private WoRCP.UI.Toggle PinStateToggle;
        private System.Windows.Forms.Label PinModeState;
        private WoRCP.UI.Toggle PinModeToggle;
        private System.Windows.Forms.Label PinModeLabel;
        private UI.CollapsiblePanel FanSpeedPanelPanel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempratureChart;
        private System.Windows.Forms.Label FanSpeedLabel;
        private UI.Slider FanSpeedSlider;
    }
}
