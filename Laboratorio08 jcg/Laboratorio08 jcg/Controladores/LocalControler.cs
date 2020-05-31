using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio08_jcg.Controladores
{
     class LocalControler
    {
        Form1 fORM1;
        VER_LOCALES verlocales;
        
        static public List<Local> locales = new List<Local>();
        public LocalControler(Form fORM1, Form verlocal)
        {
            Activarlistalocales();
            this.fORM1 = fORM1 as Form1;
            this.verlocales = verlocal as VER_LOCALES;
        }


        static void AlmacenarLocal(List<Local> s)      //Serializamos
        {
            Stream stream3;
            IFormatter formatter3 = new BinaryFormatter();
            stream3 = new FileStream("Locales.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter3.Serialize(stream3, s);
            stream3.Close();



        }
        static List<Local> CargarLocal()
        {
            try
            {
                IFormatter formatter4 = new BinaryFormatter();
                Stream stream4 = new FileStream("Locales.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                List<Local> s2 = (List<Local>)formatter4.Deserialize(stream4);
                stream4.Close();
                return s2;

            }

            catch
            {
                throw new Exception();

            }


        }
        public static void Activarlistalocales()
        {
            try
            {
                locales = CargarLocal();

            }
            catch
            {
                MessageBox.Show("NO HAY LOCALES PARA BUSCAR, SI ACABAS DE CREAR UNO SE ALMACENARÁ EN LA BASE DE DATOS", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
                AlmacenarLocal(locales);

            }
        }

        public static bool Agregartienda(Tienda t)
        {

            Activarlistalocales();
            for (int i = 0; i < locales.Count; i++)
            {
                if (t.Id == locales[i].Id)
                {
                    MessageBox.Show("EL ID INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (t.Nombrelocal == locales[i].Nombrelocal)
                {
                    MessageBox.Show("EL NOMBRE DEL LOCAL INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("TIENDA AGREGADA EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Agregarcine(Cine t)
        {
            Activarlistalocales();
            for (int i = 0; i < locales.Count; i++)
            {
                if (t.Id == locales[i].Id)
                {
                    MessageBox.Show("EL ID INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (t.Nombrelocal == locales[i].Nombrelocal)
                {
                    MessageBox.Show("EL NOMBRE DEL LOCAL INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("CINE AGREGADO EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Agregarrestau(Restaurante t)
        {
            Activarlistalocales();
            for (int i = 0; i < locales.Count; i++)
            {
                if (t.Id == locales[i].Id)
                {
                    MessageBox.Show("EL ID INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (t.Nombrelocal == locales[i].Nombrelocal)
                {
                    MessageBox.Show("EL NOMBRE DEL LOCAL INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("RESTATURANTE AGREGADO EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Agregarrecrea(Recreacional t)
        {

            Activarlistalocales();
            for (int i = 0; i < locales.Count; i++)
            {
                if (t.Id == locales[i].Id)
                {
                    MessageBox.Show("EL ID INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (t.Nombrelocal == locales[i].Nombrelocal)
                {
                    MessageBox.Show("EL NOMBRE DEL LOCAL INGRESADO YA PERTENECE A UN LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



            }
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("RESTATURANTE AGREGADO EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static string Buscarlocal(string nombre)
        {
            Activarlistalocales();
            string info = "";
            if (locales.Count == 0)
            {
                MessageBox.Show("NO HAY LOCALES AGREGADOS AUN", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            for (int i = 0; i < locales.Count; i++)
            {

                if (locales[i].Nombrelocal == nombre)
                {
                    switch (locales[i].Tipo)
                    {
                        case 1:
                            Cine cine = (Cine)locales[i];
                            info = cine.InformacionCine();
                            break;
                        case 2:
                            Tienda tienda = (Tienda)locales[i];
                            info = tienda.InformacionTienda();
                            break;
                        case 3:
                            Restaurante res = (Restaurante)locales[i];
                            info = res.InformacionRestaurante();
                            break;
                        case 4:
                            Recreacional recrea = (Recreacional)locales[i];
                            info = recrea.infoRecrea();
                            break;




                    }




                }


            }
            if (info == "")
            {
                MessageBox.Show("INGRESE BIEN EL NOMBRE DEL LOCAL", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return info;

        }
    }
}
