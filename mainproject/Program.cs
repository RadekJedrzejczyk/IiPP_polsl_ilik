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
            ///deklaruje różne menu
            var main_menu = new front_end.Menu("Main Menu");
            var log_in_menu = new front_end.Menu("Log in| Sign up");
            var anonymous_menu = new front_end.Menu("Guest");

            ///deklaruje różne opcje
            var log_in = new front_end.Option("Log in|Sign up", log_in_menu.show);
            var anonymous = new front_end.Option("Anonymous", anonymous_menu.show);

            ///dodaje opcje do menu 
            main_menu.Option_list.Add(log_in);
            main_menu.Option_list.Add(anonymous);

            ///właściwy program 
            main_menu.show();

        }
    }
}
