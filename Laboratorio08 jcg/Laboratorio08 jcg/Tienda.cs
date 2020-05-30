using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08_jcg
{
    [Serializable]
    class Tienda:Local
    {
        private List<string> lista_categorias = new List<string>();

        public List<string> Lista_categorias { get => lista_categorias; set => lista_categorias = value; }
        public Tienda(string nombrelocal, string duenio, int id, string fecha, List<string> listacategorias)
        {
            this.Nombrelocal = nombrelocal;
            this.Nombredueño = duenio;
            this.Id = id;
            this.Horarioatencion = fecha;
            this.Lista_categorias = listacategorias;

        }

        
    }
}
