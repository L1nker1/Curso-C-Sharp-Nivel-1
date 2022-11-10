namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int num, pares = 0, impares=0;
        for(int i = 0; i< 5; i++ ){
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0){
                if(pares==0) pares = num;
                if(pares < num) pares = num;

            }else if(num % 2 != 0){
                if(impares == 0) impares = num;
                if(impares > num) impares = num;
            }
        }
        Console.WriteLine("El mayor de los pares es: "+pares);
        Console.WriteLine("El menor de los impares es: "+impares);
    }
}

//5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.