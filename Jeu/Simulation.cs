using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    public class Simulation
    {

        public void Combat(Equipage e1, Equipage e2)
        {
            int i = 0;
            List<Personnages> _listEquipage1 = e1.GetListeEquipage();
            List<Personnages> _listEquipage2= e2.GetListeEquipage();
            

            foreach (Personnages p in _listEquipage1)
            {
                int _dgtsInfliges = p.Attaquer(); 
                if(i<_listEquipage2.Count())
                {
                    _listEquipage2[i].PerdreVie(_dgtsInfliges)
                }
                
            }
        }
    }
}
