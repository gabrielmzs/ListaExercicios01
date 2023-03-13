namespace Ex27 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.Write("Sequência de Fibonacci até o número digitado: ");

            while (c <= numero) {
                Console.Write($"{c} ");

                a = b;
                b = c;
                c = a + b;
            }

        }
    }
}