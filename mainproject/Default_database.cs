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
        protected List<Airship> airship_list = new List<Airship>();
        protected List<Procedure> procedure_blocks_list = new List<Procedure>();
        protected List<Activity> activity_blocks_list = new List<Activity>();

        public void add_to_list(Pilot pilot)
        { 

        }

        public void add_to_list(Airship airship)
        {

        }

        public void add_to_list(Procedure procedure)
        {

        }

        public void add_to_list(Activity activity)
        {

        }

        public void remove_to_list(Pilot pilot)
        { 

        }

        public void remove_to_list(Airship airship)
        {

        }

        public void remove_to_list(Procedure procedure)
        {

        }

        public void remove_to_list(Activity activity)
        {

        }

        public void search(Pilot pilot)
        {

        }

        public void search(Airship airship)
        {

        }

    }
}
