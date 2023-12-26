using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notes.Models
{
    internal class Administration
    {
        private int Id { get { return Id; } set => Id = value; }
        private string Nom { get { return Nom; } set => Nom = value; }
        private string Prenom { get { return Prenom; } set => Prenom = value; }


        public Administration(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public Administration()
        {

        }

        public void CreerEtudiant(string nom, string prenom, string niveau, string spcialités, char sexe, string anneAcademique )
        {
            // insertion de la chaine de connection et insertion des donnees a
        }

        public void EnregistrerMatiere(string intitulé, int code,int credit)
        {

        }

        public void TirerNotes(double cc, double noteTp, double noteExam,string appreciation) 
        { 
        }
    }
}
