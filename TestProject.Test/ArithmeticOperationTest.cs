using NUnit.Framework;
using System;

namespace TestProject.Test
{
    [TestFixture]
    public class ArithmeticOperationTest
    {
        [Test]
        public void AdditionOfTwoNumber_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            ArithmeticOperation calc = new();

            //Act
            int result = calc.AdditionOfTwoNumber(10, 20);

            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void AdditionOfTwoNumber_InputTwoInt_GetWrongAddition()
        {
            //Arrange
            ArithmeticOperation calc = new();

            //Act
            int result = calc.AdditionOfTwoNumber(10, 20);

            //Assert
            Assert.AreEqual(40, result);
        }



    }
}
