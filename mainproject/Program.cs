using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainproject
{/// <summary>
 /// Klasa wywoływania danych funkcji
 /// </summary>
    class Program
    {
        static void Main(string[] args)
        {   
            var database = new back_end.Default_database();

            database.test(); //to przypisujcie jak nie wiecie co robić - database.test;

            var front_assistant = new front_end.Login_assistant(database); //obiekt pomocniczy do bardziej zaawansowanych zadań

            ///deklaruje różne menu
            var main_menu = new front_end.Menu("Main Menu");
            var log_in_menu = new front_end.Menu("Log in| Sign up");
            var anonymous_menu = new front_end.Menu("Guest");
            var logged_menu = new front_end.Menu("Logged");
            var admin_menu = new front_end.Menu("Admin");
            var main_database_menu = new front_end.Menu("Main Database Options");
            var main_database_editor = new front_end.Menu("Edit Main Database");
            var user_database_menu = new front_end.Menu("Private Database Menu");
            var logs_menu = new front_end.Menu("Logs menu");
        


            ///dodaje różne opcje
            main_menu.add_option("Log in|Sign up", log_in_menu.show);
            main_menu.add_option("Anonymous", anonymous_menu.show);

            log_in_menu.add_option("Log in", front_assistant.login);
            log_in_menu.add_option("Sign in", front_assistant.sign_up);

            anonymous_menu.add_option("Browse public database", database.test);

            logged_menu.add_option("Edit your data", database.test);
            logged_menu.add_option("Check your data", database.test);
            logged_menu.add_option("Download data", database.test);
            logged_menu.add_option("Account settings", database.test);
            logged_menu.add_option("Manage your database", user_database_menu.show);
            logged_menu.add_option("Show public database", database.test); 
            logged_menu.add_option("Show your database", database.test); 

            admin_menu.add_option("Manage main database", main_database_menu.show);
            admin_menu.add_option("Show logs", logs_menu.show);

            logs_menu.add_option("Read", database.test);
            logs_menu.add_option("Add", database.test);
            logs_menu.add_option("Remove", database.test);
            logs_menu.add_option("Download", database.test);

            main_database_menu.add_option("Download", database.test);
            main_database_menu.add_option("Load", database.test);
            main_database_menu.add_option("Edit", main_database_editor.show);

            main_database_editor.add_option("Add", database.test);
            main_database_editor.add_option("Remove", database.test);

            user_database_menu.add_option("Add", database.test); //nie jestem pewny jak to zrobić
            user_database_menu.add_option("Remove", database.test);
            user_database_menu.add_option("Download", database.test);
            user_database_menu.add_option("Load", database.test);


            ///właściwy program 
            main_menu.show();
            Console.ReadKey();
        }
    }
}