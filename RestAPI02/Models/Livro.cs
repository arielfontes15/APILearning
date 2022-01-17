using System;

namespace RestAPI02.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDeLancamento { get; set; }
    }
}
