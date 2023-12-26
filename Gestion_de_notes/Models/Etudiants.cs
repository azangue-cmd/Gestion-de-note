using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notes.Models
{
    internal class Etudiants
    {
        
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public DateTime DateNaissance { get; set; }
            public string Adresse { get; set; }
            public string Telephone { get; set; }
        

    }
}
