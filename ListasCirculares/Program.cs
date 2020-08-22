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
        }
    }
}
