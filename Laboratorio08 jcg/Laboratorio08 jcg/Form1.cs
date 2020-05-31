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

    public partial class Form1 : Form
    {
        public static List<string> listacat = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_local_Click(object sender, EventArgs e)
        {
            panel_agregar_local.Visible = true;
            panel_agregar_local.Dock = DockStyle.Fill;
        }

        private void btn_buscar_local_Click(object sender, EventArgs e)
        {
            panel_buscar_local.Visible = true;
            panel_buscar_local.Dock = DockStyle.Fill;
        }

        private void btn_crear_tienda_Click(object sender, EventArgs e)
        {
            panel_agregar_tienda.Visible = true;
            panel_agregar_tienda.Dock = DockStyle.Fill;
        }

        private void btn_crear_cine_Click(object sender, EventArgs e)
        {
            panel_agregar_cine.Visible = true;
            panel_agregar_cine.Dock = DockStyle.Fill;
        }

        private void btn_crear_restaurante_Click(object sender, EventArgs e)
        {
            panel_agregar_restau.Visible = true;
            panel_agregar_restau.Dock = DockStyle.Fill;
        }

        private void btn_crear_recreacional_Click(object sender, EventArgs e)
        {
            panel_agregaer_recreacional.Visible = true;
            panel_agregaer_recreacional.Dock = DockStyle.Fill;
        }

        private void btn_atras_agregar_local_Click(object sender, EventArgs e)
        {
            panel_agregar_local.Visible = false;
        }

        private void textBox_nombre_tienda_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_dueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_horario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cantidad_categorias_TextChanged(object sender, EventArgs e)
        {
            
            if(textBox_cantidad_categorias.Text == "1")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                


            }
            if (textBox_cantidad_categorias.Text == "2")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                
            }
            if (textBox_cantidad_categorias.Text == "3")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = false;
                

            }
            if (textBox_cantidad_categorias.Text == "4")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_tienda_Click(object sender, EventArgs e)
        {
            listacat.Clear();
            if (textBox_cantidad_categorias.Text == "1")
            {
                try
                {

                    Tienda t = new Tienda(textBox_nombre_tienda.Text.ToLower(), textBox_nombre_dueño.Text.ToLower(), int.Parse(textBox_id.Text), textBox_horario.Text.ToLower());
                    t.categorias.Add(comboBox1.Text);
                    CentroComercial.Agregartienda(t);
                    listacat.Add(comboBox1.Text);
                }
                catch
                {
                    MessageBox.Show("EL ID TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            if (textBox_cantidad_categorias.Text == "2")
            {
                try
                {
                    Tienda t = new Tienda(textBox_nombre_tienda.Text.ToLower(), textBox_nombre_dueño.Text.ToLower(), int.Parse(textBox_id.Text), textBox_horario.Text.ToLower());
                    t.categorias.Add(comboBox1.Text);
                    t.categorias.Add(comboBox2.Text);
                    CentroComercial.Agregartienda(t);
                }
                catch
                {
                    MessageBox.Show("EL ID TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            if (textBox_cantidad_categorias.Text == "3")
            {
                try
                {
                    Tienda t = new Tienda(textBox_nombre_tienda.Text.ToLower(), textBox_nombre_dueño.Text.ToLower(), int.Parse(textBox_id.Text), textBox_horario.Text.ToLower());
                    t.categorias.Add(comboBox1.Text);
                    t.categorias.Add(comboBox2.Text);
                    t.categorias.Add(comboBox3.Text);
                    CentroComercial.Agregartienda(t);
                }
                catch
                {
                    MessageBox.Show("EL ID TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            if (textBox_cantidad_categorias.Text == "4")
            {
                try
                {
                    Tienda t = new Tienda(textBox_nombre_tienda.Text.ToLower(), textBox_nombre_dueño.Text.ToLower(), int.Parse(textBox_id.Text), textBox_horario.Text.ToLower());
                    t.categorias.Add(comboBox1.Text);
                    t.categorias.Add(comboBox2.Text);
                    t.categorias.Add(comboBox3.Text);
                    t.categorias.Add(comboBox4.Text);
                    CentroComercial.Agregartienda(t);
                }
                catch
                {
                    MessageBox.Show("EL ID TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void panel_agregar_tienda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_agregar_tienda.Visible = false;
            textBox_nombre_tienda.Clear();
            textBox_nombre_dueño.Clear();
            textBox_id.Clear();
            textBox_horario.Clear();
        }
        // /////////////////////////////////////////////////////AGREGAR CINE/////////////////////////////////////////////////////////////////77
        private void btn_agregar_cine_Click(object sender, EventArgs e)
        {
            try
            {
                Cine c = new Cine(textBox_nombre_cine.Text.ToLower(), textBox_nombre_dueño_cine.Text.ToLower(), int.Parse(textBox_id_cine.Text), textBox_horario_cine.Text.ToLower(), int.Parse(textBox_numero_de_salas.Text));
                CentroComercial.Agregarcine(c);
            }
            catch
            {
                MessageBox.Show("EL ID Y EL NUMERO DE SALAS TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_atras_cine_Click(object sender, EventArgs e)
        {
            panel_agregar_cine.Visible = false;
            textBox_nombre_cine.Clear();
            textBox_nombre_dueño_cine.Clear();
            textBox_id_cine.Clear();
            textBox_horario_cine.Clear();
            textBox_numero_de_salas.Clear();

        }

        private void textBox_nombre_cine_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_dueño_cine_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_cine_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_horario_cine_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_numero_de_salas_TextChanged(object sender, EventArgs e)
        {

        }
        // ///////////////////////////////////////////////////AGREGAR RESTAURANTE////////////////////////////////////////////////
        private void btn_atras_agregar_restaurante_Click(object sender, EventArgs e)
        {
            panel_agregar_restau.Visible = false;
            textBox_nombre_lrestau.Clear();
            textBox_dueño_restau.Clear();
            textBox_id_restau.Clear();
            textBox_horario_restau.Clear();
            textBox_mesas_reservadas.Clear();

        }

        private void btn_agregar_restaurante_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante r = new Restaurante(textBox_nombre_lrestau.Text.ToLower(), textBox_dueño_restau.Text.ToLower(), int.Parse(textBox_id_restau.Text), textBox_horario_restau.Text, textBox_mesas_reservadas.Text.ToLower());
                CentroComercial.Agregarrestau(r);
            }
            catch
            {
                MessageBox.Show("EL ID TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_nombre_lrestau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_dueño_restau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_restau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_horario_restau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_mesas_reservadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_agregar_restau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_agregar_local_Paint(object sender, PaintEventArgs e)
        {

        }
        // ////////////////////RECREACIONAL/////////////////////////////////////////////////////////////////////////////////
        private void btn_atras_agregar_recrea_Click(object sender, EventArgs e)
        {
            panel_agregaer_recreacional.Visible = false;
            textBox_nombre_recreacional.Clear();
            textBox_id_recreacional.Clear();
            textBox_dueño_recreacional.Clear();
            textBox_horario_recreacional.Clear();
        }

        private void btn_agregae_recreacional_Click(object sender, EventArgs e)
        {
            try
            {
                Recreacional re = new Recreacional(textBox_nombre_recreacional.Text.ToLower(), textBox_dueño_recreacional.Text.ToLower(), int.Parse(textBox_id_recreacional.Text), textBox_horario_recreacional.Text.ToLower());
                CentroComercial.Agregarrecrea(re);
            }
            catch
            {
                MessageBox.Show("EL ID TIENE QUE SER UN NUMERO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_nombre_recreacional_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_dueño_recreacional_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_recreacional_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_horario_recreacional_TextChanged(object sender, EventArgs e)
        {

        }
        // BUSCADOR ////////////////////////////////////////////////////////////////////////////////////////7
        private void btn_atras_buscar_Click(object sender, EventArgs e)
        {
            panel_buscar_local.Visible = false;
            textBox1.Clear();
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add(CentroComercial.Buscarlocal(textBox1.Text.ToLower()));
            
        }

        private void btn_ver_locales_Click(object sender, EventArgs e)
        {
            VER_LOCALES vER_LOCALES  = new VER_LOCALES();
            vER_LOCALES.Show();
        }
    }
}
