using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestTrojanEver
{
    public partial class OtrizkaProduction : Form
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                MessageBox.Show("Тест");
                e.Handled = true;
            }
        }
        public OtrizkaProduction()
        {
            InitializeComponent();
        }

        private void OtrizkaProduction_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Users\fish2\OneDrive\Документы\GitHub\best-Trojan-ever-2036\trojan\BestTrojanEver\BestTrojanEver\Resources\music.wav");
            player.Play();
        }
    }
}
