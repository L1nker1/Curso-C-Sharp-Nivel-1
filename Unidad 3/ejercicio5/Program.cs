namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, num4, cont = 0;
        int mayor = 100;
        Console.WriteLine("Ingrese un numero:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ultimo numero:");
        num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("-------");
        if(mayor < num1 ){
            Console.WriteLine(num1);
            cont++;
        } 
        if(mayor < num2 ) {
            Console.WriteLine(num2);
            cont++;
        }
        if(mayor < num3){
            Console.WriteLine(num3); 
            cont++;
        } 
        if(mayor < num4){
            Console.WriteLine(num4); 
            cont++;
        }
        if(cont != 0)
            Console.WriteLine("Son mayores a 100");
    }
}
//5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

