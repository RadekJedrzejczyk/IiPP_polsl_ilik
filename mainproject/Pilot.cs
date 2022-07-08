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
        private string user_id;
        private List<Airship> available_airship_list = new List<Airship>();
        /// <summary>
        /// funkcja dopisujaca zawy imienia i nazwiska numerlicencji rodzaj legitymacji numer urzytkownika i hasło
        /// </summary>
        public Pilot(string name, string surname, string licention_number, string legitimation_type, int user_id_count, string login, string password)
        {
            this.name = name;
            this.surname = surname;
            this.licention_number = licention_number;
            this.legitimation_type = legitimation_type;
            this.user_id = Convert.ToString(user_id_count);
            Private_database private_database = new Private_database(user_id);
            this.login = login;
            this.password = password;
            
        }

        /// <summary>
        /// Wyświetla informacje na temat użytkownika.
        /// </summary>
        /// <param name="admin"> Jeżeli 'true' wyswietla również dane poufne</param>
        public void who_are_you(bool admin = false)
        { 
        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname=value; }
        public string Licention_number { get => licention_number; set => licention_number = value; }
        public string Legitimation_type { get => legitimation_type; set => legitimation_type = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string User_id { get => user_id; }
    }
}
