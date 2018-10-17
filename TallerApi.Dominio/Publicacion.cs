using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerApi.Dominio
{

    [Table("Publicacion")]
    public class Publicacion
    {

        public int Id { get; set; }
        [MaxLength(50)]
        public string Usuario { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Megusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool Privado { get; set; }
    }
}
