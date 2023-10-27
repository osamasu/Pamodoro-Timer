using About;
using Pamodoro_Time.Properties;
using System;
using System.Drawing;
using System.Media;


namespace Pamodoro_Time
{

    public enum EnPamadoraMode { StudyMode, RestMode };

    public partial class Pamodoro : DevExpress.XtraEditors.XtraForm
    {
        private EnPamadoraMode _PamadoraMode = EnPamadoraMode.StudyMode;

        public Pamodoro()
        {
            InitializeComponent();

            _PamadoraMode = EnPamadoraMode.StudyMode;
            gaugeControl1.ColorScheme.Color = Color.Crimson;
        }

        private void Pamodoro_Load(object sender, EventArgs e)
        {

            _RefreshColours_TextByMode();


            if (_PamadoraMode == EnPamadoraMode.StudyMode)
            {
                RemainingTime = clsSettings.StudyTime;
            }
            else
                RemainingTime = clsSettings.RestTime;


            LB_TimeLeft.Text = $"{RemainingTime.Hours.ToString().PadLeft(2, '0')}:{RemainingTime.Minutes.ToString().PadLeft(2, '0')}:{RemainingTime.Seconds.ToString().PadLeft(2, '0')}";
            initTimerInterval();

            arcScaleRangeBarComponent1.Value = 0;
        }

        private void _RefreshTimerLabel()
        {
            LB_TimeLeft.Text = $"{RemainingTime.Hours.ToString().PadLeft(2, '0')}:{RemainingTime.Minutes.ToString().PadLeft(2, '0')}:{RemainingTime.Seconds.ToString().PadLeft(2, '0')}";
        }

        private void _RefreshColours_TextByMode()
        {


            switch (_PamadoraMode)
            {
                case EnPamadoraMode.StudyMode:

                    labelControl1.Text = "حان الوقت لأنجاز الأعمال الخاصة بك";
                    //labelControl1.ImageOptions.Image = DXImage.(@"Office2013\Actions\Merge_16x16.png");
                    gaugeControl1.ColorScheme.Color = Color.Orange;
                    labelControl1.ImageOptions.Image = Resources.studying__1_;

                    break;

                case EnPamadoraMode.RestMode:
                    labelControl1.Text = "حأن الوقت لأخذ قسط من الراحة";
                    gaugeControl1.ColorScheme.Color = Color.LightGreen;
                    labelControl1.ImageOptions.Image = Resources.coffee__1_;

                    break;

            }

            if (arcScaleRangeBarComponent1.Value == 100)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                SoundPlayer TimerFinishSound = new SoundPlayer(Resources.microwave_timer);
                TimerFinishSound.Play();
                this.Activate();
            }
        }


        private void arcScaleRangeBarComponent1_Changed(object sender, EventArgs e)
        {

        }

        private void initTimerInterval()
        {
            TimeSpan Time;
            if (_PamadoraMode == EnPamadoraMode.StudyMode)
            {
                TimeRemainTimer.Interval = ((int)clsSettings.StudyTime.TotalMilliseconds / (int)TimeProgressBar.MaxValue);
                Time = clsSettings.StudyTime;
            }
            else
            {
                TimeRemainTimer.Interval = ((int)clsSettings.RestTime.TotalMilliseconds / (int)TimeProgressBar.MaxValue);
                Time = clsSettings.RestTime;
            }

            // we add here second to increse realiality in user interface
            RemainingTime = Time.Add(new TimeSpan(0, 0, 1));
        }

        private void Btn_Active_Click(object sender, EventArgs e)
        {
            //if (arcScaleRangeBarComponent1.Value == 100)
            //    initTimerInterval();

            Btn_Pause.Enabled = true;
            BarSettings.Enabled = false;
            this.Btn_Active.Enabled = false;

            _RefreshColours_TextByMode();


            TimeRemainTimer.Enabled = true;
            TimeRemainTimer.Start();

            timer1.Enabled = true;
            timer1.Start();


        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Btn_Active.Enabled = true;
            BarSettings.Enabled = true;

            this.Btn_Pause.Enabled = false;

            gaugeControl1.ColorScheme.Color = Color.Crimson;

            TimeRemainTimer.Stop();
            timer1.Stop();

        }

        private void BarSupport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:Osamataher306@Outlook.com");
        }

        private void BarDeveloperInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAbout MyDevAboutFrm = new FrmAbout();
            MyDevAboutFrm.TopMost = true;
            MyDevAboutFrm.ShowDialog();
        }

        private void TimeProgressBar_ValueChanged(object sender, EventArgs e)
        {
            labelComponent1.Text = arcScaleRangeBarComponent1.Value.ToString();
        }

        private void TimeRemainTimer_Tick(object sender, EventArgs e)
        {
            if (arcScaleRangeBarComponent1.Value <= 100)
            {

                switch (_PamadoraMode)
                {
                    case EnPamadoraMode.StudyMode:

                        if (arcScaleRangeBarComponent1.Value < 100)
                            arcScaleRangeBarComponent1.Value++;
                        else
                        {
                            _PamadoraMode = EnPamadoraMode.RestMode;
                            arcScaleRangeBarComponent1.Value = 0;
                            initTimerInterval();
                        }
                        break;

                    case EnPamadoraMode.RestMode:

                        if (arcScaleRangeBarComponent1.Value < 100)
                            arcScaleRangeBarComponent1.Value++;
                        else
                        {
                            _PamadoraMode = EnPamadoraMode.StudyMode;
                            arcScaleRangeBarComponent1.Value = 0;
                            initTimerInterval();
                        }
                        break;
                }


                _RefreshColours_TextByMode();

            }

        }

        private void arcScaleRangeBarComponent1_Changed_1(object sender, EventArgs e)
        {
            labelComponent1.Text = arcScaleRangeBarComponent1.Value.ToString();
        }

        TimeSpan RemainingTime = TimeSpan.Zero;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RemainingTime == TimeSpan.Zero && arcScaleRangeBarComponent1.Value == 100)
            {
                initTimerInterval();
            }

            if (RemainingTime != TimeSpan.Zero)
                RemainingTime = RemainingTime.Subtract(new TimeSpan(0, 0, 1));

            _RefreshTimerLabel();
        }

        private void BarSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSettings SettingsForm = new FrmSettings();
            SettingsForm.TopMost = true;
            SettingsForm.Init = Pamodoro_Load;
            SettingsForm.ShowDialog();
            _RefreshTimerLabel();
        }
    }
}