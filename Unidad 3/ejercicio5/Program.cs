namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, num4;
        int mayor = 100;
        Console.WriteLine("Ingrese un numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("numeros mayores a " + mayor + ":");
        if(mayor < num1 ) Console.WriteLine(num1);
        if(mayor < num2 ) Console.WriteLine(num2);
        if(mayor < num3) Console.WriteLine(num3); 
        if(mayor < num4) Console.WriteLine(num4); 
    }
}
//5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

