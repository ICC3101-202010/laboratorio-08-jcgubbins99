using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio08_jcg
{
    public partial class VER_LOCALES : Form
    {
        public VER_LOCALES()
        {
            InitializeComponent();
        }

        private void btn_atras_locales_activos_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void listBox_locales_activos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_ver_Click(object sender, EventArgs e)
        
        {
            CentroComercial.Activarlistalocales();
            
            if (CentroComercial.locales.Count == 0)
            {
                MessageBox.Show("NO HAY LOCALES AGREGADOS AUN", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            for (int i = 0; i < CentroComercial.locales.Count; i++)
            {
                if (CentroComercial.locales[i].Tipo == 1)
                {
                    Cine cine = (Cine)CentroComercial.locales[i];
                    listBox_locales_activos.Items.Add(cine.InformacionCine());
                }
                if (CentroComercial.locales[i].Tipo == 2)
                {
                    Tienda tienda = (Tienda)CentroComercial.locales[i];
                    listBox_locales_activos.Items.Add(tienda.InformacionTienda());
                }
                if (CentroComercial.locales[i].Tipo == 3)
                {
                    Restaurante res = (Restaurante)CentroComercial.locales[i];
                    listBox_locales_activos.Items.Add(res.InformacionRestaurante());
                }
                if (CentroComercial.locales[i].Tipo == 4)
                {
                    Recreacional recrea = (Recreacional)CentroComercial.locales[i];
                    listBox_locales_activos.Items.Add(recrea.infoRecrea());
                }
                

            }
            
        }
    }
}
