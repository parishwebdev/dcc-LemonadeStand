using System;
using DCC_Parish_LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DCC_Parish_LemonadeStand_Test
{
    [TestClass]
    public class DayTest
    {
        [TestMethod]
        public void Subtract_Wallet_DollarValues_Return_Positive_Profit()
        {
            //Arrange
            DayUnitTesting day = new DayUnitTesting();
            double wallet1 = 12.50;
            double wallet2 = 17.25;
            double expectedResult = 4.75;
            //Act
            double actualResult = day.SetDayProfit(wallet1, wallet2);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_Wallet_DollarValues_Return_Negative_Profit()
        {
            //Arrange
            DayUnitTesting day = new DayUnitTesting();
            double wallet1 = 17.25;
            double wallet2 = 12.50; 
            double expectedResult = -4.75;
            //Act
            double actualResult = day.SetDayProfit(wallet1, wallet2);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_Wallet_DollarValues_Return_No_Profit()
        {
            //Arrange
            DayUnitTesting day = new DayUnitTesting();
            double wallet1 = 12.50;
            double wallet2 = 12.50;
            double expectedResult = 0.00;
            //Act
            double actualResult = day.SetDayProfit(wallet1, wallet2);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
