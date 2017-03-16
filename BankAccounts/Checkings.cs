using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BankAccounts
{
    class Checkings : accountHolder
    {
        public Checkings(decimal Balance) : base(Balance)
        {

        }

        private int amount;
        private int userInput;

        public static void caAccount(int amount, int userInput, decimal balance )
        {
            
            Console.WriteLine("\n Press 1 To: Deposit ");
            Console.WriteLine("\n Press 2 To: Withdrawal ");
            Console.WriteLine("\n Press 3 To: Exit ");
            userInput = int.Parse(Console.ReadLine());
             
            if ( 1 == userInput)
            {
                Console.WriteLine("What would you like to Deposit: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n Your new balance is: " + (amount + balance));
                return;
            }

            else if (2 == userInput)
            {
                Console.WriteLine("What would you like to Withdrawal: ");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n Your new balance is: " + (balance - amount));
                return;
                    
            }

            else if (3 <= userInput)
            {
                Console.WriteLine("Thank you for choosing safe one. Goodbye!");
                return;
            }


        }
          

        
        
        

        
        

        
        
    }
}
