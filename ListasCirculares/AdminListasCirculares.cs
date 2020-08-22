using System;
using System.Collections.Generic;
using System.Text;

namespace ListasCirculares
{
    public class AdminListasCirculares
    {
        private Nodo nodoInicial;
        private Nodo nodoActual;

        public AdminListasCirculares()
        {
            nodoInicial = new Nodo();
            nodoInicial.Enlace = nodoInicial;
        }

        public bool ValidaVacia()
        {
            return (nodoInicial.Enlace == nodoInicial);
        }

        public void VaciarLista()
        {
            nodoInicial.Enlace = nodoInicial;
        }

        public string RecorrerLista()
        {
            string datos = string.Empty;

            nodoActual = nodoInicial;

            while (nodoActual.Enlace.Dato != null)
            {
                nodoActual = nodoActual.Enlace;
                datos += $" {nodoActual.Dato} =>";
            }

            
            return $"\n\t{datos}   {nodoInicial.Enlace.Dato}\n";
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;

            while(nodoActual.Enlace.Dato != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;
            nuevoNodo.Enlace = nodoInicial;
            nodoActual.Enlace = nuevoNodo;
        }



    }
}
