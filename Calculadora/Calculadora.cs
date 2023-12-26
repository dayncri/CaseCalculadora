using System;
using System.Collections.Generic;

class CaseCalculadora
{
    static void Main()
    {
        // Lista de operações a serem processadas
        List<string> operacoes = new List<string>
        {
            "14 - 8",
            "5 * 6",
            "2147483647 + 2",
            "18 / 3"
        };

        // Dicionário para armazenar as operações e resultados correspondentes
        Dictionary<string, long> operacoesResultados = new Dictionary<string, long>();

        // Pilha para armazenar os resultados
        Stack<long> resultados = new Stack<long>();

        foreach (var operacao in operacoes)
        {
            // Divida a operação em operandos e operador
            string[] elementos = operacao.Split(' ');
            long operando1 = long.Parse(elementos[0]);
            long operando2 = long.Parse(elementos[2]);
            char operador = elementos[1][0];

            // Executa a operação correspondente
            long resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if (operando2 != 0)
                    {
                        resultado = operando1 / operando2;
                    }
                    else
                    {
                        Console.WriteLine("Divisão por zero não é permitida.");
                        continue; // Pula para a próxima iteração
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }

            // Adiciona a operação e o resultado ao dicionário
            operacoesResultados.Add(operacao, resultado);

            // Imprime a operação e o resultado
            Console.WriteLine($"{operacao} = {resultado}");
        }

        // Imprime o dicionário de operações e resultados
        Console.WriteLine("Dicionário de Operações e Resultados:");
        foreach (var operacaoResultado in operacoesResultados)
        {
            Console.WriteLine($"{operacaoResultado.Key} = {operacaoResultado.Value}");
        }
    }
}
