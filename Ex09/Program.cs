namespace Ex09 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o valor da primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            double mediaHarmonica = 2/(1/nota1 + 1/nota2);
            Console.WriteLine($"A média harmônica é: {mediaHarmonica}");
        }
    }
}