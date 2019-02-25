using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameProject.Classes.SpawnObjects
{
    class ShootSpawnObject : SpawnObject
    {
        public int speed = 20;

        public string direction;
        Timer tm = new Timer();
        PictureBox Bullet = new PictureBox();

        private Form1 context;

        public ShootSpawnObject(Form1 formContext)
        {
            context = formContext;
            direction = context.direction;
        }

        public void spawn()
        {
            Bullet.BackColor = System.Drawing.Color.Gold;
            Bullet.Size = new Size(5, 5);
            Bullet.Tag = SpawnObject.SHOOT;
            Bullet.Left = context.playerBox.Left + (context.playerBox.Width / 2);
            Bullet.Top = context.playerBox.Top + (context.playerBox.Height / 2);
            Bullet.BringToFront();
            context.Controls.Add(Bullet);

            tm.Interval = speed;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();

        }

        public void tm_Tick(object Sender, EventArgs e)
        {
            if (direction == "left")
            {
                Bullet.Left -= speed;
            }

            if (direction == "right")
            {
                Bullet.Left += speed;
            }

            if (direction == "up")
            {
                Bullet.Top -= speed;
            }

            if (direction == "down")
            {
                Bullet.Top += speed;
            }

            if (Bullet.Left < 16 || Bullet.Left > 900 || Bullet.Top < 10 || Bullet.Top > 660)
            {
                tm.Stop();
                tm.Dispose();
                Bullet.Dispose();
                tm = null;
                Bullet = null;
            }
        }
    }
}
