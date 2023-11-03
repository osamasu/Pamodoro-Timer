namespace Pamodoro_Time
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TimeSpan_WorkTime = new DevExpress.XtraEditors.TimeSpanEdit();
            this.TimeSpan_RestTime = new DevExpress.XtraEditors.TimeSpanEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan_WorkTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan_RestTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(234, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 38);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "وقت العمل";
            // 
            // TimeSpan_WorkTime
            // 
            this.TimeSpan_WorkTime.EditValue = System.TimeSpan.Parse("00:00:00");
            this.TimeSpan_WorkTime.Location = new System.Drawing.Point(44, 29);
            this.TimeSpan_WorkTime.Name = "TimeSpan_WorkTime";
            this.TimeSpan_WorkTime.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TimeSpan_WorkTime.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TimeSpan_WorkTime.Properties.AdvancedModeOptions.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.TimeSpan_WorkTime.Properties.Appearance.Font = new System.Drawing.Font("Noto Sans Cond", 10.8F, System.Drawing.FontStyle.Bold);
            this.TimeSpan_WorkTime.Properties.Appearance.Options.UseFont = true;
            this.TimeSpan_WorkTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeSpan_WorkTime.Properties.MaskSettings.Set("mask", "hh:mm:ss");
            this.TimeSpan_WorkTime.Properties.MaskSettings.Set("inputMode", DevExpress.Data.Mask.TimeSpanMaskInputMode.NotRestrictedLargestUnit);
            this.TimeSpan_WorkTime.Properties.MaskSettings.Set("allowNegativeValues", false);
            this.TimeSpan_WorkTime.Properties.SuppressMouseEventOnOuterMouseClick = true;
            this.TimeSpan_WorkTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TimeSpan_WorkTime.Properties.UseMaskAsDisplayFormat = false;
            this.TimeSpan_WorkTime.Size = new System.Drawing.Size(125, 34);
            this.TimeSpan_WorkTime.TabIndex = 1;
            this.TimeSpan_WorkTime.EditValueChanged += new System.EventHandler(this.TimeSpan_WorkTime_EditValueChanged);
            // 
            // TimeSpan_RestTime
            // 
            this.TimeSpan_RestTime.EditValue = System.TimeSpan.Parse("00:00:00");
            this.TimeSpan_RestTime.Location = new System.Drawing.Point(44, 104);
            this.TimeSpan_RestTime.Name = "TimeSpan_RestTime";
            this.TimeSpan_RestTime.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TimeSpan_RestTime.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.TimeSpan_RestTime.Properties.AdvancedModeOptions.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.TimeSpan_RestTime.Properties.Appearance.Font = new System.Drawing.Font("Noto Sans Cond", 10.8F, System.Drawing.FontStyle.Bold);
            this.TimeSpan_RestTime.Properties.Appearance.Options.UseFont = true;
            this.TimeSpan_RestTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeSpan_RestTime.Properties.MaskSettings.Set("mask", "hh:mm:ss");
            this.TimeSpan_RestTime.Properties.MaskSettings.Set("allowNegativeValues", false);
            this.TimeSpan_RestTime.Properties.SuppressMouseEventOnOuterMouseClick = true;
            this.TimeSpan_RestTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TimeSpan_RestTime.Size = new System.Drawing.Size(125, 34);
            this.TimeSpan_RestTime.TabIndex = 3;
            this.TimeSpan_RestTime.EditValueChanged += new System.EventHandler(this.TimeSpan_RestTime_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(197, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(181, 38);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "وقت الأستراحة";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(397, 172);
            this.Controls.Add(this.TimeSpan_RestTime);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TimeSpan_WorkTime);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmSettings.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan_WorkTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan_RestTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeSpanEdit TimeSpan_WorkTime;
        private DevExpress.XtraEditors.TimeSpanEdit TimeSpan_RestTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}