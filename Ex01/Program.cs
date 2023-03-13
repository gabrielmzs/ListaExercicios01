namespace Ex01 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho da base da caixa: ");
            double baseCaixa = double.Parse(Console.ReadLine());
            Console.Write("Informe o lado da caixa: ");
            double lado = double.Parse(Console.ReadLine());
            Console.Write("Informe a profundidade da caixa: ");
            double profundidade = double.Parse(Console.ReadLine());
            double volume = baseCaixa * lado * profundidade;

            Console.WriteLine($"\nO volume da caixa é: {volume}");
        }
    }
}