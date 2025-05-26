using Egysegteszt_KovacsRoland;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RectangleAreaTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void NormalCase()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(5, 10);

            Assert.AreEqual(50, actual);

        }
        [TestMethod]
        public void ZeroAsWidth()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(0, 10);

            Assert.AreEqual(0, actual);

        }

        [TestMethod]
        public void ZeroAsHeight()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(10, 0);

            Assert.AreEqual(0, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NegativAsWidth()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(-5, 10);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NegativAsHeight()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(10, -5);

        }

        [TestMethod]
        public void UsingBigNumbers()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(1000000, 2000000);

            Assert.AreEqual(2000000000000, actual);

        }

        [TestMethod]
        public void UsingNotEvenNumbers()
        {
            var peldany = new Rectangle();

            double actual = peldany.CalculateArea(4.5, 8.2);

            Assert.AreEqual(36.9, actual);

        }
    }
}
