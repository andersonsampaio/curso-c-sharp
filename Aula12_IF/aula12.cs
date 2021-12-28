using System;
class Aula12_IF{
    static void Main(){

        float n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;

        Console.WriteLine("Digite a nota 01: ");
        n1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a nota 02: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 03: ");
        n3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 04: ");
        n4 = float.Parse(Console.ReadLine());

        res = n1+n2+n3+n4;

        string resultado = "Reprovado";

        if(res/4 >=60){
           resultado="Aprovado";                             
        }
        
        Console.WriteLine("Resultado:{0} a média é {1}",resultado,res/4);
    }

}