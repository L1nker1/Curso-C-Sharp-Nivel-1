namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, num4;

        Console.WriteLine("Ingrese un numero");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero");
        num2=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero");
        num3=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero");
        num4=int.Parse(Console.ReadLine());
        if(num1 > num2 && num2 > num3 && num3 > num4)
            Console.WriteLine("Los numeros están ordenados");
    }
}
/*
Hacer un programa para ingresar 4 números.
Luego analizar e informar por pantalla si los mismos
se encuentran ordenados de forma decreciente .
*/