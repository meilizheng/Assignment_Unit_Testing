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
    public class CheckingDepositNagtiveTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            //Arrange
            Checking checking = new Checking(1000);
            double totalDeposit = -200;
            double expectedResult = 1000;
            //Act
            checking.Deposit(totalDeposit);
            //Assert
            Assert.AreEqual(expectedResult, checking.Balance);
        }
    }
}