using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_bibliotheque
{
    class Bibliotheque
    {
        public Livres LesLivres { get; set; } = new Livres();
        public Adherents LesAdherents { get; set; } = new Adherents();
        public Emprunts LesEmprunts { get; set; } = new Emprunts();
    }
}
