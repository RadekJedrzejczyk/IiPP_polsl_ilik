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
            Console.WriteLine("Podaj " + text);
            text = Console.ReadLine();
            return text;
        }
    }
}
