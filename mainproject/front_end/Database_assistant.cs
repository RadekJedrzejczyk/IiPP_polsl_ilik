using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{/// <summary>
/// Klasa łącząca back_end baz danych z front_endem widocznym przez użytkownika.
/// </summary>
    class Database_assistant
    {
        private back_end.Default_database database = new back_end.Default_database();

        internal back_end.Default_database Database { get => database; set => database = value; }
        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="database">Baza danych na której operują funkcje klasy.</param>
        public Database_assistant(back_end.Default_database database)
        {
            this.database = database;
        }
        /// <summary>
        /// Umożliwia użytkownikowi dodanie maszyny do bazy danych. 
        /// </summary>
        public void Add_airship()
        {
            var name = Menu_assistant.Ask_for("airship name");
            var type = Menu_assistant.Ask_for("airship type");
            var leg = Menu_assistant.Ask_for("requiered legitimation");
            back_end.Airship air = new back_end.Airship(name, type, leg);
            database.Add_to_list(air);

            Console.WriteLine("Do you want to add procedures? (y/n)");
            var procedures = Console.ReadLine();
            if (procedures == "y")
            {
                Console.WriteLine("Sorry, we didn't support this at the moment");
                Console.ReadKey();
            }
            return;
        }
        /// <summary>
        /// Umożliwia użytkownikowi usunięcie maszyny z bazy danych.
        /// </summary>
        public void Delete()
        {
            int Nr = 1;
            foreach (var airship in database.Airship_list)
            {
                Console.WriteLine(Nr + airship.Name);
            }
            var num = Menu_assistant.Ask_for("which one (number on the list)");

            database.Remove_from_list(database.Airship_list.ElementAt(Convert.ToInt32(num) - 1));
            Console.WriteLine("Complete");
            Console.ReadKey();
        }
        /// <summary>
        /// Umożliwia użytkownikowi ściągniecie baz danych, w tym maszyn.
        /// </summary>
        /// <param name="logged_user">Zalogowny użytkownik, który pobiera dane</param>
        /// <param name="private_database">Określa czy zapisać prywatną bazę danych</param>

        public void Download(back_end.Pilot logged_user, bool private_database = false)
        {
            Console.WriteLine("Where to save the file with public database?");
            var save_location = Console.ReadLine();
            back_end.File_assistant.Save_airship_database(database, save_location);

            if (private_database == true)
            {
                Console.WriteLine("Where to save the file with your data?");
                save_location = Console.ReadLine();
                var data_list = new List<string>
                {
                    "Name: " + logged_user.Name,
                    "Surname: " + logged_user.Surname,
                    "Licention number: " + logged_user.Licention_number,
                    "legitimation type: " + logged_user.Legitimation_type,
                    "User_id: " + logged_user.User_id,
                    "Login: " + logged_user.Login,
                    "Password: **********"
                };

                back_end.File_assistant.Save(data_list, save_location);

                Console.WriteLine("Where to save the file with your private database?");
                save_location = Console.ReadLine();
                back_end.File_assistant.Save_airship_database(logged_user.Private_database, save_location);


            }

            return;
        }


        /// <summary>
        /// Wyświetla prywatną bazę danych.
        /// </summary>
        /// <param name="database_priv">Prywatna baza dancyh do wyświetlenia.</param>
        public void Show_private(back_end.Default_database database_priv)
        {
            var buf = database;
            database = database_priv;
            Show();
            database = buf;

        }
        /// <summary>
        /// Umożliwia użytkownikowi wyświetlenie listy maszyn oraz opcjonalnie przypisanych im procedur. 
        /// </summary>
        public void Show()
        {
            int i = 1;
            Console.WriteLine("Oto lista maszyn:");
            foreach (var plane in database.Airship_list)
            {
                Console.WriteLine(i + ". " + plane.Name);
                i++;
            }

            Console.WriteLine("Czy chcesz zobaczyć listę procedur i dodatkowe informacje dla konkretnej maszyny? t/n");
            string decision;
            decision = Console.ReadLine();

            if (decision == "t")
            {
                Console.WriteLine("Dla której? (Podaj numer)");
                i = Convert.ToInt32(Console.ReadLine());
                var plane = database.Airship_list.ElementAt(i - 1);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Model: " + plane.Name);
                Console.WriteLine("Typ statku powietrznego: " + plane.Type);
                Console.WriteLine("Wymagane uprawnienia: " + plane.Required_legitimation);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Procedury: ");
                foreach (var proc in plane.Procedure_list)
                {
                    Console.WriteLine("");
                    Console.WriteLine(proc.Action + ": ");
                    Console.WriteLine("");
                    i = 1;
                    foreach (var act in proc.Activity_list)
                    {
                        Console.WriteLine(i + ". " + act);
                        i++;
                    }
                }
                Console.ReadKey();
            }
            return;
        }
    }
}