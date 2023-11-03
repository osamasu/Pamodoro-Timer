namespace Pamodoro_Time
{
    partial class Pamodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pamodoro));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.circularGauge14 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.TimeProgressBar = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BarSettings = new DevExpress.XtraBars.BarButtonItem();
            this.BarDeveloperInfo = new DevExpress.XtraBars.BarButtonItem();
            this.BarSupport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Btn_Active = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.TimeRemainTimer = new System.Windows.Forms.Timer(this.components);
            this.LB_TimeLeft = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gaugeControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.ImageOptions.Image = global::Pamodoro_Time.Properties.Resources.coffee__1_;
            this.labelControl1.ImageOptions.SvgImageSize = new System.Drawing.Size(45, 45);
            this.labelControl1.Location = new System.Drawing.Point(275, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(249, 90);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "حأن الوقت لأخذ قسط من الراحة";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl1.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)(((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl1.Controls.Add(this.svgImageBox1);
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge14});
            this.gaugeControl1.Location = new System.Drawing.Point(12, 14);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(219, 216);
            this.gaugeControl1.TabIndex = 2;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.svgImageBox1.Location = new System.Drawing.Point(71, 71);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(77, 77);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 0;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // circularGauge14
            // 
            this.circularGauge14.Bounds = new System.Drawing.Rectangle(8, 7, 203, 201);
            this.circularGauge14.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge14.Name = "circularGauge14";
            this.circularGauge14.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge14.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.TimeProgressBar});
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 24F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Pixel);
            this.labelComponent1.Name = "circularGauge_Percent";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(205F, 100F);
            this.labelComponent1.Size = new System.Drawing.SizeF(50F, 40F);
            this.labelComponent1.Text = "0";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.TimeProgressBar;
            this.arcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 62F;
            this.arcScaleRangeBarComponent1.Value = 0F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            this.arcScaleRangeBarComponent1.Changed += new System.EventHandler(this.arcScaleRangeBarComponent1_Changed_1);
            // 
            // TimeProgressBar
            // 
            this.TimeProgressBar.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.TimeProgressBar.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.TimeProgressBar.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.TimeProgressBar.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.TimeProgressBar.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.5F);
            this.TimeProgressBar.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.TimeProgressBar.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.TimeProgressBar.CustomLogarithmicBase = 2.718282F;
            this.TimeProgressBar.EndAngle = -37F;
            this.TimeProgressBar.LogarithmicBase = DevExpress.XtraGauges.Core.Model.LogarithmicBase.Exponential;
            this.TimeProgressBar.MajorTickCount = 0;
            this.TimeProgressBar.MajorTickmark.FormatString = "{0:F0}";
            this.TimeProgressBar.MajorTickmark.ShapeOffset = -14F;
            this.TimeProgressBar.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.TimeProgressBar.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.TimeProgressBar.MaxValue = 100F;
            this.TimeProgressBar.MinorTickCount = 0;
            this.TimeProgressBar.MinorTickmark.ShapeOffset = -7F;
            this.TimeProgressBar.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.TimeProgressBar.Name = "scale1";
            this.TimeProgressBar.StartAngle = -270F;
            this.TimeProgressBar.Value = 40F;
            this.TimeProgressBar.ValueChanged += new System.EventHandler(this.TimeProgressBar_ValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarSettings,
            this.BarDeveloperInfo,
            this.BarSupport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Noto Sans Cond", 8.999999F, System.Drawing.FontStyle.Bold);
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarDeveloperInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSupport)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // BarSettings
            // 
            this.BarSettings.Caption = "الأعدادات";
            this.BarSettings.Id = 0;
            this.BarSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BarSettings.ImageOptions.SvgImage")));
            this.BarSettings.Name = "BarSettings";
            this.BarSettings.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BarSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarSettings_ItemClick);
            // 
            // BarDeveloperInfo
            // 
            this.BarDeveloperInfo.Caption = "حول المطور";
            this.BarDeveloperInfo.Id = 1;
            this.BarDeveloperInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarDeveloperInfo.ImageOptions.Image")));
            this.BarDeveloperInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarDeveloperInfo.ImageOptions.LargeImage")));
            this.BarDeveloperInfo.Name = "BarDeveloperInfo";
            this.BarDeveloperInfo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BarDeveloperInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarDeveloperInfo_ItemClick);
            // 
            // BarSupport
            // 
            this.BarSupport.Caption = "الدعم الفني";
            this.BarSupport.Id = 2;
            this.BarSupport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BarSupport.ImageOptions.Image")));
            this.BarSupport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BarSupport.ImageOptions.LargeImage")));
            this.BarSupport.Name = "BarSupport";
            this.BarSupport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BarSupport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarSupport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(536, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 241);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(536, 40);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 241);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(536, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 241);
            // 
            // Btn_Active
            // 
            this.Btn_Active.Appearance.BorderColor = System.Drawing.Color.Lime;
            this.Btn_Active.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Active.Appearance.Options.UseBorderColor = true;
            this.Btn_Active.Appearance.Options.UseFont = true;
            this.Btn_Active.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Active.ImageOptions.SvgImage")));
            this.Btn_Active.Location = new System.Drawing.Point(408, 175);
            this.Btn_Active.Name = "Btn_Active";
            this.Btn_Active.Size = new System.Drawing.Size(116, 55);
            this.Btn_Active.TabIndex = 7;
            this.Btn_Active.Text = "تفعيل";
            this.Btn_Active.Click += new System.EventHandler(this.Btn_Active_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Appearance.BorderColor = System.Drawing.Color.Lime;
            this.Btn_Pause.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pause.Appearance.Options.UseBorderColor = true;
            this.Btn_Pause.Appearance.Options.UseFont = true;
            this.Btn_Pause.Enabled = false;
            this.Btn_Pause.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Pause.ImageOptions.SvgImage")));
            this.Btn_Pause.Location = new System.Drawing.Point(356, 175);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(46, 55);
            this.Btn_Pause.TabIndex = 18;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // TimeRemainTimer
            // 
            this.TimeRemainTimer.Interval = 1000;
            this.TimeRemainTimer.Tick += new System.EventHandler(this.TimeRemainTimer_Tick);
            // 
            // LB_TimeLeft
            // 
            this.LB_TimeLeft.Appearance.Font = new System.Drawing.Font("Liberation Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TimeLeft.Appearance.Options.UseFont = true;
            this.LB_TimeLeft.Appearance.Options.UseTextOptions = true;
            this.LB_TimeLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LB_TimeLeft.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LB_TimeLeft.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.LB_TimeLeft.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LB_TimeLeft.ImageOptions.Image")));
            this.LB_TimeLeft.ImageOptions.SvgImageSize = new System.Drawing.Size(45, 45);
            this.LB_TimeLeft.Location = new System.Drawing.Point(186, 175);
            this.LB_TimeLeft.Name = "LB_TimeLeft";
            this.LB_TimeLeft.Size = new System.Drawing.Size(154, 54);
            this.LB_TimeLeft.TabIndex = 23;
            this.LB_TimeLeft.Text = "00:00:15";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pamodoro
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(536, 281);
            this.Controls.Add(this.LB_TimeLeft);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Active);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Pamodoro.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pamodoro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pamodoro Time";
            this.Load += new System.EventHandler(this.Pamodoro_Load);
            this.gaugeControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BarSettings;
        private DevExpress.XtraBars.BarButtonItem BarDeveloperInfo;
        private DevExpress.XtraBars.BarButtonItem BarSupport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge14;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent TimeProgressBar;
        private DevExpress.XtraEditors.SimpleButton Btn_Active;
        private DevExpress.XtraEditors.SimpleButton Btn_Pause;
        private System.Windows.Forms.Timer TimeRemainTimer;
        private DevExpress.XtraEditors.LabelControl LB_TimeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}