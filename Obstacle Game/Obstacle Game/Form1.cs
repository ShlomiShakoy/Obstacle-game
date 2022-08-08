using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obstacle_Game
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        public Form1()
        {
            InitializeComponent();
            gameReset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)//if the space keyboard is pressed 
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if(e.KeyCode==Keys.R &&isGameOver==true)
            {
                gameReset();
            }
        }
        private void gameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score " + score;
            Shlomi.Image = Properties.Resources.shlomi;
            isGameOver = false;
            Shlomi.Top = 367;
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")//if the object is photo and also obstacle.
                                                                   //the Control is connected to Form and it displays information of the user
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }
            gameTimer.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void shlomi2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void Amit_Click(object sender, EventArgs e)
        {

        }

        private void CSharp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Shlomi.Top += jumpSpeed;
            txtScore.Text = "Score: " + score;
            if(jumping == true && force<0)
            {
                jumping = false;
            }
            if(jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else 
            {
                jumpSpeed = 12;
            }
            if(Shlomi.Top>366&&jumping==false)
            {
                force = 12;
                Shlomi.Top = 367;
                jumpSpeed = 0;
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox &&(string)x.Tag=="obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if(x.Left<-100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if(Shlomi.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        Shlomi.Image = Properties.Resources.shlomi;//when shlomi is dead
                        txtScore.Text += "  press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }
            if(score>10)
            {
                obstacleSpeed = 15;
            }
        }
    }
}
