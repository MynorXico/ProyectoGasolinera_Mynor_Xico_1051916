using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class Deposito
    {
        Validador objValidador = new Validador();
        Formato objFormato = new Formato();
        MenuSecundario menu1 = new MenuSecundario("", "Si", "No");


        private double _cantCombustible;
        private double _limit;
        private double _costoPorGalon;
        private double _precioPorGalon;
        private double _inventarioMinimo;
        private string _label;

        private double _combustibleConsumido;
        private double _dineroConsumido;
        private double _comprasQuetzales;

        public Deposito()
        {
        }
        public Deposito(double unaCantidad, double unCosto, double unPrecio, string label)
        {
            _cantCombustible = unaCantidad;
            _limit = 78;
            _costoPorGalon = unCosto;
            _precioPorGalon = unPrecio;
            _inventarioMinimo = 5;
            _label = label;

        }

        public double cantCombustible
        {
            get
            {
                return _cantCombustible;
            }
            set
            {
                _cantCombustible = value;
            }
        }
        public double costoPorGalon
        {
            get
            {
                return _costoPorGalon;
            }
            set
            {
                _costoPorGalon = value;
            }
        }
        public double precioPorGalon
        {
            get
            {
                return _precioPorGalon;
            }
            set
            {
                _precioPorGalon = value;
            }
        }
        public double limit
        {
            get
            {
                return _limit;
            }
        }
        public double inventarioMinimo
        {
            get
            {
                return _inventarioMinimo;
            }
            set
            {
                _inventarioMinimo = value;
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

        public double combustibleConsumido
        {
            get
            {
                return _combustibleConsumido;
            }
            set
            {
                _combustibleConsumido = value;
            }
        }
        public double dineroConsumido
        {
            get
            {
                return _dineroConsumido;
            }
            set
            {
                _dineroConsumido = value;
            }
        }
        public double comprasQuetzales
        {
            get
            {
                return _comprasQuetzales;
            }set
            {
                _comprasQuetzales = value;
            }
        }


        public void ingresarCombustible(double cantidad, double costo)
        {
            {
                _costoPorGalon = (_cantCombustible * _costoPorGalon + cantidad * costo) / (_cantCombustible + cantidad);
                _cantCombustible += cantidad;
                _comprasQuetzales += cantidad * costo;
            }            
        }
        public void indicarNuevoPrecio(double unPrecio)
        {
            _precioPorGalon = unPrecio;
        }
        public void venderCombustible(double cantidad)
        {
            if (_cantCombustible < cantidad)
            {
                objFormato.mensajeError("No es posible realizar la venta");
                bool opcionValida = false;
                do
                {
                    objFormato.mensajeError("La cantidad disponible en el depósito de " + label + " es de " + cantCombustible + " Galones (Q " + cantCombustible*precioPorGalon+")");
                    objFormato.pregunta("¿Desea vender esa cantidad??");
                    menu1.EscribirMenuSecundario2ST();
                    string opcion = Console.ReadLine();
                    Console.ResetColor();
                    switch (opcion)
                    {
                        case "1":
                            opcionValida = true;
                            venderCombustible(_cantCombustible);
                            break;
                        case "2":
                            opcionValida = true;
                            break;
                        default:
                            objFormato.mensajeError("Seleccione una opción válida");
                            Console.Clear();
                            break;
                    }
                } while (!opcionValida);
                                
            }
            else
            {
                _cantCombustible -= cantidad;
                _combustibleConsumido += cantidad;
            }
        }

        public bool disponible()
        {
            if (cantCombustible <= 5)
            {
                return false;
            }
            return true;
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
