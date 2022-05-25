using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Login_assistant
    {
        public string text;
        private string text2;

        public string Text { get => text; set => text = value; }
        public string Text2 { get => text2; set => text2 = value; }

        public string ask_for(string text)
        {
            Console.WriteLine("Podaj " + text);
            text2 = Console.ReadLine();
            return text2;

        }
        public void login()
        {
            var pytanie = new front_end.Login_assistant();

            pytanie.ask_for("login ziomek");
            pytanie.ask_for("hasło ziomek");

        }

        public void sign_up()
        {
            var pytanie = new front_end.Login_assistant();
            pytanie.ask_for("imie ziomek");
            pytanie.ask_for("nazwisko ziomek");
            pytanie.ask_for("login ziomek");
            pytanie.ask_for("hasło ziomek");
            pytanie.ask_for("numer licencji ziomek");
            pytanie.ask_for("typ legitymacji ziomek");


        }
    }
}
