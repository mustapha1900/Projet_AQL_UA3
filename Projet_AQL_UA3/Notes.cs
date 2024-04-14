using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL_UA3
{
    public class Notes
    {
        public int NumeroEtudiant { get; }
        public int NumeroCours { get; }
        public double Note { get; }

        public Notes(int numeroEtudiant, int numeroCours, double note)
        {
            NumeroEtudiant = numeroEtudiant;
            NumeroCours = numeroCours;
            Note = note;
        }
    }
}

