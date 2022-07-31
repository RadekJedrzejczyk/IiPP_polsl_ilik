using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{/// <summary>
/// Klasa wspomagająca funkcje menu.
/// </summary>
    class Menu_assistant
    {
        /// <summary>
        /// Funkcja prosząca użytkownika o podanie jakiejś danej
        /// </summary>
        /// <param name="text">Treść o podanie której prosi funkcja </param>
        /// <returns>Zwraca to co podał użytkownik</returns>
        static public string Ask_for(string text)
        {
            Console.WriteLine("Enter " + text);
            text = Console.ReadLine();
            return text;
        }
        /// <summary>
        /// Funkcja umożliwia dodanie maszyny do prywatnej bazy danych z użyciem istniejącego assystenta bazy danych.
        /// </summary>
        /// <param name="database_assistant">Używany asystent</param>
        /// <param name="front_assistant">Login_assistant w którym zalogowany jest użytkownik</param>
        static public void Add_to_private(front_end.Database_assistant database_assistant, front_end.Login_assistant front_assistant)
        {
            var buf_database = database_assistant.Database;
            database_assistant.Database = front_assistant.Logged_user.Private_database;
            database_assistant.Add_airship();
            database_assistant.Database = buf_database;
        }
        /// <summary>
        /// Funkcja umożliwia usunięcie maszyny z prywatnej bazy danych z użyciem istniejącego assystenta bazy danych.
        /// </summary>
        /// <param name="database_assistant">Używany asystent</param>
        /// <param name="front_assistant">Login_assistant w którym zalogowany jest użytkownik</param>
        static public void Delete_from_private(front_end.Database_assistant database_assistant, front_end.Login_assistant front_assistant)
        {
            var buf_database = database_assistant.Database;
            database_assistant.Database = front_assistant.Logged_user.Private_database;
            database_assistant.Delete();
            database_assistant.Database = buf_database;
        }
    }
}
