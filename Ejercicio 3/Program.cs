
int n, result;
bool vali = true;
do
{
    Console.WriteLine("Ingrese un número entero del 1 al 12");
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (n >= 1 && n <= 12)
        {
            for (int i = 1; i <= 12; i++)
            {
                result = n * i;
                Console.WriteLine($"{n}x{i}= {result}");
                vali = false;
            }
        }
        else
        {
            Console.WriteLine("El valor no esta dentro del rango, intente de nuevo");
        }
    }
    else
    {
        Console.WriteLine("No ingreso un número entero dentro del rango sugerido");
    }

} while (vali == true);



