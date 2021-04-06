using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    public class Pirate : Personnages
    {
        public Pirate (string nom, int pv, int puissance) : base(nom, pv, puissance) { }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
