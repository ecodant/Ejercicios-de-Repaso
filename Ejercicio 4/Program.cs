bool vali = true;
int n, sum= 0, num = 1;

do
{
    Console.Write("Ingrese cuántos números desea generar: ");
    if (int.TryParse(Console.ReadLine(), out n) && n> 0)
    {
        vali = false;
        for (int i = 0; i < n; i++)
        {
            int sec = sum;

            sum = num;

            num = sec + sum;
            Console.Write(sum + " ");
        }
    }
    else
    {
        Console.WriteLine("No ingreso un valor valido, intentelo de nuevo");
    }

} while (vali);
