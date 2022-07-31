using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{/// <summary>
 /// Klasa opisująca opcje, dodawane do Menu
 /// </summary>
    class Option
    {
        private string text;
        private Action function;
        public string Text { get => text; set => text = value; }
        public Action Function { get => function; set => function = value; }

        /// <summary>
        /// Konstruktor opcji.
        /// </summary>
        /// <param name="text">Treść opisująca opcję, wyświetlana w menu</param>
        /// <param name="input_function">Funkcja uruchamiana przez opcję.</param>
 
        public Option(string text, Action input_function)
        {
            this.text = text;
            this.function = input_function; 


        }

    }
}
