using System;
class Aula25_PassagemReferencia{
    static void Main(){
        int num=50;
        dobrar(ref num);
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor){
        valor*=2;
    }
}