
namespace ConsoleApp06.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumeros = 0;
            int contadorDePares = 0;
            int mayorNumero = 0;
            int menorNumero = 0;
            int sumaNumeros = 0;
            Console.Write("Ingrese la suma tope del ciclo:");
            int tope=int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Ingrese un numero:");
                int numeroIngresado=int.Parse(Console.ReadLine());
                contadorNumeros++;
                sumaNumeros += numeroIngresado;
                if (EsPar(numeroIngresado))
                {
                    contadorDePares++;
                }
                if (contadorNumeros==1)
                {
                    mayorNumero = numeroIngresado;
                    menorNumero=numeroIngresado;
                }
                else
                {
                    if (numeroIngresado>mayorNumero)
                    {
                        mayorNumero = numeroIngresado;
                    }
                    if (numeroIngresado<menorNumero)
                    {
                        menorNumero = numeroIngresado;
                    }
                }

            } while (sumaNumeros<=tope);
            Console.WriteLine($"Suma de números: {sumaNumeros}");
            Console.WriteLine($"Cantidad Números:{contadorNumeros}");
            Console.WriteLine($"Cantidad de Pares:{contadorDePares}");
            Console.WriteLine($"Mayor número ingresado: {mayorNumero}");
            Console.WriteLine($"Menor número ingresado: {menorNumero}");
        }

        private static bool EsPar(int numeroIngresado)
            => numeroIngresado % 2 == 0;
        
    }
}
