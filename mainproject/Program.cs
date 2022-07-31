using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mainproject
{
    ///<summary>
    /// Główny program
    /// </summary>
    class Program
    {
        static void Main()
        {
            var main_database = new back_end.Default_database();
            var front_assistant = new front_end.Login_assistant(main_database);
            var database_assistant = new front_end.Database_assistant(main_database);

            //wczytywanie baz danych z pliku 
            main_database.Procedure_blocks_list = back_end.File_assistant.Load_procedures("procedury.txt");
            back_end.File_assistant.Airship_data(main_database, "maszyny.txt");

            //deklaruje różne menu
            var main_menu = new front_end.Menu("Main Menu");
            var log_in_menu = new front_end.Menu("Log in| Sign up");
            var anonymous_menu = new front_end.Menu("Guest");
            var logged_menu = new front_end.Menu("Logged");
            var admin_menu = new front_end.Menu("Admin");
            var user_database_menu = new front_end.Menu("Private Database Assistant Menu");


            //dodaje różne opcje 
            main_menu.Add_option("Log in|Sign up", log_in_menu.Show);
            main_menu.Add_option("Anonymous", anonymous_menu.Show);

            log_in_menu.Add_option("Log in", () => front_assistant.Login(logged_menu.Show));
            log_in_menu.Add_option("Sign in", front_assistant.Sign_up);

            anonymous_menu.Add_option("Browse public database", database_assistant.Show);

            logged_menu.Add_option("Check your data", front_assistant.Show_data);
            logged_menu.Add_option("Edit your data", front_assistant.Edit_data);
            logged_menu.Add_option("Download data", () => database_assistant.Download(front_assistant.Logged_user, true));
            logged_menu.Add_option("Manage your database", user_database_menu.Show);
            logged_menu.Add_option("Show public database", database_assistant.Show);
            logged_menu.Add_option("Show your database", () => database_assistant.Show_private(front_assistant.Logged_user.Private_database));

            user_database_menu.Add_option("Add_airship", () => front_end.Menu_assistant.Add_to_private(database_assistant, front_assistant));
            user_database_menu.Add_option("Remove_airship", () => front_end.Menu_assistant.Delete_from_private(database_assistant, front_assistant));

            admin_menu.Add_option("Manage main database", () => { Console.WriteLine("Nothing is here ;)"); Console.ReadKey(); });



            //uruchomienie
            main_menu.Show();
            Console.Clear();
            Console.WriteLine("Koniec pracy programu");
            Console.ReadKey();
        }
    }
}