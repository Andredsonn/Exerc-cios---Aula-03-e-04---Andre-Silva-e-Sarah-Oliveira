using System;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;

namespace Aula03Colecoes
{
    public class Program
    {
        static List<Funcionario> lista = new List<Funcionario>();
        static void Main(string[] args)
        {
            CriarLista();
            ObterPorNome();
        }
  public static void ObterPorNome()

{
    Console.WriteLine("Digite o nome");
        String nome = (Console.ReadLine());
        Funcionario fBusca = lista.Find(x => x.Nome.ToLower().Contains(nome.ToLower()));
        if(fBusca == null)
            Console.WriteLine("Não Encontrado");
        else
            Console.WriteLine($"Funcionário encontrado: {fBusca.Nome}");
}


        /*public static void ObterPorId()
        {
            lista = lista.FindAll(x => x.Id ==1);
            ExibirLista();

        }

    public static void AdicionarFuncionario()
    {
        Funcionario f = new Funcionario();

        Console.WriteLine("Digite o nome:");
        f.Nome = Console.ReadLine();

        Console.WriteLine("Digite o salário: ");
        f.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a data de admissão: ");
        f.DataAdmissao = DateTime.Parse(Console.ReadLine());

        if (string.IsNullOrEmpty(f.Nome))
        {
            Console.WriteLine("O nome deve ser preenchido");
            return;
        }
        else if (f.Salario == 0)
        {
            Console.WriteLine("Valor do salário não pode ser 0");
            return;
        }
        else
        {
            lista.Add(f);
            ExibirLista();
        }
}
    public static void ObterPorIdDigitado()
    {
        Console.WriteLine("Digite o Id");
        int id= int.Parse(Console.ReadLine());
        Funcionario fBusca = lista.Find(x => x.Id == id);

        if(fBusca == null)
            Console.WriteLine("Não Encontrado");
        else
            Console.WriteLine($"Funcionário encontrado: {fBusca.Nome}");
    }

    public static void ObterPorSalario()
    {
        Console.WriteLine("Digite o valor mínimo");
        decimal salario = decimal.Parse(Console.ReadLine());
        lista = lista.FindAll(x => x.Salario >= salario);
        ExibirLista();
    }
    */


         public static void ExibirLista()
        {
            string dados = "";
            for(int i = 0; i < lista.Count; i++)
            {
                dados += "==========================================";
                dados += string.Format("Id: {0} \n", lista[i].Id);
                dados += string.Format("Nome: {0} \n", lista[i].Nome);
                dados += string.Format("CPF: {0} \n", lista[i].Cpf);
                dados += string.Format("Admissão: {0:dd/MM/yyyy} \n", lista[i].DataAdmissao);
                dados += string.Format("Salário: {0:c2} \n", lista[i].Salario);
                dados += string.Format("Tipo: {0} \n", lista[i].TipoFuncionario);
                dados += "==========================================";
            }

            Console.WriteLine(dados);

        }

         public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Neymar";
            f1.Cpf = "12345678910";
            f1.DataAdmissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100000M;
            f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f1);

            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "Cristiano Ronaldo";
            f2.Cpf = "01987654321";
            f2.DataAdmissao = DateTime.Parse("30/06/2002");
            f2.Salario = 150000M;
            f2.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "Messi";
            f3.Cpf = "135792468";
            f3.DataAdmissao = DateTime.Parse("01/11/2003");
            f3.Salario = 70000M;
            f3.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "Mbappe";
            f4.Cpf = "246813579";
            f4.DataAdmissao = DateTime.Parse("15/09/2005");
            f4.Salario = 80000M;
            f4.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f4);

            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "Lewa";
            f5.Cpf = "246813579";
            f5.DataAdmissao = DateTime.Parse("20/10/1998");
            f5.Salario = 90000M;
            f5.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f5);

            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Roger Guedes";
            f6.Cpf = "246813579";
            f6.DataAdmissao = DateTime.Parse("13/12/1997");
            f6.Salario = 300000M;
            f6.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f6);
        }
    }
}