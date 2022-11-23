namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int a=0, num;
        Console.WriteLine("ingrese un entero");
        num = int.Parse(Console.ReadLine());
        positivoNegativoCero(num ,ref a);
        Console.WriteLine("El valor de a es: "+ a);
    }
    static void positivoNegativoCero(int num, ref int a){
        if(num > 0) a = 1;
        if(num < 0) a = -1;
        if(num == 0) a = 0;

    }
}
//Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
// que reciba un número por valor y una variable por referencia.
// Que analice el número y escriba variable recibida por referencia con:

//a. 1 si el número es positivo.
//b. -1 si el número es negativo.
//c. 0 si el número es cero.

