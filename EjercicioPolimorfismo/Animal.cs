

namespace EjercicioPolimorfismo
{
    public abstract class Animal
    {
        public abstract void HacerSonido();

        public virtual void Comer()
        {
            Console.WriteLine("El animal está comiendo.");
        }
    }
}
