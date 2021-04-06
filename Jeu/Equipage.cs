using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
   public class Equipage
        {
            private List<Personnages> _listePersonnages;
            private Ressources _tresorEquipage;
            private int _x;
            private int _y;
            private bool _estEnMer;
            private int _puissanceEquipage;

            public Equipage(List<Personnages> listePersos, Ressources tresor, int x, int y)
            {
                _listePersonnages = listePersos;
                _tresorEquipage = tresor;
                _x = x;
                _y = y;
                _estEnMer = true;
                foreach (Personnages p in _listePersonnages)
                {
                    _puissanceEquipage += p.GetPuissance();
                }
            }

            public override string ToString()
            {
                string ch = "Ressources - Butin : " + _tresorEquipage.GetMontantButin() + " Nourritures : " + _tresorEquipage.GetNbNourriture() + " Rhum : " + _tresorEquipage.GetLitresRhum() + " Nombre de canons : " + _tresorEquipage.GetNbCanons();
                ch += "\nPosition - X : " + _x + " Y : " + _y + " En mer : " + _estEnMer;
                ch += "\n Equipages";
                foreach (Personnages p in _listePersonnages)
                {
                    ch += "\n -" + p.ToString();
                }
                return ch;
            }

        public List<Personnages> GetListeEquipage() { return _listePersonnages; }
        }
}
