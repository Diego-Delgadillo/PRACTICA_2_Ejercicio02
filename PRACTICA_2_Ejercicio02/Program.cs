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
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el nombre del elemento {0}: ",i + 1);
            nombreElemento[i] = Console.ReadLine();
            Console.WriteLine("Ingrese el símbolo del elemento {0}: ",i + 1);
            simboloElemento[i] = Console.ReadLine();
            Console.WriteLine("Ingrese el número atómico del elemento {0}: ",i + 1);
            noAtomicoElemento[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la masa atómica del elemento {0}: ",i + 1);
            masaAtomica[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el radio atómico del elemento {0}: ",i + 1);
            radioAtomico[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el estado ordinario del elemento {0}: ",i + 1);
            estadoOrdinarioElemento[i] = Console.ReadLine();
        }

        Console.WriteLine("\n");
        Console.WriteLine("Nombre\tSímbolo\tNo.atómico\t Masa atómica\t Estado ordinario\t");
        Console.WriteLine("\n");
        //Ciclo for que imprime los elementos
        for (int j=0; j < nElementos; j++)
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
        int n = 0;// variable para almcaenar la cantidad de datos a ingresar
        Console.WriteLine("HOLA MUNDO :D");
        elemento elementosIngresados = new elemento();
        Console.WriteLine("Cuantos elementos desea ingresar? ");
        n = Convert.ToInt32(Console.ReadLine());
        elementosIngresados.ingresarDatos(n);
        Console.ReadKey();

    }
}







