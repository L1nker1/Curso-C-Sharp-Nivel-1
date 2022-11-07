namespace num_cubo;
class Program
{
    static void Main(string[] args)
    {
        int num, resultado;
        Console.WriteLine("Ingrese el numero que quiera elevar al cubo");
        num = int.Parse(Console.ReadLine());
        resultado =num*num*num;
        Console.WriteLine("El resultado es " + resultado);

    }
}
