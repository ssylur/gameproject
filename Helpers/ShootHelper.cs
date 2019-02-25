using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameProject
{
    class ShootHelper
    {
        public string direction;
        public int speed = 20;
        Timer tm = new Timer();
        PictureBox Bullet = new PictureBox();

        public int bulletLeft;
        public int bulletTop;

        public void fire(Form form)
        {
            Bullet.BackColor = System.Drawing.Color.Gold;
            Bullet.Size = new Size(5, 5);
            Bullet.Tag = "shoot";
            Bullet.Left = bulletLeft;
            Bullet.Top = bulletTop;
            Bullet.BringToFront();
            form.Controls.Add(Bullet);

            tm.Interval = speed;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
          
        }

        public void tm_Tick(object Sender, EventArgs e)
        {
            if(direction == "left")
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

            if(Bullet.Left < 16 || Bullet.Left > 900 || Bullet.Top < 10 || Bullet.Top > 660)
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
