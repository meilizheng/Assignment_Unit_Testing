using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing.Tests
{
    [TestClass()]
    public class CheckingWithdrawOverTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            //Arrange
            Checking checking = new Checking(500);
            double withdrawAmount = 600;
            double expectedResult = 485;
            //Act
            checking.Withdraw(600);
            //Assert
            Assert.AreEqual(expectedResult, checking.Balance);
        }
    }
}