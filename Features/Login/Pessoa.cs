using System;

namespace patrimonioDB.Features.Login
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}