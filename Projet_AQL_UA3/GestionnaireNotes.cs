using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL_UA3
{
    public class GestionnaireNotes
    {
        private List<Etudiant> LesEtudiants = new List<Etudiant>();
        private List<Cours> LesCours = new List<Cours>();
        private List<Notes> LesNotes = new List<Notes>();

        public void AjouterEtudiant(Etudiant etudiant)
        {
            LesEtudiants.Add(etudiant);
        }

        public void AjouterCours(Cours cours)
        {
            LesCours.Add(cours);
        }

        public void AjouterNote(Notes note)
        {
            LesNotes.Add(note);
        }

        public void EnregistrerDonnees()
        {
            EnregistrerEtudiants();
            EnregistrerCours();
            EnregistrerNotes();
        }

        private void EnregistrerEtudiants()
        {
            foreach (Etudiant etudiant in LesEtudiants)
            {
                string nomFichier = $"etudiant_{etudiant.NumeroEtudiant}.txt";
                using (StreamWriter sw = new StreamWriter(nomFichier))
                {
                    sw.WriteLine($"Numéro d'étudiant: {etudiant.NumeroEtudiant}");
                    sw.WriteLine($"Nom: {etudiant.Nom}");
                    sw.WriteLine($"Prénom: {etudiant.Prenom}");
                }
            }
        }

        private void EnregistrerCours()
        {
            foreach (Cours cours in LesCours)
            {
                string nomFichier = $"cours_{cours.NumeroCours}.txt";
                using (StreamWriter sw = new StreamWriter(nomFichier))
                {
                    sw.WriteLine($"Numéro du cours: {cours.NumeroCours}");
                    sw.WriteLine($"Code: {cours.Code}");
                    sw.WriteLine($"Titre: {cours.Titre}");
                }
            }
        }

        private void EnregistrerNotes()
        {
            foreach (Notes note in LesNotes)
            {
                string nomFichier = $"notes_{note.NumeroEtudiant}_{note.NumeroCours}.txt";
                using (StreamWriter sw = new StreamWriter(nomFichier, true))
                {
                    sw.WriteLine($"Note de l'étudiant {note.NumeroEtudiant} pour le cours {note.NumeroCours}: {note.Note}");
                }
            }
        }

        public void AfficherReleveNotes(int numeroEtudiant)
        {
            Console.WriteLine($"Relevé de notes pour l'étudiant numéro {numeroEtudiant}:");
            foreach (Notes note in LesNotes)
            {
                if (note.NumeroEtudiant == numeroEtudiant)
                {
                    Console.WriteLine($"Cours numéro {note.NumeroCours}: La note est : {note.Note}");
                }
            }
        }
    }
}
