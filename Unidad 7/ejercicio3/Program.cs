namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        char caracter1; //valor a reemplazar
        char caracter2; //valor que reemplaza
        char letra;
        char[] frase = new char[30];
        int indice = 0;
        Console.WriteLine("Ingrese una frase");
        letra = char.Parse(Console.ReadLine());
        while (letra != '0'){  //guardo la frase
            frase[indice] = letra;
            indice++;
            letra = char.Parse(Console.ReadLine());
        };
        Console.WriteLine("Ingrese un caracter que quieras reemplazar en la frase");
        caracter1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un caracter nuevo");
        caracter2 = char.Parse(Console.ReadLine());
        for(int x = 0; x < indice; x++){ //imprime la frase
            if(frase[x] == caracter1){
                frase[x] = caracter2;
            }
            Console.Write(frase[x]);
        };
    }
}
//alt+39 ''
/*Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
Mostrar el resultado en pantalla. Ejemplo:

CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni"
*/
