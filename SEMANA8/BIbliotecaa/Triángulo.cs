﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BIbliotecaa
{
    public class Triángulo
    {
        public void area()
        {
            Console.Write("Ingrese la altura: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la base: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Área= " + (b * h) / 2);

        }

        public void perimetro()
        {
            Console.Write("Ingrese lado 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            int l3 = int.Parse(Console.ReadLine());

            Console.Write("Perímetro: " + (l1 + l2 + l3));
        }

    }
}
