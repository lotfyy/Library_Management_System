using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_bibliotheque
{
    class Emprunts
    {
        public List<Emprunt> lstEmprunts { get; set; }
        public Emprunts()
        {
            lstEmprunts = new List<Emprunt>();
        }
        public bool Add(Emprunt Ep)
        {
            if (lstEmprunts.Contains(Ep))
                return false;

            lstEmprunts.Add(Ep);
            return true;
        }
    }
}
