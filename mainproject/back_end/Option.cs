using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{/// <summary>
 /// Klasa opisująca opjce, które można wykonać 
 /// </summary>
    class Option
    {
        private string text;
        private Action function;
        public string Text { get => text; set => text = value; }
        public Action Function { get => function; set => function = value; }

        void universal_function() { }
        public Option(string text, Action input_function, bool admin = false)
        {
            this.text = text;
            this.function = input_function; 
            //this.function = universal_function;

        }

    }
}
