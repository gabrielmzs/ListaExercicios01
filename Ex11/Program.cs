namespace Ex11 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            string primo = "teste";

            for (int i = 2; i < numero; i++) {
                if (numero % i == 0) {
                    primo = "NÃO É PRIMO";
                } else {
                    primo = "É PRIMO";
                }
            }

            Console.WriteLine($"O número {primo}.");
        }
    }
}