using System.Drawing;
using System.Windows.Forms;
using GameProject.Classes;

namespace GameProject
{
    class UserInterfaceHelper
    {
        public static void updateBullets(Label label, int number)
        {
            label.Text = "Bullets: " + new string('|', number);
        }

        public static void updateScore(Label scoreLabel, int score)
        {
            scoreLabel.Text = "Score: " + score;
        }

        public static void showEndGame(Label startLabel, int score)
        {
            startLabel.Text = "Koniec gry. Twój wynik: " + score;
            startLabel.BackColor = Color.DarkRed;
            startLabel.ForeColor = Color.Black;
            startLabel.Font = new Font(startLabel.Font.FontFamily, 58);
            startLabel.Visible = true;
            startLabel.BringToFront();
        }
    }
}
