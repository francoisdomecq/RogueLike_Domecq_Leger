using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    abstract public class Personnages
    {
        private string _nomPerso;
        private int _pvPerso;
        private int _pvMax;
        private int _puissancePerso;
        List<Capacites> _listCapacites;

        public Personnages(string nom, int pvMax, int puissance)
        {
            this._nomPerso = nom;
            this._puissancePerso = puissance;
            this._pvPerso = pvMax;
            this._pvMax = pvMax;
            this._listCapacites = new List<Capacites>();
        }

        public int GetPuissance() { return _puissancePerso; }

        public int GetPv() { return _pvPerso; }

        public int GetPvMax() { return _pvMax; }

        public void AddCapacites(Capacites c)
        {
            _listCapacites.Add(c);
        }
        public void Manger(int pv)
        {
            if (this._pvPerso == this._pvMax)
                Console.WriteLine("PV déjà au max");
            else
            {
                if (this._pvPerso + pv > _pvMax)
                    this._pvPerso = _pvMax;
                else
                    this._pvPerso += pv;
            }
        }
        public void BoireRhum(int puissance) //A redéfinir pour que ça ne dure que deux tours ou quoi
        {
            this._puissancePerso += puissance;
        }
        public int Attaquer()
        {
            Random _nbDgtsAleatoire = new Random();
            int _nbDgts = _nbDgtsAleatoire.Next(_puissancePerso - 2, _puissancePerso);
            return _nbDgts;
        }
        public void PerdreVie(int nbPv)
        {
            this._pvPerso -= nbPv;
            this._pvPerso -= nbPv;
        }
        public override string ToString()
        {
            string chRes = "Nom :" + this._nomPerso + " Pv actuels:" + this._pvPerso + " Pv Max :" + this._pvMax + " Puissance:" + this._puissancePerso + " Capacites:";
            foreach (Capacites c in _listCapacites)
            {
                chRes += c;
            }
            return chRes;
        }
    }
}
