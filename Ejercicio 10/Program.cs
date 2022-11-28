int num, sum = 0;
bool vali = true;
Random rNumber= new Random();
do
{
    Console.WriteLine("Ingrese para el tamaño de su matriz, el valor debe ser un número entero entre 3 y 6");
    if(int.TryParse(Console.ReadLine(), out num) && num >= 3 && num <= 6)
    {
        int[,] matriz = new int[num, num];
        vali = false;
        Console.WriteLine("Su Matriz es la siguiente");
        for (int i = 0; i < num; i++) //Colums
        {
            for (int j = 0; j < num; j++) //Rows
            {

                matriz[i, j] = rNumber.Next(1, 100);
                if (i == j)
                {
                    sum += matriz[i, j];
                }
            }
        }
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write($"{matriz[i,j]} ");
            }
            Console.Write("\n");
        }
        Console.WriteLine($"La suma de la diagonal es: {sum}");
    }
    else
    {
        Console.WriteLine("ERROR,no ingreso lo que se pide, intente de nuevo");
    }
} while (vali);




