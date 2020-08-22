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

        public void AgregarInicio(string dato)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;
            nuevoNodo.Enlace = nodoInicial.Enlace;
            nodoInicial.Enlace = nuevoNodo;
        }

        public Nodo Buscar(string dato)
        {
            if (ValidaVacia())
            {
                return null;
            }

            Nodo nodoBusqueda = nodoInicial;

            while (nodoBusqueda.Enlace.Dato != null)
            {
                nodoActual = nodoBusqueda;
                nodoBusqueda = nodoBusqueda.Enlace;
                if(nodoBusqueda.Dato == dato)
                {
                    return nodoBusqueda;
                }

            }
            return null;
        }

        public string Eliminar(string dato)
        {
            Nodo borrarNodo = Buscar(dato);
            if (borrarNodo != null)
            {
                nodoActual.Enlace = borrarNodo.Enlace;
                return borrarNodo.Dato;
            }
            return null;
        }


    }
}
