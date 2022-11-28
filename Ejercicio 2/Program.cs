int[] numbers = new int[3];
int count = 0;

while (count < 3)
{
    Console.WriteLine("Ingrese un número, por favor");
    if (int.TryParse(Console.ReadLine(), out numbers[count]))
    {
        count++;
    }else
    {
        Console.WriteLine("No ingreso un número, intentelo de nuevo");
    }
}
Array.Sort(numbers);
Console.WriteLine($"El número mayor es {numbers[2]}");