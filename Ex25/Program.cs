namespace Ex25 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o número da tabuada: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}