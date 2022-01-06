using System;

class Aula22_foreach{
    static void Main(){

        Console.Clear();
        
        int[] num=new int[5];

        for(int i=0;i<num.Length;i++){
            num[i]=i;
        }

        foreach(int n in num){
            Console.WriteLine(n);
        }
    }
}