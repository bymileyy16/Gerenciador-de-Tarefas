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
            Formatacao.Cor("Lista de Tarefas :) ", ConsoleColor.Cyan);
            Gerenciador.ListarTarefa();
            break;
        case "3":
             Formatacao.Cor("Tarefa concluida :) ", ConsoleColor.Green);
            break;
         case "4":
            Formatacao.Cor("\tTarefa removida", ConsoleColor.Red);
            break;
            case "0":
            Formatacao.Cor("Você saiu do Gerenciador de Tarefas! ", ConsoleColor.Red);
            break;
        default:
            Console.WriteLine("tarefa");
            break;
           

    }
} while (opcao != "0");

