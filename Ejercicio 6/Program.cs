int n;
Random nuevoNumero = new Random();
int guess = nuevoNumero.Next(1, 21);
int intentos = 4;
bool acierto = false;
Console.WriteLine("**SE HA GENERADOR UN NÚMERO RANDOM ENTRE 1 Y 20, TIENE 4 INTENTOS PARA ADIVINAR");
while (intentos > 0)
{
    Console.WriteLine("Ingrese el número que crea que es.");
    if (int.TryParse(Console.ReadLine(), out n) && (n > 0 && n  <= 20))
    {
        if (n == guess)
        {
            Console.WriteLine($"Usted ingreso: {n}, el número a adivinar era: {guess}");
            Console.WriteLine("Felicidades, ha adivinado el número");
            intentos = 0;
            acierto = true;
          
        }
        else if (n < guess)
        {
            Console.WriteLine("El número ingresado, esta por debajo del número a adivinar");
            intentos--;
        }
        else if (n > guess)
        {
            Console.WriteLine("El número ingresado, se pasó del número a adivinar");
            intentos--;
        }
    }
    else
    {
        Console.WriteLine("No ingreso un valor valido");
    }
}
if (intentos == 0 && !acierto)
{
    Console.WriteLine($"Ha fallado, el número a avidinar era {guess}");
}