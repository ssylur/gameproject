using System;
using System.Windows.Forms;

namespace GameProject.Classes.SpawnObjects
{
    class HealSpawnObject : SpawnObject
    {
        Random rnd = new Random();

        private Form context;
        public HealSpawnObject(Form1 formContext)
        {
            context = formContext;
        }

        public void spawn()
        {
            PictureBox heal = new PictureBox();
            heal.Image = Properties.Resources.medkit;
            heal.SizeMode = PictureBoxSizeMode.Zoom;
            heal.Width = 45;
            heal.Height = 45;
            heal.Left = rnd.Next(10, Settings.SCREEN_WIDTH - 100);
            heal.Top = rnd.Next(60, Settings.SCREEN_HEIGHT - 100);
            heal.Tag = SpawnObject.HEAL;
            context.Controls.Add(heal);
            heal.BringToFront(); 
        }
    }
}
