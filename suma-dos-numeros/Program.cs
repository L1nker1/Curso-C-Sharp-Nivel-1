namespace suma_dos_numeros;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, resultado;
        Console.WriteLine("ingrese un numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese otro numero");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 + num2;
        Console.WriteLine("El resultado de la suma es: " + resultado);
    }
}
