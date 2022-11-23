namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int num, r, pares=0;
        int[] numeros = new int[20];
        Console.WriteLine("Ingrese un numero entero!");
        for (int i = 0; i < 20; i++){
            num=int.Parse(Console.ReadLine());
            r=par(num);
            if(r == 1)pares++;
        };               
        Console.WriteLine("hay un total de "+pares+" numeros pares");

    }
    static int par(int num){
        if(num % 2 == 0) return 1;
        else return 0;

    }
}

//2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
// Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

