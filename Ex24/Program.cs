namespace Ex24 {
    internal class Program {
        static void Main(string[] args) {
            int soma = 0;
            for (int i = 1; i <= 500; i++) {
                if (i % 3 == 0 && i % 2 !=0) {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}