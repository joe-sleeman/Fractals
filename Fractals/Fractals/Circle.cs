using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    public class Circle
    {
        Random r;

        public Circle()
        {
            r = new Random();
        }

        // Having trouble with vertical circles - revisit if time..
        public void DrawCircles(Graphics g, int depth, PointF origin, PointF destination)
        {

            if (depth != Constants.BASE_CASE)
            {
                // Hacky way to find radius for X and Y. 
                double radiusX = (destination.X - origin.X) / 2;
                double radiusY = (destination.Y - origin.Y) / 2;
                PointF centerX = Utilities.CalculateMidPoint(origin, destination);

                // Find bottom & top of circle.
                PointF bottom = new PointF(centerX.X, centerX.Y - (float)radiusX);
                PointF top = new PointF(centerX.X, centerX.Y + (float)radiusX);

                // Find centerY, the mid point between top & bottom.
                PointF centerY = Utilities.CalculateMidPoint(bottom, top);

                // Draw our Y circles.
                DrawCircleFromMid(g, (int)centerY.X, (int)centerY.Y, (int)radiusY);
                // Draw our X circles.
                DrawCircleFromMid(g, (int)centerX.X, (int)centerX.Y, (int)radiusX);
                // Recurse 4 times.
                DrawCircles(g, depth - 1, bottom, centerY);
                DrawCircles(g, depth - 1, centerY, top);
                DrawCircles(g, depth - 1, origin, centerX);
                DrawCircles(g, depth - 1, centerX, destination);
            }

        }


        // This method will draw a circle around the passed in point, rather than based
        // on a rect that FillElipse expects.
        public void DrawCircleFromMid(Graphics g, int centerX, int centerY, int radius)
        {
            Brush br = Utilities.GenerateBrushColour(r);
            g.FillEllipse(br, centerX - radius, centerY - radius, radius * 2 + 1, radius * 2 + 1);
        }
    }
}
