using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mainproject
{
    ///<summary>
    /// Klasa wywoływania danych funkcji
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var main_database = new back_end.Default_database();
            var front_assistant = new front_end.Login_assistant(main_database); //obiekt zajmujący się front_endem zalogowanego użytkownika
            var database_assistant = new front_end.Database_assistant(main_database);


            main_database.Procedure_blocks_list = back_end.File_assistant.load_procedures("procedury.txt");
            back_end.File_assistant.airship_data(main_database, "cos.txt");

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
            main_menu.add_option("Log in|Sign up", log_in_menu.show);
            main_menu.add_option("Anonymous", anonymous_menu.show);

            log_in_menu.add_option("Log in", () => front_assistant.login(logged_menu.show));
            log_in_menu.add_option("Sign in", front_assistant.sign_up);

            anonymous_menu.add_option("Browse public database", database_assistant.show);

            logged_menu.add_option("Check your data", front_assistant.show_data);
            logged_menu.add_option("Edit your data", front_assistant.edit_data);
            logged_menu.add_option("Download data", () => database_assistant.download(front_assistant.Logged_user, true));
            logged_menu.add_option("Manage your database", user_database_menu.show);
            logged_menu.add_option("Show public database", database_assistant.show);
            logged_menu.add_option("Show your database", () => database_assistant.show_private(front_assistant.Logged_user.Private_database));

            user_database_menu.add_option("Add_airship", () => front_end.Menu_assistant.add_to_private(database_assistant, front_assistant));
            user_database_menu.add_option("Remove_airship", () => front_end.Menu_assistant.delete_from_private(database_assistant, front_assistant));

            admin_menu.add_option("Manage main database", () => { Console.WriteLine("Nothing is here ;)"); Console.ReadKey(); });



            ///uruchomienie
            main_menu.show();
            Console.Clear();
            Console.WriteLine("Koniec pracy programu");
            Console.ReadKey();
        }
    }
}