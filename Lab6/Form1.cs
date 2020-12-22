using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        int xMax = 10;
        int yMax = 10;
        public Form1()
        {
            InitializeComponent();
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            //draw x,y Axis
            var x1 = canvas.Width / 2;
            var y1 = canvas.Height / 2;


            var g = canvas.CreateGraphics();
            var blackPen = new Pen(Color.Black, 1f);
            g.DrawLine(blackPen, 0, y1, canvas.Width, y1);
            g.DrawLine(blackPen, x1, 0, x1, canvas.Height);

            //define and draw unitX, unitmark

            int unitDividend = 10;
            int count = 0;
            int heightOfMark = 10;
 
            float addX = ((float)x1 / (float)xMax) * 0.9f;
            float addY = ((float)y1 / (float)yMax) * 0.9f;

            // marks on x
            for (float x = x1; x <= canvas.Width; x += addX) //x: relative value without U
            {
                if (x != x1)
                {
                    if (count % 10 == 0)
                    {
                        g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark); // 1u, 2u, 3u  

                        //label
                        string text = (count).ToString();
                        if (text != "0")
                        {
                            Label l = new Label();
                            l.Text = text;
                            l.AutoSize = true;
                            l.Location = new Point((int)(x - l.Width / 11), (int)(y1 + l.Height / 5));
                            l.Parent = canvas;
                        }
                    }
                    else if (count % 5 == 0) g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark * 2 / 3);
                    else if (xMax < 60) g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark / 3);
                }
                count++;
            }
            count = 0;
            for (float x = x1; x >= 0; x -= addX)
            {
                if (x != 0)
                {
                    if (count % 10 == 0)
                    {
                        g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark); // 1u, 2u, 3u  

                        //label
                        string text = (count).ToString();
                        if (text != "0")
                        {
                            Label l = new Label();
                            l.Text = text;
                            l.AutoSize = true;
                            l.Location = new Point((int)(x - l.Width / 11), (int)(y1 + l.Height / 5));
                            l.Parent = canvas;
                        }
                    }
                    else if (count % 5 == 0) g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark * 2 / 3);
                    else if (xMax < 60) g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark / 3);
                }
                count++;
            }

            //define and draw unitY, unitmarks
            count = 0;
            for (float y = y1; y <= canvas.Height; y += addY)
            {
                if (y != y1)
                {
                    if (count % 10 == 0)
                    {
                        g.DrawLine(blackPen, x1, y, x1 + heightOfMark, y); // 1u, 2u, 3u  

                        //label
                        string text = (count).ToString();
                        if (text != "0")
                        {
                            Label l = new Label();
                            l.Text = text;
                            l.AutoSize = true;
                            l.Location = new Point((int)(x1 - l.Width / 3), (int)(y - l.Height / 5));
                            l.Parent = canvas;
                        }
                    }
                    else if (count % 5 == 0) g.DrawLine(blackPen, x1, y, x1 + heightOfMark * 2 / 3, y);
                    else if (xMax < 60) g.DrawLine(blackPen, x1, y, x1 + heightOfMark / 3, y);
                }
                count++;
            }
            count = 0;
            for (float y = y1; y >= 0; y -= addY)
            {
                if (y != y1)
                {
                    if (count % 10 == 0)
                    {
                        g.DrawLine(blackPen, x1, y, x1 + heightOfMark, y); // 1u, 2u, 3u  

                        //label
                        string text = (count).ToString();
                        if (text != "0")
                        {
                            Label l = new Label();
                            l.Text = text;
                            l.AutoSize = true;
                            l.Location = new Point((int)(x1 - l.Width / 3), (int)(y - l.Height / 5));
                            l.Parent = canvas;
                        }
                    }
                    else if (count % 5 == 0) g.DrawLine(blackPen, x1, y, x1 + heightOfMark * 2 / 3, y);
                    else if (xMax < 60) g.DrawLine(blackPen, x1, y, x1 + heightOfMark / 3, y);
                }
                count++;
            }
        }
        
        private void x_Change(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                xMax++;
                yMax++;
            }
            else
            {
                yMax--;
                xMax--;
            }
            var label = this.canvas.Controls.OfType<Label>();
            foreach(Label l in label)
            {
                this.canvas.Controls.Remove(l);
                //l.Dispose();
            }
            canvas.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tb2_a.Text);
            int b = int.Parse(tb2_b.Text);
            int c = int.Parse(tb2_c.Text);
            float delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                xMax = 20;
            }
            else if(delta == 0)
            {
                xMax = (-(b)) / (2 * a);
            }
            else
            {
                var x1 = ((-(b)) - Math.Sqrt(delta)) / (2 * a);
                var x2 = ((-(b)) + Math.Sqrt(delta)) / (2 * a);
                if (x1 > x2)
                {
                    xMax = (int)x1;
                }
                else xMax = (int)x2;
            }
            var label = this.canvas.Controls.OfType<Label>();
            foreach (Label l in label)
            {
                this.canvas.Controls.Remove(l);
                //l.Dispose();
            }
            canvas.Refresh();
        }
    }
}
