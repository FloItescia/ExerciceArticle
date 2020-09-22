using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Exercice
{
    class Disque : Article
    {
        protected string label;

        public static void Ecouter(string label)
        {
            Console.WriteLine("Vous écouter {0}", label);
        }

    }
}
