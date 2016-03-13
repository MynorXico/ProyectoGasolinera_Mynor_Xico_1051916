using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class Bomba
    {
        // Definición de atributos de la clase
        #region Atributos de la Clase
        private double _combustibleConsumido;
        private double _dineroConsumido;
        private string _label;
        #endregion

        // Instanciación de menús para el objeto
        #region Instnciación de menús
        MenuSecundario menu1 = new MenuSecundario("", "Por Galón", "Por Monto de Dinero");
        MenuSecundario menu2 = new MenuSecundario("", "Diesel", "Regular", "Super");
        MenuSecundario menu3 = new MenuSecundario("", "Si", "No");
        #endregion

        // Constructor de la Clase
        public Bomba(string label)
        {
            _label = label;
        }

        // Depósito que se utilizará para las ventas
        public Deposito _depositoAUsar;

        //Instnciación de objetos auxiliares
        #region Objetos Auxiliares
        Formato objFormato = new Formato();
        Validador objValidador = new Validador();
        #endregion

        // Propiedad de la clase
        #region Propiedades
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
        #endregion

        // Método utilizados para la venta
        #region Métodos para Venta
        /// <summary>
        /// Método que se utiliza para seleccionar el depósito a utilizar para la venta
        /// </summary>
        /// <param name="unDeposito"></param>
        public void seleccionarCombustible(ref Deposito unDeposito)
        {
            if (unDeposito.cantCombustible <= unDeposito.inventarioMinimo)
            {
                _depositoAUsar = unDeposito;
            }
        }
        /// <summary>
        ///  Método que se utiliza para vender combustible por quetzales
        /// </summary>
        /// <param name="cantidadQuetzales"></param>
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

                objFormato.mensajeExito("Se vendieron " + Math.Round(cantidadGalones, 2) +" galones " + "(Q "+ string.Format("{0:0.00}",((Math.Round(cantidadQuetzales, 2))))+") de gasolina desde la " + this.label);
            }
            else
            {
                string cantidadActual = (_depositoAUsar.cantCombustible * _depositoAUsar.precioPorGalon).ToString();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es posible realizar la venta. La cantidad actual de combustible en quetzales en el depósito de " + _depositoAUsar.label + " es" + cantidadActual);
                Console.ReadLine();
            }
        }   
        /// <summary>
        /// Método que se utiliza para vneder combustible por galones
        /// </summary>
        /// <param name="cantidadGalones"></param>
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
                objFormato.mensajeExito("Se vendieron " + cantidadGalones + " galones " + "(Q " + string.Format("{0:0.00}" ,(Math.Round(cantidadQuetzales))) + ") de gasolina desde la " + this.label);
                
            }
            else
            {
                string cantidadActual = _depositoAUsar.cantCombustible.ToString();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es posible realizar la venta. La cantidad actual de combustible en galones en el depósito de " + _depositoAUsar.label + " es" + cantidadActual);
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Método que se utiliza para mostrar el consumo de la Bomba
        /// </summary>
        /// <returns></returns>
        public string MostrarConsumo()
        {
            string a = "El número de galones consumidos de la " + label + " es: " + _combustibleConsumido;
            string b = "La cantidad de quetzales consumidos de la " + label + " es: " + _dineroConsumido;
            return (a + b);
        }
        /// <summary>
        /// Método que se utiliza para dispensar combustible 
        /// </summary>
        /// <param name="unDeposito">Depósito del cual se obtendrá la gasolina</param>
        /// <param name="tipoDeVenta">Entero que indica el tipo ode venta que se utilizará para realizar la venta</param>
        public void Dispensar(Deposito unDeposito, int tipoDeVenta)
        {
            double dblCantidad = 0;
            bool cantidadValida = false;
            do {
                objFormato.pregunta("╔══════════════════════════════════════════════╗");
                objFormato.pregunta("║Ingrese la cantidad de " + unDeposito.label + " que desea vender");
                objFormato.pregunta("╚══════════════════════════════════════════════╝");
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
                    if (dblCantidad <= unDeposito.cantCombustible)
                    {
                        _combustibleConsumido += unDeposito.cantCombustible;
                        _dineroConsumido += unDeposito.cantCombustible * unDeposito.precioPorGalon;
                        unDeposito.venderCombustible(dblCantidad);
                        objFormato.mensajeExito("Se han vendido " + dblCantidad + " galones (Q +" + string.Format("{0:0.00}", (dblCantidad * unDeposito.precioPorGalon)) + ") de " + unDeposito.label + " desde la" + label);
                    }
                    else {
                        objFormato.mensajeError("No es posible realizar la venta");
                        bool opcionValida1 = false;
                        do
                        {
                            objFormato.mensajeError("La cantidad disponible en el depósito de " + unDeposito.label + " es de " + unDeposito.cantCombustible + " Galones (Q " + string.Format("{0:0.00}",(unDeposito.cantCombustible * unDeposito.precioPorGalon)) + ")");
                            objFormato.pregunta("¿Desea vender esa cantidad??");
                            menu3.EscribirMenuSecundario2ST();
                            string opcion = Console.ReadLine();
                            Console.ResetColor();
                            switch (opcion)
                            {
                                case "1":
                                    opcionValida1 = true;
                                    double anterior = unDeposito.cantCombustible;
                                    _combustibleConsumido += unDeposito.cantCombustible;
                                    _dineroConsumido += unDeposito.cantCombustible * unDeposito.precioPorGalon;
                                    unDeposito.venderCombustible(unDeposito.cantCombustible);
                                    objFormato.mensajeExito("Se han vendido " + anterior + " galones (Q " + string.Format("{0:0.00}",(anterior*unDeposito.precioPorGalon))+") de  " + unDeposito.label + " desde la" + label);
                                    break;
                                case "2":
                                    opcionValida1 = true;
                                    break;
                                default:
                                    objFormato.mensajeError("Seleccione una opción válida");
                                    Console.Clear();
                                    break;
                            }
                        } while (!opcionValida1);
                    }
                    break;
                case 2:
                    if (dblCantidad <= unDeposito.cantCombustible)
                    {
                        _combustibleConsumido += dblCantidad / unDeposito.precioPorGalon;
                        _dineroConsumido += dblCantidad;
                        unDeposito.venderCombustible(dblCantidad / unDeposito.precioPorGalon);
                        objFormato.mensajeExito("Se han vendido " + dblCantidad + " galones (Q " + string.Format("{0:0.00}", (dblCantidad * unDeposito.precioPorGalon)) + ") de  " + unDeposito.label + " desde la" + label);

                    }
                    objFormato.mensajeError("No es posible realizar la venta");
                   
                    bool opcionValida = false;
                    do
                    {
                        objFormato.mensajeError("La cantidad disponible en el depósito de " + unDeposito.label + " es de " + unDeposito.cantCombustible + " Galones (Q " + string.Format("{0:0.00}",(unDeposito.cantCombustible * unDeposito.precioPorGalon)) + ")");
                        objFormato.pregunta("¿Desea vender esa cantidad??");
                        menu3.EscribirMenuSecundario2ST();
                        string opcion = Console.ReadLine();
                        Console.ResetColor();
                        switch (opcion)
                        {
                            case "1":
                                opcionValida = true;
                                double anterior = unDeposito.cantCombustible;
                                unDeposito.venderCombustible(unDeposito.cantCombustible);
                                _combustibleConsumido += unDeposito.cantCombustible / unDeposito.precioPorGalon;
                                _dineroConsumido += unDeposito.cantCombustible;
                                objFormato.mensajeExito("Se han vendido " + anterior + " galones(Q " + string.Format("{0:0.00}", (anterior*unDeposito.precioPorGalon)) + ") de " + unDeposito.label + " desde la " + label);
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
                    break;
            }
        }
        #endregion


        /// <summary>
        /// Método que se utiliz para mostrar las ventas que se realizar on en la bomba
        /// </summary>        
        public void mostrarVentas()
        {
            objFormato.pregunta("╔═══════╗");
            objFormato.pregunta("║" + _label + "║");
            objFormato.pregunta("╚═══════╝");
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║Cantidad vendida en Galones: " + Math.Round(_combustibleConsumido, 2));
            Console.WriteLine("║Cantidad vendida en Quetzales: " + string.Format("{0:0.00}",(Math.Round(_dineroConsumido, 2))));
            Console.WriteLine("╚═════════════════════════════════════════╝");
            System.Threading.Thread.Sleep(600);
        }
        
        
        
    }
}
