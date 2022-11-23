namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        float litros, importe; 
        Console.WriteLine("Ingrese la cantidad de litros vendidos");
        litros = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el importe a pagar");
        importe = float.Parse(Console.ReadLine());
        if(litros <= 100)
            //sin desc
            Console.WriteLine("su total a pagar  es de: " +importe);
        else if(litros >= 101 && litros < 300){
            //desc 10
            importe -= importe*0.10f;
            Console.WriteLine("su total a pagar es de: "+importe);
        }else if(litros >= 301 && litros <= 500){
            //desc 15
            importe -= importe*0.15f;
            Console.WriteLine("su total a pagar es de: "+importe);
        }else{
            //desc 25
            importe -= importe*0.25f;
            Console.WriteLine("su total a pagar es de: "+importe);
        }
        
    }
}
/*
Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
Si vende menos de 100 litros, no hay descuento.
Si vende entre 101 y 300 litros, el descuento es del 10%.
Si vende entre 301 y 500 litros, el descuento es del 15%.
Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y
la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
*/