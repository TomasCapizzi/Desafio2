using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    public interface IUsuario
    {
        public void ModificarNombreUsuario();
        public void ModificarContraseña();
        public void ModificarMail();
        public void EliminarUsuario();

    }
}
