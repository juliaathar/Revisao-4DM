Random random = new Random();
int numeroAleatorio = random.Next(0, 11);
int tentativa;
int contador = 0;

Console.WriteLine("Adivinhe o número em que estou pensando (0 a 10): ");

do
{
    tentativa = int.Parse(Console.ReadLine());
    contador++;

    if (tentativa != numeroAleatorio)
    {
        Console.WriteLine("Errou, tente novamente:");
    }
} while (tentativa != numeroAleatorio);

Console.WriteLine($"Acertou! O número era {numeroAleatorio} e você precisou de {contador} tentativas para adivinhar!");