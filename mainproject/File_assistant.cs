using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class File_assistant
    {
        /// <summary>
        /// Funkcja wczytuje listę z pliku
        /// </summary>
        /// <param name="from_where"> Ścieżka do pliku z z którego chcesz zwracać listę.</param>
        /// <returns>Zwraca listę stringów, gdzie każdy element to jedna linia z pliku. Pierwsza to nagłówek</returns>
        public static List<string> load (string from_where)
            {
            string line;
            var reader= new StreamReader(from_where);
            line = reader.ReadLine();
            Console.WriteLine("Wczytuję " + line);
            var list = new List<string>();
            while (line != null)
            {
                list.Add(line);
                line = reader.ReadLine();   
            }
            reader.Close();
            return list;
        }


     //   public static List<Procedure> load_activities(string from_where)
       // { 

        //}

        public static List<Procedure> load_procedures(string from_where)
        {
            var loaded_list = load(from_where);
            var procedure_list = new List<Procedure>();

            bool procedure = false;
            foreach (var text in loaded_list)
            {
                if (text == ".")
                {
                    procedure = true;
                }
                else
                {
                    if (procedure == true)
                    {
                        var proc = new Procedure(text);
                        procedure_list.Add(proc);
                        procedure = false;
                    }
                    else
                    {
                        procedure_list.ElementAt(loaded_list.IndexOf(text)).Activity_list.Add(text);
                    }

                }

            }
            return procedure_list;
        }
        /// <summary>
        /// Funkcja zapisująca do pliku.
        /// </summary>
        /// <param name="list">Lista stringów, którą chcemy zapisać do pliku. Każdy element to jedna linia</param>
        /// <param name="where">Ścieżka do pliku w którym wszystko zostanie zapisane.</param>
        public static void save(List<string>list, string where)
        {
            var writer = new StreamWriter(where);
            foreach (var line in list)
            {
                writer.WriteLine(line);
            }
        }
    }
}
