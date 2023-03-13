namespace Ex19 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso/(altura * altura);

            if (imc < 18.5) Console.WriteLine("Abaixo do Peso.");
            else if (imc < 25) Console.WriteLine("Peso normal.");
            else if (imc <= 30) Console.WriteLine("Peso Acima.");
            else  Console.WriteLine("Obeso.");
        }
    }
}