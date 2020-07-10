using System;

namespace apilive.Models.Response
{
    public class FilmeGetResponse
    {
        public int ID { get; set; }
        public string Filme { get; set; }
        public string Genero { get; set; }
        public decimal? Avaliacao { get; set; }
        public bool? Disponivel { get; set; }
        public int? Duracao { get; set; }
        public DateTime? Lancamento { get; set; }
    }
}