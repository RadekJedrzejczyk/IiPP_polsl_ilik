using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Menu_assistant
    {
        static public string ask_for(string text)
        {
            Console.WriteLine("Enter " + text);
            text = Console.ReadLine();
            return text;
        }
        static public void add_to_private(front_end.Database_assistant database_assistant, front_end.Login_assistant front_assistant)
        {
            var buf_database = database_assistant.Database;
            database_assistant.Database = front_assistant.Logged_user.Private_database;
            database_assistant.add_airship();
            database_assistant.Database = buf_database;
        }
        static public void delete_from_private(front_end.Database_assistant database_assistant, front_end.Login_assistant front_assistant)
        {
            var buf_database = database_assistant.Database;
            database_assistant.Database = front_assistant.Logged_user.Private_database;
            database_assistant.delete();
            database_assistant.Database = buf_database;
        }
    }
}
