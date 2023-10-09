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
    public class SavingsTestsWithdrawPositive
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            //Arrange
            Savings savings = new Savings(500);
            double withdrawAmount = 200;
            double expectedResult = 300;
            //Act
            savings.Withdraw(withdrawAmount);
            //Assert
            Assert.AreEqual(expectedResult, savings.Balance);
        }
    }
}