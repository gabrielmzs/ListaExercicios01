namespace Ex04 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a quilometragem inicial: ");
            double kmInicial = double.Parse(Console.ReadLine());
            Console.Write("Informe a quilometragem final: ");
            double kmFinal = double.Parse(Console.ReadLine());
            Console.Write("Informe o consumo de combustível: ");
            double consumo = double.Parse(Console.ReadLine());
            double consumoKm = (kmFinal - kmInicial) / consumo;

            Console.WriteLine($"Consumo de combustível: {consumoKm} l/km");
        }
    }
}