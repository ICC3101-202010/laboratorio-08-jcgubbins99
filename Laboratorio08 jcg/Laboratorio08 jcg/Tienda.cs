﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08_jcg
{
    [Serializable]
    class Tienda:Local
    {
        public List<string> categorias = new List<string>();
        public Tienda(string nombrelocal, string duenio, int id, string fecha)
        {
            this.Nombrelocal = nombrelocal;
            this.Nombredueño = duenio;
            this.Id = id;
            this.Horarioatencion = fecha;
            this.Tipo = 2;


        }

        public string verinfocategorias()
        {
            string info2 = "";
            for (int i = 0; i < categorias.Count; i++)
            {
                info2 += categorias[i] +", ";

            }
            return info2;

        }
        public string InformacionTienda()
        {
            string informacion2 = ("NOMBRE TIENDA: " + Nombrelocal + " DUEÑO: " + Nombredueño + " ID: " + Id + " HORARIO: " + Horarioatencion +" CATEGORIAS: "+ verinfocategorias());
            
            return informacion2;
        }
    }
}
