Random rand = new Random();

int i;
int j;
int k;
int[] tab;
tab = new int[100];

for (i = 0; i < 100; i++)
{
    tab[i] = rand.Next(1, 1000);
    Console.Write("{0,8}", tab[i]);
}

Console.WriteLine("Liczby pierwsze w powyzszym zbiorze: ");

int suma = 0;
for (j = 0; j < tab.Length; j++)
{
    for (k = 2; k < tab[j]; k++)

        if (tab[j] % k == 0)
        {

            tab[j] = 0;
            break;
        }
    if (k == tab[j])
        Console.Write("{0,8}", tab[j]);
    {
        if (tab[j] > 0)
            tab[j] = 0 + 1;
        suma = suma + tab[j];

    }
}
Console.WriteLine("\n     W podanym zakresie znajduje sie {0} liczb pierwszych.", suma);


Console.ReadKey();