﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{/// <summary>
 /// Prywatna baza danych, dostępna dla danego użytkownika. 
 /// </summary>
    class Private_database :Default_database
    {
        private string id;
        
        public Private_database (string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
   
    }
}
