using System;
class Aula21_do_while{
    static void Main(){

        string senha="123";
        string senhauser;
        int tentativas=0;

        do{
            Console.Clear();
            Console.Write("Digite a senha: ");
            senhauser=Console.ReadLine();
            tentativas++;
        }while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha Correta, tentativas: {0}\n\n\n\n",tentativas);
    }
}