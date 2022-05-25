using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Asker
    {
        public string text;
        private string text2;

        public string Text { get => text; set => text = value; }
        public string Text2 { get => text2; set => text2 = value; }

        public string ask_for(string text)
        {
            Console.WriteLine("Podaj "+text);
            text2 = Console.ReadLine();
            return text2; 
            
        }
    }
}
