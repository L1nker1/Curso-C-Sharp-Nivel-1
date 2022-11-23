namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int promedio=0, mayores=0, numero;
        for(int i = 1; i <= 20; i++){
            Console.WriteLine("Ingrese su edad");
            numero = int.Parse(Console.ReadLine());
            if(numero >= 18){
                promedio += numero; 
                mayores++;
            }
        }
        //Console.WriteLine(mayores);
        //Console.WriteLine(promedio);
        promedio = promedio / mayores;
        Console.WriteLine("El promedio de todos los mayores de edad es: "+ promedio);
    }
}

//3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

