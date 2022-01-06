using System;
class Aula19_FOR{
    static void Main(){

        Console.Clear();

        int[] num=new int[15];

        for(int i=0;i<num.Length;i++){
            num[i]=i;
        }

        for(int i=0;i<num.Length;i++){
            Console.WriteLine("Valor de num na posição {0}: {1}",i,num[i]);
        }
    }
}