using System;

namespace ListasCirculares
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamar a clase para funcionalidad
            AdminListasCirculares lista = new AdminListasCirculares();

            lista.AgregarNodo("segundo");
            lista.AgregarNodo("tercero");
            //string impresion = lista.RecorrerLista();
            Console.WriteLine(lista.RecorrerLista());
            Nodo respuesta = lista.Buscar("terecero");
            string r = respuesta != null ? "si se encontro" : "no se encontro";
            Console.WriteLine("\t"+r);
            Console.WriteLine($"\tEl dato {lista.Eliminar("segundo")} fue eliminado");
            Console.WriteLine(lista.RecorrerLista());
        }
    }
}
