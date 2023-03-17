// Prima funzione

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


// Seconda funzione
Console.WriteLine("Inserisci un numero");
int numero = Convert.ToInt32(Console.ReadLine());
int quadrato = Quadrato(numero);
Console.WriteLine(quadrato);
int Quadrato(int numero)
{
    return numero * numero;
}
