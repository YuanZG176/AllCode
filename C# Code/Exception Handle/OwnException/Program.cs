// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using OwnException;
using System;
using static System.Console;

class TayBankAccount
{
    static void Main()
    {
        BankAccount acct = new BankAccount();
        try
        {
            acct.AccountNum = 1223;
            acct.Balance = -1000;
        }
        catch(NagitiveBalanceException e)
        {
            WriteLine(e.Message);
            WriteLine(e.StackTrace);
        }
    }
   
}
