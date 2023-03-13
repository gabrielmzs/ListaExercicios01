namespace Ex12 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho da frente do terreno: ");
            double frente = double.Parse(Console.ReadLine());
            Console.Write("Informe o tamanho do lado do terreno: ");
            double lado = double.Parse(Console.ReadLine());
            double area = lado * frente;

            Console.WriteLine($"O terreno possui uma área de {area} m².");
        }   
    }
}