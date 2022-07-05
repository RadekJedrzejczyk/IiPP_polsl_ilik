using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Database_assistant
    {
        private back_end.Default_database database;
        public Database_assistant(back_end.Default_database database)
        {
            this.database = database;
        }
        public void add_airship()
        {
          var name =  Menu_assistant.ask_for("airship name");
          var type =  Menu_assistant.ask_for("airship type");
          var leg =  Menu_assistant.ask_for("requiered legitimation");
           database.add_to_list(new back_end.Airship(name, type, leg));

            Console.WriteLine("Do you want to add procedures? (y/n)");
            var procedures = Console.ReadLine();
            if (procedures == "y")
            {
                Console.WriteLine("Sorry, we didn't support this at the moment");
                Console.ReadKey();
            }
            return;
        }

        public void delete() {
            int Nr = 1;
            foreach (var airship in database.Airship_list)
            {
                Console.WriteLine(Nr + airship.Name);
            }
            var num = Menu_assistant.ask_for("which one (number on the list)");

            database.remove_from_list(database.Airship_list.ElementAt(Convert.ToInt32(num) - 1));
            Console.WriteLine("Complete");
            Console.ReadKey();
        }


        public void download(back_end.Pilot logged_user, bool private_database = false)
        {
            Console.WriteLine("Where to save the file with public database?");
            var save_location = Console.ReadLine();
            back_end.File_assistant.save_airship_database(database, save_location);

            if (private_database == true) { 
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

                back_end.File_assistant.save(data_list, save_location);

                Console.WriteLine("Where to save the file with your private database?");
                save_location = Console.ReadLine();
                back_end.File_assistant.save_airship_database(logged_user.Private_database, save_location);

                
             }

        return;
        }

      

        public void show_private (back_end.Default_database database_priv)
        {
            var buf = database;
            database = database_priv;
            show();
            database = buf;

        }
        public void show()
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
                Console.WriteLine("Model: " + plane.Name + "Typ statku powietrznego: " + plane.Type + "Wymagane uprawnienia: " + plane.Required_legitimation);
                Console.WriteLine("Procedury: ");
                foreach (var proc in plane.Procedure_list)
                {
                    Console.WriteLine(proc.Action + ": ");
                    foreach (var act in proc.Activity_list)
                    {
                        i = 1;
                        Console.WriteLine(i + ". " + act);
                    }
                }
            }
            return;
        }
    }
}
