int num = 0;
int i = 1;

while (i <= 100) 
{
    if (i % 2 == 0)
    {
        num += i;
    }

    i++;
}

Console.WriteLine("Soma dos números pares de 1 a 100: " + num);