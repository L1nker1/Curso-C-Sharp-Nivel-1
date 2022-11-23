namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int[] articulos = new int[16];
        int[] ventas = new int[16];
        int vendidos = 0; //
        int indice = 0;
        Console.WriteLine("Ingrese el numero del articulo");
        indice = int.Parse(Console.ReadLine()); //2
        articulos[indice] = indice;
        while (indice != 0)
        {
            Console.WriteLine("Cantidad de unidades vendidas"); //5
            vendidos = int.Parse(Console.ReadLine());
            ventas[indice] += vendidos;
            Console.WriteLine("Ingrese el numero del articulo");
            indice = int.Parse(Console.ReadLine());
            articulos[indice]=indice;
        }
        int mayor=0;
        int Indice_Vendidos=0;
        int Indice_Sin_Vender=0;
        int articulo10 = 0;
        string sin ="";
        for (int i = 1; i < 16; i++)
        {
            if(ventas[i]>mayor){
                mayor = ventas[i];
                Indice_Vendidos = i;
            };
            if(ventas[i] == 0){
                Indice_Sin_Vender = i;
                sin += (Indice_Sin_Vender+" ");
            };
            if(ventas[10] > 0 ){
                articulo10=ventas[10];
            }
        };
        Console.WriteLine("El articulo numero "+ Indice_Vendidos +" es el mas vendido con "+mayor+" unidades");// bien
        Console.WriteLine("Los articulos que no se vendieron son: " + sin);
        if(ventas[10] > 0){
            Console.WriteLine("El articulo numero 10 vendio un total de "+articulo10+" unidades");
        }else Console.WriteLine("El articulo 10 no registro ventas");
    }
}

/*Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10.

*/