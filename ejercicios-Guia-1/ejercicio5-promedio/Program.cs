﻿using System;

namespace ejercicio5_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
          //  5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
          //  y luego calcule y emita por pantalla el promedio final.

          float nota1, nota2, nota3, promedio;

          Console.WriteLine("ingrese nota 1: ");
          nota1 = float.Parse(Console.ReadLine());
          Console.WriteLine("ingrese nota 2: ");
          nota2 = float.Parse(Console.ReadLine());
          Console.WriteLine("ingrese nota 3: ");
          nota3 = float.Parse(Console.ReadLine());

          promedio = (nota1 + nota2 + nota3) / 3;

          Console.WriteLine("El promedio es " + promedio.ToString("0.00"));
        }
    }
}
