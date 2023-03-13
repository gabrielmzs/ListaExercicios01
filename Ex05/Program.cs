namespace Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = (4* raio * raio * raio * 3.1416)/3;
            Console.WriteLine($"Volume da esfera: {volume}");
        }
    }
}