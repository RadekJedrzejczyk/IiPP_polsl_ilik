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
        private back_end.Pilot logged_user;

        public back_end.Pilot Logged_user { get => logged_user; set => logged_user = value; }

        public Login_assistant (back_end.Default_database database)
        {
            this.database = database;
        }
    
        public void login(Action if_true)
        {
           
            string login = Menu_assistant.ask_for("Login");
            string password = Menu_assistant.ask_for("Password");
            if (database.check_logging(login, password) == true)
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

        public void sign_up()
        {
            string name = Menu_assistant.ask_for("Name");
            string surname = Menu_assistant.ask_for("Surname");
            string login = Menu_assistant.ask_for("Login");
            string password = Menu_assistant.ask_for("Password");
            string lic_num = Menu_assistant.ask_for("Legitimation number");
            string legitimation_type= Menu_assistant.ask_for("Legitimation type");
            if (database.sign_up_check(login) == true)
            {
                database.add_to_list(name, surname, lic_num, legitimation_type,login,password);
                Console.WriteLine("Registering complete");
                Console.ReadKey();
                return; 
            }
            Console.WriteLine("Registering error - this user probably already exist");
            Console.ReadKey();
            return; 
        }

        public void show_data()
        {
            Logged_user.who_are_you(true);
            return;
        }

        public void edit_data()
        {
            var what_to_edit = Menu_assistant.ask_for("Co chcesz edytować? (name/surname/password/licention number/legitimation type)");
            switch (what_to_edit)
            {   case "name":
                case "Name":
                    Logged_user.Name = Menu_assistant.ask_for("Name");
                    break;
                case "surname":
                case "Surname":
                    Logged_user.Surname = Menu_assistant.ask_for("Surname");
                    break;
                case "password":
                case "Password":
                    Logged_user.Password = Menu_assistant.ask_for("Password");
                    break;
                case "licention number":
                case "Licention number":
                    Logged_user.Licention_number = Menu_assistant.ask_for("Licention number");
                    break;
                case "legitimation type":
                case "Legitimation type":
                    Logged_user.Legitimation_type = Menu_assistant.ask_for("Legitimation type");
                    break;
            }
            Console.WriteLine("Edition complete");
            Console.ReadKey();
        }
    }
}
