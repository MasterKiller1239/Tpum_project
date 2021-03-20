using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace UnitTests_for_Testprogram
{
    [TestClass]
    public class BankAccountTest
    {
        [TestClass]
        public class BankAccountTests
        {
            [TestMethod]
            public void Debit_WithValidAmount_UpdatesBalance()
            {
                // Arrange
                double beginningBalance = 11.99;
                double debitAmount = 4.55;
                double expected = 7.44;
                BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

                // Act
                account.Debit(debitAmount);

                // Assert
                double actual = account.Balance;
                Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
            }
            [TestMethod]
            public void Check_Credit_Method()
            {
                // Arrange
                double beginningBalance = 11.99;
                double debitAmount = 5.01;
                double expected = 17.00;
                BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

                // Act
                account.Credit(debitAmount);

                // Assert
                double actual = account.Balance;
                Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
            }
        }
    }
}
