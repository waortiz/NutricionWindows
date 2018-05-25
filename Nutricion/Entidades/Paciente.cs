using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion.Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public bool Beneficiario { get; set; }
        public string Telefono { get; set; }
        public long NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        public int IdEstadoCivil { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        
        public int IdTipoDocumento { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
