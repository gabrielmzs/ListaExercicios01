namespace Ex08 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o formato da lata: 1 - Cilindrica ou 2 - Retangular");
            string tipo = Console.ReadLine();

            if(tipo == "1") {
                Console.Write("Informe a altura da lata: ");
                double altura = double.Parse(Console.ReadLine());
                Console.Write("Informe o raio da lata: ");
                double raio = double.Parse(Console.ReadLine());
                double volume = 3.1316 * raio * raio * altura;
                Console.WriteLine($"O volume da lata de óleo é: {volume}");
            }
            else if (tipo == "2") {
                Console.Write("Informe o tamanho da base da lata: ");
                double baseCaixa = double.Parse(Console.ReadLine());
                Console.Write("Informe o lado da lata: ");
                double lado = double.Parse(Console.ReadLine());
                Console.Write("Informe a profundidade da lata: ");
                double profundidade = double.Parse(Console.ReadLine());
                double volume = baseCaixa * lado * profundidade;

                Console.WriteLine($"\nO volume da lata de óleo é: {volume}");
            } else {
                Console.WriteLine("Tipo Inválido!");
            }
        }
    }
}