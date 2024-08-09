

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro dice: ¡Guau! ¡Guau!");
        }

        public override void Comer()
        {
            Console.WriteLine("El perro está comiendo su comida.");
        }
    }
}
