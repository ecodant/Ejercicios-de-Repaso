int n;
long factorial = 1;
bool validate = true;

while (validate)
{
    Console.WriteLine("Ingrese un valor entero positivo para averiguar su respectivo factorial");

    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Operación completada → {n}! = {factorial}");
        validate = false;
    }
    else
    {
        Console.WriteLine("**ERROR, POR FAVOR, INGRESE UN VALOR VALIDO");
    }
}