﻿using laboratorio88;

internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcretal concretal = new ClaseConcretal();
        concretal.printOut();
        Console.WriteLine(concretal.prefixValor("ES_"));

        ClaseConcreta2 concreta2 = new ClaseConcreta2();
        concreta2.printOut();
        Console.WriteLine(concreta2.prefixValor("ES_"));
    }
}