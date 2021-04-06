using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLNET;


namespace Jeu
{
    class Program
    {
        /*// The screen height and width are in number of tiles
         private static readonly int _screenWidth = 100;
         private static readonly int _screenHeight = 70;

         private static RLRootConsole _rootConsole;*/

        public static void Main()
        {
            /*// This must be the exact name of the bitmap font file we are using or it will error.
            string fontFileName = "terminal8x8.png";
            // The title will appear at the top of the console window
            string consoleTitle = "RougeSharp V3 Tutorial - Level 1";
            // Tell RLNet to use the bitmap font that we specified and that each tile is 8 x 8 pixels
            _rootConsole = new RLRootConsole(fontFileName, _screenWidth, _screenHeight,
              8, 8, 1f, consoleTitle);
            // Set up a handler for RLNET's Update event
            _rootConsole.Update += OnRootConsoleUpdate;
            // Set up a handler for RLNET's Render event
            _rootConsole.Render += OnRootConsoleRender;
            // Begin RLNET's game loop
            _rootConsole.Run();
        }

        // Event handler for RLNET's Update event
        private static void OnRootConsoleUpdate(object sender, UpdateEventArgs e)
        {
            _rootConsole.Print(10, 10, "It worked!", RLColor.White);
           
        }

        // Event handler for RLNET's Render event
        private static void OnRootConsoleRender(object sender, UpdateEventArgs e)
        {
            // Tell RLNET to draw the console that we set
            _rootConsole.Draw();
        }*/
            Pirate p1 = new Pirate("Kevin", 10, 2);
            Pirate p2 = new Pirate("Dylan", 6, 2);
            Pirate p3 = new Pirate("Dimitri", 8, 2);
            List<Personnages> _listePersos = new List<Personnages>();
            _listePersos.Add(p1);
            _listePersos.Add(p2);
            _listePersos.Add(p3);
            Ressources _ressourcesEq1 = new Ressources(500, 10, 5, 2);
            Equipage E1 = new Equipage(_listePersos, _ressourcesEq1, 5, 5);


            Pirate p4 = new Pirate("Jack", 10, 2);
            Pirate p5 = new Pirate("Georges", 6, 2);
            Pirate p6 = new Pirate("Malory", 8, 2);
            List<Personnages> _listePersosE2 = new List<Personnages>();
            _listePersosE2.Add(p4);
            _listePersosE2.Add(p5);
            _listePersosE2.Add(p6);
            Ressources _ressourcesEq2 = new Ressources(500, 10, 5, 2);
            Equipage E2 = new Equipage(_listePersosE2, _ressourcesEq2, 6, 6);
            Console.WriteLine(E1);
            Console.WriteLine(E2);
            Console.ReadKey();

        }
    }
}
