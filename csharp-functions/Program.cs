//Prima funzione

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














//int Quadrato(int numero);