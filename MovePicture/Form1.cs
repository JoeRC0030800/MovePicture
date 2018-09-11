using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovePicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
        }
        //moves diagonal downwards to the left
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 5);
        }
        //moves downwards diagonal to the right
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);

                
        }
        //moves upwards diagonal to the left
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
        }
        //moves diagonal upwards to the right
        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
