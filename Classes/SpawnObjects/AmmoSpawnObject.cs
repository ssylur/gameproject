using System;
using System.Windows.Forms;

namespace GameProject.Classes.SpawnObjects
{
    class AmmoSpawnObject : SpawnObject
    {
        Random rnd = new Random();

        private Form context;
        public AmmoSpawnObject(Form1 formContext)
        {
            context = formContext;
        }

        public void spawn()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.shells;
            ammo.SizeMode = PictureBoxSizeMode.Zoom;
            ammo.Width = 45;
            ammo.Height = 45;
            ammo.Left = rnd.Next(10, Settings.SCREEN_WIDTH - 100);
            ammo.Top = rnd.Next(60, Settings.SCREEN_HEIGHT - 100);
            ammo.Tag = SpawnObject.AMMO;
            context.Controls.Add(ammo);
            ammo.BringToFront(); //zindex problem
           // context.player.BringToFront();
        }

        internal void spawn(int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
