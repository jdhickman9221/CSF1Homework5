using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework5
{
    class atmApplication
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ATM Application");
            Console.Title = "ATM Application";
            //orginal values
            #region//original set up value
            string account = "8675309";
            string password = "password";
            string denied = "Invalid account number or pin entered. Please enter again:\n";
            bool isntCustomer = true;
            bool stillIsntCustomer = true;
            bool hasAttempt = true;
            int attempts = 3;
            #endregion


            //1 asking customer for input.
            Console.WriteLine("Welcome to your local CodeBank ATM. Enter your 7 digit account number now: ");

            //2 while its true they aren't a confirmed customer, repeat while loop. Escape while loop if isntCustomer = false.
            while (isntCustomer || stillIsntCustomer)
            {
                    string userAccount = Console.ReadLine().Trim();//3 user input assigns their userAccount number. 
                    string accountChars = "";//4 blank string assigned.
                    foreach (char userDigit in userAccount)//5 This loop will reassign accountChars string to display a "*" for every char in userAccount.
                    {
                        Console.WriteLine(userDigit);
                        accountChars += "*";//5reassigns for every char in userAccount.
                        Console.Clear();
                    }//endForeach1
                    Console.WriteLine(accountChars);


                if (userAccount == account)//6 if true, it just confirms their acct number. Still need to match password. Only escaped prev loop because one of two 
                    //conditions were met.
                {
                    isntCustomer = false;//7. See, we still assume it's not them.
                    
                        while(stillIsntCustomer) //8. While we still assume that we give the customer a chance for their input matching password on record.
                        {
                                Console.WriteLine("Please enter account pin:\n ");//9. Asking fot user input again.
                                string userPassword = Console.ReadLine().Trim().ToLower();//10. Made a new string based on that input.
                                string passwordChars = "";
                                
                                foreach (char userDigit in userPassword)
                                {
                                    Console.WriteLine(userDigit);
                                    passwordChars += "*";
                                    Console.Clear();
                                }//endForeach2
                                Console.WriteLine(passwordChars);//11.Display's typed characters as * for every character typed by user.

                        if (userPassword == password)//12.If password matches then they escape the loop beacuse stillIsntCustomer will now be true.
                        {
                        stillIsntCustomer = false;
                        }//endIf2


                        else//13. Else, because if their password didn't match it will go here.
                        {
                            
                            Console.WriteLine($"{denied}");//14. Inform user denial of use.
                            attempts--;//15. Takes one counter off attempts (set above in OG value region) 
                            Console.WriteLine($"You have {attempts} log in attempts left.");//16. Write to user how many of the attempts they now have.
                            if(attempts < 1 )//17. New if tree if they run out of attempts.
                            {
                                hasAttempt = false;//18. hasAttempt is made false, meaning the counter reached < 1, which will trigger this section.
                                Console.WriteLine("You are now locked out. Please contact us by phone or wait 24hrs.");                                
                                if(attempts < 0)//19. If they try after lockout, then the following text appears.
                                {
                                 Console.Clear();
                                 Console.WriteLine("We have taken your facial photo and have notified the\n" +
                                 " local police department. Unauthorized attempts");
                                 Console.ReadLine();
                                }//endIf3
                                }//endIf4
                            
                                }//endElse2
                        }//endWhile2
                }//endIf1
                            else
                            {
                             Console.WriteLine($"{denied}");
                            }//endElse1
            }//endWhile1
            Console.Clear();
            decimal balance = 1000.00m;
            bool repeat = true;
            string exitMessage = "Thanks for choosing CodeBank ATM, have a great day!";
            string anotherTransaction = "Would you like to make another transaction?\n" +
            " Y/N";



                do
                {
                    Console.WriteLine("Please make a selection from the menu:\n" +
                        "D)eposit\n" +
                        "W)ithdraw\n" +
                        "S)how Balance\n" +                        
                        "Esc) to exit ATM");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.D:
                        Console.WriteLine("Enter deposit amount: $");
                        balance += decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"\nDeposit accepted. Your current balance is {balance:c}");
                        Console.ReadLine();
                        Console.WriteLine($"{anotherTransaction}");
                        ConsoleKey userChoice2 = Console.ReadKey().Key;
                        Console.Clear();
                                    switch (userChoice2)
                                    {
                                        case ConsoleKey.Y:                                
                                        break;
                                        case ConsoleKey.N:
                                        repeat = false;
                                        break;
                                    }//endSwitch2
                        break;

                        case ConsoleKey.W:
                        Console.WriteLine("Enter witherdraw amount: $");
                        balance -= decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"\nWithdraw accepted. Your current balance is {balance:c}");
                        Console.ReadLine();
                        Console.WriteLine($"{anotherTransaction}");
                        ConsoleKey userChoice3 = Console.ReadKey().Key;
                        Console.Clear();
                                    switch (userChoice3)
                                    {
                                         case ConsoleKey.Y:
                                         Console.Clear();
                                         break;
                                         case ConsoleKey.N:
                                         repeat = false;
                                         break;
                                    }//endSwitch3
                        break;

                    case ConsoleKey.S:
                        Console.WriteLine($"{balance:c}");
                        Console.ReadLine();
                        Console.WriteLine($"{anotherTransaction}");
                        ConsoleKey userChoice4 = Console.ReadKey().Key;
                        Console.Clear();
                        switch (userChoice4)
                        {
                            case ConsoleKey.Y:
                                Console.Clear();
                                break;
                            case ConsoleKey.N:
                                repeat = false;
                                break;
                        }//endSwitch3
                        break;

                    case ConsoleKey.Escape:
                        repeat = false;
                        break;

                        //default:
                        Console.Clear();
                        Console.WriteLine("That wasn't an option. Please try again.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }//endSwitch1
                } while (repeat != false);//endDo

            Console.WriteLine($"{exitMessage}");
            Console.ReadLine();
            Console.Clear();














        }//End Main()
    }//End Class
}//End Namespace
