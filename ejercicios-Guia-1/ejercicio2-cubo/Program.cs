﻿using System;

namespace ejercicio2_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para solicitar por teclado un número
            // y luego devolver su valor elevado al cubo.
            
            //declarar las variables
            int n, cubo;

            //pedir numero
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            //elevar al cubo
            cubo = n * n * n;

            //mostrar resultado
            Console.WriteLine("El resultado de elevar " + n + " al cubo es " + cubo);

        }
    }
}
