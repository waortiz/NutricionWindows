using Datos;
using Nutricion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AccesoDatosPaciente
    {
        private static Context context = new Context(); 
        public static void IngresarPaciente(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            context.SaveChanges();
        }

        internal static List<TipoDocumento> ObtenerTiposDocumento()
        {
            return context.TiposDocumento.ToList();
        }

        internal static List<EstadoCivil> ObtenerEstadosCiviles()
        {
            return context.EstadosCiviles.ToList();
        }
    }
}
