using Nutricion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Ciudadanía", Id = 1 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Extranjería", Id = 2 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Tarjeta de Identidad", Id = 3 });

            context.EstadosCiviles.Add(new EstadoCivil() { Nombre = "Soltero", Id = 1 });
            context.EstadosCiviles.Add(new EstadoCivil() { Nombre = "Casado", Id = 2 });

            base.Seed(context);
        }
    }
}
