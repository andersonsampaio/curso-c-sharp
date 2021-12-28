using System;
class Aula10_Enumeradores{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){

        //DiasSemana ds = DiasSemana.Domingo;
        //DiasSemana ds = (DiasSemana)3; //CAST converte indices para inteiro
        int ds = (int)DiasSemana.Sexta; // CAST converte string para

        Console.WriteLine(ds);
    }
}