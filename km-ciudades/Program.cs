namespace km_ciudades;
class Program
{
    static void Main(string[] args)
    {
        int distancia, velocidad, resultado;
        Console.WriteLine("Ingrese la distacia en kilometros entre dos ciudades");
        distancia = int.Parse(Console.ReadLine());
        Console.WriteLine("Ahora ingrese la velocidad promedio de su vehiculo");
        velocidad=int.Parse(Console.ReadLine());
        resultado = distancia / velocidad;
        Console.WriteLine("Usted tiene un tiempo de viaje estimado de " + resultado + " horas hasta llegar a su destino." );
    }
}
//Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
//y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado
//que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

