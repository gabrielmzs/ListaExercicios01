namespace Ex13 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número de pães vendidos hoje: ");
            int pao = int.Parse(Console.ReadLine());
            Console.Write("Informe o número de broas vendidos hoje: ");
            int broa = int.Parse(Console.ReadLine());

            double total = (pao * 0.12) + (broa * 1.5);
            double poupanca = total * 0.10;

            Console.WriteLine($"Foram vendidos {pao} pães e {broa} broas no dia de hoje. Totalizando R$ {total} em vendas. \nDeverá ser depositado em poupança o valor de R$ {poupanca} .");
        }
    }
}