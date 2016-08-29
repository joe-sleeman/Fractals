using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    // 1. Draw the trunk
    // 2. At the end of the trunk, split by some angle, draw
    //    two branches.
    // 3. Repeat at the end of each brance until base case.
    public class Tree
    {
        Random r;
        public Tree()
        {
            r = new Random();
        }
        public void DrawTree(Graphics g, int depth, int startX, int startY, double angle)
        {
            // Base case will just end function, so recurse while we are
            // not at our base case.
            if (depth != Constants.BASE_CASE)
            {
                Pen pen = new Pen(Utilities.GenerateBrushColour(r));
                pen.Width = 4;
                // Convert angle to radians.
                double rad = Utilities.ToRadians(angle);

                // Figure out coordinates for the new Point using maths.               
                int newX = startX + (int)(Math.Cos(rad) * depth * Constants.TREE_BASE_HEIGHT);
                int newY = startY + (int)(Math.Sin(rad) * depth * Constants.TREE_BASE_HEIGHT);

                // Draw a line to our new point.
                g.DrawLine(pen, startX, startY, newX, newY);

                // Recurse for both branches, decrementing/incrementing angles.
                DrawTree(g, depth - 1, newX, newY, angle - Constants.TREE_ANGLE);
                DrawTree(g, depth - 1, newX, newY, angle + Constants.TREE_ANGLE);
            }
        
        }
        
    }
}
