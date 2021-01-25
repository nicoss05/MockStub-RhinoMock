using System;
using System.Collections.Generic;

namespace MockStub
{
    internal class Bodega
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        internal void Agregar(string producto, int cantidad)
        {
            if (dic.ContainsKey(producto))
            {
                dic[producto] += cantidad;
            }
            else
            {
                dic.Add(producto, cantidad);
            }            
        }

        internal int Existencia(string producto)
        {
            if(dic.ContainsKey(producto))
            {
                return dic[producto];
            }
            return 0;
        }

        internal void ActualizarExistencia(string producto, int cantidad)
        {            
            if (dic.ContainsKey(producto))
            {
                dic[producto] = cantidad;
            }
            else
            {
                Agregar(producto, cantidad);
            }
            
        }
    }
}