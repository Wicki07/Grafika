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
        float xMax = 10;
        float yMax = 10;
        List<PointF> points = new List<PointF>();
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var x1 = canvas.Width / 2;
            var y1 = canvas.Height / 2;
            g = canvas.CreateGraphics();
            var blackPen = new Pen(Color.Black, 1f);
            g.DrawLine(blackPen, 0, y1, canvas.Width, y1);
            g.DrawLine(blackPen, x1, 0, x1, canvas.Height);
            int count = 0;
            int heightOfMark = 10;
            float addX = ((float)x1 / (float)xMax) * 0.9f;
            float addY = ((float)y1 / (float)yMax) * 0.9f;

            // Rysowanie osi współrzędnych
            for (float x = x1; x <= canvas.Width; x += addX) 
            {
                if (x != x1)
                {
                    if (count % 10 == 0)
                    {
                        g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark); 

                        string text = (count).ToString();
                        if (text != "0") // Doanie kiresek na osiach
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
                        g.DrawLine(blackPen, x, y1, x, y1 - heightOfMark);

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
            for (float y = y1; y <= canvas.Height; y += addY)
            {
                if (y != y1)
                {
                    if (count % 10 == 0)
                    {
                        g.DrawLine(blackPen, x1, y, x1 + heightOfMark, y);

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
                        g.DrawLine(blackPen, x1, y, x1 + heightOfMark, y); 
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
        // zmiany warotści maksymalnych zakresów w zależności od skrolowania
        private void x_Change(object sender, MouseEventArgs e)
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
            canvas.Controls.Clear();
            canvas.Refresh();
            foreach(var point in points)
            {
                DrawPoint(point.X, point.Y);
            }
        }
        //Główna metoda rysowania fukcji
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tb2_a.Text);
            int b = int.Parse(tb2_b.Text);
            int c = int.Parse(tb2_c.Text);
            float delta = CountingXmax(a, b, c); ;
            
            CountingYmax(delta, a);
            canvas.Controls.Clear();
            canvas.Refresh();

            DrawQuadraticEquation(a, b, c);


        }
        //wyliczanie maksywalnej wartosic X
        private float CountingXmax(int a, int b, int c)
        {
            float delta = b * b - 4 * a * c;
            float x1, x2;

            if (delta < 0)
            {
                xMax = 20;
            }
            else if (delta == 0)
            {
                xMax = (-(b)) / (2 * a);
            }
            else
            {
                x1 = (float)(((-(b)) - Math.Sqrt(delta)) / (2 * a));
                x2 = (float)(((-(b)) + Math.Sqrt(delta)) / (2 * a));
                if (x1 > x2)
                {
                    xMax = x1;
                }
                else xMax = x2;
            }

            return delta;
        }
        //wylicznie maksywalnej wartosci Y
        private void CountingYmax(float delta, int a)
        {
            yMax = (-(delta) / 4 * a);
            if(yMax <= 5)
            {
                yMax = 5;
            }
        }
        // Wylicznie współrzędnych fukcji
        private void DrawQuadraticEquation(float a, float b, float c, float step = 0.005f)
        {
            float x, y, maxX; 
            maxX = (canvas.Width - (canvas.Width / 2)) / xMax;
            for (x = (0 - (canvas.Width / 2)) / xMax; x <= maxX; x += step)
            {
                y = a * x * x + b * x + c;
                points.Add(new PointF(x, y));
                DrawPoint(x, y);
            }
        }
        //rysowanie punktów funkcji
        private void DrawPoint(float x, float y, Color? color = null, float height = 0.05f, float width = 0.05f)
        {
            Pen pen = new Pen(color ?? Color.Red, height);
            PointF p_Abs = new PointF((canvas.Width / 2) + x * xMax, (canvas.Height / 2) - y * yMax);
            PointF _p_Abs = new PointF(p_Abs.X + width, p_Abs.Y);
            g.DrawLine(pen, p_Abs, _p_Abs);
        }
    }
}
