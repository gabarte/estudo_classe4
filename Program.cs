using ex2_classe_funcionário;
using System.Globalization;

Funcionario f = new Funcionario();

Console.WriteLine("Entre com os dados do funcionário:");
Console.Write("Nome: ");
f.Nome = Console.ReadLine();

Console.WriteLine();
Console.Write("Salário bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine();
double salarioLiquido = f.SalarioLiquido();
Console.Write("Salário Liquido: " + salarioLiquido, CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcent);

Console.WriteLine();
Console.Write("Dados do funcionário: " + f);
