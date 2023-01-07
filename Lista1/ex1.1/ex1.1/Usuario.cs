using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1._1
{
    public class Usuario
    {
        public string Username { get; set; }
        private string Password { get; set; }
        protected string Email { get; set; }

        public void definirSenha()
        {
            Password = "123";
            Console.WriteLine("\nDefinindo senha na mesma classe em que foi criada");
        }
        public void exibirSenha()
        {

            Console.WriteLine("Exibindo senha na mesma classe em que foi criada: " + Password);
        }
    }
}
