using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Tests
{
    [TestClass]
    public class CalculationsTests
    {

        [TestMethod]
        public void Test_Sum_Method()
        {
            Calculations calculations = new Calculations();
            int result = calculations.Sum(7, 11);
            Assert.AreEqual(18, result);

        }

        [TestMethod]
        public void Test_Multiply_Method()
        {
            Calculations calculations = new Calculations();
            int result = calculations.Multiply(7, 11);
            Assert.AreEqual(77, result);
        }

    }
}
