using Igreja.Dominio.Enums;
using System;

namespace Igreja.Dominio.Entidades
{
    public class Membro : Commom
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
    }
}
