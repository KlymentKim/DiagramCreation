using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagrams
{
    public partial class Form1 : Form
    {
        //Color CurrentColor = Color.Black;
        Point pointStat;
        Point pointEnd;
        List<int> listP = new List<int>();
        Graphics g;
        Bitmap bmp;
       
       
        public Form1()
        {
            InitializeComponent();

        }
        private void LoadBackGroundImage()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Image im = Image.FromFile("background.png");
            bmp = new Bitmap(im, pictureBox1.Size.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBackGroundImage();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           
            ToolStripButton stButton = toolStrip1.Items.OfType<ToolStripButton>().FirstOrDefault(t => t.Checked);
            if (stButton != null)
            {
                // rectangle config vars
                int minX = pointStat.X < e.X ? pointStat.X : e.X;
                int minY = pointStat.Y < e.Y ? pointStat.Y : e.Y;
                int width = Math.Abs(pointStat.X - e.X);
                int height = Math.Abs(pointStat.Y - e.Y);

                if (stButton.Text == "Rect")
                {
                    Pen stRectangle = new Pen(Color.Red, 2);
                    g.DrawRectangle(stRectangle, new Rectangle(new Point(minX, minY), new Size(width, height)));
                }
                else if (stButton.Text == "Ellips")
                {
                    Pen stEllips = new Pen(Color.Magenta, 2);
                    g.DrawEllipse(stEllips, new Rectangle(new Point(minX, minY), new Size(width, height)));
                }
                else if (stButton.Text == "Line")
                {
                    Pen stLine = new Pen(Color.Brown, 2);
                    g.DrawLine(stLine, pointStat, e.Location);
                }
                pictureBox1.Image = bmp;
            }
           
        }

      
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ToolStripButton stButton = toolStrip1.Items.OfType<ToolStripButton>().FirstOrDefault(t => t.Checked);
           
            if (stButton != null)
            {
                //Pen
                if (stButton.Text == "FigLine")
                {
                    SolidBrush s = new SolidBrush(Color.Black);
                    g.FillEllipse(Brushes.Black, e.X, e.Y,4, 4);
                   
                }
            }
            
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            pointStat = e.Location;
        }

        private void toolStripButton_Rect_Click(object sender, EventArgs e)
        {
            if (toolStripButton_Rect.Checked)
            {
                toolStripButton_Rect.Checked = true;
                toolStripButton_Line.Checked = false;
                toolStripButton_Ellips.Checked = false;
                toolStripButton_Figure.Checked = false;

            }
        }

        private void toolStripButton_Line_Click(object sender, EventArgs e)
        {
            if (toolStripButton_Line.Checked)
            {
                toolStripButton_Rect.Checked = false;
                toolStripButton_Line.Checked = true;
                toolStripButton_Ellips.Checked = false;
                toolStripButton_Figure.Checked = false;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton_Ellips.Checked)
            {
                toolStripButton_Rect.Checked = false;
                toolStripButton_Line.Checked = false;
                toolStripButton_Ellips.Checked = true;
                toolStripButton_Figure.Checked = false;
            }
        }

      
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void toolStripButton_Figure_Click(object sender, EventArgs e)
        {
            if (toolStripButton_Figure.Checked)
            {
                toolStripButton_Figure.Checked = true;
                toolStripButton_Rect.Checked = false;
                toolStripButton_Line.Checked = false;
                toolStripButton_Ellips.Checked = false;
               
            }
        }
       
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            g.Clear(Color.Teal);
            pictureBox1.Image = bmp;
            LoadBackGroundImage();
            pictureBox1.Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog()==DialogResult.OK)
            {
                toolStripButton_Color.BackColor = color.Color;

            }
        }
    }
}
