using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion.Entidades
{
    [Table("TiposDocumento")]
    public class TipoDocumento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
