namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3;
        Console.WriteLine("Ingrese el primer numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el sugundo numero");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero");
        num3 = int.Parse(Console.ReadLine());
        if(num1 + num2 > num2*num3){
            Console.WriteLine("La suma de los primeros dos numeros es mayor al producto de los ultimos dos");
            Console.WriteLine((num1 + num2) + " es mayor que " + (num2*num3));
        }
    }
}
/*
Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma
de los dos primeros es mayor al producto del segundo con el tercero.
*/