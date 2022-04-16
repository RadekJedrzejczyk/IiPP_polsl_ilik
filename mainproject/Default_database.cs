using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end

{
    class Default_database
    {
        /// <summary>
        /// Domyślna baza danych, dostępna dla każdego, zawierająca oficjalne dane
        /// </summary>
        private List<Pilot> users_list = new List<Pilot>();
        private List<Airship> airship_list = new List<Airship>();
        private List<Procedure> procedure_list = new List<Procedure>();
        private List<Activity> activity_list = new List<Activity>();

        public Default_database(string path)
        {
            ///wczytuje dane ze ścieżki i wpisuje
        }

    }
}
