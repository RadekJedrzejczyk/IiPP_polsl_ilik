using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{/// <summary>
/// Klasa umożliwiające komunikację użytkownika z jego informacjami na back endzie.
/// </summary>
    class Login_assistant
    {
        private readonly back_end.Default_database database;
        private back_end.Pilot logged_user;

        public back_end.Pilot Logged_user { get => logged_user; set => logged_user = value; }
        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="database">Baza danych z której pochodzą informacje</param>
        public Login_assistant (back_end.Default_database database)
        {
            this.database = database;
        }
    /// <summary>
    /// Funkcaj pozwalająca zalogować się użytkownikowi.
    /// </summary>
    /// <param name="if_true">Funkcja która wykona się, jeżeli logowanie się powiedzie.</param>
        public void Login(Action if_true)
        {
           
            string login = Menu_assistant.Ask_for("Login");
            string password = Menu_assistant.Ask_for("Password");
            if (database.Check_logging(login, password) == true)
            {
                foreach (var user in database.Users_list)
                {
                    if (user.Login == login)
                    {
                        if (user.Password == password)
                        {
                            Logged_user = user;
                        }
                    }
                }
                if_true(); 
            }
            return;
        }
        /// <summary>
        /// Funkcja umożliwiająca zarejestrowanie się użytkownikowi.
        /// </summary>
        public void Sign_up()
        {
            string name = Menu_assistant.Ask_for("Name");
            string surname = Menu_assistant.Ask_for("Surname");
            string login = Menu_assistant.Ask_for("Login");
            string password = Menu_assistant.Ask_for("Password");
            string lic_num = Menu_assistant.Ask_for("Legitimation number");
            string legitimation_type= Menu_assistant.Ask_for("Legitimation type");
            if (database.Sign_up_check(login) == true)
            {
                database.Add_to_list(name, surname, lic_num, legitimation_type,login,password);
                Console.WriteLine("Registering complete");
                Console.ReadKey();
                return; 
            }
            Console.WriteLine("Registering error - this user probably already exist");
            Console.ReadKey();
            return; 
        }
        /// <summary>
        /// Funkcja wyświetla wszystkie dane użytkownika.
        /// </summary>
        public void Show_data()
        {
            Logged_user.Who_are_you(true);
            return;
        }
        /// <summary>
        /// Funkcja umożliwia użytkowikowi edycję jego danych.
        /// </summary>
        public void Edit_data()
        {
            var what_to_edit = Menu_assistant.Ask_for("Co chcesz edytować? (name/surname/password/licention number/legitimation type)");
            switch (what_to_edit)
            {   case "name":
                case "Name":
                    Logged_user.Name = Menu_assistant.Ask_for("Name");
                    break;
                case "surname":
                case "Surname":
                    Logged_user.Surname = Menu_assistant.Ask_for("Surname");
                    break;
                case "password":
                case "Password":
                    Logged_user.Password = Menu_assistant.Ask_for("Password");
                    break;
                case "licention number":
                case "Licention number":
                    Logged_user.Licention_number = Menu_assistant.Ask_for("Licention number");
                    break;
                case "legitimation type":
                case "Legitimation type":
                    Logged_user.Legitimation_type = Menu_assistant.Ask_for("Legitimation type");
                    break;
            }
            Console.WriteLine("Edition complete");
            Console.ReadKey();
        }
    }
}
