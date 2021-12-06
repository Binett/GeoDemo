using Calculator.Add;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{  
    public class AdditionTests
    {  

        [Test]
        [TestCase(1,1,2)]
        [TestCase(55,25,80)]
        public void Addition_AddTwoNumbers_ShouldReturnResult(
            int firstnum, 
            int secondnum, 
            int expected)
        {
            var calc = new Addition(firstnum, secondnum);
            var actual = calc.Calculate();
            Assert.AreEqual(expected, actual);
        }
    }
}
