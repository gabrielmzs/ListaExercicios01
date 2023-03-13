namespace Ex29 {
    internal class Program {
        static void Main(string[] args) {
            for (int i = 1; i <= 10; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.Write("{0}\t", i +  "x" + j + "=" + i * j);
                    //Console.WriteLine("{0}\t",$"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}