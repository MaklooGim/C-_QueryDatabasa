using System;
using Area;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaTest
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void Area_Circle_4_50()
        {
            //arrange
            int r = 4;
            double S = Math.PI * 4 * 4;
            //act
            Area.Area S_circle = new Area.Area();
            double actual = S_circle.FindArea(4);
            //assert
            Assert.AreEqual(S, actual);
        }
        [TestMethod]
        public void Area_Circle_0_Error()
        {
            //arrange
            int r = 0;
            //act
            Area.Area S_circle = new Area.Area();
            //assert
            Assert.Fail($"{S_circle.FindArea(0)}");
        }
        [TestMethod]
        public void Area_triangle_1_2_10_()
        {
            int a = 1, b = 2, c = 10;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Area.Area S_triengl = new Area.Area();
            double actual = S_triengl.FindArea(1, 2, 10);

            Assert.AreEqual(S, actual); // Не могу понять, что с тестом не так 
        }
        [TestMethod]
        public void Area_triangle_1_0_9_ERROR()
        {
            int a = 1, b = 0, c = 9;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Area.Area S_triengl = new Area.Area();
            double actual = S_triengl.FindArea(1, 2, 10);

            Assert.Fail($"{S_triengl.FindArea(1, 2, 10)}"); // Не могу понять, что с тестом не так 
            //Саму библиотеку я проверил выдает все как положено, а тесты не работают 
        }
    }
}
