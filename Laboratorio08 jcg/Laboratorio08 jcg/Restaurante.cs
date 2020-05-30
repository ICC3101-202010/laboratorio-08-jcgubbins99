using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08_jcg
{
    [Serializable]
    class Restaurante : Local
    {
        private string tenermesaexclusiva;

        public string Tenermesaexclusiva { get => tenermesaexclusiva; set => tenermesaexclusiva = value; }

        public Restaurante(string nombrelocal, string duenio, int id, string fecha, string mesaexclusiva)
        {
            this.Nombrelocal = nombrelocal;
            this.Nombredueño = duenio;
            this.Id = id;
            this.Horarioatencion = fecha;
            this.Tenermesaexclusiva = mesaexclusiva;
        }
    }
}
