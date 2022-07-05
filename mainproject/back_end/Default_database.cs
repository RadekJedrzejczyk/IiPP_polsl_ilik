using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end

{ /// <summary>
  /// Domyślna baza danych zaiwerająca losty pilotów, statków powietrznych, procedur i możliwych czynności, a także podstawowe funkcjonalności.
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


        public void test()
        {
            Console.WriteLine("testowy komunikat");
        }
        public void add_to_list(string name, string surname, string licention_number, string legitimation_type, string login, string password)
        { 
            var pilot = new Pilot(name, surname, licention_number, legitimation_type, User_id_count, login, password);
            Users_list.Add(pilot);
            User_id_count++;
            Console.WriteLine("Dodano użytkownika do bazy danych");
        }


        public void add_to_list(Airship airship)
        {
            Airship_list.Add(airship);
        }

        public void add_to_list(Procedure procedure)
        {
            Procedure_blocks_list.Add(procedure);
        }


        public void remove_from_list(Pilot pilot)
        {
            Users_list.Remove(pilot);
        }

        public void remove_from_list(Airship airship)
        {
            Airship_list.Remove((Airship)airship);
        }

        public void remove_from_list(Procedure procedure)
        {
            Procedure_blocks_list.Remove(procedure);
        }
        /// <summary>
        /// Sprawdza czy dany login już istnieje.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool sign_up_check(string login)
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
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool check_logging(string login, string password)
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
