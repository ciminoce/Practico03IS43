

namespace ConsoleApp01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumaNros = 0;
            int contadorPares = 0;
            int contadorMayores10 = 0;
            Console.Write("Ingrese la cantidad de números:");
            if (!int.TryParse(Console.ReadLine(), out int cantidadNumeros))
            {
                Console.WriteLine("Cantidad mal ingresada");
                return;
            }
            if (cantidadNumeros>0)
            {
                
                for (int contador = 1; contador <= cantidadNumeros; contador++)
                {
                    Console.Write($"Ingrese el {contador} número:");
                    int numeroIngresado = int.Parse(Console.ReadLine());
                    sumaNros+= numeroIngresado;//sumaNros=sumaNros+numeroIngresado
                    if (EsPar(numeroIngresado))
                    {
                        contadorPares++;
                    }
                    if (EsMayor10(numeroIngresado))
                    {
                        contadorMayores10++;
                    }
                    Console.WriteLine($"Suma Parcial: {sumaNros}");
                }
                var promedioNros = sumaNros / cantidadNumeros;
                Console.WriteLine($"Suma de números: {sumaNros}");
                Console.WriteLine($"Promedio.......: {promedioNros}");
                Console.WriteLine($"Cant. de Pares.: {contadorPares}");
                Console.WriteLine($"Cant. Mayores 10: {contadorMayores10}");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser superior a 0");
            }
        }

        private static bool EsMayor10(int numeroIngresado) => numeroIngresado > 10;
        

        private static bool EsPar(int numeroIngresado) => numeroIngresado % 2 == 0;
        
    }
}
