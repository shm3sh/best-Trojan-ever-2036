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

namespace BestTrojanEver
{
    public partial class OtrizkaProduction : Form
    {
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
        }

        private void OtrizkaProduction_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer mainSound = new System.Media.SoundPlayer(@"music.wav");
            mainSound.Play();

            MessageBox.Show("При открытии диспетчера задач компик перезапустится <3");
        }
    }
}
