using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Laboratorio08_jcg
{
    static class CentroComercial
    {
        static public List<Local> locales = new List<Local>();



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
        static void Activarlistalocales()
        {
            try
            {
                locales = CargarLocal();

            }
            catch
            {

                AlmacenarLocal(locales);

            }
        }

        public static bool Agregartienda(Tienda t)
        {
            Activarlistalocales();
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("TIENDA AGREGADA EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Agregarcine(Cine t)
        {
            Activarlistalocales();
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("CINE AGREGADO EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Agregarrestau(Restaurante t)
        {
            Activarlistalocales();
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("RESTATURANTE AGREGADO EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Agregarrecrea(Recreacional t)
        {
            Activarlistalocales();
            locales.Add(t);
            AlmacenarLocal(locales);
            MessageBox.Show("RESTATURANTE AGREGADO EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }



    }
}
