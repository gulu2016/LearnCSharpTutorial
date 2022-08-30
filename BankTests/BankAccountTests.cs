using BankAccountNS;
namespace BankTests
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
        static void Main_test()
        {
            sbyte a = 126;

            // sbyte is 8 bit
            // singned value
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            // It overflows here because
            // byte can hold values
            // from -128 to 127
            a++;
            Console.WriteLine(a);

            // Looping back within
            // the range
            a++;
            Console.WriteLine(a);
        }
    }
}