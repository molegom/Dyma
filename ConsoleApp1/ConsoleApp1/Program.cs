using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    string s = i + "*" + j+ "=" + i*j;
                    Console.WriteLine(s);
                }
            }

        }
       
        Console.ReadeLine();
    }
}





