using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08_jcg
{
    [Serializable]
    public class Local
    {
        private string nombrelocal;
        private string nombredueño;
        private int id;
        private string horarioatencion;
        private int tipo; //1: Cine,2: Tienda
        public string Nombredueño { get => nombredueño; set => nombredueño = value; }
        public int Id { get => id; set => id = value; }
        public string Horarioatencion { get => horarioatencion; set => horarioatencion = value; }
        public string Nombrelocal { get => nombrelocal; set => nombrelocal = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
