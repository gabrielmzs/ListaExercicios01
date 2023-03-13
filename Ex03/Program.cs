namespace Ex03 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = 3.1316 * raio * raio * altura;
            Console.WriteLine($"Volume do cilindro: {volume}");
        }
    }
}