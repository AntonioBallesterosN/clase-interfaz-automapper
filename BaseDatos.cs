using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_interfaz_automapper
{
    internal class MueblesBaseDeDatos
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
    }

    internal class AutomovilBaseDeDatos
    {
        public int Id { get; set; }
        public string Transmicion { get; set; }
        public string Marca { get; set; }
    }
    internal class PersonaBaseDeDatos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

}
