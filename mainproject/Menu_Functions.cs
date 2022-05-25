using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end
{
    class Logger
    {
        
        public void login()
        {
            var pytanie = new front_end.Asker();
            pytanie.ask_for("login ziomek");
            pytanie.ask_for("hasło ziomek");
            
        }

        public void sign_up()
        {
            var pytanie = new front_end.Asker();
            pytanie.ask_for("imie ziomek");
            pytanie.ask_for("nazwisko ziomek");
            pytanie.ask_for("login ziomek");
            pytanie.ask_for("hasło ziomek");
            pytanie.ask_for("numer licencji ziomek");
            pytanie.ask_for("typ legitymacji ziomek");
            
            
        }
    }
}
