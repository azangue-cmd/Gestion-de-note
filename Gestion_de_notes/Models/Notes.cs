using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_notes.Models
{
    internal class Notes
    {
        public List<Etudiants> Etudiants { get; set; }
        public List<Matieres> Matieres { get; set; }
        public List<Notes> Note { get; set; }
    }
}
