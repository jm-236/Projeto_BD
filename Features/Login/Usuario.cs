using System;

namespace patrimonioDB.Features.Login
{
    public class Usuario : Pessoa
    {
        public int SetorId { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}