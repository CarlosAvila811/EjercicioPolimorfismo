
namespace EjercicioPolimorfismo
{
    public class Gato :Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato dice: ¡Miau! ¡Miau!");
        }

        public override void Comer()
        {
            Console.WriteLine("El gato está comiendose un raton.");
        }
    }
}
