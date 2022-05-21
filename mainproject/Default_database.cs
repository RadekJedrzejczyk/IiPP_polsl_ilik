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
            users_list.Add(pilot);

        }

        public void add_to_list(Airship airship)
        {
            airship_list.Add(airship);
        }

        public void add_to_list(Procedure procedure)
        {
            procedure_blocks_list.Add(procedure);
        }

        public void add_to_list(Activity activity)
        {
            activity_blocks_list.Add((Activity)activity);
        }

        public void remove_to_list(Pilot pilot)
        { 
            users_list.Remove(pilot);
        }

        public void remove_to_list(Airship airship)
        {
       airship_list.Remove((Airship)airship);
        }

        public void remove_to_list(Procedure procedure)
        {
            procedure_blocks_list.Remove(procedure);
        }

        public void remove_to_list(Activity activity)
        {
            activity_blocks_list.Remove(activity);
        }
        public Pilot search(string nazwisko)
        { 
         for(int i=0; i<users_list.Count();i++)
            {

            }
              return users_list[0];
        }
    }
}
