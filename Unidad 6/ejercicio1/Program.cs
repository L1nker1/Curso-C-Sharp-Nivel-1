namespace ejercicio1;
class Program
{
//Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos
    static void Main(string[] args)
    {
        int primos=0, divi, num1;

        for(int i = 0; i < 5; i++){
            Console.WriteLine("ingrese el primer numero");
            num1=int.Parse(Console.ReadLine()); 
            divi=0;
            for(int x = 1 ; x <= num1; x++){ //si un numero es divisible mas de 2 veces no es primo
                if(num1 % x == 0){ //condicion para saber si es divisible 
                    divi++;
                }
            }
            if(divi == 2){ //si el contador es 2, es primo, sumo uno al contador de primos.
                primos++;
            } 
        }
        Console.WriteLine("hay un total de "+primos+" numeros primos");
    }
}