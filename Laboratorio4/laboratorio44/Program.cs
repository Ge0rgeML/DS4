﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota del estudiante");

        float score = float.Parse(Console.ReadLine());

        if (score >= 70)
        {

            Console.WriteLine();

            Console.WriteLine($"su nota es (score) ha aprobado");

        }

        else
        {

            Console.WriteLine($"Su nota es (score) ha reprobado, debe repetir");

        }
    }
}