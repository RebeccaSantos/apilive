using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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


        public List<Models.TbFilme> ConsultarPorNomeGenero (string nome, string genero)
        {
            List<Models.TbFilme> filmes = 
                ctx.TbFilme.Where(x => x.NmFilme.ToLower().Contains(nome.ToLower())
                                && x.DsGenero.ToLower().Contains(genero.ToLower()))
                            .ToList();

            return filmes;
        }
    }
}