Console.WriteLine("------   Teste Jorge Luis   ------");
Console.Write("Digite uma string para inverter: ");
string? input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Entrada inválida. Digite uma string não vazia.");
    return;
}

string invertedString = InverterString(input.Trim());

Console.WriteLine($"String invertida: {invertedString}");

    static string InverterString(string str)
{
    char[] array = new char[str.Length];
    int j = 0;

    for (int i = str.Length - 1; i >= 0; i--)
    {
        array[j++] = str[i];
    }

    return new string(array);
}