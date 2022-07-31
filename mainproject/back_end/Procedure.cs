using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{        /// <summary>
         /// Klasa opisująca procedurę.
         /// </summary>
    class Procedure
    {

        private string action;
        private List<string> activity_list = new List<string>();

        public string Action { get => action; set => action = value; }
        public List<string> Activity_list { get => activity_list; set => activity_list = value; } //lista czynności wewnątrz procedury
        /// <summary>
        /// Konstruktor procedury.
        /// </summary>
        /// <param name="action">Nazwa procedury</param>
        public Procedure(string action)
        {
            this.action = action;

        }

        /// <summary>
        /// Funkcja wyświetla listę kolejnych czynności, które zawiera procedura
        /// </summary>
        public void Show()
        {
            int i = 1;
            Console.WriteLine(this.Action);
            foreach (var act in Activity_list)
            {
                Console.WriteLine(i + ". " + act);
                i++;
            }
        }
    }
}
