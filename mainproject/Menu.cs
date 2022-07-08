using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    /// <summary>
    /// Tutaj program pokazuje glowne menu i daje mozliwosc wyboru co sie chce zrobic
    /// </summary>
    class Menu
    {
        private string name;
        private List<Option> option_list = new List<Option>();

        public string Name { get => name; set => name = value; }
        public List<Option> Option_list { get => option_list; set => option_list = value; }


        /// <summary>
        /// Wyświetla informacje na temat użytkownika.
        /// </summary>
        /// <param name=name></param>
        public Menu (string name)

        {
            this.name = name;
        }

        public void add_option(string text, Action function)
        {
            var new_option = new front_end.Option(text, function);
            this.Option_list.Add(new_option);
        }
        /// <summary>
        /// funckja wypisująca listye opcji
        /// </summary>
        public void show()
        {
          
            int nr = 1;
            Console.WriteLine(Name);
            Console.WriteLine("-----------------------------");
            foreach (var opt in Option_list)
            {
                Console.WriteLine(nr + ". " + opt.Text);
                nr++;
            }
            Console.Write("TYPE THE NUMBER: ");
            string choice = Console.ReadLine();
            nr = Convert.ToInt32(choice) - 1;
            Option_list.ElementAt(nr).Function(); //to nie działa
        }
        
    }
}