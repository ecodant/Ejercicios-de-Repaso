
using System.Text.RegularExpressions;

string[] names = new string[5];
int[] ages = new int[5];
int count = 0, edad;
Regex valiString = new Regex(@"^[a-zA-Z]+$");


datosGathering();
printMayores();
;void printMayores()
{
    Console.Write("Las personas mayores de edad son: ");
    for (int i = 0; i < 5; i++)
    {
        if (ages[i] >= 18)
        {
            Console.Write($", {names[i]}");
        }
    }
    Console.Write("\n");
}
void datosGathering()
{
	do
	{
		Console.WriteLine("Escriba un nombre");
		string? inputText = Console.ReadLine();
		if (valiString.IsMatch(inputText))
		{
			names[count] = inputText;
            bool vali = true;
            while(vali)
            {
                Console.WriteLine("Escriba una edad");
                if (int.TryParse(Console.ReadLine(), out edad) && edad > 0)
                {
                    ages[count] = edad;
                    count++;
                    vali = false;
                }
                else
                {
                    Console.WriteLine("No es un valor valido para edad");
                }
            }
        }
		else
		{
			Console.WriteLine("No es un valor valido para un nombre");
		}
    } while (count < 5);
   
}
