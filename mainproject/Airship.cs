using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{/// <summary>
 /// Klasa opisująca statek powietrzny nazwe typ potrzebne wymagania i liste procedur
 /// </summary>
    class Airship
    {/// <summary>
     ///deklarowanie zmiennych i list
     /// </summary>
        private string name;
        private string type;
        private string required_legitimation;
        private List<Procedure>procedure_list=new List<Procedure>();
    }
}
