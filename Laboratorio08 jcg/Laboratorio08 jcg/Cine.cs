using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08_jcg
{
    [Serializable]
    class Cine:Local
    {
        private int numerosalas;

        public int Numerosalas { get => numerosalas; set => numerosalas = value; }

        public Cine(string nombrelocal, string duenio, int id, string fecha, int numerosalas)
        {
            this.Nombrelocal = nombrelocal;
            this.Nombredueño = duenio;
            this.Id = id;
            this.Horarioatencion = fecha;
            this.Numerosalas = numerosalas;

        }
    }
}
