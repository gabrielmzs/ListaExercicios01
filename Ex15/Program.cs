namespace Ex15 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a temperatura em Celsius: ");
            double tempC = double.Parse(Console.ReadLine());
            double tempF = (tempC * 1.8) + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {tempF}");
        }
    }
}