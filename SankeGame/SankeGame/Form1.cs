using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SankeGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public int score;
        public int SnakeSpeed = 10;
        public bool Goleft, Goright, Godown, Goup;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Score_Text.Text = "Score: " + score;
            if (Godown == true)
            {
                Head.Top += SnakeSpeed;
                Body.Left = Head.Left;
                Body.Top = (Head.Top - 20);

            }
            if (Goup == true)
            {
                Head.Top -= SnakeSpeed;
                Body.Left = Head.Left;
                Body.Top = (Head.Top + 20);



            }
            if (Goleft == true)
            {
                Head.Left -= SnakeSpeed;
                Body.Top = Head.Top;
                Body.Left = (Head.Left + 20);
                
            }
            if (Goright == true)
            {
                Head.Left += SnakeSpeed;
                Body.Top = Head.Top;
                Body.Left = (Head.Left - 20);
                if (score >= 1)
                {
                    Body.Width = Body.Height;
                    

                }

            }
            if (apple.Bounds.IntersectsWith(Head.Bounds))
            {
                apple.Left = random.Next(10, 700);
                apple.Top = random.Next(700);
                Body.Height += 20;
                ++score;
            }


        }



        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Goup = true;
                Goright = false;
                Goleft = false;
                Godown = false;
            }
            if (e.KeyCode == Keys.S)
            {
                Goup = false;
                Goright = false;
                Goleft = false;
                Godown = true;
            }
            if (e.KeyCode == Keys.A)
            {
                Goup = false;
                Goright = false;
                Goleft = true;
                Godown = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Goup = false;
                Goright = true;
                Goleft = false;
                Godown = false;
            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {

        }
    }
}
