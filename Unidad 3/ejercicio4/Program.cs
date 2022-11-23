namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, num4, menor;
        Console.WriteLine("Ingrese un numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num4 = int.Parse(Console.ReadLine());
        
        menor = num1;
        if(menor > num2 )
            menor = num2;
        if(menor > num3) 
            menor=num3; 
        if(menor > num4)
            menor =num4; 
        Console.WriteLine("El numero menor es: "+ menor);
    }
}
//4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

