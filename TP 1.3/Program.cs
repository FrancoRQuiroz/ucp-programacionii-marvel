﻿using System;

namespace TP_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHeroe Heroe = new SuperHeroe("IronMan", 1963, "Tales of Suspense", 100, new SuperPoder(), 2);

            Villano Villano = new Villano("Venom", 1984, "The Amazing Spiderman", 100);

            Combate Combate = new Combate(Heroe, Villano, 1);       
        }

    }
}
