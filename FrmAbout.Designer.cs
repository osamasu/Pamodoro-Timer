namespace About
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.hyperlink_Email = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlink_LinkedIN = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlink_Github = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.SuspendLayout();
            // 
            // hyperlink_Email
            // 
            this.hyperlink_Email.Appearance.Font = new System.Drawing.Font("Noto Sans Cond", 11.2F, System.Drawing.FontStyle.Bold);
            this.hyperlink_Email.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(29)))));
            this.hyperlink_Email.Appearance.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(29)))));
            this.hyperlink_Email.Appearance.Options.UseFont = true;
            this.hyperlink_Email.Appearance.Options.UseForeColor = true;
            this.hyperlink_Email.Appearance.Options.UseLinkColor = true;
            this.hyperlink_Email.LineVisible = true;
            this.hyperlink_Email.Location = new System.Drawing.Point(59, 162);
            this.hyperlink_Email.Name = "hyperlink_Email";
            this.hyperlink_Email.Size = new System.Drawing.Size(247, 26);
            this.hyperlink_Email.TabIndex = 0;
            this.hyperlink_Email.Text = "Osamataher306@Outlook.com";
            this.hyperlink_Email.Click += new System.EventHandler(this.hyperlink_Email_Click);
            // 
            // hyperlink_LinkedIN
            // 
            this.hyperlink_LinkedIN.Appearance.Font = new System.Drawing.Font("Noto Sans Cond", 11F, System.Drawing.FontStyle.Bold);
            this.hyperlink_LinkedIN.Appearance.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(29)))));
            this.hyperlink_LinkedIN.Appearance.Options.UseFont = true;
            this.hyperlink_LinkedIN.Appearance.Options.UseLinkColor = true;
            this.hyperlink_LinkedIN.Location = new System.Drawing.Point(59, 214);
            this.hyperlink_LinkedIN.Name = "hyperlink_LinkedIN";
            this.hyperlink_LinkedIN.Size = new System.Drawing.Size(299, 24);
            this.hyperlink_LinkedIN.TabIndex = 1;
            this.hyperlink_LinkedIN.Text = "OSAMA THABIT ABDULLAH MOHAMMED";
            this.hyperlink_LinkedIN.Click += new System.EventHandler(this.hyperlink_LinkedIN_Click);
            // 
            // hyperlink_Github
            // 
            this.hyperlink_Github.Appearance.Font = new System.Drawing.Font("Noto Sans Cond", 11F, System.Drawing.FontStyle.Bold);
            this.hyperlink_Github.Appearance.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(29)))));
            this.hyperlink_Github.Appearance.Options.UseFont = true;
            this.hyperlink_Github.Appearance.Options.UseLinkColor = true;
            this.hyperlink_Github.Location = new System.Drawing.Point(68, 271);
            this.hyperlink_Github.Name = "hyperlink_Github";
            this.hyperlink_Github.Size = new System.Drawing.Size(69, 24);
            this.hyperlink_Github.TabIndex = 2;
            this.hyperlink_Github.Text = "Osamasu";
            this.hyperlink_Github.Click += new System.EventHandler(this.hyperlink_Github_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Pamodoro_Time.Properties.Resources.DESKTOP_IMAGE_MY_INFO;
            this.ClientSize = new System.Drawing.Size(634, 305);
            this.Controls.Add(this.hyperlink_Github);
            this.Controls.Add(this.hyperlink_LinkedIN);
            this.Controls.Add(this.hyperlink_Email);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmAbout.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Contact INFO";
            this.Click += new System.EventHandler(this.FrmAbout_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlink_Email;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlink_LinkedIN;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlink_Github;
    }
}

