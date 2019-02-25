//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GameProject
//{
//    class Fight
//    {
//        private void spawnAmmo()
//        {
//            PictureBox ammo = new PictureBox();
//            ammo.Image = Properties.Resources.shells;
//            ammo.SizeMode = PictureBoxSizeMode.Zoom;
//            ammo.Width = 45;
//            ammo.Height = 45;
//            ammo.Left = rnd.Next(10, ScreenWidth - 45);
//            ammo.Top = rnd.Next(60, ScreenHeight - 45);
//            ammo.Tag = "ammo";
//            this.Controls.Add(ammo);
//            ammo.BringToFront(); //zindex problem
//            player.BringToFront();
//        }

//        private void shoot(string direction)
//        {
//            ShootHelper shoot = new ShootHelper();
//            shoot.direction = direction;
//            shoot.bulletLeft = player.Left + (player.Width / 2);
//            shoot.bulletTop = player.Top + (player.Height / 2);
//            shoot.fire(this);
//        }

//        private void spawnZombies()
//        {
//            PictureBox zombie = new PictureBox();
//            zombie.Tag = "zombie";
//            zombie.BackgroundImage = Properties.Resources.zombie_bottom;
//            zombie.BackgroundImageLayout = ImageLayout.Zoom;

//            zombie.Left = rnd.Next(0, ScreenWidth);
//            zombie.Top = rnd.Next(0, ScreenHeight);
//            zombie.Width = 30;
//            zombie.Height = 59;
//            zombie.BackColor = Color.Transparent;
//            zombie.SizeMode = PictureBoxSizeMode.Normal;
//            this.Controls.Add(zombie);
//            player.BringToFront();
//        }
//    }
//}
