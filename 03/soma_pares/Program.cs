﻿int[] numeros = new int[10];
int somaPares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        somaPares += numeros[i];
    }
}

Console.WriteLine($"A soma dos números pares nessa sequência é {somaPares}");