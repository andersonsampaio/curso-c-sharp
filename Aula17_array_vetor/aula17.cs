using System;
class Aula17_array_vetor{
    static void Main(){
        int[] n=new int[5]; //forma 1 de declarar o array
        int[] num=new int[3]{55,77,99};//forma 2
        int[] nu={55,77,99,66,88};

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine(n[4]);
        Console.WriteLine(num[2]);
        Console.WriteLine(nu[3]);
    }
}