using System;

namespace mayoromenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Este es un programa para saber que numero es mayor o menor\n ");
            int Num1, Num2, Num3;

            Console.WriteLine("\nDiga el primer numero\n ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDiga el segundo numero\n ");
            Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDiga el tercer numero\n ");
            Num3 = int.Parse(Console.ReadLine());

            int max = Num1;
            int min = Num1;

         
            if (Num2 > max)
                max = Num2; 
            if (Num3 > max)
                max = Num3;

            
            if (Num2 < min)
                min = Num2;
            if (Num3 < min)
                min = Num3;

            Console.WriteLine("El numero mayor es: " + max);
            Console.WriteLine("El numero menor es: " + min);

            Console.WriteLine();




        }
    }
}
