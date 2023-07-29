using System;
public class DigitosNumero
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int digitos = 0;

        if (x < 0)
        {
            Console.WriteLine("(Advertencia: es un numero negativo)");
            x = -x;
        }

        while (x > 0)
        {
            x /= 10;
            digitos++;
        }

        if (digitos == 0)
        {
            digitos = 1;
        }

        Console.WriteLine("{0} digitos", digitos);
    }
}