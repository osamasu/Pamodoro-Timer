using System;

namespace Pamodoro_Time
{
    public partial class FrmSettings : DevExpress.XtraEditors.XtraForm
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        public delegate void LoadEventInvoke(object sender, EventArgs e);
        public LoadEventInvoke Init;

        void Invoke()
        {
            Init?.Invoke(this, null);
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            TimeSpan_WorkTime.TimeSpan = clsSettings.StudyTime;
            TimeSpan_RestTime.TimeSpan = clsSettings.RestTime;
        }

        private void TimeSpan_WorkTime_EditValueChanged(object sender, EventArgs e)
        {
            clsSettings.StudyTime = TimeSpan_WorkTime.TimeSpan;
            Invoke();

        }

        private void TimeSpan_RestTime_EditValueChanged(object sender, EventArgs e)
        {
            clsSettings.RestTime = TimeSpan_RestTime.TimeSpan;
            Invoke();
        }
    }
}