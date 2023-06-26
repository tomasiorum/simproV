using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimproV.BD
{
    public static class JsonBD
    {
        public static List<Utente> Utentes()
        {
            List<Utente> lista = new List<Utente>();

            return lista;
        }
        //public static Utente LoadUtentes(string fullName)
        //{
        //    var filestream = new System.IO.FileStream(fullName,
        //                                                  System.IO.FileMode.Open,
        //                                                  System.IO.FileAccess.Read,
        //                                                  System.IO.FileShare.ReadWrite);
        //    var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);

        //    Utente entidades = new Entidades();


        //    string s = file.ReadToEnd();
        //    if (s != null)
        //    {
        //        entidades = JsonConvert.DeserializeObject<Entidades>(s);
        //    }
        //    file.Close();
        //    return entidades;
        //}
    }
}
