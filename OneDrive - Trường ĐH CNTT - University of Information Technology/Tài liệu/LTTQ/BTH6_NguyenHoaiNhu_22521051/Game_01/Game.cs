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
            this.DoubleBuffered = true; //tạo bản sao đệm của game -> giảm số lần update screen -> cải thiện hiệu suất đồ họa
            start();
        }

        void start()
        {
            listBall = new List<Ball>(); //danh sách lưu trữ ball
            basket = new Basket(ClientSize.Width, ClientSize.Height); //tạo basket với khu vực chỉ định
            dropSpeed = 4; //tốc độ rơi
            moveSpeed = 5; //tốc độ di chuyển của Basket
            score = 0;
            chance = 2;
            timeradd.Interval = 3000; //time thêm bóng mới

            isMovingLeft = false;
            isMovingRight = false;

            timeradd.Start();
            timergame.Start();

            //random bóng từ resources vs tọa độ ngẫu nhiên

            int x = random.Next(1, ClientSize.Width - 39);

            int y = random.Next(0,3);

            //thêm bóng mới vào list
            listBall.Add( new Ball(x,y));

        }

        private void Game1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Object item in listBall)
            {
                item.DrawObject(g);
            }

            basket.DrawObject(g);

            Font drawFont = new Font("SVN-Cookies", 16); //Đổi kiểu chữ và font 
            SolidBrush drawBrush = new SolidBrush(Color.DarkBlue); //Chỉnh màu chữ

            e.Graphics.DrawString("Score: " + score.ToString() + "\nChance left: " + chance.ToString(), drawFont, drawBrush, 10, 10); 

        }

        //xử lí khi chơi
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
                if (item.IntersertCheck(basket)) //nếu ball chạm basket
                {
                    ballsToRemove.Add(item);
                    score++;
                    success.Play();
                }
                else if (item.IsOut(ClientSize.Height) && !item.checkWasOut()) //nếu rơi khỏi screen
                {
                    item.setWasOut(); //đánh dấu đã rơi
                    ballsToRemove.Add(item);
                    chance--;
                    missed.Play();

                    //nếu rơi quá 2 lần
                    if (chance < 0)
                    {
                        //dừng game
                        timergame.Stop();
                        timeradd.Stop();

                        //xuất thông báo
                        DialogResult result = MessageBox.Show($"Your score:  {score}. Play again?", "Game over!", MessageBoxButtons.YesNo);
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

            //xóa ball tạo, tạo cửa sổ mới
            foreach (Ball ball in ballsToRemove)
            {
                listBall.Remove(ball);

            }
            this.Refresh();
        }

        //Ham dieu khien basket
        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                isMovingLeft = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                isMovingRight = true;
            }
        }


        private void Game1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                isMovingLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                isMovingRight = false;
            }


        }

        //thêm bóng mới trong khoảng thời gian đều đặn
        private void timeradd_Tick(object sender, EventArgs e)
        {
            //điểm rơi ngẫu nhiên
            int x = random.Next(1, ClientSize.Width - 39);

            //random hình trong resources
            int y = random.Next(0,3);

            listBall.Add(new Ball(x, y));

            //chỉnh tốc độ rơi
            if (dropSpeed < 10)
                dropSpeed += 0.1;

            //chỉnh tốc độ tạo ball, tạo bóng nhanh hơn nếu khoảng thời gian giữa 2 lần tạo bóng > 500
            if (timeradd.Interval > 500)
                timeradd.Interval -= 25;

            //chỉnh tốc độ di chuyển 
            if (moveSpeed < 30)
                moveSpeed += 0.25;
        }
    }
}
