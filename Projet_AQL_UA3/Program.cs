using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL_UA3
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestionnaireNotes gestionnaire = new GestionnaireNotes();

            while (true)
            {
                Console.WriteLine("1. Ajouter un étudiant");
                Console.WriteLine("2. Ajouter un cours");
                Console.WriteLine("3. Saisir une note");
                Console.WriteLine("4. Afficher le relevé de notes d'un étudiant");
                Console.WriteLine("5. Quitter");
                Console.Write("Votre choix: ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        ajouterEtudiant(gestionnaire);
                        break;
                    case "2":
                        ajouterCours(gestionnaire);
                        break;
                    case "3":
                        saisirNote(gestionnaire);
                        break;
                    case "4":
                        afficherReleveNotes(gestionnaire);
                        break;
                    case "5":
                        gestionnaire.enregistrerDonnees();
                        return;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }
        }

        static void ajouterEtudiant(GestionnaireNotes gestionnaire)
        {
            Console.Write("Numéro d'étudiant: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nom: ");
            string nom = Console.ReadLine();
            Console.Write("Prénom: ");
            string prenom = Console.ReadLine();

            Etudiant etudiant = new Etudiant(numero, nom, prenom);
            gestionnaire.ajouterEtudiant(etudiant);
            Console.WriteLine("Étudiant ajouté avec succès.");
        }

        static void ajouterCours(GestionnaireNotes gestionnaire)
        {
            Console.Write("Numéro du cours: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Code: ");
            string code = Console.ReadLine();
            Console.Write("Titre: ");
            string titre = Console.ReadLine();

            Cours cours = new Cours(numero, code, titre);
            gestionnaire.ajouterCours(cours);
            Console.WriteLine("Cours ajouté avec succès.");
        }

        static void saisirNote(GestionnaireNotes gestionnaire)
        {
            Console.Write("Numéro d'étudiant: ");
            int numeroEtudiant = int.Parse(Console.ReadLine());
            Console.Write("Numéro du cours: ");
            int numeroCours = int.Parse(Console.ReadLine());
            Console.Write("Note: ");
            double note = double.Parse(Console.ReadLine());

            Notes nouvelleNote = new Notes(numeroEtudiant, numeroCours, note);
            gestionnaire.ajouterNote(nouvelleNote);
            Console.WriteLine("Note enregistrée avec succès.");
        }

        static void afficherReleveNotes(GestionnaireNotes gestionnaire)
        {
            Console.Write("Numéro d'étudiant: ");
            int numeroEtudiant = int.Parse(Console.ReadLine());
            gestionnaire.afficherReleveNotes(numeroEtudiant);
        }
    }
}
