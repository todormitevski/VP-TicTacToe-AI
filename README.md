<h1>Tic-Tac-Toe</h1>
<p>

  <h2> Објаснување на проблемот (апликацијата) </h2>
Тик-так-тоу (Tic-Tac-Toe) е класична игра на хартија, која може да се имплементира и како компјутерска апликација.

Целта на играта Тик-так-тоу е да се создаде линија од три исти симболи (обично "X" или "O") во хоризонтална, вертикална или дијагонална насока на игралното поле. Играта се игра во редослед со два играчи, кои придвижуваат своите симболи на празните полиња на таблата.

Кога ќе започне играта, играчите се менуваат да ставаат своите симболи ("X" или "O") на слободните места на таблата. Правилата се едноставни - играчите ги наменуваат своите симболи наизменично и обидуваат се да создадат линија од три симболи исти во било која насока. Првиот играч кој успее да ги формира трите симболи во линија станува победник. Ако сите полиња на таблата бидат исполнети и нема победник, играта завршува со нерешено.

<hr>

  <h2> Опис на решението </h2>
Решението на проблемот е имплементирано преку Windows Forms апликација во C#. Апликацијата содржи класа Game, која наследува од класата Form и го дефинира главното прозорче на играта Тик-так-тоу.

Во оваа класа, податоците и функционалностите за играта се имплементирани преку следните членови:

- Променливи за бодови на играчот (PlayerScore), компјутерот (ComputerScore) и нерешени партии (Draws).
  ```c#
  public int PlayerScore { get; set; } = 0;
  public int ComputerScore { get; set; } = 0;
  public int Draws { get; set; } = 0;
  ```
- Променлива isSpaceFree која означува дали има слободно поле на таблата.
  ```c#
  public bool isSpaceFree { get; set; } = false;
  ```
- Dictionary board кој ги чува состојбите на полињата на таблата, каде што клучот претставува позицијата на полето (1 до 9), а вредноста претставува симболот ('X', 'O' или празно поле).
  ```c#
  Dictionary<int, char> board = new Dictionary<int, char>
  {
      { 1, ' ' }, { 2, ' ' }, { 3, ' ' },
      { 4, ' ' }, { 5, ' ' }, { 6, ' ' },
      { 7, ' ' }, { 8, ' ' }, { 9, ' ' }
  };
  ```
- Dictionary boardButton кој ги чува копчињата на таблата, каде што клучот претставува позицијата на полето (1 до 9), а вредноста претставува соодветното копче.
  ```c#
  Dictionary<int, Button> boardButton = new Dictionary<int, Button>();

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
  ```
- Статични променливи player и computer кои ги дефинираат симболите на играчот и компјутерот. Player е О, а компјутерот е X.

```c#
static char player = 'O';
static char computer = 'X';
```

Останатите функции во класата служат за имплементација на различни функционалности на играта:

- EnableAllButtons(): Овозможување на сите копчиња на таблата.
  ```c#
  public void EnableAllButtons()
  {
      for (int i = 1; i <= boardButton.Count; i++)
      {
          boardButton[i].Enabled = true;
      }
  }
  ```
- SpaceIsFree(int position): Проверка дали полето на одредена позиција е слободно.
  ```c#
  public bool SpaceIsFree(int position)
  {
      if (board[position] == ' ')
      return true;

      return false;
  }
  ```
- InsertLetter(char letter, int position): Вметнување на симбол во одредено поле на таблата. Го ажурираат состојбата на таблата и проверуваат дали има победник или нерешена партија.
  ```c#
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
  ```
- CheckWin(): Проверка дали има победник.
- CheckDraw(): Проверка дали има нерешена партија.
- <b>MiniMax(Dictionary<int, char> board, bool isMaximizing): Алгоритам за избор на најдобар потег за компјутерот користејќи го минимакс алгоритмот.</b>

  *Објаснување за minmax во следна точка.*

- CheckWhichMarkWon(char mark): Проверка дали одреден симбол има победено во моментната состојба на таблата.
- PlayerMove(object sender, MouseEventArgs e): Обработување на потегот на играчот при клик на копче. Ги ажурира состојбата на таблата и овозможува потег на компјутерот.
  ```c#
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
  ```
- ComputerMove(): Извршување на потегот на компјутерот врз основа на избраниот најдобар потег преку ***минимакс алгоритмот***.
- restartGame(): Рестартирање на играта и ресетирање на состојбата на таблата и бодовите

<hr>

<h2> Опис на Minmax функцијата </h2>

```c#
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
```

Функцијата MiniMax имплементира алгоритмот MiniMax за пребарување на оптимална стратегија во игра со два играчи. Функцијата ја добива моменталната состојба на играта претставена како dictionary (board), каде што клучевите се позициите на board-от, а вредностите се обележјата ('X', 'O', или празно поле).

Аргументот isMaximizing го означува моменталниот играч - true за компјутерот (максимизирач) и false за играчот (минимизирачот). Ако е на ред компјутерот, функцијата ги генерира сите можни потези, ги извршува наредбите за потезите еден по еден, пресметувајќи го рекурзивниот повик на MiniMax, и го пресметува најдобриот резултат (највисока вредност) помеѓу потезите кои компјутерот може да ги направи. На крајот, враќа најдобриот резултат.

Ако е на ред играчот, функцијата генерира потези и ги пресметува најниските вредности помеѓу потезите кои играчот може да ги направи.

Овој алгоритам се базира на претпоставката дека двата играчи се играат со оптимална стратегија. Рекурзивно го пребарува целото дрво на можни игри и го одредува најдобриот потег за максимизирачот и најлошиот потег за минимизирачот.

<hr>

<h2> Краток опис и screenshots </h2>
Играта се игра со кликнување на понудените копчиња.

![image](https://github.com/todormitevski/VP-TicTacToe-AI/assets/74872391/49e60949-d9fd-407a-a2b0-f8fb5fed2cce)

Има две опции за играње, првата опција е Play vs CPU, со која играчот игра против компјутер кои користи minmax алгоритам.

![image](https://github.com/todormitevski/VP-TicTacToe-AI/assets/74872391/9b65f651-3af2-4638-a002-6f7e4c4b4764)

Втората опција нуди можност да се игра против друг играч од ист компјутер.

![image](https://github.com/todormitevski/VP-TicTacToe-AI/assets/74872391/16a4c78e-5ee2-49e5-aed9-6b5af2421654)

Со копчето Options може да се запре или повторно пушти музиката која е веќе стартува со лансирање на програмата. Од тука може да се вратиме назад во менито со помош на копчето Back.

![image](https://github.com/todormitevski/VP-TicTacToe-AI/assets/74872391/e9e88695-749d-4cd6-b9be-8ab44f538f51)

Копчето EXIT се користи за исклучување на апликацијата, соодветно.

Целта на играта Тик-так-тоу е да се создаде линија од три исти симболи (обично "X" или "O") во хоризонтална,
вертикална или дијагонална насока на игралното поле. Играта се игра во редослед со два играчи,
кои придвижуваат своите симболи на празните полиња на таблата.

<h3>Windows Forms Project изработено од: Тодор Митевски(213165) и Иван Ристов(213213)</h3>

</p>
