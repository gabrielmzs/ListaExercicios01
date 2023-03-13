namespace Ex26 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o valor fatorial: ");
            int a = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = a; i >= 1; i--) {
                resultado *= i;
            }
            Console.WriteLine($"{a}! = {resultado}");
        }
    }
}