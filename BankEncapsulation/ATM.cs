namespace BankEncapsulation;

public class ATM
{
    public void StartTransaction()
    {
        BankAccount _bankAccount = new BankAccount();
        InteractiveMenu _interactiveMenu = new InteractiveMenu();
        UserInteractions _userInteractions = new UserInteractions();
        var endSession = false;

        _bankAccount.Owner = _userInteractions.GetName(_bankAccount); // make this method
        _userInteractions.WelcomeMessage(_bankAccount.Owner);

        do
        {
            _userInteractions.MakeAChoice();


            int choice = _interactiveMenu.GetChoice();
            switch (choice)
            {
                case 1:
                    double deposit = _userInteractions.GetAmount("deposit");
                    _bankAccount.Deposit(deposit);
                    _userInteractions.ClosedLoopCommunication("deposit", deposit);
                    break;
                case 2:
                    double withdrawAmount = _userInteractions.GetAmount("withdraw");
                    if (!_bankAccount.Withdraw(withdrawAmount))
                        _userInteractions.InsufficientFunds();
                    else
                        _userInteractions.ClosedLoopCommunication("withdrawn", withdrawAmount);

                    break;
                case 3:
                    _userInteractions.CurrentBalance(_bankAccount);
                    break;
                case 4:
                    _userInteractions.ThankYouMessage();
                    endSession = true;
                    break;
            }

            if (choice != 4)
                _userInteractions.Pause();
        } while (endSession == false);
    }


    //I want the main method to call this class which asks for username/number then pulls up user's account
}

//deposit
//withdraw
//check balance
// end session