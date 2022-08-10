namespace Application.Models;

public class BankAccount
{
    public long? AccountNumber { get; }
    public int? Agency { get; }
    public double Balance { get; private set; }

    public BankAccount()
    {
        AccountNumber = 0;
        Agency = 0;
        Balance = 0;
    }

    public BankAccount(long? accountNumber, int? agency, double balance)
    {
        AccountNumber = accountNumber;
        Agency = agency;
        Balance = balance;
    }

    public void Deposit(double value)
    {
        if (value <= 0) throw new ArgumentException();
        Balance += value;
    }

    public void Withdraw(double value)
    {
        //TODO.: se o valor for menor igual a zero, lançar uma exceção
        //TODO.: se a conta não tiver saldo suficiente, lançar uma exceção
        //TODO.: se a conta tiver saldo suficiente, debitar o valor do saldo
    }

    public void Transfer(BankAccount bankAccount, double value)
    {
        //TODO.: se o valor for menor igual a zero, lançar uma exceção
        //TODO.: se a conta não tiver saldo suficiente, lançar uma exceção
        //TODO.: se a conta tiver saldo suficiente, debitar o valor do saldo e realizar deposito
        // na BankAccount beneficiaryAccount
    }
}