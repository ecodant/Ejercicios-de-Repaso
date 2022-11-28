
int n, orderNumber;
bool vali = true;
string? inputUser;

do
{
    Console.WriteLine("Ingrese un número entero de 3 cifras, por favor");
	inputUser= Console.ReadLine();

	if (int.TryParse(inputUser, out n))
	{
        if (n < 0 && inputUser.Length == 4)
        {
			n *= -1;
            Console.Write("-");
            for (int i = 0; i < 3; i++)
            {
                orderNumber = n % 10;
                n /= 10;
                Console.Write(orderNumber);
                vali = false;
            }
            Console.Write("\n");
        }
        if (n > 0 && inputUser.Length == 3)
		{
			for (int i = 0; i < 3; i++)
			{
				orderNumber = n % 10;
				n /= 10;
				Console.Write(orderNumber);
				vali = false;
			}
			Console.Write("\n");
		}
		else
		{
			Console.WriteLine("El número no tiene más de 3 cifras, intentelo de nuevo");
		}
	}
	else 
	{
		Console.WriteLine("No ingreso un valor valido, intentelo de nuevo");
	}
} while (vali == true);