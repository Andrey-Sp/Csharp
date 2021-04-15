using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point tmp_location;
        Size tmp_size;
        int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK button has been pressed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > button1.Location.X - button1.Size.Width / 2 && e.X < button1.Location.X + button1.Size.Width / 2 && e.Y > button1.Location.Y - button1.Size.Height / 2 && e.Y < button1.Location.Y + button1.Size.Height / 2)
            {
                tmp_location = button1.Location;
                tmp_location.X += 10;
                tmp_location.Y += 10;
                button1.Location = new Point(tmp_location.X, tmp_location.Y);
                tmp_size = button1.Size;
                tmp_size.Width -= 1;
                tmp_size.Height -= 1;
                button1.Size = new Size(tmp_size.Width, tmp_size.Height);
            }
            if (e.X > button1.Location.X + button1.Size.Width / 2 && e.X < button1.Location.X + button1.Size.Width * 1.5 && e.Y > button1.Location.Y - button1.Size.Height / 2 && e.Y < button1.Location.Y + button1.Size.Height / 2)
            {
                tmp_location = button1.Location;
                tmp_location.X -= 10;
                tmp_location.Y += 10;
                button1.Location = new Point(tmp_location.X, tmp_location.Y);
                tmp_size = button1.Size;
                tmp_size.Width -= 1;
                tmp_size.Height -= 1;
                button1.Size = new Size(tmp_size.Width, tmp_size.Height);
            }
            if (e.X > button1.Location.X - button1.Size.Width / 2 && e.X < button1.Location.X + button1.Size.Width / 2 && e.Y > button1.Location.Y + button1.Size.Height / 2 && e.Y < button1.Location.Y + button1.Size.Height * 1.5)
            {
                tmp_location = button1.Location;
                tmp_location.X += 10;
                tmp_location.Y -= 10;
                button1.Location = new Point(tmp_location.X, tmp_location.Y);
                tmp_size = button1.Size;
                tmp_size.Width -= 1;
                tmp_size.Height -= 1;
                button1.Size = new Size(tmp_size.Width, tmp_size.Height);
            }
            if (e.X > button1.Location.X + button1.Size.Width / 2 && e.X < button1.Location.X + button1.Size.Width * 1.5 && e.Y > button1.Location.Y + button1.Size.Height / 2 && e.Y < button1.Location.Y + button1.Size.Height * 1.5)
            {
                tmp_location = button1.Location;
                tmp_location.X -= 10;
                tmp_location.Y -= 10;
                button1.Location = new Point(tmp_location.X, tmp_location.Y);
                tmp_size = button1.Size;
                tmp_size.Width -= 1;
                tmp_size.Height -= 1;
                button1.Size = new Size(tmp_size.Width, tmp_size.Height);
            }
            if (tmp_size.Height == 0 && tmp_size.Width == 0)
            {
                timer3.Start();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Press 'OK'!!!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Press 'OK'!!!";
            counter++;
            timer2.Start();
            if (counter == 8)
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = " ";
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Text = "'OK' cannot be pressed!!!";
            timer2.Start();
        }
    }
}
