using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    public class MenuSecundario
    {
        // Diferente opciones que pueda tener un menú
        string _titulo;
        string _opcion1;
        string _opcion2;
        string _opcion3;
        string _opcion4;
        string _opcion5;
        string _opcion6;
        string _opcion7;

        /// <summary>
        ///  instnaciación de objeto Fomrato
        /// </summary>
        Formato objFormato = new Formato();


        /// <summary>
        /// Constructor de menu con cuatro opciones
        /// </summary>
        /// <param name="titulo">Título del menú</param>
        /// <param name="opcion1">Opción #1</param>
        /// <param name="opcion2">Opción #2</param>
        /// <param name="opcion3">Opción #3</param>
        /// <param name="opcion4">Opción #4</param>
        public MenuSecundario(string titulo, string opcion1, string opcion2, string opcion3, string opcion4)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _opcion3 = opcion3;
            _opcion4 = opcion4;
            _titulo = titulo;
        }

        /// <summary>
        /// Constructor de menu con seis opciones
        /// </summary>
        /// <param name="titulo">Título del menú </param>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
        /// <param name="opcion4">Opcion #4</param>
        /// <param name="opcion5">Opcion #5</param>
        /// <param name="opcion6">Opcion #6</param>
        public MenuSecundario(string titulo, string opcion1, string opcion2, string opcion3, string opcion4, string opcion5, string opcion6)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _opcion3 = opcion3;
            _opcion4 = opcion4;
            _opcion5 = opcion5;
            _opcion6 = opcion6;
            _titulo = titulo;
        }

        /// <summary>
        /// Constructor de menú con siete opciones
        /// </summary>
        /// <param name="titulo">Título del menú </param>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
        /// <param name="opcion4">Opcion #4</param>
        /// <param name="opcion5">Opcion #5</param>
        /// <param name="opcion6">Opcion #6</param>
        /// <param name="opcion7">Opcion #7</param>
        public MenuSecundario(string titulo, string opcion1, string opcion2, string opcion3, string opcion4, string opcion5, string opcion6, string opcion7)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _opcion3 = opcion3;
            _opcion4 = opcion4;
            _opcion5 = opcion5;
            _opcion6 = opcion6;
            _opcion7 = opcion7;
            _titulo = titulo;
        }

        /// <summary>
        /// Constructor de menú con tres opciones
        /// </summary>
        /// <param name="titulo">Título del menú </param>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion #2</param>
        /// <param name="opcion3">Opcion #3</param>
        public MenuSecundario(string titulo, string opcion1, string opcion2, string opcion3)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _opcion3 = opcion3;
            _titulo = titulo;
        }

        /// <summary>
        /// Constructor de menú con dos opciones
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="opcion1">Opcion #1</param>
        /// <param name="opcion2">Opcion "2</param>
        public MenuSecundario(string titulo, string opcion1, string opcion2)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _titulo = titulo;
        }

        /// <summary>
        ///  Método que muestra un menú con tres opciones
        /// </summary>
        public void EscribirMenuSecundario3()
        {
            Console.ResetColor();
            objFormato.mensajeBienvenida(_titulo);
            objFormato.menuFormato(_opcion1, _opcion2, _opcion3);
        }

        /// <summary>
        /// Método que muestra un menú con dos opciones sin título
        /// </summary>
        public void EscribirMenuSecundario2ST()
        {
            Console.ResetColor();
            objFormato.menuFormato(_opcion1, _opcion2);
        }

        /// <summary>
        /// Método que muestra un menú con siete opciones sin título
        /// </summary>
        public void EscribiRmenuSecundario7ST()
        {
            Console.ResetColor();
            objFormato.menuFormato(_titulo, _opcion1, _opcion2, _opcion3, _opcion4, _opcion5, _opcion6, _opcion7);
        }

        /// <summary>
        /// Método que muestra un menú con cuatro opciones sin título
        /// </summary>
        public void EscribirMenuSecundario4()
        {
            Console.ResetColor();
            objFormato.mensajeBienvenida(_titulo);
            objFormato.menuFormato(_opcion1, _opcion2, _opcion3, _opcion4);
        }

    }
}
