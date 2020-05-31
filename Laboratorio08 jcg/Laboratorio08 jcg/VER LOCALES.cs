using Laboratorio08_jcg.Controladores;
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
            LocalControler.Activarlistalocales();
            
            if (LocalControler.locales.Count == 0)
            {
                MessageBox.Show("NO HAY LOCALES AGREGADOS AUN", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            for (int i = 0; i < LocalControler.locales.Count; i++)
            {
                if (LocalControler.locales[i].Tipo == 1)
                {
                    Cine cine = (Cine)LocalControler.locales[i];
                    listBox_locales_activos.Items.Add(cine.InformacionCine());
                }
                if (LocalControler.locales[i].Tipo == 2)
                {
                    Tienda tienda = (Tienda)LocalControler.locales[i];
                    listBox_locales_activos.Items.Add(tienda.InformacionTienda());
                }
                if (LocalControler.locales[i].Tipo == 3)
                {
                    Restaurante res = (Restaurante)LocalControler.locales[i];
                    listBox_locales_activos.Items.Add(res.InformacionRestaurante());
                }
                if (LocalControler.locales[i].Tipo == 4)
                {
                    Recreacional recrea = (Recreacional)LocalControler.locales[i];
                    listBox_locales_activos.Items.Add(recrea.infoRecrea());
                }
                

            }
            
        }
    }
}
