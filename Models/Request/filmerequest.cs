using System;
namespace apilive.Models.Request
{
    public class filmerequest
    {
        public string Filme{get;set;}
        public string Genero{get;set;}
        public decimal Avaliacao{get;set;}
        public bool Disponivel{get;set;}
        public int Duracao {get;set;}
        public DateTime Lancamento{get;set;}
    }
}