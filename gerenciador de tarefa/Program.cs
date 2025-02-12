using Layout;
using System;
using Tarefas;
using GerenciarTarefas;

var Gerenciador = new Gerenciador();

string opcao = Formatacao.ImprimirCabecalho();

switch (opcao)
{
    case "1":
        Console.WriteLine("Informe a tarefa: ");
        string tarefa = Console.ReadLine();
        Gerenciador.AdicionarTarefa(tarefa);
        break;
    default:
        Console.WriteLine("tarefa");
        break;
}