using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccounts
{
    class accountHolder
    {

        DateTime accountTime = DateTime.Now;
        private string userName;
        private string accountNumb;
        private decimal Balance;
        private double Deposit;
        private double Withdrawal;
        private string userAmount;
        private string userAnswer;
        
       
        public accountHolder()
        {
            
        }

        public accountHolder(decimal Balance)
        {
            balance = Balance;
        }

        public accountHolder(decimal Balance, double Deposit, double Withdrawal)
        {
           
            this.Balance = Balance;
            this.Deposit = Deposit;
            this.Withdrawal = Withdrawal;

        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string AccountNumb
        {
            get { return this.accountNumb; }
            set { this.accountNumb = value; }
        }
        public decimal balance
        {
            get { return this.Balance; }
            set { this.Balance = value; }
        }

        public double deposit
        {
            get { return this.Deposit; }
            set { this.Deposit = value; }
        }

        public double withdrawal
        {
            get { return this.Withdrawal; }
            set { this.Withdrawal = value; }
        }

        internal DateTime AccountTime
        {
            get
            {
                return accountTime;
            }

            set
            {
                accountTime = value;
            }
        }

        public static void AccountMenu(Checkings ca, Savings sa, Reserved rd)
        {

            Console.WriteLine(ca.balance);
            Console.WriteLine(sa.balance);
            Console.WriteLine(rd.balance);
            Console.WriteLine("\n Account Balance: ");
            Console.WriteLine("\n Checkings: " + ca.balance);
            Console.WriteLine("\n Savings: " + sa.balance);
            Console.WriteLine("\n Reserved: " + rd.balance);

            List<string> list = new List<string>();

            list.Add("\n\n Press 1 to: Checkings ");
            list.Add("\n Press 2 to: Savings ");
            list.Add("\n Press 3 to: Reserved ");
            list.Add("\n Press 4 to: Exit ");


            foreach (string currentVal in list)
            {
                Console.WriteLine(currentVal);
            } 

            
            { 
                int userNumb = int.Parse(Console.ReadLine());

                if (1 == userNumb)
                {
                    Checkings.caAccount(000, 000 , ca.balance);
                }

                else if (2 == userNumb)
                {
                    Savings.saAccount(000, 000, sa.balance);
                }

                else if (3 == userNumb)
                {
                    Reserved.rdAccount(000, 000, rd.balance);
                    
                }

                else if (4 <= userNumb)
                {
                    Console.WriteLine( "\n Thank you for choosing safe one. Goodbye!" );
                    
                }
                        
                        
                       

            }

           
            

        }

        



        
     

      
        

        
        



    }

}
