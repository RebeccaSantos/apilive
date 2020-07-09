namespace apilive.Database
{
    public class filmedatabase
    {
        Models.apidbContext ctx=new Models.apidbContext();      
         public Models.TbFilme Inserir(Models.TbFilme tabela)
       {
                ctx.TbFilme.Add(tabela);
                ctx.SaveChanges();
                return tabela;
       } 
    }
}