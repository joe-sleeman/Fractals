using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fractals;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindLeftThird_ReturnInt()
        {
            int expected = 2;
            int actual = Utilities.FindLeftThird(0, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindOneQuarter()
        {
            int expected = 2;
            int actual = Utilities.FindOneQuarter(0, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindRightThird()
        {
            int expected = 4;
            int actual = Utilities.FindRightThird(0, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateMidPoint_ReturnMidPointX()
        {
            PointF origin = new Point(0, 0);
            PointF destination = new Point(8, 0);
            PointF expected = new Point(4, 0);
            PointF actual = Utilities.CalculateMidPoint(origin, destination);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateMidPoint_ReturnMidPointY()
        {
            PointF origin = new Point(0, 0);
            PointF destination = new Point(0, 8);
            PointF expected = new Point(0, 4);
            PointF actual = Utilities.CalculateMidPoint(origin, destination);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateMidPoint_ReturnMidPointXY()
        {
            PointF origin = new Point(0, 0);
            PointF destination = new Point(8, 8);
            PointF expected = new Point(4, 4);
            PointF actual = Utilities.CalculateMidPoint(origin, destination);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToRadians_ReturnRadians()
        {
            double expected = 1.57;
            // Use Math.Round so that we don't have to deal with big decemals.
            double actual = Math.Round(Utilities.ToRadians(90), 2);

            Assert.AreEqual(expected, actual);
        }

    }
}
