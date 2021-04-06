using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    public class Ressources
    {
        private float _montantButin;
        private int _nbNourritures;
        private int _litresRhum;
        private int _nbCanons;

        public Ressources(float butin, int nbN, int lR, int nbC)
        {
            this._montantButin = butin;
            this._nbCanons = nbC;
            this._nbNourritures = nbN;
            this._litresRhum = lR;
        }
        public int GetNbNourriture() { return _nbNourritures; }
        public float GetMontantButin() { return _montantButin; }
        public int GetLitresRhum() { return _litresRhum; }
        public int GetNbCanons() { return _nbCanons; }
    }
}

