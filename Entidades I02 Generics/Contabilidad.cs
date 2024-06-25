using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_I02_Generics
{
    public class Contabilidad<T, U> where U : Documento, new()
        where T : Documento
    {

        private List<T> _egresos;
        private List<U> _ingresos;

        public List<T> Egresos { get => _egresos; set => _egresos = value; }
        public List<U> Ingresos { get => _ingresos; set => _ingresos = value; }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if(egreso is T)
            {
                c._egresos.Add(egreso);
            }
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (ingreso is U)
            {
                c._ingresos.Add(ingreso);
            }
            return c;
        }
    }
}
