namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int num, mayor = 0,pos=0;
        int[] array = new int[10];
        Console.WriteLine("Ingrese 10 numeros enteros");
        for (int i = 0; i < 10; i++)
        {
            num = int.Parse(Console.ReadLine());
            array[i]= num;
            if(array[i] > mayor){
                mayor = array[i];
                pos = i;
            } 
        }
        Console.WriteLine("El valor maximo dentro del array es: "+mayor+ " y se encuentra en la posicion "+ pos);

    }
}


//Hacer un programa que solicite 10 números enteros y los guarde en un vector.
//Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

