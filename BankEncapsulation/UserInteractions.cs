namespace BankEncapsulation;

public class UserInteractions
{
    public string GetName(BankAccount bankAccount)
    {
        var validResponse = false;
        string name;
        Console.Write("Please enter your name: ");
        do
        {
            name = Console.ReadLine();
            if (name == null || name.Length == 0)
                Console.Write("Please enter a valid name: ");
            else
                validResponse = true;
        } while (!validResponse);

        Console.Clear();
        return name;
    }

    public void WelcomeMessage(string owner)
    {
        Console.WriteLine(
            $"Hello {owner}. Welcome to \u001b[33m*~.+`.\u001b[36mBank Encapsulation\u001b[33m.'+.~*\u001b[0m");
    }

    public void MakeAChoice()
    {
        Console.WriteLine($"\nPlease use the up and down arrows to make a selection from the following menu. Please " +
                          $"type 'Enter' to make your selection.");
    }

    public double GetAmount(string use)
    {
        Console.WriteLine($"How much money would you like to {(use == "deposit"? "deposit": "withdraw")}");
        var validResponse = false;
        double amount = 0;
        do
        {
            validResponse = double.TryParse(Console.ReadLine(), out amount);
            if(!validResponse)
                Console.Write("I'm sorry, that was not a valid number. Please enter a valid amount: ");
        } while (!validResponse);
        return amount;
    }

    public void InsufficientFunds()
    {
        Console.WriteLine($"You do not have enough funds to cover this withdrawal.");
        
    }

    public void CurrentBalance(BankAccount _bankAccount)
    {
        Console.WriteLine($"Your current balance is {_bankAccount.GetBalance():C}");
    }

    public void ThankYouMessage()
    {
        Console.WriteLine("Thank you for using \u001b[33m*~.+`.\u001b[36mBank Encapsulation\u001b[33m.'+.~*\u001b[0m");
    }

    public void Pause()
    {
        Console.WriteLine("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
    }

    public void ClosedLoopCommunication(string use, double amount)
    {
        Console.WriteLine($"You have {(use == "deposit"? "deposited":"withdrawn")} {amount:C}.");
    }
}