using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankOO.Funcionarios
{
    public class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        public static string CPF { get; private set; }

        public string Nome { get; set; }
       
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {

            CPF = cpf;
            TotalDeFuncionarios++;
        }

        public void AumentarSalario()
        {
            Salario = Salario * 3.3;
        }


        public virtual double GetBonificacao()
        {

            return Salario * 0.10;

        }

        public void ExibirStatus()
        {
            string nome = Nome;
            double salario = Salario;
            Console.WriteLine("nomw: " + nome , "salario: " + salario );
        }

     
    }
 }
