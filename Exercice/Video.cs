using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice
{
    class Video : Article
    {
        protected float duree;

        public static void Afficher(float duree)
        {
            Console.WriteLine("Le film dure {0} heure", duree);
        }
    }
}
