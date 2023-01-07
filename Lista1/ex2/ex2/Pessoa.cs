using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Pessoa
    {
        private string NomeCompleto { get; set; }
        private string Email { get; set; }
        public string PrimeiroNome { get; set; }

        public void NomePessoa()
        {
            PrimeiroNome = "Rafael";
            Console.WriteLine("Primeiro Nome: " + PrimeiroNome);
            NomeCompleto = "Rafael Gualdieri Pinheiro";
            Console.WriteLine("Nome Completo: " + NomeCompleto);
        }

        public void EmailPessoa()
        {
            Email = "rafael.gualdieri.pinheiro@email.com";
            Console.WriteLine("Email: " + Email);
        }
    }
}
