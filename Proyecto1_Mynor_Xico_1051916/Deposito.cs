using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class Deposito
    {

        // Instanciación de objetos auxiliares
        #region Objetos Auxiliares 
        Validador objValidador = new Validador();
        Formato objFormato = new Formato();
        #endregion

        // Instanciación de menú para la clase
        MenuSecundario menu1 = new MenuSecundario("", "Si", "No");

        // Propiedades del objeto depósito
        #region Propiedades del objeto
        private double _cantCombustible;
        private double _limite;
        private double _costoPorGalon;
        private double _precioPorGalon;
        private double _inventarioMinimo;
        private string _label;
        private double _combustibleConsumido;
        private double _dineroConsumido;
        private double _comprasQuetzales;
        #endregion

        /// <summary>
        /// Constructor de la clase sin parámetros
        /// </summary>
        public Deposito()
        {
        }

        /// <summary>
        /// Constructor de la clase 
        /// </summary>
        /// <param name="unaCantidad">Cantidad de combustible que tendrá el depósito por defecto</param>
        /// <param name="unCosto">Costo del depósito</param>
        /// <param name="unPrecio">Precio del combustiblew</param>
        /// <param name="label"></param>
        public Deposito(double unaCantidad, double unCosto, double unPrecio, string label)
        {
            _cantCombustible = unaCantidad;
            _limite = 78;
            _costoPorGalon = unCosto;
            _precioPorGalon = unPrecio;
            _inventarioMinimo = 5;
            _label = label;

        }

        // Propiedades del depósito
        #region Propiedades del depósito
        /// <summary>
        /// Cantidad de combustible  en el depósito
        /// </summary>
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
        /// <summary>
        /// Costo del galónde combustible
        /// </summary>
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
        /// <summary>
        /// Precio por galón del depósito
        /// </summary>
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
        /// <summary>
        /// Capacidad mázxima del depósito
        /// </summary>
        public double limit
        {
            get
            {
                return _limite;
            }
        }
        /// <summary>
        /// Cantidadmínima que debe haber en el dépósito paraefectuar unaventa
        /// </summary>
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
        /// <summary>
        /// Nombre del depósito
        /// </summary>
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
        /// <summary>
        /// Combustible consumido en el depósito
        /// </summary>
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
        /// <summary>
        /// Dinero consumido por depósito de combustible
        /// </summary>
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
        /// <summary>
        /// Total de dinero consumido en el depósito
        /// </summary>
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
        #endregion


        //Métodos utilizados para la venta
        #region Métodos para la venta
        /// <summary>
        /// Método para realizar ventas por combustible.
        /// </summary>
        /// <param name="cantidad">Cantidad que se venderá</param>
        public void venderCombustible(double cantidad)
        {
            if (cantidad > _cantCombustible)
            {
            }
            else
            {
                _cantCombustible -= cantidad;
                _combustibleConsumido += cantidad;
            }
        }
        /// <summary>
        /// Método que muestra las ventas efectuadas por depósito
        /// </summary>
        public void mostrarVentas()
        {
            objFormato.pregunta("╔════════╗");
            objFormato.pregunta("║" + _label);
            objFormato.pregunta("╚════════╝");
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║Cantidad vendida en Galones: " + Math.Round(_combustibleConsumido, 2));
            Console.WriteLine("║Cantidad vendida en Quetzales: Q" + string.Format("{0:0.00}",(Math.Round(_dineroConsumido, 2))));
            Console.WriteLine("╚════════════════════════════════════════╝");
            System.Threading.Thread.Sleep(600);
        }
        #endregion

        /// <summary>
        /// Método par ingresar combustible al depósito
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        public void ingresarCombustible(double cantidad, double costo)
        {
            {
                _costoPorGalon = (_cantCombustible * _costoPorGalon + cantidad * costo) / (_cantCombustible + cantidad);
                _cantCombustible += cantidad;
                _comprasQuetzales += cantidad * costo;
            }            
        }

        /// <summary>
        /// Método para fijar nuevo precio de tipo de combustible
        /// </summary>
        /// <param name="unPrecio">Precio nuevo que tendrá el combustible</param>
        public void indicarNuevoPrecio(double unPrecio)
        {
            _precioPorGalon = unPrecio;
        }        

        /// <summary>
        /// Indica si el combustible se encuentra disponible para la venta
        /// </summary>
        /// <returns> Devuelve verdadero o falso</returns>
        public bool disponible()
        {
            if (cantCombustible <= 5)
            {
                return false;
            }
            return true;
        }        
    }
}
