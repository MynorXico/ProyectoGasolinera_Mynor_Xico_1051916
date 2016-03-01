using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class Bomba
    {
        // Definición de atributos de la 
        private double _combustibleConsumido;
        private double _dineroConsumido;
        private string _label;


        MenuSecundario menu1 = new MenuSecundario("", "Por Galón", "Por Monto de Dinero");
        MenuSecundario menu2 = new MenuSecundario("", "Diesel", "Regular", "Super");

        // Constructor de la Clase
        public Bomba(string label)
        {
            _label = label;
        }

        Deposito _depositoAUsar;
        Formato objFormato = new Formato();
        Validador objValidador = new Validador();

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


        public void Dispensar(Deposito unDeposito, int tipoDeVenta)
        {
            double dblCantidad = 0;
            bool cantidadValida = false;
            do { 
                Console.WriteLine("Ingrese la cantidad de " + unDeposito.label + " que desea vender");
                string strCantidad = Console.ReadLine();
                Console.ResetColor();
                if (objValidador.esNumeroDouble(strCantidad))
                {
                    dblCantidad = double.Parse(strCantidad);
                    if (objValidador.esPositivo(dblCantidad))
                    {
                        cantidadValida = true;
                    }
                    else
                    {
                        objFormato.mensajeError("Ingresó una cantidad no válida");
                    }
                }
                else
                {
                    objFormato.mensajeError("Ingrese una cantidad válida por favor");
                }Console.Clear();    
            } while (!cantidadValida);
            switch (tipoDeVenta){
                case 1:
                    _combustibleConsumido += dblCantidad;
                    _dineroConsumido += dblCantidad * unDeposito.precioPorGalon;
                    unDeposito.venderCombustible(dblCantidad);
                    break;
                case 2:
                    _combustibleConsumido += dblCantidad / unDeposito.precioPorGalon;
                    _dineroConsumido += dblCantidad;
                    unDeposito.venderCombustible(dblCantidad / unDeposito.precioPorGalon);
                    break;
            }
        }
        public void mostrarVentas()
        {
            objFormato.escribirTitulo(_label);
            Console.WriteLine("Cantidad vendida en Galones: " + Math.Round(_combustibleConsumido, 2));
            Console.WriteLine("Cantidad vendida en Quetzales: " + Math.Round(_dineroConsumido, 2));
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }
        
        
        
    }
}
