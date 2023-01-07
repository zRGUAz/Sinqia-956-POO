namespace ex1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();

            Console.WriteLine("Definindo username em uma classe não derivada à classe em que username foi criada");
            user.Username = "Rafael";
            Console.WriteLine("Exibindo username em uma classe não derivada à classe em que username foi criada: " + user.Username);

            //user.password = "123"; (private - não pode)
            user.definirSenha();
            //Console.WriteLine(user.password); (private - não pode)
            user.exibirSenha();

            Usuario2 user2 = new Usuario2();
            //user.email = "meuEmail@email.com"; (protected - não pode)
            user2.definirEmail();
            //Console.WriteLine(user.email); (protected - não pode) 
            user2.exibirEmail();
        }
    }
}