using Application.Models;

namespace UnitTests;

public class BankAccountTestFixture
{
    public BankAccount BankAccount { get; private set; }

    public BankAccountTestFixture()
    {
        BankAccount = new BankAccount(123456, 123, 0);
    }
}