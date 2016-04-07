using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    interface IRepositorio<T> : IRepositorioLectura<T>
    {
        bool Adicionar(T ao_entidad);
        bool Actualizar(T ao_entidad);
        bool GuardarCambios();
    }
}
