using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Køen
{
    class GUI
    {
        Logic logic = new Logic();
        Guest guest = new Guest();
        string userinput;
        public void Main()
        {
            Console.WriteLine("1. Add Guest");
            Console.WriteLine("2. Delete Guest");
            Console.WriteLine("3. Show number of guest");
            Console.WriteLine("4. Show max number of guest");
            Console.WriteLine("5. Find Guest");
            Console.WriteLine("6. Find All");
            Console.WriteLine("7. Exit");
        }
        public void SelectionMenu()
        {
            while (true)
            {
                Main();
                userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(logic.AddGuest(Console.ReadLine(), int.Parse(Console.ReadLine())));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(logic.DeleteGuest());
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(logic.ShowNumberOfGuest());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine($"Max is: {guest.MaxLimit}");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(logic.FindItem());
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine(logic.ShowAll());
                        Console.ReadKey();
                        break;
                    case "7":
                        Environment.Exit(1);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
