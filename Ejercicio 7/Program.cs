
int[] numbers = new int[5];

int count= 0, n, valorActual = 0, pos = 0;
while(count < 5)
{
    Console.WriteLine("Ingrese un valor para la array");
    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        numbers[count] = n;
        count++;
    }
    else
    {
        Console.WriteLine("No ingreso un valor validor");
    }
}

int valorCompare = numbers[0];

for (int i = 1; i < 5; i++)
{
  
    if (numbers[i] > valorCompare)
    {
        valorCompare= numbers[i];
        valorActual = numbers[i];
        pos = i;
    }
    else
    {
        valorActual = valorCompare;
    }
}
Console.WriteLine($"El valor mayor fue: {valorActual} está en la posición {pos}");
for (int i = 1; i < 5; i++)
{

    if (numbers[i] < valorCompare)
    {
        valorCompare = numbers[i];
        valorActual = numbers[i];
        pos = i;
    }
    else
    {
        valorActual = valorCompare;
    }
}
Console.WriteLine($"El valor menor fue: {valorActual} está en la posición {pos}");