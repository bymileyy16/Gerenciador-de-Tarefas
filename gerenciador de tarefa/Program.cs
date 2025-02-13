using Layout;
using System;
using Tarefas;
using GerenciarTarefas;

var Gerenciador = new Gerenciador();
string opcao;
do
{
    opcao = Formatacao.ImprimirCabecalho();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Informe a tarefa: ");
            string tarefa = Console.ReadLine();
            Gerenciador.AdicionarTarefa(tarefa);
            break;
        case "2":
            Console.WriteLine("Visualização das Listas");
            Gerenciador.ListarTarefa();
            break;
        case "3":
            Console.WriteLine("Conclusão de Tarefa ");
            break;
        default:
            Console.WriteLine("tarefa");
            break;

    }
} while (opcao != "0");

