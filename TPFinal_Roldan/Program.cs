using System;

namespace TPFinal_Roldan
{
    class Program
    {
        static void Main(string[] args)
        {
        /*  Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            a. El mayor de los números Pares.
            b. La cantidad de números impares.
            c. El menor de los números primos.

            Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda
            */

            int num, mayorPares=0, cantidadImpar=0, menorPrimo=0;
            bool primos;
            Console.WriteLine("Comience a cargar numeros de a uno, pueder cortar la carga ingresando el 0");
            num=int.Parse(Console.ReadLine());
            while (num != 0)
            {
                if(num % 2 == 0 ){ //pares
                    if(mayorPares == 0) mayorPares=num;
                    else if(num > mayorPares) mayorPares = num;
                }else cantidadImpar++;  //impares

                //primos
                primos = primo(num);
                if(primos == true){
                    if(menorPrimo == 0) menorPrimo=num;
                    else if (menorPrimo > num)menorPrimo=num;
                }
                num=int.Parse(Console.ReadLine());
            }
            if (mayorPares == 0) Console.WriteLine("No se ingresaron numeros Pares");
            else Console.WriteLine("El mayor de los numeros Pares ingresados es: "+mayorPares);

            if(cantidadImpar == 0) Console.WriteLine("No se ingresaron numeros Impares");
            else Console.WriteLine("La cantidad de numeros impares ingresados es de: "+cantidadImpar);

            if(menorPrimo == 0) Console.WriteLine("No se ingresaron numeros Primos");
            else Console.WriteLine("El menor de los numeros Primos ingresados es: "+menorPrimo);
        }
        static bool primo (int num){
            bool primo = true;
            for (int i = 2; i < num; i++){
                if(num % i == 0) primo = false;
            }
            if(num > 0 && primo == true) return primo;
            else return false;
        }
    }
}
