using System;
class Aula08_lendo_val{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("\nDigite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("\n\n\n=============================================");
        Console.WriteLine("\t{0} welcome to funny calculater",nome);
        Console.WriteLine("=============================================");

        Console.Write("\nDigite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1+v2;
        Console.WriteLine("\n\n\n=================================");
        Console.WriteLine("\nA soma de {0} mais {1} é: {2}",v1,v2,soma);
        Console.WriteLine("\n=================================");
        Console.WriteLine("\nTHANKS!!!\nHave a nice FRIDOU {0}\n\n\n",nome);
    }
}