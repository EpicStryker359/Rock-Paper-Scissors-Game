using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public enum GameMove
    {
        Rock,Paper,Scissors,
    };


    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        //Variables 
        bool picked = false;
        bool no_more_time;

        bool youwin, youlose,draw;

        int seconds = 3;
        int milliseconds;

        int enemscore = 0, yourscore = 0;
        int cpuchoice;

        public int score_limit;

        string cpumove, mymove;

        //Set of Words that the Game will say:
        string[] winsay = {"Rock beats Scissors", "Scissors beats Paper", "Paper beats Rock", "Draw", "You chose nothing" , "You Win!", "You Lose!"};

        Random randomizer = new Random();

        //Click to exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Rock_Click(object sender, EventArgs e)
        {
            if (!picked)
            {
                mymove = GameMove.Rock.ToString();
                Rock.BackgroundImage = Properties.Resources.PlayerRock;
                MoveTimer.Enabled = false;
                CPUMove();
                CheckWinner();
            }
            picked = true;
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            if (!picked)
            {
                mymove = GameMove.Paper.ToString();
                Paper.BackgroundImage = Properties.Resources.PaperPlayer;
                MoveTimer.Enabled = false;
                CPUMove();
                CheckWinner();
            }
            picked = true;
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            if (!picked)
            {
                mymove = GameMove.Scissors.ToString();
                Scissors.BackgroundImage = Properties.Resources.PlayerScissor;
                MoveTimer.Enabled = false;
                CPUMove();
                CheckWinner();
            }
            picked = true;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            MoveTimer.Enabled = true;
            retrybutton.Visible = false;
            wintext.Visible = false;
            WhoWins.Visible = false;

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Hide();
            menu.ShowDialog();
            Close();
        }

        private void retrybutton_Click(object sender, EventArgs e)
        {
            //Hide Text
            retrybutton.Visible = false;
            wintext.Visible = false;
            WhoWins.Visible = false;

            //Reset States
            no_more_time = false;
            picked = false;

            //Reset Pictures
            Scissors.BackgroundImage = Properties.Resources.Scissors1;
            Rock.BackgroundImage = Properties.Resources.Rock1;
            Paper.BackgroundImage = Properties.Resources.Paper1;

            //Reset Time
            seconds = 3;
            milliseconds = 0;

            //Turn on Timers
            MoveTimer.Enabled = true;

            //Reset Win States
            draw = false;
            youwin = false;
            youlose = false;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveTime.Text = seconds + " s";

            milliseconds++;
            while (milliseconds == 5)
            {
                milliseconds = 0;
                if (seconds == 0)
                {
                    no_more_time = true;
                    if (no_more_time)
                    {
                        //Scoring
                        enemscore++;
                        cpuscore.Text = "CPU : " + enemscore;
                        //To Break the Loop
                        milliseconds = 6;

                        //Show The Pics
                        Scissors.BackgroundImage = Properties.Resources.NothingScissors;
                        Rock.BackgroundImage = Properties.Resources.NothingRock;
                        Paper.BackgroundImage = Properties.Resources.NothingPaper;

                        //Win Text
                        wintext.Text = winsay[6];
                        wintext.Visible = true;
                        WhoWins.Visible = true;
                        WhoWins.Text = winsay[4];
                        retrybutton.Visible = true;
                    }
                    break;
                }
                seconds--;
            }
        }

        private void CPUMove()
        {
            choose:
            cpuchoice = randomizer.Next(0, 3);
            switch (cpuchoice)
            {
                case 1:
                    if (mymove == GameMove.Rock.ToString())
                    {
                        Rock.BackgroundImage = Properties.Resources.DrawRock;
                    }
                    else
                    {
                        Rock.BackgroundImage = Properties.Resources.CPURock;
                    }
                    cpumove = GameMove.Rock.ToString();
                    break;
                case 2:
                    if (mymove == GameMove.Paper.ToString())
                    {
                        Paper.BackgroundImage = Properties.Resources.DrawPaper;
                    }
                    else
                    {
                        Paper.BackgroundImage = Properties.Resources.PaperCPU;
                    }
                    cpumove = GameMove.Paper.ToString();
                    break;
                case 3:
                    if (mymove == GameMove.Scissors.ToString())
                    {
                        Scissors.BackgroundImage = Properties.Resources.DrawScissor;
                    }
                    else
                    {
                        Scissors.BackgroundImage = Properties.Resources.CPUScissor;
                    }
                    cpumove = GameMove.Scissors.ToString();
                    break;
                default:
                    goto choose;
            }
        }

        private void CheckWinner()
        {

            //Rock beats Scissors
            if (mymove == GameMove.Rock.ToString() && cpumove == GameMove.Scissors.ToString()) // I win
            {
                youwin = true;
                WhoWins.Text = winsay[0];
            }

            else if (mymove == GameMove.Scissors.ToString() && cpumove == GameMove.Rock.ToString()) // I lose
            {
                youlose = true;
                WhoWins.Text = winsay[0];
            }

            //Paper beats Rock
            else if (mymove == GameMove.Paper.ToString() && cpumove == GameMove.Rock.ToString()) // I win
            {
                youwin = true;
                WhoWins.Text = winsay[2];
            }
            else if (mymove == GameMove.Rock.ToString() && cpumove == GameMove.Paper.ToString()) // I lose
            {
                youlose = true;
                WhoWins.Text = winsay[2];
            }

            //Scissors beats Paper
            else if (mymove == GameMove.Scissors.ToString() && cpumove == GameMove.Paper.ToString()) // I win
            {
                youwin = true;
                WhoWins.Text = winsay[1];
            }
            else if (mymove == GameMove.Paper.ToString() && cpumove == GameMove.Scissors.ToString()) // I lose
            {
                youlose = true;
                WhoWins.Text = winsay[1];
            }

            //Draw
            else if (mymove == GameMove.Scissors.ToString() && cpumove == GameMove.Scissors.ToString()) // Draw
            {
                draw = true;
                WhoWins.Text = winsay[3];
            }
            else if (mymove == GameMove.Paper.ToString() && cpumove == GameMove.Paper.ToString()) // Draw
            {
                draw = true;
                WhoWins.Text = winsay[3];
            }
            else if (mymove == GameMove.Rock.ToString() && cpumove == GameMove.Rock.ToString()) // Draw
            {
                draw = true;
                WhoWins.Text = winsay[3];
            }


            if (youwin)
            {
                yourscore++;
                playerscore.Text = "User : " + yourscore;

                //Win Text
                wintext.Text = winsay[5];
                wintext.Visible = true;
                WhoWins.Visible = true;
                retrybutton.Visible = true;
            }
            else if (youlose)
            {
                //Scoring
                enemscore++;
                cpuscore.Text = "CPU : " + enemscore;

                //Win Text
                wintext.Text = winsay[6];
                wintext.Visible = true;
                WhoWins.Visible = true;
                retrybutton.Visible = true;
            }
            else if (draw)
            {
                wintext.Text = winsay[3];
                wintext.Visible = true;
                WhoWins.Visible = true;
                retrybutton.Visible = true;
            }

            if(yourscore == score_limit) {
                Menu menu = new Menu();

                MessageBox.Show("You have reached the total limit!", "You Win", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                MessageBox.Show("Game Over!", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Hide();
                menu.ShowDialog();
                Close();
            }
            else if(enemscore == score_limit)
            {
                Menu menu = new Menu();

                MessageBox.Show("You have reached the total limit!", "You Lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Game Over!", "You Lose", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Hide();
                menu.ShowDialog();
                Close();
            }

        }



        //Move Form
        //Move Variables
        bool click;
        Point mouseloc;

        private void Clicked(object sender, MouseEventArgs e)
        {
            click = true;
            mouseloc = e.Location;
        }

        private void Released(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void Moved(object sender, MouseEventArgs e)
        {
            if (click)
            {
                this.Location = new Point((this.Location.X - mouseloc.X) + e.X, (this.Location.Y - mouseloc.Y) + e.Y);
            }
        }
    }
}

