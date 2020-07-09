namespace apilive.utils
{
    public class filmeconversor
    {
        public Models.TbFilme ParaModeloTabela(Models.Request.filmerequest req)
        {
            Models.TbFilme tabela=new Models.TbFilme();

            tabela.NmFilme=req.Filme;
            tabela.DsGenero=req.Genero;
            tabela.VlAvaliacao=req.Avaliacao;
            tabela.BtDisponivel=req.Disponivel;
            tabela.DtLancamento=req.Lancamento;
            tabela.NrDuracao=req.Duracao;

            return tabela;

        }


        public Models.Response.filmeresponse ParamodeloResponse(Models.TbFilme tabela)
        {
            Models.Response.filmeresponse resp=new Models.Response.filmeresponse();

            resp.Id=tabela.IdFilme;
            resp.Filme=tabela.NmFilme;
            resp.Genero=tabela.DsGenero;
            resp.Avaliacao=tabela.VlAvaliacao;
            resp.Disponivel=tabela.BtDisponivel;
            resp.Duracao=tabela.NrDuracao;
            resp.Lancamento=tabela.DtLancamento;

            return resp;
        }
        
    }
}