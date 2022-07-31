using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{      /// <summary>
       /// Podstawowa klasa opisująca użytkownika i jego uprawnienia.
       /// </summary>
    class Pilot
    {
   
        private string name;
        private string surname;
        private string licention_number;
        private string legitimation_type;
        private string login;
        private string password;
        private readonly string user_id;
        private Private_database private_database = new Private_database("0");
        /// <summary>
        /// Konstruktor Pilota.
        /// </summary>
        /// <param name="name">Imię użytkownika</param>
        /// <param name="surname">Nazwisko użytkownika</param>
        /// <param name="licention_number">Numer licencji pilota</param>
        /// <param name="legitimation_type">Uprawnienia pilota</param>
        /// <param name="user_id_count">Id przypisane do użytkownika</param>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        public Pilot(string name, string surname, string licention_number, string legitimation_type, int user_id_count, string login, string password)
        {
            this.name = name;
            this.surname = surname;
            this.licention_number = licention_number;
            this.legitimation_type = legitimation_type;
            this.user_id = Convert.ToString(user_id_count);
            this.private_database.Id = user_id;
            this.login = login;
            this.password = password;
            
        }

        /// <summary>
        /// Wyświetla informacje na temat użytkownika.
        /// </summary>
        /// <param name="admin"> Jeżeli 'true' wyswietla również dane poufne</param>
        public void Who_are_you(bool admin = false)
        {
            Console.WriteLine(Name + Surname + ", licention number: " + Licention_number + ". Legitimation type: " + Legitimation_type + ".");
            if (admin == true) Console.WriteLine ("User_id: " + User_id+ ". Login: "+ Login+". Password: "+ Password+ ".");
            Console.ReadKey();
        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname=value; }
        public string Licention_number { get => licention_number; set => licention_number = value; }
        public string Legitimation_type { get => legitimation_type; set => legitimation_type = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string User_id { get => user_id; }
        public Private_database Private_database { get => private_database; set => private_database = value; }
    }
}
