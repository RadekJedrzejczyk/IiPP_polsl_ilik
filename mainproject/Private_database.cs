using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Private_database:Default_database
    {/// <summary>
     /// Prywatna baza każdego użytkownika
     /// </summary>
        private string id;
        
        public Private_database (string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
   
    }
}
