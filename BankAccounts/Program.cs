using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {

            accountHolder user = new accountHolder();
            user.UserName = "Tyshawnna";
            user.AccountNumb = "022872";

            Console.WriteLine("Hello " + user.UserName);

            Checkings ca = new Checkings(1290);
            Savings sa = new Savings(80000);
            Reserved rd = new Reserved(2500);


            accountHolder.AccountMenu( ca,  sa, rd);
                
         


            

   

            


             




























}
    }
}
