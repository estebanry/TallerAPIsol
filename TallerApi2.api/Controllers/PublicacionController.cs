using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerApi.Dominio;
using TallerApi2.api.Models;

namespace TallerApi2.api.Controllers
{
    public class PublicacionController : ApiController
    {

        public IEnumerable<Publicacion> Get()
        {
            using (PublicacionContext context = new PublicacionContext())
            {
                return context.Publicaciones.ToList();
            }
                
        }

    }
}
