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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }



        private void Enter_Click(object sender, EventArgs e)
        {
            Game game = new Game();

            //To avoid a god damn error 
           if(ScoreLimit.Text != String.Empty)
            {
                game.score_limit = Int32.Parse(ScoreLimit.Text);

                if (game.score_limit < 0 || game.score_limit > 100 || ScoreLimit.Text == null)
                {
                    game.score_limit = 0;
                    MessageBox.Show("Your given limit is either too big or too low");
                }
                else if (game.score_limit >= 1 || game.score_limit <= 100)
                {
                    Hide();
                    game.ShowDialog();
                    Close();
                }
            }
           //just asking if the user wants an error
            MessageBox.Show("Do you want an error? Please insert a score limit!", "Important Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Hide();
            menu.ShowDialog();
            Close();
        }
    }
}
