using System.Globalization;

namespace Atividade2 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario F = new Funcionario();

            Console.Write("Nome:");
            F.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            F.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: "+ F);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            F.AumentoSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+F);
        }
    }
}
