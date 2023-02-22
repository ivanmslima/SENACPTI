using System;

namespace VetorExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê a quantidade de elementos do vetor
            Console.Write("Digite a quantidade de elementos: ");
            int n = int.Parse(Console.ReadLine());

            // Cria o vetor com o tamanho informado pelo usuário
            int[] vetor = new int[n];

            // Lê cada um dos elementos do vetor
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            // Chama as funções que implementam os itens a e b
            int maiorDiferenca = CalcularMaiorDiferenca(vetor);
            bool emOrdemCrescente = VerificarOrdemCrescente(vetor);

            // Imprime os resultados na tela
            Console.WriteLine("Maior diferença: " + maiorDiferenca);
            Console.WriteLine("Vetor em ordem crescente? " + emOrdemCrescente);
        }

        // Implementa o item a
        static int CalcularMaiorDiferenca(int[] vetor)
        {
            int maiorDiferenca = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    // Calcula a diferença entre os elementos i e j
                    int diferenca = Math.Abs(vetor[i] - vetor[j]);
                    if (diferenca > maiorDiferenca)
                    {
                        // Se a diferença calculada for maior do que a maior diferença atual,
                        // atualiza o valor da maior diferença
                        maiorDiferenca = diferenca;
                    }
                }
            }
            // Retorna a maior diferença encontrada
            return maiorDiferenca;
        }

        // Implementa o item b
        static bool VerificarOrdemCrescente(int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                // Verifica se o elemento i é maior do que o elemento i+1
                if (vetor[i] > vetor[i + 1])
                {
                    // Se for, o vetor não está em ordem crescente e retorna false
                    return false;
                }
            }
            // Se todos os elementos estiverem em ordem crescente, retorna true
            return true;
        }
    }
}
