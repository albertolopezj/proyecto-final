using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento = 0;
        int contador = 0;

        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.WriteLine("He pensado un número entre 1 y 100. ¿Puedes adivinarlo?");

        while (intento != numeroSecreto)
        {
            Console.Write("Introduce tu número: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out intento))
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                continue;
            }

            contador++;

            if (intento < numeroSecreto)
                Console.WriteLine("Más alto...");
            else if (intento > numeroSecreto)
                Console.WriteLine("Más bajo...");
            else
                Console.WriteLine($"¡Felicidades! Lo lograste en {contador} intentos.");
        }
    }
}