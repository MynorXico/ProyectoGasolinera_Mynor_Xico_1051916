using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class Formato
    {
        public void menuFormato(string opcion1, string opcion2, string opcion3, string opcion4, string opcion5, string opcion6)
        {   Console.BackgroundColor = ConsoleColor.Black;            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.WriteLine("     4. " + opcion4);
            Console.WriteLine("     5. " + opcion5);
            Console.WriteLine("     6. " + opcion6);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void menuFormato(string opcion1, string opcion2, string opcion3)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void menuFormato(string opcion1, string opcion2, string opcion3, string opcion4)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.WriteLine("     4. " + opcion4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void menuFormato(string opcion1, string opcion2)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void escribirContenido(string contenido)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**********************************************************");
            Console.ResetColor();
            Console.WriteLine(contenido);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**********************************************************");
        }
        public void escribirTitulo(string titulo)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("                    " + titulo + "                ");
            Console.ResetColor();
        }
        public void mensajeBienvenida(string mensaje)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      "+mensaje+"                   ");
        }
        public void mensajeExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ResetColor();
            System.Threading.Thread.Sleep(1200);
        }
        public void pregunta(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       " + mensaje);
            Console.ResetColor();
        }
        public void mensajeError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      " + mensaje);
            System.Threading.Thread.Sleep(900);
            Console.ResetColor();
        }
    }
}