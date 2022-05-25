using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Option
    {
        private string text;
        private Action function;
        public string Text { get => text; set => text = value; }
        public Action Function { get => function; set => function = value; }

        public Option(string text, Action function)
        {
            this.text = text;
            this.function = function; //idk czy dobrze (raczej źle)
        }
    }
}