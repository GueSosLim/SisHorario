﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Contextos
{
    public class ContextoBase<T> : DbContext where T : DbContext
    {
        public ContextoBase(string as_conexion)
            : base(as_conexion)
        {
            Database.SetInitializer<T>(null);
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //Configuration.ProxyCreationEnabled = false;
        }
    }
}
