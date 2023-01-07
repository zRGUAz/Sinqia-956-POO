using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1._1
{
    public class Usuario2 : Usuario
    {
        public void definirEmail()
        {
            Email = "meuEmail@email.com";
            Console.WriteLine("\nDefinindo email em uma classe derivada onde o email foi criado");
        }

        public void exibirEmail()
        {
            Console.WriteLine("Exibindo email em uma classe deriava onde o email foi criado: " + Email);
        }
    }
}
