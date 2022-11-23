namespace promedio;
class Program
{
    static void Main(string[] args)
    {
        float nota1, nota2, nota3;
        float promedio;
        Console.WriteLine("Ingrese su primer calificacion");
        nota1= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su segunda calificacion");
        nota2= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su tercer calificacion");
        nota3= int.Parse(Console.ReadLine());
        promedio = (nota1+nota2+nota3) / 3;
        Console.WriteLine("Su promedio es de "+ promedio.ToString("0.00"));
    }
}

//ingresar 3 notas, calcular promedio.