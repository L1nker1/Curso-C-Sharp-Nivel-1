namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int num, acu = 0, promedio = 0;
        int[] array = new int[11];
        int[] resultado = new int[11];
        Console.WriteLine("Ingrese 10 numeros enteros!");
        for (int i = 0; i < 10; i++) //cargo 10 y sumo los valores
        {
            num = int.Parse(Console.ReadLine());
            array[i] =  num;
            acu += array[i];

        };
        promedio = acu / 10; //saco promedio

        Console.WriteLine("Los numeros mayores al promedio son: ");
        for(int x = 0; x<10;x++) //reviso el array y comparo cada numero con el promedio.
        {
            if(array[x] > promedio){
                Console.WriteLine(array[x]);
            }
        };
    }
}
//Hacer un programa que solicite 10  números enteros y los guarde en un vector.
//Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

