﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08_jcg
{
    [Serializable]
    class Recreacional : Local
    {
        public Recreacional(string nombrelocal, string nombresdueño, int id, string fecha)
        {
            this.Nombrelocal = nombrelocal;
            this.Nombredueño = nombresdueño;
            this.Id = id;
            this.Horarioatencion = fecha;
        }
    }
}
