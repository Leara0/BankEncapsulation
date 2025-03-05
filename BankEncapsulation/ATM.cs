namespace BankEncapsulation;

public class ATM
{
    public void StartTransaction()
    {
        BankAccount bankAccount = new BankAccount();
        InteractiveMenu interactiveMenu = new InteractiveMenu();
        UserInteractions userInteractions = new UserInteractions();
        var endSession = false;

        bankAccount.Owner = userInteractions.GetName(bankAccount); // make this method
        userInteractions.WelcomeMessage(bankAccount.Owner);

        do
        {
            userInteractions.MakeAChoice();


            int choice = interactiveMenu.GetChoice();
            switch (choice)
            {
                case 1:
                    double deposit = userInteractions.GetAmount("deposit");
                    bankAccount.Deposit(deposit);
                    userInteractions.ClosedLoopCommunication("deposit", deposit);
                    break;
                case 2:
                    double withdrawAmount = userInteractions.GetAmount("withdraw");
                    if (!bankAccount.Withdraw(withdrawAmount))
                        userInteractions.InsufficientFunds();
                    else
                        userInteractions.ClosedLoopCommunication("withdrawn", withdrawAmount);

                    break;
                case 3:
                    userInteractions.CurrentBalance(bankAccount);
                    break;
                case 4:
                    userInteractions.ThankYouMessage();
                    endSession = true;
                    break;
            }

            if (choice != 4)
                userInteractions.Pause();
        } while (endSession == false);
    }


    //I want the main method to call this class which asks for username/number then pulls up user's account
}

//deposit
//withdraw
//check balance
// end session