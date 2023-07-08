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
    public partial class PlayerVsPlayer : Form
    {
        public bool Player1Turn { get; set; }   = true;
        Dictionary<int, char> board = new Dictionary<int, char>
        {
            { 1, ' ' }, { 2, ' ' }, { 3, ' ' },
            { 4, ' ' }, { 5, ' ' }, { 6, ' ' },
            { 7, ' ' }, { 8, ' ' }, { 9, ' ' }
        };

        Dictionary<int, Button> boardButton = new Dictionary<int, Button>();

        static char player = 'O';
        static char computer = 'X';

        List<Button> buttons;
        private char[] butonot;

        public void EnableAllButtons()
        {
            for (int i = 1; i <= boardButton.Count; i++)
            {
                boardButton[i].Enabled = true;
            }
        }

        public PlayerVsPlayer()
        {
            InitializeComponent();
            turnLabel.Text = "Turn: Player 1 (O)";


            boardButton.Add(1, button1);
            boardButton.Add(2, button2);
            boardButton.Add(3, button3);
            boardButton.Add(4, button4);
            boardButton.Add(5, button5);
            boardButton.Add(6, button6);
            boardButton.Add(7, button7);
            boardButton.Add(8, button8);
            boardButton.Add(9, button9);

        }



        public bool SpaceIsFree(int position)
        {
            if (board[position] == ' ')
                return true;

            return false;
        }


        public void InsertLetter(char letter, int position)
        {

            if (SpaceIsFree(position))
            {
                board[position] = letter;
                boardButton[position].Text = letter.ToString();
                boardButton[position].Enabled = false;


                if (CheckDraw())
                {


                    DialogResult result = MessageBox.Show("Draw! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                        restartGame();
                    else
                        Close();
                }

                if (CheckWin())
                {
                    if (letter == 'X')
                    {
                        DialogResult result = MessageBox.Show("Player 2 wins! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                            restartGame();
                        else
                            Close();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Player 1 wins! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                            restartGame();
                        else
                            Close();
                    }
                }
            }
           
        }


        public bool CheckWin()
        {
            if ((board[1] == board[2] && board[1] == board[3] && board[1] != ' ') ||
                (board[4] == board[5] && board[4] == board[6] && board[4] != ' ') ||
                (board[7] == board[8] && board[7] == board[9] && board[7] != ' ') ||
                (board[1] == board[4] && board[1] == board[7] && board[1] != ' ') ||
                (board[2] == board[5] && board[2] == board[8] && board[2] != ' ') ||
                (board[3] == board[6] && board[3] == board[9] && board[3] != ' ') ||
                (board[1] == board[5] && board[1] == board[9] && board[1] != ' ') ||
                (board[7] == board[5] && board[7] == board[3] && board[7] != ' '))
            {
                return true;
            }

            return false;
        }


        public bool CheckDraw()
        {
            foreach (var key in board.Keys)
            {
                if (board[key] == ' ')
                    return false;
            }

            return true;
        }


        private void PlayerMove(object sender, MouseEventArgs e)
        {

            if (Player1Turn)
            {
                turnLabel.Text = "Turn: Player 2 (X)";


                var button = (Button)sender;

                butonot = button.Name.ToCharArray();
                int position = Int16.Parse(butonot[butonot.Length - 1].ToString());
                button.BackColor = Color.MediumPurple;
                button.Text = "O";
                button.Enabled = false;
                InsertLetter(player, position);
               
               
                Player1Turn = false;
            }
            else
            {
                turnLabel.Text = "Turn: Player 1 (O)";

                var button = (Button)sender;
                butonot = button.Name.ToCharArray();
                int position = Int16.Parse(butonot[butonot.Length - 1].ToString());
                button.BackColor = Color.Green;
                button.Text = "X";
                button.Enabled = false;
                InsertLetter(computer, position);
                

                Player1Turn = true;

            }






        }

     


        private void restartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = " ";
                button.BackColor = DefaultBackColor;
            }

            foreach (var key in board.Keys.ToList())
            {
                board[key] = ' ';
            }
   
            turnLabel.Text = "Turn: Player 1 (O)";
            EnableAllButtons();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            restartGame();
        }


    }
}


