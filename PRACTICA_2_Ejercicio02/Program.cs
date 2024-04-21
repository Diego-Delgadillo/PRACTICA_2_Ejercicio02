/*
Ejercicio 02
Generar un programa usando el paradigma de POO en el que se permita, por un lado,
ingresar los datos de los elementos químicos (Nombre del elemento, Símbolo, Número
Atómico, Masa Atómica, Radio atómico, Estado ordinario), por otro lado, debe contar con
una opción o método para mostrar la información del elemento químico y otro para
almacenarlo en un archivo de texto (.txt). El programa debe mostrar las opciones para ingresar
los elementos, mostrarlos y guardar todos los elementos almacenados hasta el momento (se
debe revisar que elementos se encuentran ya guardados)
*/


using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//Declaramos la clase para los elementos
public class elemento
{
    //declaramos lso atributos de la clase
    public string[] nombreElemento;
    public string[] simboloElemento;
    public int[] noAtomicoElemento;
    public double[] masaAtomica;
    public double[] radioAtomico;
    public string[] estadoOrdinarioElemento;
    

    //ahora creamos un método para ingresar cada atributo dentro de un arreglo
    public void ingresarDatos(int nElementos)
    {
        nombreElemento = new string[nElementos];
        simboloElemento = new string[nElementos];
        noAtomicoElemento = new int[nElementos];
        masaAtomica = new double[nElementos];
        radioAtomico = new double[nElementos];
        estadoOrdinarioElemento = new string[nElementos];


        //creamos un ciclo for para ir almacenando cada atributo en el arreglo
        for (int i = 0; i < nElementos; i++)
        {
            string c; bool num; 
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el nombre del elemento {0}: ",i + 1);
            nombreElemento[i] = Console.ReadLine();
            Console.WriteLine("Ingrese el símbolo del elemento {0}: ",i + 1);
            simboloElemento[i] = Console.ReadLine();

            do// este ciclo es para que se ingresen solo números enteros mayores a cero
            {
                Console.WriteLine("Ingrese el número atómico del elemento {0}: ", i + 1);
                c = Console.ReadLine();
                num = int.TryParse(c, out noAtomicoElemento[i]);
            } while (!num || noAtomicoElemento[i] <= 0);
            noAtomicoElemento[i] = Convert.ToInt32(c);

            do // este ciclo es para que se ingresen solo números flotantes mayores a cero
            {
                Console.WriteLine("Ingrese la masa atómica del elemento {0}: ", i + 1);
                c = Console.ReadLine();
                num = double.TryParse(c, out masaAtomica[i]);
            } while (!num || masaAtomica[i] <= 0);
            masaAtomica[i] = Convert.ToDouble(c);

            do // este ciclo es para que se ingresen solo números flotantes mayores a cero
            {
                Console.WriteLine("Ingrese el radio atómico del elemento {0}: ", i + 1);
                c= Console.ReadLine();
                num = double.TryParse(c, out radioAtomico[i]);
            } while (!num || radioAtomico[i] <= 0);
            Console.WriteLine("Ingrese el radio atómico del elemento {0}: ",i + 1);
            radioAtomico[i] = Convert.ToDouble(c);


            Console.WriteLine("Ingrese el estado ordinario del elemento {0}: ",i + 1);
            estadoOrdinarioElemento[i] = Console.ReadLine();
        }
    }

    public void imprimirDatos(int nElementos) //este método nos ayuda a imprimir los datos ingreesados previamente
    {

        Console.WriteLine("\n");
        Console.WriteLine("Nombre\tSímbolo\tNo.atómico\t Masa atómica\t Estado ordinario\t");
        Console.WriteLine("\n");
        //Ciclo for que imprime los elementos
        for (int j = 0; j < nElementos; j++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", nombreElemento[j], simboloElemento[j], noAtomicoElemento[j], masaAtomica[j], radioAtomico[j], estadoOrdinarioElemento[j]);
            Console.WriteLine("\n");
        }
    }

}


public class program()
{
    static public void Main()
    {
        elemento elementosIngresados = new elemento(); //creamos el objeto de la clase "elemento"
        int opcionMenu1 = 0; //varible de control para el menu
        int n = 0; //variable para la opcion 1 donde indica la cantidad de datos a ingresar
        bool opcionMenu = true;
        string cadena; //esta variable es para comparar si es string en el metodo Tryparse
        bool num; // esta variable se utiliza en le metod tryparse para ver si es verdadero o falso el metodo tryparse

        //Creamos una funcion para que continue o salga del programa
        bool continuar()
        {
            uint n; // variable para que solo ingrese numero
            bool opcionMenu; string c; bool num;

            // ciclo que evalúa si es un numero dentro del rango
            do
            {
                Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                c = Console.ReadLine();
                num = uint.TryParse(c, out n);
            } while ((n > 1) || (n < 0) || !num);

            opcionMenu = Convert.ToBoolean(n);
            return opcionMenu;
        }

        while(opcionMenu == true)
        {

            Console.WriteLine("Este programa permite ingresar, guardar y mostrar datos de distintos elementos químicos.\n");


            do
            {
                Console.WriteLine("Ingrese una opción: (1)Ingresar datos, (2)Mostrar datos, (3)Almacenar en un archivo(.txt), (4)Salir\r\n");
                cadena = Console.ReadLine();    
                num = int.TryParse(cadena, out opcionMenu1);
            } while (!num);

            opcionMenu1 = Convert.ToInt32(cadena);


            switch (opcionMenu1)
            {
                case 1:  //variable para almacenar esa cantidad de datos
                    Console.WriteLine("\n¿Cuántos elementos desea ingresar? ");
                    n = Convert.ToInt32(Console.ReadLine());
                    elementosIngresados.ingresarDatos(n);
                    opcionMenu = continuar();
                    break;

                case 2:
                    elementosIngresados.imprimirDatos(n);
                    opcionMenu = continuar();
                    break;

                case 3: //esta opcion genera un archivo .txt con los datos posteriormente se ira desarrollando esta parte
                    opcionMenu = continuar();
                    break;

                case 4: // esta opcione es para salir del programa :D
                    opcionMenu = false;
                    break;

                default: Console.WriteLine("Ingrese una opción válida!"); Console.Beep(); break;
            }
        }

        Console.WriteLine("\nPrograma terminado!\nPresione cualquier tecla para continuar...");
        Console.ReadKey();Console.Beep();
        
    }
}






 
