using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{   
    /*
        Clase utilizada para dar formato a mensaje 
    */
    class Formato
    {
        // Métodos para Menús
        #region Métodos para Menús
        /// <summary>
        /// Formato para menú con seis opciones
        /// </summary>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
        /// <param name="opcion4">Opcion #4</param>
        /// <param name="opcion5">Opcion #5</param>
        /// <param name="opcion6">Opcion #6</param>
        public void menuFormato(string opcion1, string opcion2, string opcion3, string opcion4, string opcion5, string opcion6)
        {   Console.BackgroundColor = ConsoleColor.Black;            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.WriteLine("     4. " + opcion4);
            Console.WriteLine("     5. " + opcion5);
            Console.WriteLine("     6. " + opcion6);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }

        /// <summary>
        /// Formato para menú con cinco opciones
        /// </summary>
        /// <param name="opcion1">Opción #1</param>
        /// <param name="opcion2">Opción #2</param>
        /// <param name="opcion3">Opción #3</param>
        /// <param name="opcion4">Opción #4</param>
        /// <param name="opcion5">Opción #5</param>
        public void menuFormato(string opcion1, string opcion2, string opcion3, string opcion4, string opcion5)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.WriteLine("     4. " + opcion4);
            Console.WriteLine("     5. " + opcion5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }

        /// <summary>
        /// Formato para menú con seis opciones
        /// </summary>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
        /// <param name="opcion4">Opcion #4</param>
        /// <param name="opcion5">Opcion #5</param>
        /// <param name="opcion6">Opcion #6</param>
        /// <param name="opcion7">Opcion #7</param>
        public void menuFormato(string titulo, string opcion1, string opcion2, string opcion3, string opcion4, string opcion5, string opcion6, string opcion7)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.WriteLine("     4. " + opcion4);
            Console.WriteLine("     5. " + opcion5);
            Console.WriteLine("     6. " + opcion6);
            Console.WriteLine("     7. " + opcion7);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }

        /// <summary>
        /// Formato para menú con seis opciones
        /// </summary>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
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
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }

        /// <summary>
        /// Formato para menú con seis opciones
        /// </summary>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
        /// <param name="opcion4">Opcion #4</param>
        public void menuFormato(string opcion1, string opcion2, string opcion3, string opcion4)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.WriteLine("     3. " + opcion3);
            Console.WriteLine("     4. " + opcion4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }

        /// <summary>
        /// Formato para menú con seis opciones
        /// </summary>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        public void menuFormato(string opcion1, string opcion2)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ResetColor();
            Console.WriteLine("Seleccione la opción que desea: ");
            Console.WriteLine("     1. " + opcion1);
            Console.WriteLine("     2. " + opcion2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        #endregion

        // Metodos para mostar mensajes al usuario
        #region Métodos para mostrar mensajes al usuario
        /// <summary>
        /// Formato para escribir contenido
        /// </summary>
        /// <param name="contenido">Contenido a resaltar</param>
        public void escribirContenido(string contenido)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************************************************");
            Console.ResetColor();
            Console.WriteLine(contenido);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************************************************************");
            Console.ResetColor();
        }
        /// <summary>
        ///  Formato para escribir títulos
        /// </summary>
        /// <param name="titulo"></param>
        public void escribirTitulo(string titulo)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("                    " + titulo + "                ");
            Console.ResetColor();
        }
        /// <summary>
        /// Formato para escribir Mensaje de Bienvenida
        /// </summary>
        /// <param name="mensaje"></param>
        public void mensajeBienvenida(string mensaje)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      "+mensaje+"                   ");
            Console.ResetColor();
        }
        /// <summary>
        /// Formato para escribir mensajes de éxito
        /// </summary>
        /// <param name="mensaje"></param>
        public void mensajeExito(string mensaje)
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ResetColor();
            System.Threading.Thread.Sleep(1200);
        }
        /// <summary>
        /// Formtato para escribir preguntas
        /// </summary>
        /// <param name="mensaje"></param>
        public void pregunta(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       " + mensaje);
            Console.ResetColor();
        }
        /// <summary>
        /// Formato para escribir mensajes de error
        /// </summary>
        /// <param name="mensaje"></param>
        public void mensajeError(string mensaje)
        {
            Console.Beep();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("      " + mensaje);
            System.Threading.Thread.Sleep(900);
            Console.ResetColor();
        }
        #endregion
    }
}