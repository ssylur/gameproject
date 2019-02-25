using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject.Classes.SpawnObjects
{
    class ZombieSpawnObject : SpawnObject
    {
        Random rnd = new Random();
        private Form context;

        public ZombieSpawnObject(Form1 formContext)
        {
            context = formContext;
        }
        public void spawn()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = SpawnObject.ZOMBIE;
            zombie.BackgroundImage = Properties.Resources.zombie_bottom;
            zombie.BackgroundImageLayout = ImageLayout.Zoom;

            zombie.Left = rnd.Next(0, Settings.SCREEN_WIDTH);
            zombie.Top = rnd.Next(0, Settings.SCREEN_HEIGHT);
            zombie.Width = 30;
            zombie.Height = 59;
            zombie.SizeMode = PictureBoxSizeMode.Normal;
            context.Controls.Add(zombie);
        }
    }
}
