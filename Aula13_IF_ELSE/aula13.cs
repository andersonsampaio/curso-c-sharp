using System;
class Aula13_IF_ELSE{
    static void Main(){

        float n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado;

        Console.WriteLine("Digite a nota 01: ");
        n1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a nota 02: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 03: ");
        n3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 04: ");
        n4 = float.Parse(Console.ReadLine());

        res = n1+n2+n3+n4;

        //>=60 aprovado
        //59 e 40 - Recuperação
        //<40 - Reprovado

        if(res/4 <40){
           resultado="Reprovado";                             
        }else if(res/4<60){
            resultado="recuperação";
        }else{
            resultado="Aprovado";
        }

        Console.WriteLine("Resultado:{0} a média é {1}",resultado,res/4);

    }

}