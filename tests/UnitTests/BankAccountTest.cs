using System.ComponentModel;

namespace UnitTests;

public class BankAccountTest : IClassFixture<BankAccountTestFixture>
{
    private readonly BankAccountTestFixture _fixture;
    
    public BankAccountTest(BankAccountTestFixture fixture)
    {
        _fixture = fixture;
    }
    
    [Fact]
    [Description("Bank Account should have an account number and agency number")]
    public void TestBankAccountShouldHaveAccountNumberAndAgency()
    {
        Assert.NotNull(_fixture.BankAccount.AccountNumber);
        Assert.NotNull(_fixture.BankAccount.Agency);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    [InlineData(-5)]
    [InlineData(-3)]
    [InlineData(-15)]
    [Description("A Deposit shouldn't be zero or negative value")]
    public void TestDepositShouldNotBeZeroOrNegativeValue(double value)
    {
        Assert.Throws<ArgumentException>(() => _fixture.BankAccount.Deposit(value));
    }    
}