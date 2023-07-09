using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
  
    public partial class Game : Form
    {
        System.Media.SoundPlayer playerSound = new System.Media.SoundPlayer(Resources.click1);
        public int PlayerScore { get; set; } = 0;
        public int ComputerScore { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public bool isSpaceFree { get; set; } = false;

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

        public Game()
        {
            InitializeComponent();

            boardButton.Add(1, button1);
            boardButton.Add(2, button2);
            boardButton.Add(3, button3);
            boardButton.Add(4, button4);
            boardButton.Add(5, button5);
            boardButton.Add(6, button6);
            boardButton.Add(7, button7);
            boardButton.Add(8, button8);
            boardButton.Add(9, button9);

            this.MaximizeBox = false;
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
                isSpaceFree = true;

                if (CheckDraw())
                {
                    DialogResult result = MessageBox.Show("Draw! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                        restartGame();
                    else
                        Close();

                    scoreLabel.Text = $"{PlayerScore} {++Draws} {ComputerScore}";
                }

                if (CheckWin())
                {
                    if (letter == 'X')
                    {
                        DialogResult result = MessageBox.Show("Bot wins! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                            restartGame();
                        else
                            Close();

                        scoreLabel.Text = $"{PlayerScore} {Draws}   {++ComputerScore}";
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Player wins! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                            restartGame();
                        else
                            Close();

                        scoreLabel.Text = $"{++PlayerScore} {Draws}   {++ComputerScore}";
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

        public int MiniMax(Dictionary<int, char> board, bool isMaximizing)
        {
            if (CheckWhichMarkWon(computer))
                return 1;
            else if (CheckWhichMarkWon(player))
                return -1;
            else if (CheckDraw())
                return 0;

            if (isMaximizing)
            {
                int bestScore = int.MinValue;

                var keys = new List<int>(board.Keys);

                foreach (var key in keys)
                {
                    if (board[key] == ' ')
                    {
                        board[key] = computer;
                        int score = MiniMax(board, false);
                        board[key] = ' ';

                        if (score > bestScore)
                            bestScore = score;
                    }
                }

                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;

                var keys = new List<int>(board.Keys);

                foreach (var key in keys)
                {
                    if (board[key] == ' ')
                    {
                        board[key] = player;
                        int score = MiniMax(board, true);
                        board[key] = ' ';

                        if (score < bestScore)
                            bestScore = score;
                    }
                }

                return bestScore;
            }
        }


        public bool CheckWhichMarkWon(char mark)
        {
            if ((board[1] == board[2] && board[1] == board[3] && board[1] == mark) ||
                (board[4] == board[5] && board[4] == board[6] && board[4] == mark) ||
                (board[7] == board[8] && board[7] == board[9] && board[7] == mark) ||
                (board[1] == board[4] && board[1] == board[7] && board[1] == mark) ||
                (board[2] == board[5] && board[2] == board[8] && board[2] == mark) ||
                (board[3] == board[6] && board[3] == board[9] && board[3] == mark) ||
                (board[1] == board[5] && board[1] == board[9] && board[1] == mark) ||
                (board[7] == board[5] && board[7] == board[3] && board[7] == mark))
            {
                return true;
            }

            return false;
        }

        private void PlayerMove(object sender, MouseEventArgs e)
        {     
            var button = (Button)sender;
            butonot = button.Name.ToCharArray();
            int position = Int16.Parse(butonot[butonot.Length - 1].ToString());
            button.BackColor = Color.Green;
            button.Text = "O";
            button.Enabled = false;
            
            playerSound.Play();
            InsertLetter(player, position);

            if(isSpaceFree)
                ComputerMove();
        }

        public void ComputerMove()
        {
            int bestScore = -800;
            int bestMove = 0;

            var keys = new List<int>(board.Keys);

            foreach (var key in keys)
            {
                if (board[key] == ' ')
                {
                    board[key] = computer;
                    int score = MiniMax(board, false);
                    board[key] = ' ';

                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = key;
                    }
                }
            }

            boardButton[bestMove].BackColor = Color.Red;

            InsertLetter(computer, bestMove);
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

            isSpaceFree  = false;
            EnableAllButtons();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            restartGame();
            PlayerScore = 0;
            Draws = 0;
            ComputerScore = 0;
            scoreLabel.Text = $"{PlayerScore} {Draws} {ComputerScore}";
        }
    }
}


   
