using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Options : Form
    {
        private MainMenu mainMenu;
        public Options(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void btnMusicOn_Click(object sender, EventArgs e)
        {
            mainMenu.musicOn();
        }

        private void btnMusicOff_Click(object sender, EventArgs e)
        {
            mainMenu.musicOff();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
