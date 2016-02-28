using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class Bomba
    {
        private double _combustibleConsumido;
        private double _dineroConsumido;
        private Deposito _depositoAUsar;
        private string _label;
        // Constructor de la Clase
        public Bomba(string label)
        {
            _label = label;
        }

        public void seleccionarCombustible(Deposito unDeposito)
        {
            if (unDeposito.cantCombustible <= unDeposito.inventarioMinimo)
            {
                _depositoAUsar = unDeposito;
            }
        }

        public string label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }

        public void venderPorQuetzales(double cantidadQuetzales)
        {
            double cantidadGalones = cantidadQuetzales / _depositoAUsar.precioPorGalon;
            if (cantidadGalones < _depositoAUsar.cantCombustible)
            {
                _depositoAUsar.cantCombustible -= cantidadGalones;

                _combustibleConsumido += cantidadGalones;
                _dineroConsumido += cantidadQuetzales;

                _depositoAUsar.combustibleConsumido += cantidadGalones;
                _depositoAUsar.dineroConsumido += cantidadQuetzales;
            }
            else
            {
                string cantidadActual = (_depositoAUsar.cantCombustible * _depositoAUsar.precioPorGalon).ToString();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es posible realizar la venta. La cantidad actual de combustible en quetzales en el depósito de " + _depositoAUsar.label + " es" + cantidadActual);
                Console.ReadLine();
            }
        }
        public void venderPorGalones(double cantidadGalones)
        {
            double cantidadQuetzales = cantidadGalones * _depositoAUsar.precioPorGalon;
            if (cantidadGalones < _depositoAUsar.cantCombustible)
            {
                _depositoAUsar.cantCombustible -= cantidadGalones;

                _combustibleConsumido += cantidadGalones;
                _dineroConsumido += cantidadQuetzales;

                _depositoAUsar.combustibleConsumido += cantidadGalones;
                _depositoAUsar.dineroConsumido += cantidadQuetzales;
            }
            else
            {
                string cantidadActual = _depositoAUsar.cantCombustible.ToString();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es posible realizar la venta. La cantidad actual de combustible en galones en el depósito de " + _depositoAUsar.label + " es" + cantidadActual);
                Console.ReadLine();
            }
        }
        public string MostrarConsumo()
        {
            string a = "El número de galones consumidos de la " + label + " es: " + _combustibleConsumido;
            string b = "La cantidad de quetzales consumidos de la " + label + " es: " + _dineroConsumido;
            return (a + b);
        }

    }
}
