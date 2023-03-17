// Prima funzione
Console.WriteLine("PRIMA FUNZIONE ");
int[] numeri = { 1, 2, 3, 4, 5 };
StampaArray(numeri);
void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
Console.WriteLine("");

// Seconda funzione
Console.WriteLine("SECONDA FUNZIONE ");
Console.WriteLine("Inserisci un numero");
int numero = Convert.ToInt32(Console.ReadLine());
int quadrato = Quadrato(numero);
Console.WriteLine(quadrato);
int Quadrato(int numero)
{
    return numero * numero;
}
Console.WriteLine("");

// Terza funzione
Console.WriteLine("TERZA FUNZIONE ");
int[] numbers = { 1, 2, 3, 4, 5 };
int[] numeriAlQuadrato = ArrayAlQuadrato(numbers);
Console.WriteLine("");
StampaArray(numeriAlQuadrato);
int[] ArrayAlQuadrato(int[] array)
{
    int[] nuovoArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        nuovoArray[i] = array[i] * array[i];
        Console.Write($"{nuovoArray[i]} ");
    }
    return nuovoArray;
}
Console.WriteLine("");
