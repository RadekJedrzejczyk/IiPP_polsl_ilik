using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainproject
{
    /// <summary>
    /// Tutaj program pokazuje glowne menu i daje mozliwosc wyboru co sie chce zrobic
    /// </summary>
    class Menu
    {

        public void Main_menu()
        {

            Console.Write("Witaj Uzytkowniku \n");
            Console.Write("-----------------------------\n");
            Console.Write("1. Log in|Sign up\n");
            Console.Write("2. Anonymous\n");
            Console.Write("TYPE THE NUMBER: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("1.Login as User");
                Console.WriteLine("2.Login as Admin");
                Console.WriteLine("3.Sign up");
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1.Edit user data");
                    Console.WriteLine("2.Check data");
                    Console.WriteLine("3.Download data");
                    Console.WriteLine("4.Account options");
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1.Edit user data");
                    Console.WriteLine("2.Check data");
                    Console.WriteLine("3.Download data");
                    Console.WriteLine("4.Account options");
                    Console.WriteLine("5.Main database menu");
                    Console.WriteLine("6.Log's menu");
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Register function");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("tu bedzie publiczna baza");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadLine();

        }
    }
}
