using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitGame
{
    /**
 * Basisimplementierzung für Actions
 */
    public abstract class AbstractAction
    {
        /**
         * Wird aufgerufen, um die Action auszuführen
         * 
         * Muss in Ableitungen überschrieben werden
         */
        public abstract void Execute();

        /**
         * Hilfsfunktion für Actions.
         * 
         * Wartet auf einen Tastendruck durch den Anwender
         */
        protected void WaitOnKey()
        {
            Console.WriteLine();
            Console.Write("   press any key to continue ...");
            Console.ReadKey(); // Waits for a key press
            Console.WriteLine();
        }
    }
}
