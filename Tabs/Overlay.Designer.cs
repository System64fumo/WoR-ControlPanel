
namespace WoRCP.Tabs
{
    partial class Overlay
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel1 = new WoRCP.RoundedPanel();
            this.PositionPanel = new WoRCP.RoundedPanel();
            this.BottomRightBTN = new WoRCP.RoundedButton();
            this.TopRightBTN = new WoRCP.RoundedButton();
            this.BottomLeftBTN = new WoRCP.RoundedButton();
            this.TopLeftBTN = new WoRCP.RoundedButton();
            this.collapsiblePanel1 = new WoRCP.CustomUI.CollapsiblePanel();
            this.OverlayState = new System.Windows.Forms.Label();
            this.OverlayToggle = new WoRCP.CustomUI.Toggle();
            this.OverlayLabel = new System.Windows.Forms.Label();
            this.AlwaysOnTop = new System.Windows.Forms.Label();
            this.AlwaysOnTopToggle = new WoRCP.CustomUI.Toggle();
            this.AlwaysOnTopLabel = new System.Windows.Forms.Label();
            this.collapsiblePanel3 = new WoRCP.CustomUI.CollapsiblePanel();
            this.StyleToggle = new WoRCP.CustomUI.Toggle();
            this.ChartsState = new System.Windows.Forms.Label();
            this.ChartsToggle = new WoRCP.CustomUI.Toggle();
            this.ChartsLabel = new System.Windows.Forms.Label();
            this.Orientation = new System.Windows.Forms.Label();
            this.OrientationToggle = new WoRCP.CustomUI.Toggle();
            this.OrientationLabel = new System.Windows.Forms.Label();
            this.StyleState = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.OpacityState = new System.Windows.Forms.Label();
            this.OpacitySlider = new WoRCP.Slider();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.collapsiblePanel2 = new WoRCP.CustomUI.CollapsiblePanel();
            this.TrayIconState = new System.Windows.Forms.Label();
            this.TrayIconToggle = new WoRCP.CustomUI.Toggle();
            this.TrayIconLabel = new System.Windows.Forms.Label();
            this.TempWarningState = new System.Windows.Forms.Label();
            this.TempWarningToggle = new WoRCP.CustomUI.Toggle();
            this.TempWarningLabel = new System.Windows.Forms.Label();
            this.MinimizeToTrayState = new System.Windows.Forms.Label();
            this.MinimizeToTrayToggle = new WoRCP.CustomUI.Toggle();
            this.MinimizeToTrayLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.PositionPanel.SuspendLayout();
            this.collapsiblePanel1.SuspendLayout();
            this.collapsiblePanel3.SuspendLayout();
            this.collapsiblePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.roundedPanel1);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel1);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel3);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 470);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel1.Controls.Add(this.PositionPanel);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 5;
            this.roundedPanel1.Size = new System.Drawing.Size(640, 240);
            this.roundedPanel1.TabIndex = 0;
            // 
            // PositionPanel
            // 
            this.PositionPanel.BackColor = System.Drawing.Color.Transparent;
            this.PositionPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.PositionPanel.Controls.Add(this.BottomRightBTN);
            this.PositionPanel.Controls.Add(this.TopRightBTN);
            this.PositionPanel.Controls.Add(this.BottomLeftBTN);
            this.PositionPanel.Controls.Add(this.TopLeftBTN);
            this.PositionPanel.Location = new System.Drawing.Point(160, 30);
            this.PositionPanel.Name = "PositionPanel";
            this.PositionPanel.rounding = 5;
            this.PositionPanel.Size = new System.Drawing.Size(320, 180);
            this.PositionPanel.TabIndex = 0;
            // 
            // BottomRightBTN
            // 
            this.BottomRightBTN.BackColor = System.Drawing.Color.Transparent;
            this.BottomRightBTN.ButtonText = "";
            this.BottomRightBTN.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.BottomRightBTN.Location = new System.Drawing.Point(160, 90);
            this.BottomRightBTN.Margin = new System.Windows.Forms.Padding(0);
            this.BottomRightBTN.Name = "BottomRightBTN";
            this.BottomRightBTN.Rounding = 5;
            this.BottomRightBTN.Size = new System.Drawing.Size(160, 90);
            this.BottomRightBTN.TabIndex = 1;
            this.BottomRightBTN.Click += new System.EventHandler(this.BottomRightBTN_Click);
            // 
            // TopRightBTN
            // 
            this.TopRightBTN.BackColor = System.Drawing.Color.Transparent;
            this.TopRightBTN.ButtonText = "";
            this.TopRightBTN.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.TopRightBTN.Location = new System.Drawing.Point(160, 0);
            this.TopRightBTN.Margin = new System.Windows.Forms.Padding(0);
            this.TopRightBTN.Name = "TopRightBTN";
            this.TopRightBTN.Rounding = 5;
            this.TopRightBTN.Size = new System.Drawing.Size(160, 90);
            this.TopRightBTN.TabIndex = 2;
            this.TopRightBTN.Click += new System.EventHandler(this.TopRightBTN_Click);
            // 
            // BottomLeftBTN
            // 
            this.BottomLeftBTN.BackColor = System.Drawing.Color.Transparent;
            this.BottomLeftBTN.ButtonText = "";
            this.BottomLeftBTN.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.BottomLeftBTN.Location = new System.Drawing.Point(0, 90);
            this.BottomLeftBTN.Margin = new System.Windows.Forms.Padding(0);
            this.BottomLeftBTN.Name = "BottomLeftBTN";
            this.BottomLeftBTN.Rounding = 5;
            this.BottomLeftBTN.Size = new System.Drawing.Size(160, 90);
            this.BottomLeftBTN.TabIndex = 1;
            this.BottomLeftBTN.Click += new System.EventHandler(this.BottomLeftBTN_Click);
            // 
            // TopLeftBTN
            // 
            this.TopLeftBTN.BackColor = System.Drawing.Color.Transparent;
            this.TopLeftBTN.ButtonText = "";
            this.TopLeftBTN.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.TopLeftBTN.Location = new System.Drawing.Point(0, 0);
            this.TopLeftBTN.Margin = new System.Windows.Forms.Padding(0);
            this.TopLeftBTN.Name = "TopLeftBTN";
            this.TopLeftBTN.Rounding = 5;
            this.TopLeftBTN.Size = new System.Drawing.Size(160, 90);
            this.TopLeftBTN.TabIndex = 0;
            this.TopLeftBTN.Click += new System.EventHandler(this.TopLeftBTN_Click);
            // 
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel1.Collapsed = true;
            this.collapsiblePanel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel1.Controls.Add(this.OverlayState);
            this.collapsiblePanel1.Controls.Add(this.OverlayToggle);
            this.collapsiblePanel1.Controls.Add(this.OverlayLabel);
            this.collapsiblePanel1.Controls.Add(this.AlwaysOnTop);
            this.collapsiblePanel1.Controls.Add(this.AlwaysOnTopToggle);
            this.collapsiblePanel1.Controls.Add(this.AlwaysOnTopLabel);
            this.collapsiblePanel1.Icon = "";
            this.collapsiblePanel1.Location = new System.Drawing.Point(10, 260);
            this.collapsiblePanel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.PanelText = "Overlay";
            this.collapsiblePanel1.Rounding = 5;
            this.collapsiblePanel1.Separators = 2;
            this.collapsiblePanel1.Size = new System.Drawing.Size(640, 60);
            this.collapsiblePanel1.TabIndex = 1;
            this.collapsiblePanel1.Text = "Overlay";
            // 
            // OverlayState
            // 
            this.OverlayState.BackColor = System.Drawing.Color.Transparent;
            this.OverlayState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverlayState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OverlayState.Location = new System.Drawing.Point(430, 61);
            this.OverlayState.Margin = new System.Windows.Forms.Padding(0);
            this.OverlayState.Name = "OverlayState";
            this.OverlayState.Size = new System.Drawing.Size(150, 50);
            this.OverlayState.TabIndex = 60;
            this.OverlayState.Text = "Disabled";
            this.OverlayState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OverlayToggle
            // 
            this.OverlayToggle.BackColor = System.Drawing.Color.Transparent;
            this.OverlayToggle.Location = new System.Drawing.Point(590, 76);
            this.OverlayToggle.Margin = new System.Windows.Forms.Padding(0);
            this.OverlayToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.OverlayToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.OverlayToggle.Name = "OverlayToggle";
            this.OverlayToggle.Size = new System.Drawing.Size(40, 20);
            this.OverlayToggle.TabIndex = 59;
            this.OverlayToggle.Toggled = false;
            this.OverlayToggle.ToggledEvent += new System.EventHandler(this.OverlayToggle_ToggledEvent);
            // 
            // OverlayLabel
            // 
            this.OverlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.OverlayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverlayLabel.ForeColor = System.Drawing.Color.White;
            this.OverlayLabel.Location = new System.Drawing.Point(45, 61);
            this.OverlayLabel.Name = "OverlayLabel";
            this.OverlayLabel.Size = new System.Drawing.Size(179, 50);
            this.OverlayLabel.TabIndex = 58;
            this.OverlayLabel.Text = "Main overlay";
            this.OverlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysOnTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.AlwaysOnTop.Location = new System.Drawing.Point(430, 112);
            this.AlwaysOnTop.Margin = new System.Windows.Forms.Padding(0);
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(150, 50);
            this.AlwaysOnTop.TabIndex = 49;
            this.AlwaysOnTop.Text = "Disabled";
            this.AlwaysOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AlwaysOnTopToggle
            // 
            this.AlwaysOnTopToggle.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysOnTopToggle.Location = new System.Drawing.Point(590, 127);
            this.AlwaysOnTopToggle.Margin = new System.Windows.Forms.Padding(0);
            this.AlwaysOnTopToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.AlwaysOnTopToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.AlwaysOnTopToggle.Name = "AlwaysOnTopToggle";
            this.AlwaysOnTopToggle.Size = new System.Drawing.Size(40, 20);
            this.AlwaysOnTopToggle.TabIndex = 48;
            this.AlwaysOnTopToggle.Toggled = false;
            this.AlwaysOnTopToggle.ToggledEvent += new System.EventHandler(this.AlwaysOnTopToggle_ToggledEvent);
            // 
            // AlwaysOnTopLabel
            // 
            this.AlwaysOnTopLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysOnTopLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysOnTopLabel.ForeColor = System.Drawing.Color.White;
            this.AlwaysOnTopLabel.Location = new System.Drawing.Point(45, 112);
            this.AlwaysOnTopLabel.Name = "AlwaysOnTopLabel";
            this.AlwaysOnTopLabel.Size = new System.Drawing.Size(179, 50);
            this.AlwaysOnTopLabel.TabIndex = 47;
            this.AlwaysOnTopLabel.Text = "Always On top";
            this.AlwaysOnTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // collapsiblePanel3
            // 
            this.collapsiblePanel3.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel3.Collapsed = true;
            this.collapsiblePanel3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel3.Controls.Add(this.StyleToggle);
            this.collapsiblePanel3.Controls.Add(this.ChartsState);
            this.collapsiblePanel3.Controls.Add(this.ChartsToggle);
            this.collapsiblePanel3.Controls.Add(this.ChartsLabel);
            this.collapsiblePanel3.Controls.Add(this.Orientation);
            this.collapsiblePanel3.Controls.Add(this.OrientationToggle);
            this.collapsiblePanel3.Controls.Add(this.OrientationLabel);
            this.collapsiblePanel3.Controls.Add(this.StyleState);
            this.collapsiblePanel3.Controls.Add(this.StyleLabel);
            this.collapsiblePanel3.Controls.Add(this.OpacityState);
            this.collapsiblePanel3.Controls.Add(this.OpacitySlider);
            this.collapsiblePanel3.Controls.Add(this.OpacityLabel);
            this.collapsiblePanel3.Icon = "";
            this.collapsiblePanel3.Location = new System.Drawing.Point(10, 330);
            this.collapsiblePanel3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.collapsiblePanel3.Name = "collapsiblePanel3";
            this.collapsiblePanel3.PanelText = "Appearance";
            this.collapsiblePanel3.Rounding = 5;
            this.collapsiblePanel3.Separators = 4;
            this.collapsiblePanel3.Size = new System.Drawing.Size(640, 60);
            this.collapsiblePanel3.TabIndex = 3;
            this.collapsiblePanel3.Text = "Appearance";
            // 
            // StyleToggle
            // 
            this.StyleToggle.BackColor = System.Drawing.Color.Transparent;
            this.StyleToggle.Location = new System.Drawing.Point(590, 128);
            this.StyleToggle.Margin = new System.Windows.Forms.Padding(0);
            this.StyleToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.StyleToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.StyleToggle.Name = "StyleToggle";
            this.StyleToggle.Size = new System.Drawing.Size(40, 20);
            this.StyleToggle.TabIndex = 71;
            this.StyleToggle.Toggled = false;
            this.StyleToggle.ToggledEvent += new System.EventHandler(this.RoundedToggle_ToggledEvent);
            // 
            // ChartsState
            // 
            this.ChartsState.BackColor = System.Drawing.Color.Transparent;
            this.ChartsState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartsState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ChartsState.Location = new System.Drawing.Point(430, 163);
            this.ChartsState.Margin = new System.Windows.Forms.Padding(0);
            this.ChartsState.Name = "ChartsState";
            this.ChartsState.Size = new System.Drawing.Size(150, 50);
            this.ChartsState.TabIndex = 66;
            this.ChartsState.Text = "Minimal";
            this.ChartsState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChartsToggle
            // 
            this.ChartsToggle.BackColor = System.Drawing.Color.Transparent;
            this.ChartsToggle.Location = new System.Drawing.Point(590, 178);
            this.ChartsToggle.Margin = new System.Windows.Forms.Padding(0);
            this.ChartsToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.ChartsToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.ChartsToggle.Name = "ChartsToggle";
            this.ChartsToggle.Size = new System.Drawing.Size(40, 20);
            this.ChartsToggle.TabIndex = 65;
            this.ChartsToggle.Toggled = false;
            this.ChartsToggle.ToggledEvent += new System.EventHandler(this.ChartsToggle_ToggledEvent);
            // 
            // ChartsLabel
            // 
            this.ChartsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChartsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartsLabel.ForeColor = System.Drawing.Color.White;
            this.ChartsLabel.Location = new System.Drawing.Point(45, 163);
            this.ChartsLabel.Name = "ChartsLabel";
            this.ChartsLabel.Size = new System.Drawing.Size(179, 50);
            this.ChartsLabel.TabIndex = 64;
            this.ChartsLabel.Text = "Charts";
            this.ChartsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Orientation
            // 
            this.Orientation.BackColor = System.Drawing.Color.Transparent;
            this.Orientation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orientation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Orientation.Location = new System.Drawing.Point(430, 214);
            this.Orientation.Margin = new System.Windows.Forms.Padding(0);
            this.Orientation.Name = "Orientation";
            this.Orientation.Size = new System.Drawing.Size(150, 50);
            this.Orientation.TabIndex = 59;
            this.Orientation.Text = "Portrait";
            this.Orientation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrientationToggle
            // 
            this.OrientationToggle.BackColor = System.Drawing.Color.Transparent;
            this.OrientationToggle.Location = new System.Drawing.Point(590, 229);
            this.OrientationToggle.Margin = new System.Windows.Forms.Padding(0);
            this.OrientationToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.OrientationToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.OrientationToggle.Name = "OrientationToggle";
            this.OrientationToggle.Size = new System.Drawing.Size(40, 20);
            this.OrientationToggle.TabIndex = 58;
            this.OrientationToggle.Toggled = false;
            this.OrientationToggle.ToggledEvent += new System.EventHandler(this.OrientationToggle_ToggledEvent);
            // 
            // OrientationLabel
            // 
            this.OrientationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrientationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrientationLabel.ForeColor = System.Drawing.Color.White;
            this.OrientationLabel.Location = new System.Drawing.Point(45, 214);
            this.OrientationLabel.Name = "OrientationLabel";
            this.OrientationLabel.Size = new System.Drawing.Size(179, 50);
            this.OrientationLabel.TabIndex = 57;
            this.OrientationLabel.Text = "Orientation";
            this.OrientationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StyleState
            // 
            this.StyleState.BackColor = System.Drawing.Color.Transparent;
            this.StyleState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.StyleState.Location = new System.Drawing.Point(430, 113);
            this.StyleState.Margin = new System.Windows.Forms.Padding(0);
            this.StyleState.Name = "StyleState";
            this.StyleState.Size = new System.Drawing.Size(150, 50);
            this.StyleState.TabIndex = 56;
            this.StyleState.Text = "Flat";
            this.StyleState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StyleLabel
            // 
            this.StyleLabel.BackColor = System.Drawing.Color.Transparent;
            this.StyleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleLabel.ForeColor = System.Drawing.Color.White;
            this.StyleLabel.Location = new System.Drawing.Point(45, 112);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(179, 50);
            this.StyleLabel.TabIndex = 54;
            this.StyleLabel.Text = "Style";
            this.StyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpacityState
            // 
            this.OpacityState.BackColor = System.Drawing.Color.Transparent;
            this.OpacityState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpacityState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OpacityState.Location = new System.Drawing.Point(295, 62);
            this.OpacityState.Margin = new System.Windows.Forms.Padding(0);
            this.OpacityState.Name = "OpacityState";
            this.OpacityState.Size = new System.Drawing.Size(150, 50);
            this.OpacityState.TabIndex = 50;
            this.OpacityState.Text = "90%";
            this.OpacityState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OpacitySlider
            // 
            this.OpacitySlider.BackColor = System.Drawing.Color.Transparent;
            this.OpacitySlider.Double = false;
            this.OpacitySlider.Location = new System.Drawing.Point(455, 71);
            this.OpacitySlider.Margin = new System.Windows.Forms.Padding(0);
            this.OpacitySlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.OpacitySlider.MaxValue = 100D;
            this.OpacitySlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.OpacitySlider.MinValue = 0D;
            this.OpacitySlider.Name = "OpacitySlider";
            this.OpacitySlider.Size = new System.Drawing.Size(175, 30);
            this.OpacitySlider.TabIndex = 49;
            this.OpacitySlider.Value = 90D;
            this.OpacitySlider.ValueP = 90D;
            this.OpacitySlider.Selecting += new System.EventHandler(this.OpacitySlider_Selecting);
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpacityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpacityLabel.ForeColor = System.Drawing.Color.White;
            this.OpacityLabel.Location = new System.Drawing.Point(45, 61);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(179, 50);
            this.OpacityLabel.TabIndex = 48;
            this.OpacityLabel.Text = "Opacity";
            this.OpacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel2.Collapsed = true;
            this.collapsiblePanel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel2.Controls.Add(this.TrayIconState);
            this.collapsiblePanel2.Controls.Add(this.TrayIconToggle);
            this.collapsiblePanel2.Controls.Add(this.TrayIconLabel);
            this.collapsiblePanel2.Controls.Add(this.TempWarningState);
            this.collapsiblePanel2.Controls.Add(this.TempWarningToggle);
            this.collapsiblePanel2.Controls.Add(this.TempWarningLabel);
            this.collapsiblePanel2.Controls.Add(this.MinimizeToTrayState);
            this.collapsiblePanel2.Controls.Add(this.MinimizeToTrayToggle);
            this.collapsiblePanel2.Controls.Add(this.MinimizeToTrayLabel);
            this.collapsiblePanel2.Icon = "";
            this.collapsiblePanel2.Location = new System.Drawing.Point(10, 400);
            this.collapsiblePanel2.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.PanelText = "Tray icon";
            this.collapsiblePanel2.Rounding = 5;
            this.collapsiblePanel2.Separators = 3;
            this.collapsiblePanel2.Size = new System.Drawing.Size(640, 60);
            this.collapsiblePanel2.TabIndex = 4;
            this.collapsiblePanel2.Text = "Tray icon";
            // 
            // TrayIconState
            // 
            this.TrayIconState.BackColor = System.Drawing.Color.Transparent;
            this.TrayIconState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrayIconState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TrayIconState.Location = new System.Drawing.Point(430, 61);
            this.TrayIconState.Margin = new System.Windows.Forms.Padding(0);
            this.TrayIconState.Name = "TrayIconState";
            this.TrayIconState.Size = new System.Drawing.Size(150, 50);
            this.TrayIconState.TabIndex = 69;
            this.TrayIconState.Text = "Disabled";
            this.TrayIconState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TrayIconToggle
            // 
            this.TrayIconToggle.BackColor = System.Drawing.Color.Transparent;
            this.TrayIconToggle.Location = new System.Drawing.Point(590, 76);
            this.TrayIconToggle.Margin = new System.Windows.Forms.Padding(0);
            this.TrayIconToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.TrayIconToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.TrayIconToggle.Name = "TrayIconToggle";
            this.TrayIconToggle.Size = new System.Drawing.Size(40, 20);
            this.TrayIconToggle.TabIndex = 68;
            this.TrayIconToggle.Toggled = false;
            this.TrayIconToggle.ToggledEvent += new System.EventHandler(this.TrayIconToggle_ToggledEvent);
            // 
            // TrayIconLabel
            // 
            this.TrayIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.TrayIconLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrayIconLabel.ForeColor = System.Drawing.Color.White;
            this.TrayIconLabel.Location = new System.Drawing.Point(45, 61);
            this.TrayIconLabel.Name = "TrayIconLabel";
            this.TrayIconLabel.Size = new System.Drawing.Size(179, 50);
            this.TrayIconLabel.TabIndex = 67;
            this.TrayIconLabel.Text = "Show tray icon";
            this.TrayIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TempWarningState
            // 
            this.TempWarningState.BackColor = System.Drawing.Color.Transparent;
            this.TempWarningState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempWarningState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TempWarningState.Location = new System.Drawing.Point(430, 163);
            this.TempWarningState.Margin = new System.Windows.Forms.Padding(0);
            this.TempWarningState.Name = "TempWarningState";
            this.TempWarningState.Size = new System.Drawing.Size(150, 50);
            this.TempWarningState.TabIndex = 66;
            this.TempWarningState.Text = "Disabled";
            this.TempWarningState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TempWarningToggle
            // 
            this.TempWarningToggle.BackColor = System.Drawing.Color.Transparent;
            this.TempWarningToggle.Enabled = false;
            this.TempWarningToggle.Location = new System.Drawing.Point(590, 178);
            this.TempWarningToggle.Margin = new System.Windows.Forms.Padding(0);
            this.TempWarningToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.TempWarningToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.TempWarningToggle.Name = "TempWarningToggle";
            this.TempWarningToggle.Size = new System.Drawing.Size(40, 20);
            this.TempWarningToggle.TabIndex = 65;
            this.TempWarningToggle.Toggled = false;
            this.TempWarningToggle.ToggledEvent += new System.EventHandler(this.TempLimitToggle_ToggledEvent);
            // 
            // TempWarningLabel
            // 
            this.TempWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempWarningLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempWarningLabel.ForeColor = System.Drawing.Color.White;
            this.TempWarningLabel.Location = new System.Drawing.Point(45, 163);
            this.TempWarningLabel.Name = "TempWarningLabel";
            this.TempWarningLabel.Size = new System.Drawing.Size(179, 50);
            this.TempWarningLabel.TabIndex = 64;
            this.TempWarningLabel.Text = "Temperature warning";
            this.TempWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinimizeToTrayState
            // 
            this.MinimizeToTrayState.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeToTrayState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeToTrayState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MinimizeToTrayState.Location = new System.Drawing.Point(430, 112);
            this.MinimizeToTrayState.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeToTrayState.Name = "MinimizeToTrayState";
            this.MinimizeToTrayState.Size = new System.Drawing.Size(150, 50);
            this.MinimizeToTrayState.TabIndex = 63;
            this.MinimizeToTrayState.Text = "Disabled";
            this.MinimizeToTrayState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinimizeToTrayToggle
            // 
            this.MinimizeToTrayToggle.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeToTrayToggle.Enabled = false;
            this.MinimizeToTrayToggle.Location = new System.Drawing.Point(590, 127);
            this.MinimizeToTrayToggle.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeToTrayToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.MinimizeToTrayToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.MinimizeToTrayToggle.Name = "MinimizeToTrayToggle";
            this.MinimizeToTrayToggle.Size = new System.Drawing.Size(40, 20);
            this.MinimizeToTrayToggle.TabIndex = 62;
            this.MinimizeToTrayToggle.Toggled = false;
            this.MinimizeToTrayToggle.ToggledEvent += new System.EventHandler(this.MinimizeToTrayToggle_ToggledEvent);
            // 
            // MinimizeToTrayLabel
            // 
            this.MinimizeToTrayLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeToTrayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeToTrayLabel.ForeColor = System.Drawing.Color.White;
            this.MinimizeToTrayLabel.Location = new System.Drawing.Point(45, 112);
            this.MinimizeToTrayLabel.Name = "MinimizeToTrayLabel";
            this.MinimizeToTrayLabel.Size = new System.Drawing.Size(179, 50);
            this.MinimizeToTrayLabel.TabIndex = 61;
            this.MinimizeToTrayLabel.Text = "Minimize to tray";
            this.MinimizeToTrayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Overlay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Overlay";
            this.Size = new System.Drawing.Size(660, 470);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.PositionPanel.ResumeLayout(false);
            this.collapsiblePanel1.ResumeLayout(false);
            this.collapsiblePanel3.ResumeLayout(false);
            this.collapsiblePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private CustomUI.CollapsiblePanel collapsiblePanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RoundedPanel PositionPanel;
        private RoundedButton BottomRightBTN;
        private RoundedButton TopRightBTN;
        private RoundedButton BottomLeftBTN;
        private RoundedButton TopLeftBTN;
        private CustomUI.CollapsiblePanel collapsiblePanel3;
        private System.Windows.Forms.Label AlwaysOnTop;
        private CustomUI.Toggle AlwaysOnTopToggle;
        private System.Windows.Forms.Label AlwaysOnTopLabel;
        private System.Windows.Forms.Label OpacityState;
        private Slider OpacitySlider;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.Label StyleState;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label Orientation;
        private CustomUI.Toggle OrientationToggle;
        private System.Windows.Forms.Label OrientationLabel;
        private System.Windows.Forms.Label ChartsState;
        private CustomUI.Toggle ChartsToggle;
        private System.Windows.Forms.Label ChartsLabel;
        private System.Windows.Forms.Label OverlayState;
        private CustomUI.Toggle OverlayToggle;
        private System.Windows.Forms.Label OverlayLabel;
        private CustomUI.Toggle StyleToggle;
        private CustomUI.CollapsiblePanel collapsiblePanel2;
        private System.Windows.Forms.Label TrayIconState;
        private CustomUI.Toggle TrayIconToggle;
        private System.Windows.Forms.Label TrayIconLabel;
        private System.Windows.Forms.Label TempWarningState;
        private CustomUI.Toggle TempWarningToggle;
        private System.Windows.Forms.Label TempWarningLabel;
        private System.Windows.Forms.Label MinimizeToTrayState;
        private CustomUI.Toggle MinimizeToTrayToggle;
        private System.Windows.Forms.Label MinimizeToTrayLabel;
    }
}
