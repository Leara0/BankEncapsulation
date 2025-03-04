using System.Runtime.InteropServices;

namespace BankEncapsulation;

public class InteractiveMenu
{
    public int GetChoice()
    {
        int optionSelected = 1;
        ConsoleKeyInfo key;
        bool isSelected = false;
        (int left, int top) = Console.GetCursorPosition();
        string selectorOpen = "\u001b[34m--> ";
        string selectorClose = " <--\u001b[39m";
        Console.CursorVisible = false;

        while (!isSelected)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"{(optionSelected == 1 ? selectorOpen : "    ")} Deposit Funds " +
                          $"{(optionSelected == 1 ? selectorClose : "    ")}\u001b[0m");
            Console.WriteLine($"{(optionSelected == 2 ? selectorOpen : "    ")} Withdraw Funds " +
                              $"{(optionSelected == 2 ? selectorClose : "    ")}\u001b[0m");
            Console.WriteLine($"{(optionSelected == 3 ? selectorOpen : "    ")} CheckBalance " +
                              $"{(optionSelected == 3 ? selectorClose : "    ")}\u001b[0m");
            Console.WriteLine($"{(optionSelected == 4 ? selectorOpen : "    ")} End Session " +
                              $"{(optionSelected == 4 ? selectorClose : "    ")}\u001b[0m");
            
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (optionSelected == 1)
                    {
                        optionSelected = 4;
                        break;
                    }

                    optionSelected--;
                    break;
                case ConsoleKey.DownArrow:
                    if (optionSelected == 4)
                    {
                        optionSelected = 1;
                        break;  
                    }
                    optionSelected++;
                    break;  
                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
            
            //Withdraw
            //Get Balance
            //Deposit
            //End Session
            
        }
        return optionSelected;
    }
}