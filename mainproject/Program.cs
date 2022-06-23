using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mainproject
{
    class Program
    {
        static void Main(string[] args)
        {
            var main_database = new back_end.Default_database();
            var front_assistant = new front_end.Login_assistant(main_database); //obiekt pomocniczy do bardziej zaawansowanych zadań

            main_database.Procedure_blocks_list = back_end.File_assistant.load_procedures("procedury.txt"); //ścieżka do pliku z procedruami

            ///deklaruje różne menu
            var main_menu = new front_end.Menu("Main Menu");
            var log_in_menu = new front_end.Menu("Log in| Sign up");
            var anonymous_menu = new front_end.Menu("Guest");
            var logged_menu = new front_end.Menu("Logged");
            var admin_menu = new front_end.Menu("Admin");
            var main_database_menu = new front_end.Menu("Main Database_assistant Options");
            var main_database_editor = new front_end.Menu("Edit Main Database_assistant");
            var user_database_menu = new front_end.Menu("Private Database_assistant Menu");
            var logs_menu = new front_end.Menu("Logs menu");
        
            ///dodaje różne opcje 
           
            // Symbol '//' w miejscach gdzie trzeba podłączyć funkcje               !!!!!!!

            main_menu.add_option("Log in|Sign up", log_in_menu.show);
            main_menu.add_option("Anonymous", anonymous_menu.show);

            log_in_menu.add_option("logowanie", () => front_assistant.login(logged_menu.show));
            log_in_menu.add_option("Sign in", front_assistant.sign_up);

            anonymous_menu.add_option("Browse public database", main_database.show);

            logged_menu.add_option("Edit your data", main_database.test);//
            logged_menu.add_option("Check your data", main_database.test);//
            logged_menu.add_option("Download data", main_database.test);//
            logged_menu.add_option("Account settings", main_database.test);//
            logged_menu.add_option("Manage your database", user_database_menu.show);
            logged_menu.add_option("Show public database", main_database.show); 
            logged_menu.add_option("Show your database", main_database.test); // 

            user_database_menu.add_option("Add", main_database.test); //nie jestem pewny jak to zrobić
            user_database_menu.add_option("Remove", main_database.test); //
            user_database_menu.add_option("Download", main_database.test); //
            user_database_menu.add_option("Load", main_database.test); //



            admin_menu.add_option("Manage main database", main_database_menu.show);

            main_database_menu.add_option("Download", main_database.test); //
            main_database_menu.add_option("Load", main_database.test); //
            main_database_menu.add_option("Edit", main_database_editor.show);


            main_database_editor.add_option("Add", main_database.test); //
            main_database_editor.add_option("Remove", main_database.test); // 

      
            ///właściwy program 
            main_menu.show();
            Console.ReadKey();
        }
    }
}