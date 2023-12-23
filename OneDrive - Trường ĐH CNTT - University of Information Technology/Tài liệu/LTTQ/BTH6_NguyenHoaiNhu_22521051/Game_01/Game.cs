using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Random;

namespace Game_01
{
    public partial class Game1 : Form
    {
        Basket basket;
        List<Ball> listBall;
        private bool isMovingLeft;
        private bool isMovingRight;
        double dropSpeed;
        double moveSpeed;
        int score;
        int chance;
        System.Media.SoundPlayer success = new System.Media.SoundPlayer(Properties.Resources.success);
        System.Media.SoundPlayer missed = new System.Media.SoundPlayer(Properties.Resources.missed);


        Random random = new Random();
        public Game1()

        {
            InitializeComponent();
            this.DoubleBuffered = true;
            start();
        }

        void start()
        {
            listBall = new List<Ball>();
            basket = new Basket(ClientSize.Width, ClientSize.Height);
            dropSpeed = 4;
            moveSpeed = 5; //tốc độ di chuyển của Basket
            score = 0;
            chance = 2;
            timeradd.Interval = 3000;

            isMovingLeft = false;
            isMovingRight = false;

            timeradd.Start();
            timergame.Start();

            Random random = new Random();
            int x = random.Next(0, ClientSize.Width - 39);

            listBall.Add(new Ball(x));
        }

        private void Game1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Object item in listBall)
            {
                item.DrawObject(g);
            }

            basket.DrawObject(g);

            Font drawFont = new Font("Arial", 16); //Đổi kiểu chữ và font 
            SolidBrush drawBrush = new SolidBrush(Color.BlueViolet); //Chỉnh màu chữ

            e.Graphics.DrawString("Score: " + score.ToString() + "\nChance left: " + chance.ToString(), drawFont, drawBrush, 10, 10); 

        }

        private void timergame_Tick(object sender, EventArgs e)
        {
            if (isMovingLeft)
            {
                basket.move(true, ClientSize.Width, moveSpeed);

            }
            else if (isMovingRight)
            {
                basket.move(false, ClientSize.Width, moveSpeed);
            }

            List<Ball> ballsToRemove = new List<Ball>();
            foreach (Ball item in listBall)
            {
                item.Drop(dropSpeed);
                if (item.IntersertCheck(basket))
                {
                    ballsToRemove.Add(item);
                    score++;
                    success.Play();
                }
                else if (item.IsOut(ClientSize.Height) && !item.checkWasOut())
                {
                    item.setWasOut();
                    ballsToRemove.Add(item);
                    chance--;
                    missed.Play();
                    if (chance < 0)
                    {
                        timergame.Stop();
                        timeradd.Stop();

                        DialogResult result = MessageBox.Show($"Your score:  {score}.Play again?", "Game over!", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            start();
                        }
                        if (result == DialogResult.No)
                        {
                            this.Hide();
                            Start start = new Start();
                            start.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }

            foreach (Ball ball in ballsToRemove)
            {
                listBall.Remove(ball);

            }
            this.Refresh();
        }

        //Ham dieu khien basket
        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isMovingLeft = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                isMovingRight = true;
            }
        }


        private void Game1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isMovingLeft = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                isMovingRight = false;
            }


        }

        private void timeradd_Tick(object sender, EventArgs e)
        {
            int x = random.Next(0, ClientSize.Width - 39);
            listBall.Add(new Ball(x));

            if (dropSpeed < 10)
                dropSpeed += 0.1;

            if (timeradd.Interval > 500)
                timeradd.Interval -= 25;

            if (moveSpeed < 30)
                moveSpeed += 0.25;
        }
    }
}
