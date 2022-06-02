﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{        /// <summary>
         /// Klasa z listą zawierającą różnego rodzaju procedury. 
         /// </summary>
    class Procedure
    {

        private string action;
        private List<Activity> activity_list = new List<Activity>();

        public string Action { get => action; set => action = value; }
        public List<Activity> Activity_list { get => activity_list; set => activity_list = value; }

        /// <summary>
        /// Funkcja wyświetla listę kolejnych czynności, które trzeba wykonać
        /// </summary>
        public void show()
        { int i = 1;
            Console.WriteLine(this.Action);
            foreach (var act in Activity_list)
                    {
                Console.WriteLine(i + ". " + act.What_to_do);
                i++;
            }
        }
        /// <summary>
        /// Funkcja pozwalająca na wczytanie listy czynności z pliku.
        /// </summary>
        public void read ()
            {}
        /// <summary>
        /// Funkcja pozwalająca na zapis listy czynności do pliku.
        /// </summary>
        public void save()
        { }
        /// <summary>
        /// Funkcja pozwalająca na dodanie elementu do listy czynności.
        /// </summary>
        public void add()
        { }
        /// <summary>
        /// Funkcja pozwalająca na usunięcie elementu z listy czynności.
        /// </summary>
        public void delete()
        { }
    }
}
