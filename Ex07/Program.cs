namespace Ex07 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o salário base: R$ ");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.Write("Informe o total de vendas: R$ ");
            double vendas = double.Parse(Console.ReadLine());
            Console.Write("Informe a comissão: ");
            double comissao = double.Parse(Console.ReadLine());
            double salarioFinal = salarioBase + (comissao * vendas) / 100;
            Console.WriteLine($"Salário final: R$ {salarioFinal}");
        }
    }
}