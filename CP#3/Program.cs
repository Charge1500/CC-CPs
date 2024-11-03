using System.Runtime.Intrinsics.Arm;

public class Program{

    
    static void Main(string[] args){

        while(true){
            Console.Clear();

            PrintExercises();

            Console.Write("> ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                continue;
            }
    
            int option = int.Parse(input);

            switch (option)
            {
                case 1:
                    PrintEnunciado(option);    
                    Factorial();
                    break;

                case 2:
                    PrintEnunciado(option);
                    SumaDeImpares();
                    break;

                case 3:
                    PrintEnunciado(option);
                    MayorMenorPromedio();
                    break;

                case 4:
                    PrintEnunciado(option);
                    RecorriendoArrays();
                    break;

                case 5:
                    PrintEnunciado(option);
                    InvertirArreglo();        
                    break;
                case 6:
                    PrintEnunciado(option);
                    FiltrandoPositivos();    
                    break;
                case 7:
                    PrintEnunciado(option);
                    Rotando();
                    break;
                case 8:
                    PrintEnunciado(option);
                    MezclaOrdenada();
                    break;
                case 9:
                    PrintEnunciado(option);
                    FinalElArr();
                    break;
                case 10:
                    PrintEnunciado(option);
                    Insertando();
                    break;
                case 11:
                    PrintEnunciado(option);
                    Eliminando();
                    break;
                case 12:
                    PrintEnunciado(option);
                    RepresentacionBinaria();
                    break;
                case 13:
                    PrintEnunciado(option);
                    EsPrimo();
                    break;
                case 14:
                    PrintEnunciado(option);
                    NumeroPerfecto();
                    break;
                case 15:
                    PrintEnunciado(option);
                    Substring();
                    break;
                case 16:
                    PrintEnunciado(option);
                    EsPalindromo();
                    break;
                case 17:
                    PrintEnunciado(option);
                    SufijoParaPalindromo();
                    break;
                case 18:
                    PrintEnunciado(option);
                    Ordenado();
                    break;
                case 19:
                    PrintEnunciado(option);
                    Mediana();
                    break;
                case 20:
                    Console.WriteLine("Adiós");
                    return;
                default:
                    return;
            }

            Console.WriteLine("\n-----------\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }


    }

    static void PrintExercises(){
        Console.WriteLine("EJERCICIOS RESUELTOS DE LA CP#1 DE POGRAMACIÓN");
        Console.WriteLine("Seleccione uno de los ejercicios siguientes para observar los resultados:");
        Console.WriteLine("--------");
        Console.WriteLine("1️⃣ Factorial");
        Console.WriteLine("2️⃣ Suma de impares");
        Console.WriteLine("3️⃣ Mayor, menor y promedio de forma perezosa");
        Console.WriteLine("4️⃣ Recorriendo arrays");
        Console.WriteLine("5️⃣ Invirtiendo");
        Console.WriteLine("6- Filtrando Positivos");
        Console.WriteLine("7- Rotando");
        Console.WriteLine("8- Mezcla ordenada");
        Console.WriteLine("9- Añadiendo al final");
        Console.WriteLine("10- Insertando");
        Console.WriteLine("11- Eliminando");
        Console.WriteLine("12- Representación Binaria");
        Console.WriteLine("13- Es Primo");
        Console.WriteLine("14- Número Perfecto");
        Console.WriteLine("15- Substring");
        Console.WriteLine("16- Es Palíndromo");
        Console.WriteLine("17- Menor sufijo para ser palíndromo");
        Console.WriteLine("18- Ordenado");
        Console.WriteLine("19- Mediana");
        Console.WriteLine("20--Salir--");

    }

    //EJERCICIO 1
    static void Factorial(){
        Console.WriteLine("Inserte un número para calcular su factorial");

        long n=long.Parse(Console.ReadLine()!);
        long resultado=1;

        for(long i=n;i>1;i--){
            resultado*=i;
        }

        Console.WriteLine($"El factorial de {n} es {resultado}");
    }

    //EJERCICIO 2
    static void SumaDeImpares(){
        Console.WriteLine("Inserte un número para hallar la suma de los primeros impares menores iguales que n");

        int n=int.Parse(Console.ReadLine()!);
        int resultado=0;

        for(int i=1;i<=n;i+=2){
            resultado+=i;
        }

        Console.WriteLine($"La suma de los {n} impares es {resultado}");
    }        

    //EJERCICIO 3
    static void MayorMenorPromedio(){

        int cantidad=0;
        int num;
        string nums="";
        int mayor=int.MinValue;
        int menor=int.MaxValue;
        float promedio=0;


        Console.WriteLine("Inserte una secuencia de números,para no insertar más toque espacio y luego enter");
        while(true){
            
            nums=Console.ReadLine();

            if(cantidad!=0 && nums==""){
                promedio/=cantidad;
                break;
            }
            num=int.Parse(nums);
            cantidad++;

            if(menor>num){
                menor=num;
            }
            if(mayor<num){
                mayor=num;
            }

            promedio+=num;
        }

        Console.WriteLine("El mayor, el menor y el promedio de su lista son respectivamente:");
        Console.WriteLine($"El mayor es {mayor}");
        Console.WriteLine($"El menor es {menor}");
        Console.WriteLine($"El promedio es {promedio}");
    }

    //EJERCICIO 4
    static int[] CreandoArreglo()
    {
        Console.WriteLine("Inserte el tmaño de un arreglo y luego inserte sus elementos elementos");

        Console.WriteLine("Tamaño del arreglo");
        int tam=int.Parse(Console.ReadLine());
        int[] n=new int[tam];

        Console.WriteLine($"Inserte cada elemento del arreglo de tamaño {tam}");
        for(int i=0;i<n.Length;i++){
            n[i]=int.Parse(Console.ReadLine());
        }
        return n;
    }
    static float CalcularPromedioArreglo(int[] arreglo){
        float promedio=0;

        for (int i = 0; i < arreglo.Length; i++)
                {
                    promedio+=arreglo[i];
                }
                promedio/=(float)(arreglo.Length);
        return promedio;
    }

    static void RecorriendoArrays(){
        Console.WriteLine("¿Cuál de las opciones desea ejecutar?:");
        Console.Write(">");
        string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }
    
            int option = int.Parse(input);

            int[] n=CreandoArreglo();

        switch(option){
            case 1: 
                
                int mayor=int.MinValue;

                for (int i = 0;i<n.Length;i++){
                    if(mayor<n[i]){
                        mayor=n[i];
                    }
                }
                Console.WriteLine($"El mayor número del arreglo es:{mayor}" );
            break;
            case 2:
                int menor=int.MaxValue;
                int menor2=int.MaxValue;


                for (int i = 0;i<n.Length;i++){
                    if(menor>n[i]){
                        menor2=menor;
                        menor=n[i];
                    } else if(menor2>n[i]){
                        menor2=n[i];
                    }
                }

                Console.WriteLine($"El segundo menor número del arreglo es:{menor2}" );
    
            break;
            case 3: 
                
                System.Console.WriteLine("Inserte un número para saber si pertenece al array");
                int num=int.Parse(Console.ReadLine()!);

                for (int i = 0; i < n.Length; i++)
                {
                    if(num==n[i]){
                        System.Console.WriteLine($"El número {num} pertenece al arreglo");
                        break;
                    }
                }

            break;
            case 4:

                System.Console.WriteLine($"El promedio de la suma de los elementos del arreglo es {CalcularPromedioArreglo(n)}");

            break;
            case 5:

            int cant=0;
            float promedio=CalcularPromedioArreglo(n);

            for (int i = 0; i < n.Length; i++)
            {
                if(promedio<n[i]){
                    cant++;
                }
            }
            System.Console.WriteLine($"Hay {cant} que son mayores que el promedio del array");  
            break;
            default:
            return;
        }
    }
    
    //Ejercicio 5

    static void InvertirArreglo(){
        int[] n1=CreandoArreglo();
        int[] n2=new int[n1.Length];
        int j=n1.Length-1;

       for (int i = 0; i < n2.Length; i++)
        {
            n2[i]=n1[j];
            j--;
            System.Console.Write($"{n2[i]} ");
        }
    }

    //Ejercicio 6

    static void FiltrandoPositivos(){
        int[] n1=CreandoArreglo();
        int[] n2=new int[n1.Length];
        int j=0;
        System.Console.WriteLine("Los números positivos del arreglo son");
       for (int i = 0; i < n2.Length; i++)
        {
            if(n1[i]>=0){
                n2[j]=n1[i];
                System.Console.Write($"{n2[j]} ");
                j++;
            }
            
        }
    }

    //Ejercicio 7

    static void Rotando(){
        /*int[] a=CreandoArreglo();
        int[] resultado=new int[a.Length];

        Console.WriteLine("Introduzca cuantas veces desea que rote el array");
        int n=int.Parse(Console.ReadLine());  

        n=n%a.Length;
        for(int i=0;i<a.Length;i++){
            if(n>0){
                resultado[(i+n)%a.Length]=a[i];
            }   else if(n==0){
                resultado=a;
            }   else{
                if(i<n)
                    resultado[a.Length-(i+n)]=a[i];
                else{
                    resultado[i+n]=a[i];
                }
            }
            Console.Write($"{resultado[i]  } ");
        }*/
        System.Console.WriteLine("Por resolver");
    }

    //Ejercicio 8

    static void MezclaOrdenada(){
        System.Console.WriteLine("Inserte dos arreglos ordenados para unirlos y crear un nuevo arreglo ordenado");
        int[] arr1=CreandoArreglo();
        int[] arr2=CreandoArreglo();
        int[] arr3=new int[arr1.Length+arr2.Length];

        int j=0;//Elementos de arr3
        for (int i = 0; i < arr1.Length; i++)//Creando arr3
        {
            arr3[j]=arr1[i];
            j++;
        }
        for (int i = 0; i < arr2.Length; i++)//Creando arr3
        {
            arr3[j]=arr2[i];
            j++;
        }
        for (int i = 0; i < arr3.Length; i++)
        {
           for (int z = 0; z < arr3.Length-1; z++)
           {
            if(arr3[z]>arr3[z+1]){
                int aux;
                aux=arr3[z];
                arr3[z]=arr3[z+1];
                arr3[z+1]=aux;
            }
           } 
        }
        Console.WriteLine("Array mezclado ordenado: " + string.Join(", ", arr3));

    }

    //Ejercicio 9
    public static void FinalElArr(){
        int[] arr=CreandoArreglo();
        System.Console.WriteLine("¿Qué elemento desea añadir al final del arreglo?");
        int el=int.Parse(Console.ReadLine()!);

        Array.Resize(ref arr, arr.Length+1);
        arr[arr.Length-1]=el;

        System.Console.WriteLine("Nuevo arreglo " + string.Join(" ",arr));
    }

    //Ejercicio 10
    static void Insertando(){
        int[] arr=CreandoArreglo();

        System.Console.WriteLine("Posición del arreglo que desea modificar");
        int pos=int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Valor a insertar");
        int val=int.Parse(Console.ReadLine()!);

        Array.Resize(ref arr, arr.Length+1);
        
        for (int i=pos; i<arr.Length-1;i++){
            int aux=arr[i];
            arr[i]=arr[i+1];
            arr[i+1]=aux;
        }
        arr[pos]=val;

        System.Console.WriteLine("Arreglo con el elemento agregado: " + string.Join (" ",arr));
    }

    //Ejercicio 11
    static void Eliminando(){
        int[] arr=CreandoArreglo();

        System.Console.WriteLine("Diga el elemento a elminar a través de su posición");
        int pos=int.Parse(Console.ReadLine()!);

        for (int i = pos; i < arr.Length-1; i++)
        {
            arr[i]=arr[i+1];
        }
        Array.Resize(ref arr, arr.Length-1);

        System.Console.WriteLine("Arreglo con el elemento eliminado: " + string.Join(" ",arr));
    }

    //Ejercicio 12
    static void RepresentacionBinaria(){
        Console.WriteLine("¿Cuál de las opciones desea ejecutar?:");
        Console.Write(">");
        string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }
    
            int option = int.Parse(input);

        switch(option){
            case 1: 
                System.Console.WriteLine("Inserte un número entero no negativo para convertirlo a número binario");
                int num=int.Parse(Console.ReadLine()!);
                string binario="";
                while(num>0){
                    int resto=num%2;
                    num/=2; 
                    binario+=$"{resto}";
                }

                char[] binarioChar=binario.ToCharArray();//convirtiendo string a arreglo de caracteres
                Array.Reverse(binarioChar);//invirtiendo arreglo de caracteres
                binario = new string(binarioChar);
                System.Console.WriteLine(binario);

            break;
            case 2:
                System.Console.WriteLine("Inserte un número binario para convertirlo a decimal");
                string binary=Console.ReadLine()!;
                int ndecimal=0;
    
                for (int i = 0; i < binary.Length; i++)
                {
                    char valor=binary[binary.Length-(1+i)];
                    if (valor == '1'){
                        ndecimal+=(int)(Math.Pow(2,i));
                    }
                }
                System.Console.WriteLine(ndecimal);
            break;
            default:
            return;
        }
    }

    //Ejercicio 13
    static void EsPrimo(){
        System.Console.WriteLine("Introduzca un número entero positivo para saber si es primo");
        int num = int.Parse(Console.ReadLine()!);

        
        if (num==1){
            System.Console.WriteLine("1 no es un número primo");
        } else if(num==2){
            System.Console.WriteLine($"{num} es un número primo");
        } else if(num%2==0 && num>2){
            System.Console.WriteLine($"{num} no es un número primo");
        } else if(num<=0){
            System.Console.WriteLine($"{num} tiene que ser un entero positivo");
        }   else{
            for (int i = num-1; i > 1; i-=2){
                if(num%i==0){
                    System.Console.WriteLine($"{num} no es un número primo");
                    break;
                }
                if(i==2 ){
                    System.Console.WriteLine($"{num} es un número primo");
                }
            }
        }   
    }

    //Ejercicio 14
    static void NumeroPerfecto(){
        System.Console.WriteLine("Introduzca un número entero para saber si es perfecto");
        System.Console.WriteLine(" Un número es perfecto si la suma de sus divisores propios es igual a el. Ejemplo: 28 = 1 + 2 + 4 + 7 + 14");
        int num=int.Parse(Console.ReadLine()!);
        int resultado=0;
        for (int i=1;i<num;i++){
            if(num%i==0){
                resultado+=i;
            }
        }
        if(num==resultado){
            System.Console.WriteLine($"{num} es un número perfecto");
        } else{
            System.Console.WriteLine($"{num} NO es un número perfecto");
        }
    }

    //Ejercicio 15
    static void Substring(){
        System.Console.WriteLine("Por resolver");
    }
    static int[] OrdenarArreglo(int[] arr){
        int aux=0;
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr.Length-1;j++){
                if(arr[j]>arr[j+1]){
                    aux=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=aux;
                }
            }
        }
        return arr;
    }

    //Ejercicio 16
    static void EsPalindromo(){
        System.Console.WriteLine("Introduzca una palabra para saber si es un palíndromo");
        string palabra=Console.ReadLine()!;
        char[] palindromo=palabra.ToCharArray();
        Array.Reverse(palindromo);
        string palabraInvertida=new string(palindromo);
        if(palabraInvertida==palabra){
            System.Console.WriteLine($"La palabra {palabra} es un palíndromo");
        } else{
            System.Console.WriteLine($"La palabra {palabra} NO es un palíndromo");
        }
        
        
    }

    //Ejercicio 17
    static void SufijoParaPalindromo(){
        System.Console.WriteLine("Por resolver");
    }

    //Ejercicio 18
    static void Ordenado(){
        int[] arr=CreandoArreglo();

        arr=OrdenarArreglo(arr);    
        System.Console.WriteLine("Arreglo ordenado:" + string.Join(" ",arr));    

    }

    //Ejercicio 19
    static void Mediana(){
        int[] a=CreandoArreglo();

        a=OrdenarArreglo(a);

        Console.WriteLine($"La mediana del arreglo es: {a[a.Length/2]}");
    }

    static void PrintEnunciado(int option){
        Console.Clear();
        Console.WriteLine("-------------Enunciado-------------");
        switch (option)
            {
                case 1:
                    Console.Write("FACTORIAL:\n");       
                    Console.WriteLine("Implemente un programa que reciba un numero entero positivo ´ n de la consola y calcule el factorial de ese numero.”");       
                    Console.WriteLine("El factorial de un numero ´ n (denotado como n!) se define como el producto de todos los");       
                    Console.WriteLine("numeros enteros positivos desde 1 hasta ´ n, o lo que es lo mismo:");       
                    break;

                case 2:
                    Console.Write("SUMA DE IMPARES:\n");
                    Console.WriteLine("Implemente un programa que reciba un entero n e imprima la suma de los primeros n numeros impares.");
                    break;

                case 3:
                    Console.Write("Mayor,menor y promedio de forma perezosa\n");
                    Console.WriteLine("Implemente un programa que lea una secuencia de numeros de la consola (uno por línea) hasta que se escriba una l´ınea en blanco y de estos imprimir:");
                    Console.WriteLine("El mayor\nEl menor\nSu promedio");
                    break;

                case 4:
                    Console.Write("Recorriendo Arrays\n");
                    Console.WriteLine("Implemente un metodo para cada inciso, que reciba un array de enteros y devuelva");
                    System.Console.WriteLine("1. El mayor elemento de un array.");
                    System.Console.WriteLine("2. El segundo menor elemento de un array");
                    System.Console.WriteLine("3. Si un numero n pertenece al array a.");
                    System.Console.WriteLine("4. El promedio de todos los elementos de un array");
                    System.Console.WriteLine("5. La cantidad de elementos que son mayor que el promedio en un array.");
                    break;
                case 5:
                    System.Console.WriteLine("Invirtiendo");
                    System.Console.WriteLine("Implemente un metodo que dado el array ´ a que recibe como entrada, devuelva otro array con \nlos elementos de a en orden inverso. Ejemplo: recibe: [2, 7, −9] y devuelve [−9, 7, 2].");
                    break;
                case 6:
                    System.Console.WriteLine("Filtrando Positivos:");
                    System.Console.WriteLine("Implemente un metodo que reciba un array ´ a y devuelva un nuevo array con todos los elementos positivos del array a");
                break;
                case 7:
                    System.Console.WriteLine("Rotando");
                    System.Console.WriteLine("Implemente un metodo que reciba un array ´ a y un entero veces y rote los elementos del array tantas veces como indique el parametro ´ veces.");
                    System.Console.WriteLine("Si veces es positivo, rota los elementos a la derecha; si es negativo, rota los elementos a la izquierda. Si veces es 0, el array no se modifica");
                    System.Console.WriteLine("Por ejemplo, si rotamos el array [25, 40, 17, 83, 9] 2 veces, obtenemos el array [83, 9, 25, 40, 17], y si lo rotamos -2 veces entonces nos queda [17, 83, 9, 25, 40]");
                break;
                case 8:
                System.Console.WriteLine("Mezcla ordenada");
                System.Console.WriteLine("Implemente un metodo que a partir de los arrays ordenados ´ a y b debera devolver un nuevo ´ array que sea la mezcla ordenada de estos. ");
                System.Console.WriteLine("s. Por ejemplo, si el array a es [23, 40, 83] y el array b es [5, 17, 23, 24, 51], entonces el resultado sera el array ´ [5, 17, 23, 23, 24, 40, 51, 83]");
                break;
                case 9:
                System.Console.WriteLine("AñadiendoAlFinal");
                System.Console.WriteLine("Implemente un metodo que reciba un valor ´ val y anada dicho valor al final del array ˜ a,devolviendo un nuevo array con el elemento anadido");
                break;
                case 10:
                System.Console.WriteLine("Insertando");
                System.Console.WriteLine("Implemente un metodo que, dado un entero ´ pos y un valor val, inserte el valor val en la \n posicion´ pos de a, desplazando los elementos existentes hacia la derecha, devuelva un nuevo array con el elemento insertado");
                break;
                case 11:
                System.Console.WriteLine("Eliminando");
                System.Console.WriteLine("Implemente un metodo que, dado un entero ´ pos referente a determinada posicion del array ´ \n a, elimine el elemento que se encuentra en dicha posicion, devuelva un nuevo array sin ese ´ elemento.");
                break;
                case 12:
                System.Console.WriteLine("Representacion binaria");
                System.Console.WriteLine("1. Implemente un metodo que reciba un n ´ umero entero no negativo y devuelva un string ´ con su representacion binaria");
                System.Console.WriteLine("2. Implemente un metodo que convierta un n ´ umero de binario a decimal. (El n ´ umero binario esta representado por un string compuesto de 0s y 1s).");
                break;
                case 13:
                System.Console.WriteLine("Es Primo");
                System.Console.WriteLine("Determinar si un numero entero positivo es primo. Un n ´ umero es primo si solo tiene dos divisores: 1 y el propio numero.");
                break;
                case 14:
                System.Console.WriteLine("Número perfecto");
                System.Console.WriteLine("Determinar si un numero entero positivo es perfecto. Un n ´ umero es perfecto si la suma de sus divisores propios es igual a el. Ejemplo: 28 = 1 + 2 + 4 + 7 + 14");
                break;
                case 15:
                System.Console.WriteLine("Substring");
                System.Console.WriteLine("Un substring (subcadena) es una secuencia de caracteres que aparece consecutivamente en una cadena mayor");
                System.Console.WriteLine(". Dados los string s y x, implemente un metodo que diga si ´ x es substring de s. Ejemplo: ”” es substring de toda cadena, ”a” es substring de ”casa”, ”asap” no es substring de ”casa”.");
                break;
                case 16:
                System.Console.WriteLine("Es Palíndromo");
                System.Console.WriteLine("Implemente un metodo que determine si ´ s es pal´ındromo (se lee igual al derecho que alreves). Ejemplos: ´ ana, anitalavalatina, zz.");
                break;
                case 17:
                System.Console.WriteLine("Menor sufijo para ser Palíndromo");
                System.Console.WriteLine("Implemente un metodo que compute el menor ´ string t tal que s + t es pal´ındromo.");
                break;
                case 18:
                System.Console.WriteLine("Ordenado");
                System.Console.WriteLine("Implemente un metodo que reciba un array de enteros ´ a y devuelva un nuevo array con los mismos elementos ordenados de menor a mayor.");
                break;
                case 19:
                System.Console.WriteLine("Mediana");
                System.Console.WriteLine("Implemente un metodo que reciba un array de enteros y devuelva el elemento mediana");
                System.Console.WriteLine("La mediana de un array es el elemento que tiene la misma cantidad de elementos mayores y menores en el array.");
                System.Console.WriteLine("Ejemplos:");
                System.Console.WriteLine("  -Para el array [3, 5, 2, 8, 1]: La cantidad de numeros menores que 3 es la misma que la cantidad de numeros mayores que 3, por lo que 3 es la mediana.");
                System.Console.WriteLine("  -Para el array [3, 5, 2, 8]: El tamano del array es par, por tanto definiremos la mediana como el elemento que tiene n/2 elementos menores y n/2 − 1 elementos mayores, por lo tanto,la mediana es 5");
                break;
                default:
                    return;
            }
        Console.WriteLine("\n-------------Respuesta-------------");
    }

}
