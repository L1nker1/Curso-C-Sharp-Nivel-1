namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int precio=0, cantidadVentas=0, r;

        Console.WriteLine("ingrese el precio del articulo");
        precio=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la cantidad vendida");
        cantidadVentas=int.Parse(Console.ReadLine());
        r=producto(precio,cantidadVentas);
        Console.WriteLine("El monto total a pagar es de ");
        Console.Write(r);
    }
        static int producto(int a, int  b){
            int r;
            r=a*b;
            return r; 
    }
}

//En este caso, la idea va a ser armar una función que resuelva algo y luego armar un main que interactúe
// con una persona para pedir y mostrar datos pero que llame a esa función para resolver lo planteado. Vamos?

// Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
// Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

