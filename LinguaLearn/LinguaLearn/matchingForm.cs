using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguaLearn
{
    public partial class matchingForm : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        private List<(Point, Point)> lines = new List<(Point, Point)>();

        public matchingForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;


            label1.Location = new Point(70, 35);

            label2.Location = new Point(200, 35); 
        }

        private void matching_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void matching_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                this.Invalidate();
            }
        }

        private void matching_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                lines.Add((startPoint, endPoint));
                isDrawing = false;


                if (label1.Bounds.Contains(startPoint) && label2.Bounds.Contains(endPoint))
                {
                    MessageBox.Show("You connected label1 and label2!");
                    label3.Text = " nice";
                }

            }

            
        }

        private void matching_Paint(object sender, PaintEventArgs e)
        {
            foreach (var line in lines)
            {
                e.Graphics.DrawLine(Pens.Black, line.Item1, line.Item2);
            }

            if (isDrawing)
            {
                e.Graphics.DrawLine(Pens.Black, startPoint, endPoint);
            }
        }

        private void matchingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}