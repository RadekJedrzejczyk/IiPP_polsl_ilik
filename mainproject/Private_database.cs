using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Private_database
    {/// <summary>
     /// Prywatna baza każdego użytkownika
     /// </summary>
        private string id;
        private List<Airship> airship_list = new List<Airship>();
        private List<Procedure> procedure_list = new List<Procedure>();
        private List<Activity> activity_list = new List<Activity>();

        public Private_database (string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public List <Airship> Airship_list { get => airship_list; set => airship_list = value; }
        public List<Procedure> Procedure_list { get => procedure_list; set => procedure_list = value; }
        public List<Activity> Activity_list { get => activity_list; set => activity_list = value; }
    }
}
