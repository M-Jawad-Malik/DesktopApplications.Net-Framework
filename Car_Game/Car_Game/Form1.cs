using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Car.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            
            
        }
        Random R = new Random();
        int a;
        void enemy(int speed)
        {
            if (enm1.Top >= 500)
            {
                a = R.Next(250, 320);
                enm1.Location = new Point(a, 0);
            }
            else
            {
                enm1.Top += speed;
            }
            if (enm2.Top >= 500)
            {
                a = R.Next(0, 200);
                enm2.Location = new Point(a, 0);
            }
            else
            {
                enm2.Top += speed;
            }
            if (enm3.Top >= 500)
            {
                a = R.Next(100, 300);
                enm3.Location = new Point(a, 0);
            }
            else
            {
                enm3.Top += speed;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        void line_speed(int speed)
        {
            if(line1.Top>=500)
            {
                line1.Top = 0;
            }
            else
            {
                line1.Top += speed;
            }
            if (line2.Top >= 500)
            {
                line2.Top = 0;
            }
            else
            {
                line2.Top += speed;
            }
            
            if (line3.Top >= 500)
            {
                line3.Top = 0;
            }
            else
            {
                line3.Top += speed;
            }
            if (line4.Top >= 500)
            {
                line4.Top = 0;
            }
            else
            {
                line4.Top += speed;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            line_speed(speed);
            enemy(speed);
        }
        int speed = 5;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                if(Car.Left>0)
                {
                    Car.Left += -speed;
                }
            }
            if(e.KeyCode==Keys.Right)
            {
                if(Car.Left<=320)
                {
                    Car.Left += speed; 
                }
            }
            if(e.KeyCode==Keys.Up)
            {
                if (speed < 18)
                {
                    speed++;
                }
                if (Car.Top <400&&Car.Top>0)
                {
                  
                    Car.Top -= speed;
                }
            }
            if(e.KeyCode==Keys.Down)
            {
                if (speed > 5)
                {
                    speed--;
                }
                if (Car.Top < 400 && Car.Top > 0)
                {

                    Car.Top += speed;
                }
            }
            
            
        }

        private void enm2_Click(object sender, EventArgs e)
        {

        }
    }
}
