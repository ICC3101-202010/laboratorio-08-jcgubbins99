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
        List<string> listacat = new List<string>();
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

        }

        private void btn_crear_tienda_Click(object sender, EventArgs e)
        {
            panel_agregar_tienda.Visible = true;
            panel_agregar_tienda.Dock = DockStyle.Fill;
        }

        private void btn_crear_cine_Click(object sender, EventArgs e)
        {

        }

        private void btn_crear_restaurante_Click(object sender, EventArgs e)
        {

        }

        private void btn_crear_recreacional_Click(object sender, EventArgs e)
        {

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
            listacat.Clear();
            if(textBox_cantidad_categorias.Text == "1")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                listacat.Add(comboBox1.Text);


            }
            if (textBox_cantidad_categorias.Text == "2")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                listacat.Add(comboBox1.Text);
                listacat.Add(comboBox2.Text);
            }
            if (textBox_cantidad_categorias.Text == "3")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = false;
                listacat.Add(comboBox1.Text);
                listacat.Add(comboBox2.Text);
                listacat.Add(comboBox3.Text);

            }
            if (textBox_cantidad_categorias.Text == "4")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                listacat.Add(comboBox1.Text);
                listacat.Add(comboBox2.Text);
                listacat.Add(comboBox3.Text);
                listacat.Add(comboBox4.Text);
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

            Tienda t = new Tienda(textBox_nombre_tienda.Text, textBox_nombre_dueño.Text, int.Parse(textBox_id.Text), textBox_horario.Text, listacat);
            CentroComercial.Agregartienda(t);
        }

        private void panel_agregar_tienda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_agregar_tienda.Visible = false;
        }
    }
}
