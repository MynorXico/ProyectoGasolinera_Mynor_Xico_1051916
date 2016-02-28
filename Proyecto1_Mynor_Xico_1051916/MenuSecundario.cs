using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    public class MenuSecundario
    {
        string _titulo;
        string _opcion1;
        string _opcion2;
        string _opcion3;
        string _opcion4;
        string _opcion5;
        string _opcion6;

        public MenuSecundario(string titulo, string opcion1, string opcion2, string opcion3, string opcion4)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _opcion3 = opcion3;
            _opcion4 = opcion4;
            _titulo = titulo;
        }
        public MenuSecundario(string titulo, string opcion1, string opcion2, string opcion3)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _opcion3 = opcion3;
            _titulo = titulo;
        }
        public MenuSecundario(string titulo, string opcion1, string opcion2)
        {
            _opcion1 = opcion1;
            _opcion2 = opcion2;
            _titulo = titulo;
        }
        Formato objFormato = new Formato();

        public void EscribirMenuSecundario3()
        {
            Console.ResetColor();
            objFormato.mensajeBienvenida(_titulo);
            objFormato.menuFormato(_opcion1, _opcion2, _opcion3);
        }
        public void EscribirMenuSecundario2ST()
        {
            Console.ResetColor();
            objFormato.menuFormato(_opcion1, _opcion2);
        }

        public void EscribirMenuSecundario4()
        {
            Console.ResetColor();
            objFormato.mensajeBienvenida(_titulo);
            objFormato.menuFormato(_opcion1, _opcion2, _opcion3, _opcion4);
        }

    }
}
