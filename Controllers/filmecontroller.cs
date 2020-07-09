using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace apilive.Controllers
{
    [ApiController]
   [Route("[controller]")] 
    public class filmecontroller:ControllerBase
    {
        utils.filmeconversor convesor=new utils.filmeconversor();
        Bussines.filmebussines bussines=new Bussines.filmebussines();

        [HttpPost]
        public ActionResult<Models.Response.filmeresponse> Inserir(Models.Request.filmerequest req)
        {
               try
               {
                        
                    Models.TbFilme tabela=convesor.ParaModeloTabela(req);
                    bussines.ValidarInserir(tabela);
                    Models.Response.filmeresponse resp=convesor.ParamodeloResponse(tabela);

                    return resp;
               }
               catch(System.Exception ex)
               {
                     return  BadRequest(new Models.Response.erroresponse(400,ex.Message));
               }
        }
  
    }
}