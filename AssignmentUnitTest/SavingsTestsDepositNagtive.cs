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
    public class SavingsTestsDepositNagtive
    {
        [TestMethod()]
        public void DepositTest()
        {
            //Arrange
            Savings savings = new Savings(500);
            double totalDeposit = -100;
            double expectedResult = 500;
            //Act
            savings.Deposit(totalDeposit);
            //Assert
            Assert.AreEqual(expectedResult, savings.Balance);
        }
    }
}