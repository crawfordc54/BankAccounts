using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(0, (decimal)0.03);
            CheckingAccount checking = new CheckingAccount(0, (decimal)2.0);
            String selection;
            String output = "";
            while (1 == 1)
            {
                Console.WriteLine("Greeting, please input if you would like to interface with your checking or savings account");
                selection = Console.ReadLine();
                if(selection.ToLower().Equals("checking"))
                {
                    Console.WriteLine("Would you like to make a deposit or withdraw?");
                    selection = Console.ReadLine();
                    if(selection.ToLower().Equals("deposit"))
                    {
                        Console.WriteLine("Please input an amount to deposit.");
                        checking.Credit(Convert.ToDecimal(Console.ReadLine()), out output);
                    }
                    else if(selection.ToLower().Equals("withdraw"))
                    {
                        Console.WriteLine("Please input an amount to withdraw.");
                        checking.Debit(Convert.ToDecimal(Console.ReadLine()), out output);
                    }
                    else
                    {
                        Console.Write("Invalid input.");
                    }
                }
                else if(selection.ToLower().Equals("savings"))
                {
                    Console.WriteLine("Would you like to make a deposit or withdraw?");
                    selection = Console.ReadLine();
                    if (selection.ToLower().Equals("deposit"))
                    {
                        Console.WriteLine("Please input an amount to deposit.");
                        savings.Credit(Convert.ToDecimal(Console.ReadLine()), out output);
                    }
                    else if (selection.ToLower().Equals("withdraw"))
                    {
                        Console.WriteLine("Please input an amount to withdraw.");
                        savings.Debit(Convert.ToDecimal(Console.ReadLine()), out output);
                    }
                    else
                    {
                        Console.Write("Invalid input.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine(output);
                output = "";
                Console.WriteLine();

            }
        }
    }
}
