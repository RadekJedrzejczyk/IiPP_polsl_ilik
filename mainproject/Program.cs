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
            var database = new back_end.Default_database();
            database.test(); //to przypisujcie jak nie wiecie co robić - database.test;

            var logger = new front_end.Login_assistant();
            var signup = new front_end.Login_assistant();

            ///deklaruje różne menu
            var main_menu = new front_end.Menu("Main Menu");
            var log_in_menu = new front_end.Menu("Log in| Sign up");
            var anonymous_menu = new front_end.Menu("Guest");

            ///dodaje różne opcje
            main_menu.add_option("Log in|Sign up", log_in_menu.show);
            main_menu.add_option("Anonymous", anonymous_menu.show);

            log_in_menu.add_option("Log in", logger.login);
            log_in_menu.add_option("Sign in", signup.sign_up);

            ///właściwy program 
            main_menu.show();
            Console.ReadKey();
        }
    }
}