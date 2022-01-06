using System;
class Aula19_FOR{
    static void Main(){

        Console.Clear();

        int[] num=new int[10];

        int i=num.Length-1;//-1 pq a última posição da matriz é 9 (pq começa em 0) e não 10 (que é apenas a quantidade de posições total do vetor).
        while(i>0){
            num[i]=i;
            Console.WriteLine(num[i]);
            i--;
        }
        Console.WriteLine("Fim do loop");
    }
}