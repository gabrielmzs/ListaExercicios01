namespace Ex16 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o salário inicial: R$ ");
            double salario = double.Parse(Console.ReadLine());
            double salarioAumento = salario * 1.15;
            double salarioDesconto = salarioAumento * 0.92;

            Console.WriteLine($"Salário inicial.........:R$ {salario}");
            Console.WriteLine($"Salário com o aumento...:R$ {salarioAumento}");
            Console.WriteLine($"Salário com os descontos:R$ {salarioDesconto}");
        }
    }
}