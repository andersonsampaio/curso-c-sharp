using System;

namespace Aula02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
        }
    }
}