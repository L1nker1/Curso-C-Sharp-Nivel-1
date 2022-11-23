namespace ejercicio3;
class Program
{
    //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
    //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
    static void Main(string[] args)
    {
        int num = 1, cont=0, lista=0;

        while (num >= 0) //positivo
        {   
            lista++;
            Console.WriteLine("Ingrese un numero!");
            num= int.Parse(Console.ReadLine());
            while (num > 0){
                    cont++;
                    num= int.Parse(Console.ReadLine());   
            }
            if (cont != 0) Console.WriteLine("la lista numero "+lista+" tiene un total de "+cont+" numeros");
            cont = 0;
        }
    }
}

//debe cargar numeros
//si se ingresa 0, pasa a la siguiente lista
//si se ingresa -1 corta