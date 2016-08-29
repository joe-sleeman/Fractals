using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    public static class Utilities
    {
        // Utilities class used for common tasks throughout this
        // solution.


        // Help find the left third of a line
        public static int FindLeftThird(int origin, int delta)
        {
            // Return the original location + one third of our 
            // total length (delta).
            return origin + delta / 3;
        }

        public static int FindOneQuarter(int origin, int delta)
        {
            return origin + delta / 4;
        }

        // FindRightThird - Help find the right third of a line.
        public static int FindRightThird(int origin, int delta)
        {
            // Return the original location + two thirds of
            // total length (delta).
            return origin + 2 * delta / 3;
        }

        // Find the peak for a Koch curve.
        
        public static int FindPeak(int originA, int destinationA, int originB, int destinationB)
        {
            int originDestinationA = originA + destinationA;
            int originDestinationB = originB - destinationB;
            int mid = (int)(0.5 * originDestinationA + Math.Sqrt(3) * originDestinationB / 6);
            return mid;
        }

        // We essentially have an equilateral triangle that we know has three equal sides
        // at 60 degree angles. The height of an equilateral triangle is equal to:
        //      side/2 * SQRT(3)
        // This doesn't work and I have no idea why.
        public static Point FindPeak2(int originX, int originY, int length, double angle)
        {
            double rad = ToRadians(angle);
            int newX = originX + (int)(Math.Cos(rad) * length);
            int newY = originY + (int)(Math.Sin(rad) * length);

            return new Point(newX, newY);
        }

        // Find the mid point of a line based on two passed in points.
        public static PointF CalculateMidPoint(PointF pointA, PointF pointB)
        {
            // Midpoint = (A + B) / 2.
            // Do this for both X and Y values.
            return new PointF((pointA.X + pointB.X) / 2, (pointA.Y + pointB.Y) / 2);
        }

        // Generate a random coloured RGB brush.
        public static Brush GenerateBrushColour(Random r)
        {
            int red = r.Next(0, byte.MaxValue + 1);
            int green = r.Next(0, byte.MaxValue + 1);
            int blue = r.Next(0, byte.MaxValue + 1);
            Brush brush = new SolidBrush(Color.FromArgb(red, green, blue));
            return brush;
        }

        // Convert degrees to radians.
        public static double ToRadians(double input)
        {
            return (Math.PI / 180) * input;
        }

        // Code to find a point from a line that will draw a
        // right angle triangle and use the original line
        // as the hypotenuse. Works because maths...
        public static PointF FindRightAnglePoint(PointF origin, PointF destination)
        {
            float newX = (origin.X + destination.X) / 2 + (origin.Y - destination.Y) / 2;
            float newY = (origin.Y + destination.Y) / 2 - (origin.X - destination.X) / 2;
            // We use PointF so that our resulting point is accurate, and we get straight
            // lines when we are drawing.
            return new PointF(newX, newY);
        }
    }
}
