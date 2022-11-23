namespace sueldo;
class Program
{
    static void Main(string[] args)
    {
        float Facturacion, Comision, SueldoFinal;
        float SueldoBase = 15000;
        float porcentajeBonus = 0.05F;
        Console.WriteLine("Ingrese el valor de facturacion del empleado");
        Facturacion = int.Parse(Console.ReadLine());
        Comision = Facturacion * porcentajeBonus;
        SueldoFinal = SueldoBase + Comision;
        Console.WriteLine("El sueldo correspondiente a cobrar es de " + SueldoFinal + " pesos");
    }
}

//4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
// más una comisión del 5% sobre el total facturado por cada empleado.
// Hacer un programa para ingresar el total facturado por un empleado y que luego calcule
// y emita por pantalla el sueldo total a cobrar por el mismo.

