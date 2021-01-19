using System;
using Datalagring_ProjectManager_EFCore.Models;
using static System.Console;

namespace Datalagring_ProjectManager_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Menu();
        }

        static void Menu()
        {
            bool shouldNotExit = true;

            while (shouldNotExit)
            {


                Clear();

                WriteLine("1.Add employee");
                WriteLine("2.List employees");
                WriteLine("3.Lable3");
                WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);


                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:

                        AddEmployee();

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:

                        break;

                    case ConsoleKey.D4:

                        shouldNotExit = false;

                        break;

                }

            }
        }

        private static void AddEmployee()
        {

            Console.WriteLine("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Social security number: ");
            string socialSecurityNumber = Console.ReadLine();



            Console.WriteLine("Clearing nr.: ");
            string clearingNr = Console.ReadLine();
            Console.WriteLine("Account nr.: ");
            string accountNr = Console.ReadLine();
            Console.WriteLine("Bank: ");
            string bank = Console.ReadLine();

            PaymentAccount paymentAccount = new PaymentAccount(clearingNr,accountNr,bank);

            Employee employee = new Employee(firstName,lastName,socialSecurityNumber,paymentAccount);


        }
    }
}
