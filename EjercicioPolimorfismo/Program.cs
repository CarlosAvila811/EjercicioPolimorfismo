using EjercicioPolimorfismo;
using System;

class Program
{
    static void Main()
    {
        
        Animal[] animales = new Animal[]
        {
            new Perro(),
            new Gato()
        };

        
        foreach (var animal in animales)
        {
            animal.HacerSonido(); 
            animal.Comer(); 
            Console.WriteLine();
        }
    }
}