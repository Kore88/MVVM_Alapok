using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Alapok_Demo.Model
{
     class Jelentkezo
    {
        string nev;
        string orszag;


        public string Nev { get => nev; set => nev =value; }
        public string Orszag { get => orszag; set => orszag = value; }

        public Jelentkezo(string nev, string orszag)
        {
            Nev = nev;
            Orszag = orszag;
        }
    }


}
