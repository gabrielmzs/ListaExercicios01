namespace Ex02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a temperatura em Fahrenheit: ");
            double tempF = double.Parse(Console.ReadLine());
            double tempC = (tempF - 32) / 1.8;
            Console.WriteLine($"Temperatura em Celsius: {tempC}");

        }
    }
}