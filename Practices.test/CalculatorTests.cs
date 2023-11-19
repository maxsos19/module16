using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Practices.Test
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnNotNullValue()
        {
            var additional = new Calculator();
            Assert.That(additional.Additional(200, 10)== 210);
        }
        [Test]
        public void SubtractionMustReturnNotNullValue()
        {
            var subtraction = new Calculator();
            Assert.That(subtraction.Subtraction(100, 20) == 80);
        }
        [Test]
        public void MiltiplicationMustReturnNotNullValue()
        {
            var miltiplication = new Calculator();
            Assert.That(miltiplication.Miltiplication(10, 20) == 200);

        }
        [Test]

        public void DivisionMustReturnNotNullValue()
        {
            var division = new Calculator();
            Assert.That(division.Division(20, 20) == 1);

        }


    }
}
