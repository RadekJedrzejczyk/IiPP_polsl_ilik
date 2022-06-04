using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Login_assistant
    {
        private back_end.Default_database database;

        public Login_assistant (back_end.Default_database database)
        {
            this.database = database;
        }
    
        public void login(Action if_true)
        {
           
            string login = Menu_assistant.ask_for("login");
            string password = Menu_assistant.ask_for("hasło");
            if (database.check_logging(login, password) == true)
            {
                if_true(); 
            }
            return; // coś powinien robić
        }

        public void sign_up()
        {
            string name = Menu_assistant.ask_for("imie");
            string surname = Menu_assistant.ask_for("nazwisko");
            string login = Menu_assistant.ask_for("login");
            string password = Menu_assistant.ask_for("hasło");
            string lic_num = Menu_assistant.ask_for("numer licencji");
            string legitimation_type= Menu_assistant.ask_for("typ legitymacji");
            if (database.sign_up_check(login) == true)
            {
                database.add_to_list(name, surname, lic_num, legitimation_type,login,password);
                return; 
            }
            Console.WriteLine("Taki użytkownik już istnieje");
            Console.ReadKey();
            return; // coś powinien robić
            

        }
    }
}
