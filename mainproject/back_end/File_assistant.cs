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
            //
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
                        procedure_list.ElementAt(procedure_list.Count-1).Activity_list.Add(text);
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

        public static void save_airship_database(back_end.Default_database database, string where)
        {
            var data_list = new List<string>
            {
                "Airships:"
            };
            foreach (var airship in database.Airship_list)
            {
                data_list.Add(airship.Name);
                data_list.Add(airship.Type);
                data_list.Add(airship.Required_legitimation);
                foreach (var proc in airship.Procedure_list)
                {
                    data_list.Add(".");
                    data_list.Add(proc.Action);
                    foreach(var act in proc.Activity_list)
                    {
                        data_list.Add(act);
                    }
                }
                data_list.Add("-");
            }
            save(data_list, where);
        }
        public static void airship_data(Default_database main_database, string where)
        {
            string line;
            var reader = new StreamReader(where);
            line = reader.ReadLine();
            while (line != null)
            {
                if (line == "-")
                {
                   var name = reader.ReadLine();
                   var type = reader.ReadLine();
                   var legitimation = reader.ReadLine();
                   var airship = new Airship(name, type, legitimation);
                   main_database.add_to_list(airship);
                   line = reader.ReadLine();
                }
                else
                {
                   
                    if (line == ".")
                    {
                      
                        line = reader.ReadLine();
                    }
                    else
                    {

                        main_database.Airship_list.ElementAt(main_database.Airship_list.Count - 1).Procedure_list.ElementAt(main_database.Airship_list.ElementAt(main_database.Airship_list.Count - 1).Procedure_list.Count - 1).Activity_list.Add(line);
                       //main_database.Airship_list.ElementAt(main_database.Airship_list.Count - 1).Procedure_list.ElementAt(main_database.Procedure_blocks_list.Count - 1).Activity_list.Add(line);
                        line = reader.ReadLine();
                        //string w liscie z procedurami
                    }
                }
            }
        }
    }
}
