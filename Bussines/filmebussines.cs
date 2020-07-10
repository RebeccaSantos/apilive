using System;
using System.Linq;
using System.Collections.Generic;


namespace apilive.Bussines
{
    public class filmebussines
    {
        Database.filmedatabase db = new Database.filmedatabase();
        public Models.TbFilme ValidarInserir(Models.TbFilme tabela)
        {
                if(tabela.NmFilme==string.Empty)
                        throw new ArgumentException("Nome é obrigatorio");

                if(tabela.DsGenero==string.Empty)
                        throw new ArgumentException("Genero é obrigatorio");

                if(tabela.DtLancamento==new DateTime())
                        throw new ArgumentException("Data invalida");

                    if(tabela.NrDuracao<=0)
                        throw new ArgumentException("Duração invalida");
                
                if(tabela.VlAvaliacao<=0)
                    throw new ArgumentException("Avaliação invalida");


              db.Inserir(tabela);

              return tabela;
        }

        public List<Models.TbFilme> ConsultarPorNomeGenero (string nome, string genero)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome é obrigatório.");
            if (string.IsNullOrEmpty(genero))
                throw new ArgumentException("Gênero é obrigatório.");

            return db.ConsultarPorNomeGenero(nome, genero);
        }
    }
}