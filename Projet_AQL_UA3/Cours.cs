using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL_UA3
{
    public class Cours
    {
        public int NumeroCours { get; }
        public string Code { get; }
        public string Titre { get; }

        public Cours(int numeroCours, string code, string titre)
        {
            NumeroCours = numeroCours;
            Code = code;
            Titre = titre;
        }
    }
}
