namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int num1;
        bool primo = true;
        Console.WriteLine("Ingrese un numero");
        num1 = int.Parse(Console.ReadLine());
        for(int i = 2 ; i < num1; i++){
            if(num1 % i == 0) primo = false;
        }
        if(primo == true) Console.WriteLine("El numero es primo");
        else Console.WriteLine("El numero no es primo");
    }
}

//4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
//Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

