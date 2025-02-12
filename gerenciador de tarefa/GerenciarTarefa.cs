using Layout;
using Tarefas;

namespace GerenciarTarefas
{
    class Gerenciador
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int contadorId = 1;
        public void AdicionarTarefa(string descricao)
        {
            var  novaTarefa = new Tarefa( contadorId++, descricao);
            tarefas.Add(novaTarefa);
            Formatacao.Cor("\tTarefa adicionada  com sucesso!", ConsoleColor.Green);
        }

        // public void Concluirtarefa(int id)
        // {
        //     Tarefa tarefa = tarefas.Find(t => t.Id == id);
        //     if (tarefa! = null)
        //     {
        //         tarefa.Concluida = true
        //         Console.WriteLine(tarefa concluida com sucesso);
        //     }
        //     else
        //     {
        //         Console.WriteLine(tarefa nao encontrada);
        //     }
        // }

        // public void ListarTarefa()
        // {
        //     if (tarefas.Count == 0)
        //     {
        //         Console.WriteLine("Nao há tarefas cadastradas.");
        //     }
        //     else
        //     {
        //         foreach (var tarefa in tarefas)
        //         {
        //             tarefa.ExibirTarefa();
        //         }
        //     }
        // }    

        // public void Removertarefas(int id)
        // {
        //     Tarefa tarefa = tarefas.Find(t => t.id == id);
        //     if (tarefa !=null)
        //     {
        //         tarefas.Remove(tarefa);
        //         Console.WriteLine($"Tarefa ID {id} removida com sucesso. ");

        //     }
        //     else
        //     {
        //         Console.WriteLine($"Tarefa ID {id} nao encontrada. ");
                

        //     }
        // }
    }
}