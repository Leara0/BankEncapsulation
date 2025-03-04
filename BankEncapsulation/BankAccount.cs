namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;
    private int _accountNumber;

    public string Owner { get; set; }

    public void Deposit(double amount) => _balance += amount;

    public bool Withdraw(double amount)
    {
        if (_balance > amount)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public double GetBalance() => _balance;
}