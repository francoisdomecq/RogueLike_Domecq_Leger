using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeu.Interfaces;
using RLNET;
using RogueSharp;

namespace Jeu.Core
{
    public class Player : Actor
    {
        public Player()
        {
            Awareness = 15;
            Name = "Rogue";
            Color = Colors.Player;
            Symbol = (char)1;
            X = 10;
            Y = 10;
        }
    }
}
