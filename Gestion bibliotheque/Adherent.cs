using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_bibliotheque
{
    enum Genre { Homme, Femme}
    class Adherent
    {
        public int ID { get; set; }
        public String Nom { get; set; }
        public DateTime Datenaiss { get; set; }
        public Genre Sexe { get; set; }
        public int NoEmpruntEnCours { get; set; }
        public override bool Equals(object obj)
        {
            return this.ID == ((Adherent)obj).ID;
        }
        //public override bool Equals(object obj)
       // {
        //    return obj is Adherent adhérent &&
       //            ID == adherent.ID;
       // }

        public override int GetHashCode()
        {
            return 2108858624 + ID.GetHashCode();
        }
    }
}
