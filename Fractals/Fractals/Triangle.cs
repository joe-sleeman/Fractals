using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    public class Triangle
    {
        Random r;        
        public Triangle()
        {
            r = new Random();
        }
        // Can just pass in Points rather than PointF seeing as there is no such thing
        // as .5 of a pixel. 
        public void DrawTriangle(Graphics g, int depth, PointF top, PointF left, PointF right)
        {
            // Base case, when depth is 0.
            if (depth == Constants.BASE_CASE)
            {
                PointF[] points = { top, right, left };
                Brush br = Utilities.GenerateBrushColour(r);
                g.FillPolygon(br, points);
            }
            else
            {
                // Find our mid point of each side of triangle.
                // Left, Right & Bottom sides.
                PointF midL = Utilities.CalculateMidPoint(top, left);
                PointF midR = Utilities.CalculateMidPoint(top, right);
                PointF midB = Utilities.CalculateMidPoint(left, right);

                // Recursively draw smaller triangles.
                DrawTriangle(g, depth - 1, top, midL, midR);
                DrawTriangle(g, depth - 1, midL, left, midB);
                DrawTriangle(g, depth - 1, midR, midB, right);
            }
        }
    }
}
