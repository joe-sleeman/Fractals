using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    public class Snowflake
    {
        Random r;
        public Snowflake()
        {
            r = new Random();
        }
        public void DrawSnowflake(Graphics g, int depth, PointF top, PointF left, PointF right)
        {
            // Top => Left edge.
            DrawSnowflakeEdge(g, depth, (int)top.X, (int)top.Y, (int)left.X, (int)left.Y);
            // Left => Right edge (bottom).
            DrawSnowflakeEdge(g, depth, (int)left.X, (int)left.Y, (int)right.X, (int)right.Y);
            // Right => Top edge.
            DrawSnowflakeEdge(g, depth, (int)right.X, (int)right.Y, (int)top.X, (int)top.Y);           
        }

        public void DrawSnowflakeEdge(Graphics g, int depth, int originX, int originY,
            int destinationX, int destinationY)
        {
            int deltaX, deltaY, leftX, leftY, midX, midY, rightX, rightY;
            Brush br = Utilities.GenerateBrushColour(r);
            Pen pen = new Pen(br);
            pen.Width = 4;

            if (depth == Constants.BASE_CASE)
            {
                g.DrawLine(pen, originX, originY, destinationX, destinationY);
            }
            else
            {
                // Delta = destination - origin.
                // Solve for both X & Y.
                deltaX = destinationX - originX;
                deltaY = destinationY - originY;

                // Find our left third coordinates.
                leftX = Utilities.FindLeftThird(originX, deltaX);
                leftY = Utilities.FindLeftThird(originY,  deltaY);

                //Find our mid (peak) coordinates.
                midX = Utilities.FindPeak(originX, destinationX, originY, destinationY);
                midY = Utilities.FindPeak(originY, destinationY, destinationX, originX);

                //Point newPoint = Utilities.FindPeak2(originX, originY, deltaX, -60);
                //midX = newPoint.X;
                //midY = newPoint.Y;

                // Find our right coordinates.
                rightX = Utilities.FindRightThird(originX, deltaX);
                rightY = Utilities.FindRightThird(originY, deltaY);

                // Recursively draw the snow flake edge.
                // Origin to left third.
                DrawSnowflakeEdge(g, depth - 1, originX, originY, leftX, leftY);
                // Left third to mid point.
                DrawSnowflakeEdge(g, depth - 1, leftX, leftY, midX, midY);
                // Mid point to right third.
                DrawSnowflakeEdge(g, depth - 1, midX, midY, rightX, rightY);
                // Right third back to origin.
                DrawSnowflakeEdge(g, depth - 1, rightX, rightY, destinationX, destinationY);
            }

        }
    }
}
