using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminInversiones
{
    public class Inversiones
    {
        public string NoSocio { get; set; }
        public int solicitudInv { get; set; }
        public string Socio { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }    
        public double Tasa { get; set; }

        public List<T> llenarLista<T>(IDataReader dataReader)
        {
            List<T> lista = new List<T>();
            while (dataReader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach(var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj,Convert.ChangeType(dataReader[prop.Name].ToString(),propType));
                }
                lista.Add(obj);
            }
            return lista;
        }
    }
}
