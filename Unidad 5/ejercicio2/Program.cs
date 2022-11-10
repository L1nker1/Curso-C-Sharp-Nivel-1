namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int num1, new_num = 0, mayor = 0;
        int i = 1;

        do{
            Console.WriteLine("Ingrese un numero!");
            num1 = int.Parse(Console.ReadLine());
            if(mayor == 0) mayor = num1;  // tambien podria ser en un for cuando x valga 05
            if(num1 > mayor) mayor = num1; 
            i++;
        }while(i<=10);
        Console.WriteLine("el numero mayor es: "+ mayor);
    }
}

//2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
// Solo se debe emitir UN valor por pantalla.
