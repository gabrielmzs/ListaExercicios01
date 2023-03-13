namespace Ex18 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o valor 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor 3: ");
            double c = double.Parse(Console.ReadLine());

            if      (a > b && b > c) Console.WriteLine($"{a}, {b} e {c}.");
            else if (a > b && c > b) Console.WriteLine($"{a}, {c} e {b}.");
            else if (b > a && a > c) Console.WriteLine($"{b}, {a} e {c}.");
            else if (b > c && c > a) Console.WriteLine($"{b}, {c} e {a}.");
            else if (c > a && a > b) Console.WriteLine($"{c}, {a} e {b}.");
            else if (c > b && b > a) Console.WriteLine($"{c}, {b} e {a}.");
            

}
    }
}