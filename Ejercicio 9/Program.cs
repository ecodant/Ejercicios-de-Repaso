

int residuo = 1, count = 0, num;
bool vali = true;



do
{
    Console.WriteLine("Ingrese un número entero de 2 cifras que desea que se convierta en binario.");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num.ToString().Length < 3)
        {
            calculaBin(num);
            vali= false;
        }
        else
        {
            Console.WriteLine("No es un número de 2 cifras.");
        }
    }
    else
    {
        Console.WriteLine("Lo que ingreso no es algo valido.");
    }
} while (vali);



void calculaBin(int n)
{
    string resultado = "";
        while (n != 0)
        {
            residuo = n % 2;
            n = n / 2;
            resultado = resultado + residuo;
            count++;
        }
    char[] numBinario = resultado.ToCharArray();
    Array.Reverse(numBinario);
    Console.Write($"Operación completada su número en binario es: {new string(numBinario)}");
    //for (int i = 0 ; i < numBinario.Length; i++)
    //{
    //    Console.Write(numBinario[i]);
    //}
}

