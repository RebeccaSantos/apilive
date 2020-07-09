using System;
namespace apilive.Bussines
{
    public class filmebussines
    {
        Database.filmedatabase db=new Database.filmedatabase();
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
    }
}