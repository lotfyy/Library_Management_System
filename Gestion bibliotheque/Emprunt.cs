using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_bibliotheque
{
    class Emprunt
    {
        public int IdAdherent { get; set; }
        public int CodeLivre { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetour { get; set; }
        public override bool Equals(object obj)
        {
            var E1 = obj as Emprunt;
            return E1.CodeLivre == this.CodeLivre && E1.IdAdherent == this.IdAdherent && E1.DateEmprunt == this.DateEmprunt;
        }
    }
}
