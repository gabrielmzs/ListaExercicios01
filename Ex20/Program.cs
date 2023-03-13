namespace Ex20 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("O número é PAR.");
            } else {
                Console.WriteLine("O número é ÍMPAR.");
            }
        }
    }
}