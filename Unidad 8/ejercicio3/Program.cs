namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int num, r, primos=0, cont=0;

        Console.WriteLine("Ingrese un entero");
        //cargado de numeros
        num=int.Parse(Console.ReadLine()); 
        while (num != 0){
            r = primo(num); //funcion primo
            if(r == 1){
                primos += num;
                cont++;
            }
            Console.WriteLine(r);
            num=int.Parse(Console.ReadLine());
        }
        //promedio
        r = primos / cont;
        Console.WriteLine("El promedio de numeros primos es: "+r);
    }
    static int primo(int num){
        bool primo = true;
        for (int i = 2; i < num; i++){
            if(num % i == 0) primo = false;
        }
        if(primo == true) return 1;
        else return 0;

    }
}

//3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
//Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
//Informar el promedio teniendo en cuenta sólo los números primos.

