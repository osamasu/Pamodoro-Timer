using System;

namespace About
{
    public partial class FrmAbout : DevExpress.XtraEditors.XtraForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void hyperlink_Email_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:Osamataher306@Outlook.com");
        }

        private void hyperlink_LinkedIN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/osama-thabit-mohammed");
        }

        private void hyperlink_Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/osamasu");
        }

        private void FrmAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
