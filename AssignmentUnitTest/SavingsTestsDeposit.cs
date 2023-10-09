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
    public class SavingsTestsDeposit
    {
        [TestMethod()]
        public void DepositTest()
        {
            //Arrange
            Savings savings = new Savings(200);
            double TotalDeposit = 300;
            double expectedResult = 505;

            //Act 
            savings.Deposit(TotalDeposit);

            //Assert
            Assert.AreEqual(expectedResult, savings.Balance);
        }
    }
}