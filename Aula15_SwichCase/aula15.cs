using System;
class Aula15_SwichCase{
    static void Main(){

        float a,b;

        Console.Clear();

        Console.WriteLine("======================================================\n");
        Console.WriteLine("    Calculadora super divertida da Thifs e do Tigs");
        Console.WriteLine("\n======================================================");

        Console.Write("\nDigite seu nome: ");
        string nome = Console.ReadLine();

        var escolha = 1;
        while (escolha == 1){
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("Hello {0} WELCOME!!!",nome);
            Console.WriteLine("=======================================");
            Console.WriteLine("\n(1) ADIÇÃO");
            Console.WriteLine("(2) SUBTRAÇÃO");
            Console.WriteLine("(3) MULTIPLICAÇÃO");
            Console.WriteLine("(4) DIVISÃO");

            Console.Write("\nEscolha uma opção acima: ");       
            var opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao){
                case 1:
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos começar a somar??? Let's do it!!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\n");
                    Console.Write("Digite o 1º valor: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º valor: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos descobrir a resposta?!?!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\nO resultado da soma entre {0} e {1} é {2}\n\n\n", a, b, a+b);

                break;

                case 2:

                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos começar a subtrair??? Let's do it!!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\n");
                    Console.Write("Digite o 1º valor: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º valor: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos descobrir a resposta?!?!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\nO resultado da soma entre {0} e {1} é {2}\n\n\n", a, b, a-b);

                break;

                case 3:
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos começar a multiplicar??? Let's do it!!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\n");
                    Console.Write("Digite o 1º valor: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º valor: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos descobrir a resposta?!?!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\nO resultado da soma entre {0} e {1} é {2}\n\n\n", a, b, a*b);
                break;

                case 4:
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos começar a dividir??? Let's do it!!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\n");
                    Console.Write("Digite o 1º valor: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º valor: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("========================================================");
                    Console.WriteLine("   {0} vamos descobrir a resposta?!?!",nome);
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\nO resultado da soma entre {0} e {1} é {2}\n\n\n", a, b, a/b);
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("{0} meu fí pelo amor de Deus. Existe essa opção???? Não né!!! \n\nVamos tentar novamente?\n\n\n",nome); 
                break;
            }
            Console.Write("Deseja fazer outra operação? SIM(1) NÃO(2): ");
            escolha = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("=================================================================================");
        Console.WriteLine("   Thanks {0} obrigado por utilizar a nossa calculadora super divertida",nome);
        Console.WriteLine("=================================================================================\n\n\n\n\n\n");
    }
    
}