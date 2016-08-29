using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            int depth = getDepth();
            if (depth <= Constants.MAX_TRIANGLE_DEPTH)
            {
                g.Clear(SystemColors.Control);
                Triangle t = new Triangle();
                PointF left = new PointF(50, 800);
                PointF right = new PointF(850, 800);
                PointF top = new PointF(450, 50);
                t.DrawTriangle(g, depth, top, left, right);
            }
            else
                MessageBox.Show("Maximum depth for this fractal is " +
                    Constants.MAX_TRIANGLE_DEPTH);
        }



        private void btnTree_Click(object sender, EventArgs e)
        {
            int depth = getDepth();
            if (depth <= Constants.MAX_TREE_DEPTH)
            {
                g.Clear(SystemColors.Control);
                Tree t = new Tree();
                t.DrawTree(g, depth, 450, 800, -90);
            }
            else
                MessageBox.Show("Maximum depth for this fractal is " +
                    Constants.MAX_TREE_DEPTH);


        }

        private void btnSnowflake_Click(object sender, EventArgs e)
        {
            int depth = getDepth();
            if (depth <= Constants.MAX_SNOWFLAKE_DEPTH)
            {
                g.Clear(SystemColors.Control);
                Snowflake s = new Snowflake();
                PointF left = new PointF(50, 600);
                PointF right = new PointF(850, 600);
                PointF top = new PointF(450, 50);
                s.DrawSnowflake(g, depth, top, left, right);
            }
            else
                MessageBox.Show("Maximum depth for this fractal is " +
                    Constants.MAX_SNOWFLAKE_DEPTH);
        }

        private void btnDragon_Click(object sender, EventArgs e)
        {
            int depth = getDepth();
            if (depth <= Constants.MAX_DRAGON_DEPTH)
            {
                g.Clear(SystemColors.Control);
                Dragon d = new Dragon();
                PointF left = new PointF(200, 300);
                PointF right = new PointF(800, 300);
                d.DrawDragon(g, depth, left, right);
            }
            else
                MessageBox.Show("Maximum depth for this fractal is " +
                    Constants.MAX_DRAGON_DEPTH);
        }

        private void btnCircles_Click(object sender, EventArgs e)
        {
            int depth = getDepth();
            if (depth <= Constants.MAX_CIRCLE_DEPTH)
            {
                g.Clear(SystemColors.Control);
                Circle c = new Circle();
                PointF start = new PointF(200, 400);
                PointF end = new PointF(800, 400);
                c.DrawCircles(g, depth, start, end);
            }
            else
                MessageBox.Show("Maximum depth for circle fractal is " +
                    Constants.MAX_CIRCLE_DEPTH);
        }
        int getDepth()
        {
            return (int)nudDepth.Value;
        }
    }
}
