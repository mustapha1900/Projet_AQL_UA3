using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL_UA3
{
    public class Etudiant
    {
        public int NumeroEtudiant { get; }
        public string Nom { get; }
        public string Prenom { get; }

        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            NumeroEtudiant = numeroEtudiant;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
