using System;
using System.Collections.Generic;
using System.Text;

namespace ListasCirculares
{
    public class Nodo
    {
        //pueden o no ser definidas ya que las propiedades
        //son autoimplementadas.
        //private string dato;
        //private Nodo enlace;

        public string Dato { get; set; }
        public Nodo Enlace { get; set; }


    }
}
