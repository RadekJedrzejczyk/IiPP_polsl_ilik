using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{/// <summary>
 /// Klasa pomagająca w logowaniu 
 /// </summary>
    class Login_assistant
    {
        private back_end.Default_database database;

        public Login_assistant (back_end.Default_database database)
        {
            this.database = database;
        }/// <summary>
         /// funkcja pytajaca 
         /// </summary>
        public string ask_for(string text)
        {
            Console.WriteLine("Podaj " + text);
            text = Console.ReadLine();
            return text;

        }
        /// <summary>
        ///fucncja prosząca o login i hasło do niego przypisana
        /// </summary>
        public void login()
        {
            var question = new front_end.Login_assistant(database);

            string login = question.ask_for("login");
            string password = question.ask_for("hasło");
            if (database.check_logging(login, password) == true)
            {
                return; //tutaj powinien wysyłać do odpowiedniego menu
            }
            return; // coś powinien robić
        }
        /// <summary>
        /// funcja pomagająca w rejestracji pytająca o imie,nazwisko,login ,hasło ,nr licencji,typ legitymacji
        /// </summary>
        public void sign_up()
        {
            var question = new front_end.Login_assistant(database);
            string name = question.ask_for("imie");
            string surname = question.ask_for("nazwisko");
            string login = question.ask_for("login");
            string password = question.ask_for("hasło");
            string lic_num = question.ask_for("numer licencji");
            string legitimation_type= question.ask_for("typ legitymacji");
            if (database.sign_up_check(login) == true)
            {//tworzy użytkownika
                database.add_to_list(name, surname, lic_num, legitimation_type,login,password);
                return; 
            }
            return; // coś powinien robić
            

        }
    }
}
