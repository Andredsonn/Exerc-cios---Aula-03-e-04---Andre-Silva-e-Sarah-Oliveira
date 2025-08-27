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
bool sair = false;
while(!sair){
        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1 - Obter Funcionários Recentes");
        Console.WriteLine("2 - Detalhar Data");
        Console.WriteLine("3 - Calcular Desconto INSS");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");  
string? opcao = Console.ReadLine();
switch(opcao){
case "1":
var recentes = ObterFuncionarioRecentes();
ExibirLista(recentes);
break;
case "2":
DetalharData();
break;
case "3":
CalcularDescontoINSS();
break;
case "0":
sair = true;
break;
default:
Console.WriteLine("Opção inválida.");
break;
}
}

}

public static void DetalharData()
{
Console.WriteLine("Digite uma data (formato: dd/MM/yyyy):");
string? entrada = Console.ReadLine();
if(!DateTime.TryParse(entrada, out DateTime data)){
Console.WriteLine("Data inválida.");
return;
}
string diaSemana = data.ToString("dddd", new System.Globalization.CultureInfo("pt-BR"));
string nomeMes = data.ToString("MMMM", new System.Globalization.CultureInfo("pt-BR"));
Console.WriteLine($"Dia da semana: {diaSemana}");
Console.WriteLine($"Mês: {nomeMes}");
if(data.DayOfWeek == DayOfWeek.Sunday){
string hora = DateTime.Now.ToString("HH:mm");
Console.WriteLine($"A data informada é um domingo. Hora atual: {hora}");
}
}

public static void CalcularDescontoINSS(){
Console.WriteLine("Digite o valor do salário:");
if(!decimal.TryParse(Console.ReadLine(), out decimal salario)){
Console.WriteLine("Valor inválido.");
return;
}
decimal percentual = 0;
if(salario <= 1212.00m)
percentual = 0.075m;
else if(salario <= 2427.35m)
percentual = 0.09m;
else if(salario <= 3641.03m)
percentual = 0.12m;
else if(salario <= 7087.22m)
percentual = 0.14m;
else{
Console.WriteLine("Salário acima do teto. Use cálculo avançado.");
return;
}
decimal desconto = salario * percentual;
decimal salarioLiquido = salario - desconto;
Console.WriteLine($"Desconto do INSS: {desconto:C2}");
Console.WriteLine($"Salário com desconto: {salarioLiquido:C2}");
}

public static void ExibirLista(List<Funcionario> listaParaExibir){
foreach(var f in listaParaExibir){
Console.WriteLine("==========================================");
Console.WriteLine($"Id: {f.Id}");
Console.WriteLine($"Nome: {f.Nome}");
Console.WriteLine($"CPF: {f.Cpf}");
Console.WriteLine($"Admissão: {f.DataAdmissao:dd/MM/yyyy}");
Console.WriteLine($"Salário: {f.Salario:C2}");
Console.WriteLine($"Tipo: {f.TipoFuncionario}");
Console.WriteLine("==========================================");
}
}

public static List<Funcionario> ObterFuncionarioRecentes(){
var listaFiltrada = lista.Where(f => f.Id < 4).OrderByDescending(f => f.Salario).ToList();
return listaFiltrada;
}

public static void CriarLista(){
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
