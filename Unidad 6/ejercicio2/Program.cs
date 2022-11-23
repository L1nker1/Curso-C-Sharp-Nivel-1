namespace ejercicio2;
class Program
{
    //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
    //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

//% de numeros impares
//cantidad de numeros por grupo
//grupos que se encuentren ordenados de mayor a menor
    static void Main(string[] args)
    {
        int num;
        int cont = 0;
        int impares = 0;
        int porcentajeImpares;
        int contMayorMenor =-1;
        int Mayor_Menor = 0;
        bool Ordenado = true;
        for(int i = 0 ; i < 5; i++){ //5 listas
            Console.WriteLine("Ingrese un numero"); //ingreso numero, si no es 0 comienza a contar
            num =  int.Parse(Console.ReadLine());
            Mayor_Menor = num;
            while (num != 0)
            {
                cont++; //contador de numeros
                if(num % 2 != 0) impares++; //numeros impares
                if(num <= Mayor_Menor){
                    contMayorMenor++;
                    Mayor_Menor = num;
                }else Ordenado = false;

                num =  int.Parse(Console.ReadLine());
            };
            if(Ordenado) Console.WriteLine("El grupo "+(i + 1)+" Se encuentra ordenado de mayor a menor");
            else Console.WriteLine("El grupo no se encuentra ordenado de mayor a menor");
            porcentajeImpares = impares * 100 / cont;
            Console.WriteLine("El grupo cuenta con "+cont+" numeros y un porcentaje de "+porcentajeImpares+" % de numeros son impares");
            cont = 0;
            impares=0;
        };
    }
}
