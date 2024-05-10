using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Alapok_Demo.DBCommand
{
    internal class SQLCommands
    {
        string mindentCmd = "SELECT nev, orszag FROM konferencia.jelentkezo";
        string nevCmd = "SELECT nev FROM konferencia.jelentkezo ORDER BY nev;";

        public string NevCmd { get => nevCmd; set => nevCmd = value; }
        public string MindentCmd { get => mindentCmd; set => mindentCmd = value; }
    }
}
