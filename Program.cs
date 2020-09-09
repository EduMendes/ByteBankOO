using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankOO.Funcionarios;

namespace ByteBankOO
{
     class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
         

            Funcionario carlos = new Funcionario("546.879.157-20");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor("454.658.148-3"); 
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Funcionario joao = new Funcionario("355.968.115-8");
            joao.Nome = "João";
            joao.Salario = 7000;
            joao.ExibirStatus();
            


            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine(joao.ExibirStatus());
            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());
            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("-----------------------------------------");

            Console.ReadLine();
        }
    }
}
