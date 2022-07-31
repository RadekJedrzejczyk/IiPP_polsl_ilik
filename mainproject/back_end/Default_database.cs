using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end

{ /// <summary>
  /// Domyślny typ bazy danych zaiwerająca losty pilotów, statków powietrznych, procedur i możliwych czynności, a także podstawowe funkcjonalności.
  /// </summary>
    class Default_database
    {

        private List<Pilot> users_list = new List<Pilot>();
        private int user_id_count = 0;
        private List<Airship> airship_list = new List<Airship>();
        private List<Procedure> procedure_blocks_list = new List<Procedure>();
        
        public List<Pilot> Users_list { get => users_list; set => users_list = value; }
        public int User_id_count { get => user_id_count; set => user_id_count = value; }
        public List<Airship> Airship_list { get => airship_list; set => airship_list = value; }
        public List<Procedure> Procedure_blocks_list { get => procedure_blocks_list; set => procedure_blocks_list = value; }
        /// <summary>
        /// Funkcja dodająca użytkownika do bazy danych.
        /// </summary>
        /// <param name="name">Imię użytkownika</param>
        /// <param name="surname">Nazwisko użytkownika</param>
        /// <param name="licention_number">Numer licencji pilota</param>
        /// <param name="legitimation_type">Uprawnienia pilota</param>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        public void Add_to_list(string name, string surname, string licention_number, string legitimation_type, string login, string password)
        { 
            var pilot = new Pilot(name, surname, licention_number, legitimation_type, User_id_count, login, password);
            Users_list.Add(pilot);
            User_id_count++;
            Console.WriteLine("Dodano użytkownika do bazy danych");
        }
        /// <summary>
        /// fucncja dodająca statek powietrzny do listy 
        /// </summary>
        /// <param name="airship">Maszyna która zostanie dodana do bazy danych</param>

        public void Add_to_list(Airship airship)
        {
            Airship_list.Add(airship);
        }
        /// <summary>
        /// funcja dodająca procedury do listy
        /// </summary>
        /// <param name="procedure">Procedura, która zostanie dodany do bazy danych</param>
        public void Add_to_list(Procedure procedure)
        {
            Procedure_blocks_list.Add(procedure);
        }
        /// <summary>
        /// funkcja usuwająca z listy pilota
        /// </summary>
        /// <param name="pilot">Użytkownik który zostanie usunięty z bazy danych</param>

        public void Remove_from_list(Pilot pilot)
        {
            Users_list.Remove(pilot);
        }
        /// <summary>
        /// funkcja usuwająca z listy statek powietrzny
        /// </summary>
        /// <param name="airship">Maszyna która zostanie dodana do bazy danych</param> 
        public void Remove_from_list(Airship airship)
        {
            Airship_list.Remove((Airship)airship);
        }
        /// <summary>
        /// funkcja usuwająca z listy procedure
        /// </summary>
        /// <param name="procedure">Procedura, która zostanie usunięta z bazy danych</param>

        public void Remove_from_list(Procedure procedure)
        {
            Procedure_blocks_list.Remove(procedure);
        }
        /// <summary>
        /// Sprawdza czy dany login jest zajęty.
        /// </summary>
        /// <param name="login">Sprawdzany login</param>
        /// <returns>Zwraca false jeśli login jest zajęty i true jeśli jest wolny</returns>
        public bool Sign_up_check(string login)
        {
            foreach (var user in Users_list)
            {
                if (user.Login == login)
                {
                    Console.WriteLine("Ten login jest zajęty");
                    return false;
                }

            }
            return true;
        }
        /// <summary>
        /// Sprawda czy logowanie się powiodło
        /// </summary>
        /// <param name="login">Login podany przez użytkownika</param>
        /// <param name="password">Hasło podane przez użytkownika</param>
        /// <returns>Zwraca true jeśli dane są zgodne z bazą danych i false jeśli nie</returns>
        public bool Check_logging(string login, string password)
        {
            foreach (var user in Users_list)
            {
                if (user.Login == login)
                {
                    if (user.Password == password)
                    {
                        Console.WriteLine("Logowanie się powiodło");
                        return true;
                    }
                }
            }
            Console.WriteLine("Logowanie się nie udało");
            return false;
        }

    }
}
