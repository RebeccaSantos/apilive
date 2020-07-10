using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace apilive.utils
{
    public class FilmeGetConverter
    {
        public List<Models.Response.FilmeGetResponse> ToResponseMany(List<Models.TbFilme> filmes)
        {
            List<Models.Response.FilmeGetResponse> filmesResponse =
            filmes.Select(x => new Models.Response.FilmeGetResponse { 
                ID = x.IdFilme,
                Filme = x.NmFilme,
                Genero = x.DsGenero,
                Avaliacao = x.VlAvaliacao,
                Disponivel = x.BtDisponivel,
                Duracao = x.NrDuracao,
                Lancamento = x.DtLancamento
            }).ToList();
            
            return filmesResponse;
        }
    }
}