namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caneta 1");
            Caneta caneta1 = new Caneta();
            caneta1.Cor = "Azul";
            Console.WriteLine("Cor: " + caneta1.Cor);

            Console.WriteLine("\nCaneta 2");
            Caneta caneta2 = new Caneta();
            caneta2.Cor = "Verde";
            Console.WriteLine("Cor: " + caneta2.Cor);
        }
    }
}