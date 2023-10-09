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
    public class CheckingDepositPositiveTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            //Arrange
            Checking checking = new Checking(300);
            double DepositAmount = 200;
            double expectedResult = 500;
            //Act
            checking.Deposit(DepositAmount);
            //Assert
            Assert.AreEqual(expectedResult, checking.Balance);
        }
    }
}