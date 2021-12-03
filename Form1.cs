using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm_samples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                x += 5;
            }

            if (e.KeyCode == Keys.Left)
            {
                x -= 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                y -= 5;
            }

            if (e.KeyCode == Keys.Down)
            {
                y += 5;
            }

            if (pictureBox1.Right >= label4.Left)
            {
                label4.BackColor = Color.Red;
            }

            if (pictureBox1.Left <= label2.Right)
            {
                label2.BackColor = Color.Blue;
            }

            if (pictureBox1.Bottom >= label3.Top)
            {
                label3.BackColor = Color.Yellow;
            }

            if (pictureBox1.Top <= label1.Bottom)
            {
                label1.BackColor = Color.Green;
            }

            pictureBox1.Location = new Point(x, y);

        }

        
    }
}
