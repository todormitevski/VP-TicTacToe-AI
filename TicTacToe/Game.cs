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
  
    public partial class Game : Form
    {
        public bool PlayerTurn { get; set; } = true;
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

        public void DisableAllButtons()
        {
            for (int i = 1; i <= boardButton.Count; i++)
            {
                boardButton[i].Enabled = false;
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
                
                //PrintBoard(board);
                

                if (CheckDraw())
                {
                    DialogResult result = MessageBox.Show("Draw! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                        restartGame();
                    else
                        Close();


                    return;
                    //Environment.Exit(0);
                }

                if (CheckWin())
                {
                    if (letter == 'X')
                    {
                        label1.Text = "Bot wins";
                        DialogResult result = MessageBox.Show("Bot wins! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                            restartGame();
                        else
                            Close();
                        

                    }
                    else
                    {
                        label1.Text = "Player wins";
                        DialogResult result = MessageBox.Show("Player wins! Play again?", "Game Over", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                            restartGame();
                        else
                            Close();
                       
                        

                        


                    }

                    //Environment.Exit(0);
                }
            }
            //else
            //{
            //    Console.WriteLine("Invalid position");
            //    Console.WriteLine("Please enter a new position: ");
            //    position = int.Parse(Console.ReadLine());
            //    InsertLetter(letter, position);
            //}
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

                // Create a copy of the keys
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

                // Create a copy of the keys
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

        public void PlayerMove()
        {
            Console.WriteLine("Enter a position for 'O': ");
            //int position = int.Parse(Console.ReadLine());
            int position = 1;
            button1.Enabled = false;
            button1.BackColor = Color.MediumPurple;
            button1.Text = "O";
            InsertLetter(player, position);
        }

        int i = 0;

        private void PlayerMove(object sender, MouseEventArgs e)
        {
                           
                var button = (Button)sender;

                butonot = button.Name.ToCharArray();
                int position = Int16.Parse(butonot[butonot.Length - 1].ToString());
                label1.Text = position.ToString();
                InsertLetter(player, position);
                //char clickedButton
                //currentPlayer = Player.X;
                //button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.MediumPurple;
                button.Text = "O";
            //buttons.Remove(button);
            ++i;
            if(i != 5)
            {
                ComputerMove();
            }
        }

        public void ComputerMove()
        {
            int bestScore = -800;
            int bestMove = 0;

            // Create a copy of the keys
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

            PlayerTurn = true;

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
            i = 0;

            EnableAllButtons();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            restartGame();
        }

      
    }
}


   
