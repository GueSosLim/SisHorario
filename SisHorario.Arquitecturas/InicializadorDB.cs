using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Infraestructura
{
    class InicializadorDB : CreateDatabaseIfNotExists<SisHorarioContexto>
    {
        protected override void Seed(SisHorarioContexto context)
        {
            
        }
    }
}
