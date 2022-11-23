namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int procesador, ram, almacenamiento;
        int resultado = 0;
        Console.WriteLine("Ingrese la opcion que represente su procesador");
        procesador = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la opcion que represente su ram");
        ram = int.Parse(Console.ReadLine());
        Console.WriteLine("Desea ampliar el disco de almacenamiento a 1TB?");
        almacenamiento = int.Parse(Console.ReadLine());

        if(procesador == 1 && ram == 1) resultado = 800;
        else if(procesador == 1 && ram == 2) resultado = 900;
        else if(procesador == 1 && ram == 3) resultado = 1000;
        
        if(procesador == 2 && ram ==1) resultado = 900;
        else if (procesador ==2 && ram == 2) resultado = 1000;
        else if (procesador == 3 && ram == 3) resultado = 1400;

        if(procesador == 3 && ram == 1) resultado = 1200;
        else if(procesador == 3 && ram == 2) resultado = 1400;
        else if(procesador == 3 && ram == 3) resultado = 2000;

        if(almacenamiento == 1) resultado += 500;
        

        /* switch (procesador){
            case 1:  //error en el case 1. no se por qué
                switch (ram){
                    case 1:
                        resultado = 800;
                        break;
                    case 2:
                        resultado = 1200;
                        break;
                    default:
                        resultado = 1500;
                        break;
                }
            case  2:
                switch (ram){
                    case 1:
                        resultado = 1000;
                        break;
                    case 2:
                        resultado = 1300;
                        break;
                }
            default: break;
        } */

        Console.WriteLine("El monto a pagar es de: " + resultado);
    }   
}
/*


Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

            i5 (1)	    i7 (2)	    i9 (3)
8 RAM (1)	USD 800	    USD 900	    USD 1200
16 RAM (2)	USD 900	    USD 1000	USD 1400
32 RAM (3)	USD 1000	USD 1400	USD 2000

Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar
a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador,
la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla
el monto de la máquina seleccionada.

*/