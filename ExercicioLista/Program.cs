using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados? ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }                    

            Console.Write("Entre com o id do funcionario que terá aumento: ");
            int busca = int.Parse(Console.ReadLine());

            Funcionario funcionario = lista.Find(x => x.Id == busca);
            if (funcionario != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionario não existente!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizadas de funcionarios: ");
            foreach (Funcionario item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}