// See https://aka.ms/new-console-template for more information
/*new method not needing
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}*/
Console.WriteLine("Hello, World!");
//var
byte age = 90;//0-255
Console.WriteLine("Var byte  0-255: " + age);
int year = 2022;//-2147.483.648 - 2147.483.647
Console.WriteLine("Var int  -2147.483.648 - 2147.483.647: " + year);
char letter = 'A';
Console.WriteLine(letter);
string word = "jvgfituf hgv";
Console.WriteLine(word);
dynamic var = "I do not know data type";
Console.WriteLine(var);

//double, float, bool, ...

int num = 1, num2 = 3;
Console.WriteLine("Sum: "+(num + num2));
double num3;
num3 = Convert.ToDouble(Console.ReadLine());
double result = Math.Pow(num3, num3);
Console.WriteLine("Pow: " + result);
//   &&, ||
if (num3 != 0)
{
    Console.WriteLine("In if");
}else
{
    Console.WriteLine("In else");
}

switch (num3)
{
    case 0:
        Console.WriteLine("case 0");
        break;
    default:
        Console.WriteLine("default");
        break;

}
//while (){}
int suma3()
{
    //comment VB CTRL+k, CTRL+c
    //Undo CTRL+k, CTRL+u

    int[] nums;
    nums = new int[3]; //init 0
    //int[] nums ={2,5,3};
    //nums can not be longer later>> create bigger one and copy it.
    int res = 0;

    for (int i = 0; i < 3; i++)
    {
        
        nums[i] = Convert.ToInt32(Console.ReadLine());
        res += nums[i];
    }
    Console.WriteLine(nums);
    Console.WriteLine("suma: "+res);
    foreach (int n in nums)
    {
        Console.WriteLine(n);
    }
    return 0;
}

suma3();
//array1 = array2; //>>un unico array 2 y ambas variables apuntan al mismo sitio de memoria.Array1 se destruye!!!
//programacion101.net
//matrix
int[,] matrix1 = new int[2, 3];
matrix1[0, 0] = 1;
matrix1[1, 0] = 1;
