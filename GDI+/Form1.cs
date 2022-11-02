using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        //protected override void OnPaint(PaintEventArgs e)
        //{ 
        //    base.OnPaint(e);
        //    this.Show();
        //    Graphics g = this.CreateGraphics();
        //    SolidBrush redBrush = new SolidBrush(Color.Red);
        //    Rectangle rect = new Rectangle(0, 0, 250, 140);
        //    g.FillRectangle(redBrush, rect);
        //}
        List<Point> points = new List<Point>();
        List<Rectangle> doska = new List<Rectangle>();
        public Form1()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle= FormBorderStyle.FixedSingle;
            this.Paint+=Form1_Paint;
            //this.Paint += Form1_Paint;
        }

        public enum FontStyle
        {
            Bold,Italic,Regular,Srtikeout,Underline
        }
        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int x = 0; x <= 1920; x += 240)
            {
                for (int y = 0; y <= 1080; y += 135)
                {
                    doska.Add(new Rectangle(x, y, 240, 135));
                }
            }
            for (int i = 0; i < doska.Count; i++)
            {
                if (i%2==0)
                {
                    g.FillRectangle(Brushes.White, doska[i]);
                }
                else
                {
                    g.FillRectangle(Brushes.Black, doska[i]);
                }
            }
            //Rectangle peshka = new Rectangle(x, y, 240, 135);

            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Black, p.X, p.Y, 10F, 10F);

            }
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //Pen bluePen=new Pen(Color.Blue,6);
            //bluePen.StartCap=LineCap.SquareAnchor;
            //bluePen.EndCap = LineCap.ArrowAnchor;
            //bluePen.DashStyle = DashStyle.Dash;
            //bluePen.DashCap = DashCap.Round;
            //g.DrawLine(bluePen, 20, 100, 270, 100);
            //bluePen.Dispose();

            //int x = 20;
            //int y = 30;
            //int height = 60;
            //int width = 60;

            //Point pt = new Point(10, 10);

            //Size sz = new Size(160, 140);

            //Rectangle rest1 = new Rectangle(pt, sz);
            //Rectangle rest2 = new Rectangle(x,y,width,height);

            //g.FillRectangle(Brushes.Black, rest1);
            //g.DrawRectangle(new Pen(Brushes.Red,2), rest2);

            //int x = 30;
            //int y = 30;
            //int height = 60;
            //int width = 60;

            //Point pt = new Point(0, 0);

            //Size sz = new Size(1920, 1080);

            //Rectangle rest1 = new Rectangle(pt, sz);
            //Rectangle rest2 = new Rectangle(x, y, width, height);

            //g.FillRectangle(Brushes.Black, rest1);
            //g.DrawRectangle(new Pen(Brushes.Red, 2), rest2);


            //g.TranslateTransform(10, 50);
            //Point A = new Point(0, 0);
            //Point B = new Point(1500, 100);
            //g.DrawLine(new Pen(Brushes.Blue, 3), A, B);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100);
            g.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(100, 100, 60, 60));
            g.DrawPie(new Pen(Color.Indigo, 3), 150, 10, 150, 150, 90, 180);
            g.DrawString("Hello GDI+!", new Font("Verdana", 12, System.Drawing.FontStyle.Bold), Brushes.Black, 0, 240);
            PointF[] pArray = { new PointF(10.0F, 50.0F), new PointF(200.0F, 200.0F), new PointF(90.0F, 20.0F), new PointF(140.0F, 50.0F), new PointF(40.0F, 150.0F) };
            g.DrawPolygon(new Pen(Color.GreenYellow, 2), pArray);
            g.DrawEllipse(new Pen(Color.Green, 4), 100, 230, 30, 30);
            g.Dispose();

            //Point[] Points ={new Point(5,10), new Point(23, 130), new Point(130, 57) };
            //GraphicsPath path=new GraphicsPath();
            //path.AddEllipse(170, 170, 100, 50);
            //g.FillPath(Brushes.Aqua,path);
            //path.StartFigure();
            //path.AddCurve(Points,0.5f);
            //path.AddArc(100,50,100, 100, 0,120);
            //path.AddLine(50,150,50,200);
            //path.CloseFigure();
            //path.StartFigure();
            //path.AddArc(180, 30, 60, 60, 0, -170);
            //g.DrawPath(new Pen(Color.Blue,3),path);

            //Font f = new Font("DynarShadow",14,System.Drawing.FontStyle.Bold| System.Drawing.FontStyle.Underline);
            //g.DrawString("Hello Font!", f, Brushes.Black, 30, 55);

            //Pen pn = new Pen(Brushes.Orange, 40);
            //pn.DashStyle=System.Drawing.Drawing2D.DashStyle.Solid;
            //g.DrawEllipse(pn,50,100,170,40);
            //g.Dispose();

            //Rectangle rect = new Rectangle(20, 20, 200, 40);
            //LinearGradientBrush lgBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, 0.0f, true);
            //g.FillRectangle(lgBrush, rect);
            //Rectangle rect2 = new Rectangle(20, 80, 200, 40);
            //HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, Color.Blue);
            //g.FillRectangle(hatchBrush, rect2);
            //TextureBrush txBrush = new TextureBrush(new Bitmap("Cplus.bmp"));
            //Rectangle rect3 = new Rectangle(20, 140, 200, 40);
            //g.FillRectangle(txBrush, rect3);


            //g.Dispose();
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    points.Add(new Point(e.X, e.Y));
        //    Invalidate();
        //}
    }
}
