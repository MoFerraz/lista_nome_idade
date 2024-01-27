using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2];
            int[] idades = new int[2];

            for (int indice = 0; indice < 2; indice++)
            {
                Console.WriteLine("Digite o nome do Aluno");
                nomes[indice] = Console.ReadLine();

                Console.WriteLine("Digite a idade do aluno");
                idades[indice] = int.Parse(Console.ReadLine());

            }

            Console.Clear();

            Console.WriteLine("Lista de alunos");

            for (int indice = 0;indice < 2; indice++)
            {
                Console.WriteLine($" Nome: {nomes[indice]} idade: {idades[indice]}");
            }

            Console.ReadKey();
        }
    }
}
