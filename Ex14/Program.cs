namespace Ex14 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            int diasVividos = idade * 365;

            Console.WriteLine($"{nome}, você já viveu {diasVividos} dias.");
        }
    }
}