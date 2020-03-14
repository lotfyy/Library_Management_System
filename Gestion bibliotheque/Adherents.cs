using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_bibliotheque
{
    class Adherents
    {
        public List<Adherent> lstAdherents{ get; set; }
        public Adherents()
        {
            lstAdherents= new List<Adherent>();
        }
        public List<Adherent> lstAdhérents { get; set; } = new List<Adherent>();

        public bool Add(Adherent ad)
        {
            if (lstAdherents.Contains(ad))
                return false;
            lstAdherents.Add(ad);
            return true;
        }
        public bool AddEmprunt(int Id)
        {

            Adherent ad = lstAdherents.Where(x => x.ID == Id).First<Adherent>();
            if (ad == null)
                return false;
            ad.NoEmpruntEnCours++;
            return true;
        }

        public List<int> LesIds()
        {
            List<int> lstIds = new List<int>();
            foreach (Adherent x in lstAdhérents)
            {
                lstIds.Add(x.ID);
            }
            return lstIds;
        }
        public Adherent FindById(int Id) => lstAdherents.Where<Adherent>(x => x.ID == Id).FirstOrDefault();
    }
}
