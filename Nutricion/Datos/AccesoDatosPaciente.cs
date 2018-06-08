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

        internal static List<Paciente> ObtenerPacientes()
        {
            return context.Pacientes.ToList();
        }

        internal static void EliminarPaciente(long idPaciente)
        {
            var paciente = context.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (paciente != null)
            {
                context.Pacientes.Remove(paciente);
                context.SaveChanges();
            }
        }

        internal static List<Paciente> ObtenerPacientes(long? numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            return context.Pacientes.Where(p=> (numeroDocumento == null || p.NumeroDocumento == numeroDocumento.Value) && 
            (primerNombre == "" || p.PrimerNombre.Contains(primerNombre)) &&
            (segundoNombre == "" || p.SegundoNombre.Contains(segundoNombre)) &&
            (primerApellido == "" || p.PrimerApellido.Contains(primerApellido)) &&
            (segundoApellido == "" || p.SegundoApellido.Contains(segundoApellido)) 
            ).ToList();
        }
    }
}
