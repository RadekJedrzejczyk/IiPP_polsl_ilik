using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{/// <summary>
 /// Klasa opisująca statek powietrzny
 /// </summary>
    class Airship
    {
        private string name;
        private string type;
        private string required_legitimation;
        private List<Procedure>procedure_list=new List<Procedure>();

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Required_legitimation { get => required_legitimation; set => required_legitimation = value; }
        public List<Procedure> Procedure_list { get => procedure_list; set => procedure_list = value; }
    }
}
