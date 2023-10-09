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
    public class CheckingWithdrawTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            //Arrange
            Checking checking = new Checking(1000);
            double depositAmount = 500;
            double expectedResult = 500;
            //Act
            checking.Withdraw(depositAmount);
            //Assert
            Assert.AreEqual(expectedResult, checking.Balance);
        }
    }
}