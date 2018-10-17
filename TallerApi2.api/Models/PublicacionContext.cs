using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TallerApi.Dominio;

namespace TallerApi2.api.Models
{
    public class PublicacionContext : DbContext
    {

        public PublicacionContext() : base("PublicacionConexion")
        {

        }

        public DbSet<Publicacion> Publicaciones {get ; set;}

    }
}