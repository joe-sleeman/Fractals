using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    public class Dragon
    {
        Random r;
        public Dragon()
        {
            r = new Random();
        }
        public void DrawDragon(Graphics g, int depth, PointF origin, PointF destination)
        {
            Pen pen = new Pen(Utilities.GenerateBrushColour(r));
            pen.Width = 4;
            // Base case we will just draw a line.
            if (depth == Constants.BASE_CASE)
                g.DrawLine(pen, origin, destination);
            else
            {
                PointF midPoint = Utilities.FindRightAnglePoint(origin, destination);

                // Recursively draw from origin -> mid point
                DrawDragon(g, depth - 1, origin, midPoint);
                // Now draw from destination -> mid point
                // so that the pattern draws in the form of
                // a dragon.
                DrawDragon(g, depth - 1, destination, midPoint);
            }
        }
    }
}
