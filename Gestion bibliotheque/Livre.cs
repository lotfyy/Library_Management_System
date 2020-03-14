using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_bibliotheque
{
    class Livre
    {
        public int Code { get; set; }
        public String Titre { get; set; }
        public String Auteur { get; set; }
        public int NbreExplaire { get; set; }
        public DateTime DateSortie { get; set; }
        public override bool Equals(object obj)
        {
            return this.Code == (obj as Livre).Code ;
        }

    }
}
