using System;
class program
{
    static void Main(string[] args)
    {

        Console.Write("ingrese el numero 1:");
       string n1txt=Console.ReadLine();
       int num1 = int.Parse(n1txt);
        
        Console.Write("ingrese el numero 2 :");
        string n2txt=Console.ReadLine();
        int num2 = int.Parse(n2txt);


        int resultado = 0;


        for (int i = 0; i < num1; i++)
        {
            resultado = resultado + num2;
        }
        Console.WriteLine("el resultado es :" + resultado);
        Console.ReadKey();
    }
}

