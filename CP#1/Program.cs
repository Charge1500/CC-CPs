public class Program{

    public static string s;
    
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
                    DiHola();
                    break;

                case 2:
                    PrintEnunciado(option);
                    RecibiendoEntradas();
                    break;

                case 3:
                    PrintEnunciado(option);
                    IntercambiandoVariables();
                    break;

                case 4:
                    PrintEnunciado(option);
                    Circunferencias();
                    break;

                case 5:
                    PrintEnunciado(option);
                    EcuacionCuadratica();
                    break;
                case 6:
                    PrintEnunciado(option);
                    VelDeEscritura();
                    break;
                case 7:
                    PrintEnunciado(option);
                    FechaDeNacimiento();
                    break;
                case 8:
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
        Console.WriteLine("EJERCICIOS RESUELTOS DE LA CP#1 DE POGRAMACIÓN\n--------");
        Console.WriteLine("Seleccione uno de los ejercicios siguientes para observar los resultados:");
        Console.WriteLine("--------");
        Console.WriteLine("1️⃣ Di hola");
        Console.WriteLine("2️⃣ Recibiendo entradas");
        Console.WriteLine("3️⃣ Intercambio de variables");
        Console.WriteLine("4️⃣ Circunferencias");
        Console.WriteLine("5️⃣ Ecuación cuadrática");
        Console.WriteLine("6- Velocidad de escritura");
        Console.WriteLine("7- Fecha de nacimiento");
        Console.WriteLine("8--Salir--");

    }

    //EJERCICIO 1
    static void DiHola(){
        Console.WriteLine("\n(1) Hello, World!");
        Console.WriteLine($"(2) Valor máximo: {int.MaxValue} |||||  Valor mínimo: {int.MinValue}");
        Console.WriteLine($"(3) Valor aproximado de PI: {Math.PI}");
    }

    //EJERCICIO 2
    static void RecibiendoEntradas(){
        int num;
        int num1;
        int num2;
        Console.WriteLine("¿Cuál de las opciones desea ejecutar?:");
        Console.Write(">");
        int option = int.Parse(Console.ReadLine()!);
        switch(option){
            case 1:
                Console.WriteLine("(1)--Introduzca una cadena de caracteres--");
                s=Console.ReadLine()!;
                //Mostrando resultado
                Console.WriteLine(s + " medio limón");
            break;
            case 2:
                Console.WriteLine("(2)--Introduzca un número para hallar su doble--");
                num=int.Parse(Console.ReadLine()!);
                //Mostrando resultado
                Console.WriteLine($"El doble de {num} es {2*num}"); 
            break;
            case 3: 
                Console.WriteLine("(3)--Introduzca el primer número--");
                num1=int.Parse(Console.ReadLine()!);
                Console.WriteLine("(3)--Introduzca el segundo número--");
                num2=int.Parse(Console.ReadLine()!);
                //Determinando valor mayor
                int mayor = (num1 + num2 + Math.Abs(num1 - num2)) / 2;
                //Mostrando resultado
                Console.WriteLine($"El número mayor es: {mayor}");
            break;
            case 4:
                Console.WriteLine("(4)--Ingrese el primer número--");
                num1 = int.Parse(Console.ReadLine()!);
                Console.WriteLine("(4)--Ingrese el segundo número--");
                num2 = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Ingrese el tercer número:");
                int num3 = int.Parse(Console.ReadLine()!);
                // Calcular el máximo y el mínimo
                int max = Math.Max(Math.Max(num1, num2), num3);
                int min = Math.Min(Math.Min(num1, num2), num3);
                // Calcular el valor medio
                int medio = num1 + num2 + num3 - max - min;
                // Calcular el promedio
                double promedio = (num1 + num2 + num3) / 3.0;
                // Mostrar resultados
                Console.WriteLine($"El valor medio es: {medio}");
                Console.WriteLine($"El promedio es: {promedio}"); 
            break;
            case 5:
                Console.WriteLine("(5)--Introduzca un string--");
                s=Console.ReadLine()!;
                Console.WriteLine("(5)--Introduzca un número menor que el total de caracteres del string--");
                num=int.Parse(Console.ReadLine()!);
                //Mostrar resultado
                Console.WriteLine("La palabra " + s + " posee como caracter número "+ num + " la letra " +s[num-1]);
            break;
            default:
            return;
        }
    }        

    //EJERCICIO 3
    static void IntercambiandoVariables(){

        Console.WriteLine("--Ingrese el primer número--");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("--Ingrese el segundo número--");
        int num2 = int.Parse(Console.ReadLine()!);
        //int aux;
        num1+=num2;
        num2=num1-num2;
        num1-=num2;

        //Con variable
        //aux=num1  num1=num2   num2=num1
        
        //Sin variable
        //num1+=num2  num2=num1-num2  num1-=num2

        //Última forma
        //(num1,num2)=(num2,num1)

        Console.WriteLine($"\n 1-Número:{num1} \n 2-Número:{num2}");
    }

    //EJERCICIO 4
    static void Circunferencias(){
        Console.WriteLine("Todavía no se ha resuelto");
    }

    //EJERCICIO 5
    static void EcuacionCuadratica(){
        Console.WriteLine("Introduzca a:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca b:");
        int b=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca c:");
        int c=int.Parse(Console.ReadLine());
        
        //Hallando discriminante
        long d=b*b-4*a*c;

        //Calculando soluciones
        double s1=(-b+Math.Sqrt(d))/2*a;
        double s2=(-b-Math.Sqrt(d))/2*a;
        //Mostrando resultado
        Console.WriteLine($"Las soluciones de {a}x^2+{b}x+c son {s1} y {s2}");

    }

    //EJERCICIO 6
    static void VelDeEscritura(){
        Console.WriteLine("Todavía no se ha resuelto");
    }

    //EJERCICIO 7
    static void FechaDeNacimiento(){
        Console.WriteLine("Introduzca un carnet de identidad(11 dígitos):");
        long numeroIdentidad = long.Parse(Console.ReadLine());

        // Extraer día, mes y año usando el operador %
        int anio = (int)(numeroIdentidad / 1000000000) % 100;
        int mes = (int)(numeroIdentidad / 10000000) % 100;   
        int dia = (int)(numeroIdentidad / 100000) % 100;     
        Console.WriteLine($"La fecha de nacimiento que le corresponde a este CI es {dia}-{mes}-{anio}");

    }    

    static void PrintEnunciado(int option){
        Console.WriteLine("-------------Enunciado-------------");
        switch (option)
            {
                case 1:
                    Console.Write("DI HOLA:\n");       
                    Console.WriteLine("1.Muestre en la consola el siguiente string: ”Hello, World!”");       
                    Console.WriteLine("2.Muestre en la consola el valor maximo y el valor mínimo admitidos por el tipo int");       
                    Console.WriteLine("3.Muestre en la consola un valor aproximado de Pi (use la clase Math).");       
                    break;

                case 2:
                    Console.Write("RECIBIENDO ENTRADAS:\n");
                    Console.WriteLine("1. Reciba como entrada una cadena de caracteres (string).Luego muestre en la terminal ese mismo string pero con terminación medio limón");    
                    Console.WriteLine("2. Reciba un numero entero y muestre en la consola su doble");
                    Console.WriteLine("3. Reciba dos numeros enteros de la consola y determine cuál de los dos es mayor sin utilizar Math.Max y Math.Min.");
                    Console.WriteLine("4. Reciba tres numeros enteros. Muestre en la consola el de valor medio (Utilice Math.Max y Math.Min) y el promedio de estos.");
                    Console.WriteLine("5. Reciba un string y un entero (x) menor que el total de caracteres del string. Muestre en la consola el caracter que ocupa la posición x en el string.");
                    break;

                case 3:
                    Console.Write("INTERCAMBIO DE VARIABLES\n");
                    Console.WriteLine("Dado que tienes dos enteros guardados en las variables a y b, realiza el intercambio de sus valores de las siguientes maneras:");
                    Console.WriteLine("1.Usando una variable auxiliar.\n2.Sin usar una variable auxiliar.");
                    break;

                case 4:
                    Console.Write("CIRCUENFERENCIAS\n");
                    Console.WriteLine("Sean las circunferencias C1 y C2 de redio r. Lea de la consola el radio r (puede ser cualquier numero real, no sólo entero) y calcule el área sombreada.");
                    break;

                case 5:
                    Console.Write("ECUACIÓN CUADRÁTICA\n");
                    Console.WriteLine("Reciba los coeficientes (numeros reales) de una ecuación cuadrática y (asumiendo que tiene solución) halle sus soluciones.");
                    Console.WriteLine("ax^2 + bx + c = 0");
                    break;
                case 6:
                    Console.Write("VELOCIDAD DE ESCRITURA\n");
                    Console.WriteLine("Lea un texto de la terminal y muestre en la consola la velocidad de escritura del usuario que ingreso dicho texto\nInvestigue como utilizar Environment.TickCount para medir la cantidad de milisegundos transcurridos.");
                    break;
                case 7:
                    Console.Write("FECHA DE NACIMIENTO");
                    Console.WriteLine("Reciba de la consola el numero de identidad de una persona como tipo long e imprima su fecha de nacimiento con el formato día/mes/año\nEl año debe mostrarse con las dos cifras presentes en el carnet, por ejemplo, para el carnet 04100968518, la fecha de nacimiento sería 9/10/4.");
                    break;
                default:
                    return;
            }
        Console.WriteLine("\n-------------Respuesta-------------");
    }

}
