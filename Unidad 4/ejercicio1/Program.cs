namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Ingrese un numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = int.Parse(Console.ReadLine());
        if(num1 > num2) Console.WriteLine(num1 - num2);
        if(num1 == num2) Console.WriteLine(num1 + num2);
        if(num1 < num2) Console.WriteLine(num1 * num2); //producto        
    }
}
/*
Hacer un programa que solicite el ingreso de dos números y luego calcular:
La resta si el primero es mayor que el segundo.
La suma si son iguales.
El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente.
*/