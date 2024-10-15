using System;
using System.Collections.Generic;

namespace Bank.Presentation
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***********Bank system********");
            System.Console.WriteLine("::Login Page::");

            string userName = null, password = null;

            System.Console.Write("Username:");
            userName = System.Console.ReadLine();

            if (userName != "")
            {
                System.Console.Write("Password:");
                password = System.Console.ReadLine();
            }
            if(userName=="janani" && password == "janani@123")
            {
                int mainMenuChoice = -1;
                do
                {

                    System.Console.WriteLine(" \nMain menu ");
                    System.Console.WriteLine("1.Customers");
                    System.Console.WriteLine("2.Accounts");
                    System.Console.WriteLine("3.Funds Transfer");
                    System.Console.WriteLine("4.Funds Transfer statement");
                    System.Console.WriteLine("5.Account statement");
                    System.Console.WriteLine("0.Exit");

                    System.Console.Write("Enter choice:");
                    mainMenuChoice = int.Parse(System.Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1:
                            CustomersMenu();
                            break;
                        case 2:
                            AccountsMenu();
                            break;
                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                System.Console.WriteLine("Invalid username or password");
            }
            System.Console.WriteLine("Thank you visit again");
            System.Console.ReadKey();
        }

        static void CustomersMenu()
        {
            int CustomerMenuChoice = -1;

            do
            {
                System.Console.WriteLine("\n Customer menu");
                System.Console.WriteLine("1.Add customer");
                System.Console.WriteLine("2.Delete Customer");
                System.Console.WriteLine("3.Update Customer");
                System.Console.WriteLine("4.View Customer");
                System.Console.WriteLine("0.Back to main menu");

                System.Console.Write("enter choice:");
                CustomerMenuChoice=System.Convert.ToInt32(System.Console.ReadLine());
            } while (CustomerMenuChoice != 0);
        }

        static void AccountsMenu()
        {
            int accountsMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n Accounts menu");
                System.Console.WriteLine("1.Add Account");
                System.Console.WriteLine("2.Delete Account");
                System.Console.WriteLine("3.Update Account");
                System.Console.WriteLine("4.View Account");
                System.Console.WriteLine("0.Back to main menu");

                System.Console.Write("enter choice:");
                accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
            } while (accountsMenuChoice != 0);
        }

    }
}
