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
        protected List<Airship> airship_list = new List<Airship>();
        protected List<Procedure> procedure_blocks_list = new List<Procedure>();
        protected List<Activity> activity_blocks_list = new List<Activity>();
        /// <summary>
        /// testowa fukncja wypisująca
        /// </summary>
        public void test()
        {
            Console.WriteLine("testowy komunikat");
        }

        /// <summary>
        /// fukcja przypisująca dane do listy pilotów
        /// </summary>
        public void add_to_list(string name, string surname, string licention_number, string legitimation_type, string login, string password)
        {  
            var pilot = new Pilot(name, surname, licention_number, legitimation_type, user_id_count, login, password);
            users_list.Add(pilot);
            user_id_count++;
            Console.WriteLine("Dodano użytkownika do bazy danych");
        }
    /// <summary>
    /// fucncja dodająca statek powietrzny do listy 
    /// </summary>
    public void add_to_list(Airship airship)
        {
            airship_list.Add(airship);
        }
    /// <summary>
    /// funcja dodająca procedury do listy
    /// </summary>
    public void add_to_list(Procedure procedure)
        {
            procedure_blocks_list.Add(procedure);
        }
    /// <summary>
    /// funcja dodająca czynnosci do listy
    /// </summary>
    public void add_to_list(Activity activity)
        {
            activity_blocks_list.Add((Activity)activity);
        }
    /// <summary>
    /// funkcja usuwająca z listy pilota
    /// </summary>
    public void remove_from_list(Pilot pilot)
        {
            users_list.Remove(pilot);
        }
    /// <summary>
    /// funkcja usuwająca z listy statek powietrzny
    /// </summary>
    public void remove_from_list(Airship airship)
        {
            airship_list.Remove((Airship)airship);
        }
    /// <summary>
    /// funkcja usuwająca z listy procedure
    /// </summary>
    public void remove_from_list(Procedure procedure)
        {
            procedure_blocks_list.Remove(procedure);
        }
    /// <summary>
    /// funkcja usuwająca z listy czynnosc
    /// </summary>
    public void remove_from_list(Activity activity)
        {
            activity_blocks_list.Remove(activity);

        }
    /// <summary>
    /// funkcja wyszukująca pilota
    /// </summary>
    public List<Pilot> search_user(string id, bool adv = false)
        {
            var founded = new List<Pilot>();
            if (adv == true)
            {

                return founded;
            }
            else
            {
                foreach (var person in users_list)
                {
                    if (person.User_id == id)
                    {
                        Console.WriteLine("Znaleziono");
                        return founded;
                    }
                }
                return founded;
            }
        }

        public void search_airship(string name, bool adv = false)
        {

        }
        /// <summary>
        /// Sprawdza czy dany login już istnieje.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool sign_up_check(string login)
        {
            foreach (var user in users_list)
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
        /// Sprawdza czy logowanie się powiodło.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool check_logging(string login, string password)
        {
            foreach (var user in users_list)
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



        //   public Pilot search(string nazwisko)
        //   { 

        //    }

    }
}
