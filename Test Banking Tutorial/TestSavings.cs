using Banking_Tutorial_tql3;

namespace Test_Banking_Tutorial;

public class TestSavings
{
    Savings savings = default!;    
    public TestSavings()
    {
        savings = new Savings("TestSAvingsAccount");
    }
    [Fact]
    public void TestInterestRateat12Pct()
    {
        Assert.Equal(0.12m, savings.IntRate, 2);
    }

    [Theory]
    [InlineData(1000, 1)]
    [InlineData(1000, 100)]
    [InlineData(1000, 500)]
    [InlineData(1000, 1000)]
    [InlineData(1000, 1001)]
    public void TestWithdrawal(int deposit, int withdraw)
    {
        savings.Deposit(deposit);
        savings.Withdraw(withdraw);
        Assert.True(savings.Balance == deposit - withdraw);
    }

    [Fact] //Actions do not return anything so this can be a fact. 
    public void TestDepositNegativeAmount()
    {
        Action ex = () => throw new NonPositiveAmountException(); //method named "ex" that throws an exception from the solution (NonPositiveAm...);
        Assert.Throws<NonPositiveAmountException>(ex);
    //do this so you dont have to create a class, then a method, then put the method in the class. This is a creative way to create a method that is not attached to a class. 
    }

    [Theory]
    [InlineData(10, 10, 10, 50)]
    public void TestTransfer(int deposit1, int deposit2, int amount, int sav2balance)
    {
        var savings2 = new Savings("Second Savings Account");
        savings.Deposit(desposit1);
        savings2.Deposit(desposit2);
        savings.Transfer(amount, savings2);
        Assert.True(savings.Balance == sav2balance && savings2.Equals Balanc == sav2balance);
        
        //checking
    }
}