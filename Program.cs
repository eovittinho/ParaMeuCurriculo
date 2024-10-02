
using System;
using System.Collections.Generic;

class ListaDeTarefas
{
    static void Main(string[] args)
    {
        // Lista para armazenar as tarefas
        List<string> tarefas = new List<string>();

        // Loop para permitir que o usuário adicione tarefas
        while (true)
        {
            // Solicita ao usuário que digite uma tarefa ou "sair" para encerrar
            Console.Write("Digite uma tarefa (ou 'sair' para encerrar): ");
            string tarefa = Console.ReadLine();

            // Verifica se o usuário quer sair do loop
            if (tarefa.ToLower() == "sair")
                break;

            // Adiciona a tarefa à lista
            tarefas.Add(tarefa);
        }

        // Exibe todas as tarefas adicionadas
        Console.WriteLine("\nLista de Tarefas:");
        foreach (var t in tarefas)
        {
            Console.WriteLine($"- {t}"); // Imprime cada tarefa
        }
    }
}
