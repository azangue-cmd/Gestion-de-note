using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notes.Models
{
    internal class Enseignants
    {   
        public string Name {  get; set; }
        public string Prenom { get; set; }
        public int Matricule { get; set; }

        public Enseignants(string name, string nom , int matricule)
        {
            
            Name = name;
            Prenom = nom;
            Matricule = matricule;
        }

        public void enregistrer(double cc , double tp, double exam, string description)
        {

        }

        public void Supprimer(double cc,double tp, double exam, string description)
        {
            //supprimer dans las bd a implementer 
        }

        public void CalculMatiere()
        {
            //ici il va falloir ecrire le code pour calculer la note je n'ai pas trop compris 
        }


    }
}
