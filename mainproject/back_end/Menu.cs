using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    /// <summary>
    ///Klasa odpowiedzialna za tworzenie i wyświetlanie podstawowego menu.
    /// </summary>
    class Menu
    {
        private string name;
        private List<Option> option_list = new List<Option>();

        public string Name { get => name; set => name = value; }
        public List<Option> Option_list { get => option_list; set => option_list = value; }


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Nazwa menu</param>
        public Menu (string name)

        {
            this.name = name;
        }
        /// <summary>
        /// Funkcja dodaje opcje do menu
        /// </summary>
        /// <param name="text">Wyswietlana nazwa</param>
        /// <param name="function">Funkcja którą uruchamia opcja</param>
        public void Add_option(string text, Action function)
        {
            var new_option = new front_end.Option(text, function);
            this.Option_list.Add(new_option);
        }
        /// <summary>
        /// Funkcja wyświetla liste opcji.
        /// </summary>
        public void Show()
        {
            while (true)
            {
                int nr = 1;
                Console.WriteLine();
                Console.WriteLine(Name);
                Console.WriteLine("-----------------------------");
                foreach (var opt in Option_list)
                {
                    Console.WriteLine(nr + ". " + opt.Text);
                    nr++;
                }
                Console.WriteLine(0 + ". " +" Go back");
                Console.Write("TYPE THE NUMBER: ");
                string choice = Console.ReadLine();
                nr = Convert.ToInt32(choice);
                if (nr == 0) break;
                Console.WriteLine();
                Option_list.ElementAt(nr-1).Function();
                Console.Clear();
            }
        
        }
    }
}
