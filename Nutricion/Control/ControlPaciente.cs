﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion.Control
{
    public class ControlPaciente
    {
        public static void IngresarPaciente(Entidades.Paciente paciente)
        {
            AccesoDatosPaciente.IngresarPaciente(paciente);
        }

        internal static List<Entidades.TipoDocumento> ObtenerTiposDocumento()
        {
            return AccesoDatosPaciente.ObtenerTiposDocumento();
        }

        internal static List<Entidades.EstadoCivil> ObtenerEstadosCiviles()
        {
            return AccesoDatosPaciente.ObtenerEstadosCiviles();
        }

        internal static List<Entidades.Paciente> ObtenerPacientes()
        {
            return AccesoDatosPaciente.ObtenerPacientes();
        }

        internal static List<Entidades.Paciente> ConsultarPacientes(long? numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            return AccesoDatosPaciente.ObtenerPacientes(numeroDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido);
        }

        internal static void EliminarPaciente(long idPaciente)
        {
            AccesoDatosPaciente.EliminarPaciente(idPaciente);
        }
    }
}
