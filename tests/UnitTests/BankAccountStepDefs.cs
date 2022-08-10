using Application.Models;
using TechTalk.SpecFlow;

namespace UnitTests;

[Binding]
[Scope(Feature = "Operações em BankAccount")]
public class BankAccountStepDefs
{
    private BankAccount? _bankAccount;
    
    [Given(@"um BankAccount com saldo de R\$ (.*)")]
    public void GivenUmBankAccountComSaldoDeR(decimal p0)
    {
        _bankAccount = new BankAccount(123456, 123, 0);
    }

    [When(@"depositar R\$ (.*)")]
    public void WhenDepositarR(double p0)
    {
        _bankAccount?.Deposit(p0);
    }

    [Then(@"o saldo do BankAccount deve ser R\$ (.*)")]
    public void ThenOSaldoDeveSerR(double p0)
    {
        var saldo = _bankAccount?.Balance;
        Assert.Equal(p0, saldo);
    }
}