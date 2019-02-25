using GameProject.Classes.SpawnObjects;
using GameProject.Helpers;
using GameProject.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Form1 : Form
    {
        int ScreenWidth = Settings.SCREEN_WIDTH;
        int ScreenHeight = Settings.SCREEN_HEIGHT;
        bool goUp, goDown, goLeft, goRight;
        public string direction = Direction.UP;
        public PictureBox playerBox;
        double HP = 100;
        int speed = 10;
        int ammo = 5;
        int score = 0;
        bool gameOver = false;
        bool gameNotStarted = true;

        bool medkitOnMap = false;
        bool needtoKillzombie = false;

        Random rnd = new Random();
    
        public Form1()
        {
            InitializeComponent();
            playerBox = player;
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (gameNotStarted || gameOver) return;
            

            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
                direction = Direction.LEFT;
                player.BackgroundImage = Properties.Resources.player_left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                direction = Direction.RIGHT;
                player.BackgroundImage = Properties.Resources.player_right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                direction = Direction.UP;
                player.BackgroundImage = Properties.Resources.player_top;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                direction = Direction.DOWN;
                player.BackgroundImage = Properties.Resources.player_bottom;
            }

            player.BackColor = Color.Transparent;
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if(gameNotStarted && e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
                StartLabel.Visible = false;
                gameNotStarted = false;
                return;
            }

            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                new SpawnObjectsFactory().create(SpawnObject.SHOOT, this);

                if (ammo < 1)
                {
                    new SpawnObjectsFactory().create(SpawnObject.AMMO, this);
                }
            }
        }

        private void gameInterval(object sender, EventArgs e)
        {

            if(HP > 1)
            {
                progressBar.Value = Convert.ToInt32(HP);
            } else
            {
                player.BackgroundImage = Properties.Resources.ash;
                timer1.Stop();
                UserInterfaceHelper.showEndGame(StartLabel, score);
                gameOver = true;
            }

            UserInterfaceHelper.updateBullets(label2, ammo);
            UserInterfaceHelper.updateScore(scoreLabel, score);

            if(HP < 20)
            {
                progressBar.ForeColor = System.Drawing.Color.Red;
            }

            if(score%5 == 0 && !medkitOnMap && !needtoKillzombie)
            {
                new SpawnObjectsFactory().create(SpawnObject.HEAL, this);
                medkitOnMap = true;
            }

            if(goLeft && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight && player.Left + player.Width < ScreenWidth)
            {
                player.Left += speed;
            }

            if (goUp && player.Top > 60)
            {
                player.Top -= speed;
            }

            if (goDown && player.Top + player.Height < ScreenHeight - 80)
            {
                player.Top += speed;
            }


            foreach (Control c in this.Controls)
            {
                if (c is PictureBox) {
                    PictureBox loopedControlObject = (PictureBox)c;
                    #pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    if (c.Tag == SpawnObject.AMMO)
                    {
                        if (loopedControlObject.Bounds.IntersectsWith(player.Bounds))
                        {
                            this.Controls.Remove(loopedControlObject);
                            loopedControlObject.Dispose();
                            ammo += 5;
                        }
                    }

                    if (c.Tag == SpawnObject.SHOOT)
                    {
                        if (loopedControlObject.Left < 1 || loopedControlObject.Left > ScreenWidth || loopedControlObject.Top < 10 || loopedControlObject.Top > ScreenHeight)
                        {
                            this.Controls.Remove(loopedControlObject);
                            loopedControlObject.Dispose();
                        }
                    }

                    if (c.Tag == SpawnObject.ZOMBIE)
                    {
                        if (loopedControlObject.Bounds.IntersectsWith(player.Bounds))
                        {
                            HP -= 1;
                        }

                        int zombieSpeed = LevelMapper.adjust(score);

                        if (loopedControlObject.Left > player.Left)
                        {
                            loopedControlObject.Left -= zombieSpeed;
                            loopedControlObject.BackgroundImage = Properties.Resources.zombie_left;
                        }

                        if (loopedControlObject.Top > player.Top)
                        {
                            loopedControlObject.Top -= zombieSpeed;
                            loopedControlObject.BackgroundImage = Properties.Resources.zombie_top;
                        }

                        if (loopedControlObject.Left < player.Left)
                        {
                            loopedControlObject.Left += zombieSpeed;
                            loopedControlObject.BackgroundImage = Properties.Resources.zombie_right;
                        }

                        if (loopedControlObject.Top < player.Top)
                        {
                            loopedControlObject.Top += zombieSpeed;
                            loopedControlObject.BackgroundImage = Properties.Resources.zombie_bottom;
                        }

                        loopedControlObject.BackColor = Color.Transparent;
                    }

                    if (c.Tag == SpawnObject.HEAL)
                    {
                        if (loopedControlObject.Bounds.IntersectsWith(player.Bounds))
                        {
                            this.Controls.Remove(loopedControlObject);
                            loopedControlObject.Dispose();
                            HP += 20;
                            HP = (HP > 100) ? 100 : HP;
                            medkitOnMap = false;
                            needtoKillzombie = true;
                        }
                    }

                        foreach (Control c2 in this.Controls)
                    {
                        if ((c2 is PictureBox && c2.Tag == SpawnObject.SHOOT) && (c.Tag == SpawnObject.ZOMBIE))
                        {
                            if (c.Bounds.IntersectsWith(c2.Bounds))
                            {
                                score++;
                                this.Controls.Remove(c2);
                                c2.Dispose();
                                this.Controls.Remove(c);
                                c.Dispose();
                                new SpawnObjectsFactory().create(SpawnObject.ZOMBIE, this);
                                needtoKillzombie = false;
                            }
                        }
                    }

                }
            }
        }
    }
}
