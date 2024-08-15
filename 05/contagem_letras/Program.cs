Console.WriteLine("Digite um nome:");
string text = Console.ReadLine().ToLower();

int total = 0;

foreach (char c in text)
{
    if (c >= 'a' && c <= 'z')
    {
        total++;
    }
}

Console.WriteLine($"Total de letras diferentes que aparecem nesse nome: {total}");