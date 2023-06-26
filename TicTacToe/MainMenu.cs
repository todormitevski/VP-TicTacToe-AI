using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        private SoundPlayer player;

        public MainMenu()
        {
            InitializeComponent();
            playBgMusic();
        }

        public void playBgMusic()
        {
            player = new SoundPlayer(Resources.bgMusic1);
            player.PlayLooping();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsContainer_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackgroundImage = Resources.btnHoverBg;
        }

        private void buttonsContainer_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackgroundImage = null;
        }
    }
}
