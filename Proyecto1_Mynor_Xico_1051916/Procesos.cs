﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto1_Mynor_Xico_1051916
{
    public class Procesos
    {
        // Definición de atributos de clases Procesos
        #region Atributos
        double _combustibleConsumido;
        double _dineroConsumido;
        double _comprasQuetzales;
        double _ganancia;
        #endregion

        // Instanciación de los 7 objetos Bomba que operarán en la gasolinera
        #region Instanciación de Bombas
        static Bomba objBomba1 = new Bomba("Bomba 1");
        static Bomba objBomba2 = new Bomba("Bomba 2");
        static Bomba objBomba3 = new Bomba("Bomba 3");
        static Bomba objBomba4 = new Bomba("Bomba 4");
        static Bomba objBomba5 = new Bomba("Bomba 5");
        static Bomba objBomba6 = new Bomba("Bomba 6");
        static Bomba objBomba7 = new Bomba("Bomba 7");
        #endregion

        // Instanciación de los 3 objetos Depósito que operarán en la gasolinera
        #region Instanciación de Depósitos
        static Deposito objDepositoDiesel = new Deposito(50, 11, 13.5, "Diesel");
        static Deposito objDepositoRegular = new Deposito(30, 12.5, 17, "Regular");
        static Deposito objDepositoSuper = new Deposito(30, 14.5, 19, "Super");
        #endregion

        // Instanciación de objetos auxiliares
        #region Instanciación de objetos auxiliares
        Validador objValidador = new Validador();
        Formato objFormato = new Formato();
        #endregion

        // Instaciación de Objetos para Ventas Automáticas
        #region Instanciación de Objetos para Ventas Automáticas
        Gasolinera gasolineraVentas = new Gasolinera(objDepositoDiesel, objDepositoRegular, objDepositoSuper, objBomba1, objBomba2, objBomba3, objBomba4, objBomba5, objBomba6, objBomba7);
        ManejoDatos objManejoDatos = new ManejoDatos();
        #endregion

        // Instanciación de menus que se utilizarán durante la ejecución del programa
        #region Instanciación de submenús del programa
        MenuSecundario objMenu1 = new MenuSecundario("", "Si", "No");
        MenuSecundario objMenu2 = new MenuSecundario("", "Manual", "Automática");
        MenuSecundario objMenu3 = new MenuSecundario("", "Bomba 1", "Bomba 2", "Bomba 3", "Bomba 4", "Bomba 5", "Bomba 6", "Bomba 7");
        MenuSecundario objMenu4 = new MenuSecundario("Tipos de Combustible", "Diesel", "Regular", "Super");
        MenuSecundario objMenu5 = new MenuSecundario("", "Por Gálón", "Por Quetzales");
        #endregion
        
        // Cantidad de Combustible de Cada Depósito
        #region Cantidad de Combustible de Cada Depósito
        /// <summary>
        /// Propiedades para asignar y obtener la cantidada de diesel actual
        /// </summary>
        public double cantDiesel
        {
            get
            {
                return objDepositoDiesel.cantCombustible;
            }
        }
        /// <summary>
        /// Propiedades para asignar y obtener la cantidad de Regular actual
        /// </summary>
        public double cantRegular
        {
            get
            {
                return objDepositoRegular.cantCombustible;
            }
        }
        /// <summary>
        /// Propiedades para asignar y obtener la cantidad de Super actual
        /// </summary>
        public double cantSuper
        {
            get
            {
                return objDepositoSuper.cantCombustible;
            }
        }
        /// <summary>
        /// Propiedad para obtener el límite de los tres combustibles
        /// </summary>
        #endregion

        // Variables con información de la gasolinera
        #region Variables con información de la gasolinera
        public double limite
        {
            get
            {
                return objDepositoDiesel.limit;
            }
        }
        /// <summary>
        /// Variable que almacena la cantidad de ventas en Galones
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
        /// Variable que almacena la cantidad de ventas en Quetzales
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
        #endregion

        // Métodos para mostrar información
        #region Métodos para mostrar información
        /// <summary>
        /// Método que muestra al usuario la cantidad de combustible en cada uno de los tres depósitos
        /// </summary>
        public void MostrarCombustible()
        {
            objFormato.pregunta("╔═════════════════════════════════════╗");
            objFormato.pregunta("║Cantidad de Gasolina en los Depósitos║");
            objFormato.pregunta("╚═════════════════════════════════════╝");
            string strDiesel = "║  La cantidad de gasolina en el depósito de Diesel es:  " + Math.Round(objDepositoDiesel.cantCombustible, 2) + "/" + objDepositoDiesel.limit +". Espacio libre: " + string.Format("{0:0.00}", (objDepositoDiesel.limit-objDepositoDiesel.cantCombustible));
            string strRegular = "\n║  La cantidad de gasolina en el depósito de Regular es: " + Math.Round(objDepositoRegular.cantCombustible, 2) + "/" + objDepositoDiesel.limit + ". Espacio libre: " + string.Format("{0:0.00}", (objDepositoRegular.limit - objDepositoRegular.cantCombustible));
            string strSuper = "\n║  La cantidad de gasolina en el depósito de Super es:   " + Math.Round(objDepositoSuper.cantCombustible, 2) + "/" + objDepositoDiesel.limit + ". Espacio libre: " + string.Format("{0:0.00}", (objDepositoSuper.limit - objDepositoSuper.cantCombustible));

            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }
        /// <summary>
        /// Método que muestra al usuario la cantidad de combustible disponible para la venta
        /// </summary>
        public void MostrarCombustibleVenta()
        {
            string strDiesel = null;
            string strRegular = null;
            string strSuper = null;
            // Muestra el depósito únicamente si hay combustible disponible para la venta
            objFormato.pregunta("Cantidad de Gasolina en los Depósitos");
            if (objDepositoDiesel.disponible())
            {
                strDiesel = "  La cantidad de gasolina en el depósito de Diesel es:  " + Math.Round(objDepositoDiesel.cantCombustible, 2);
            }
            if (objDepositoRegular.disponible())
            {
                strRegular = "\n  La cantidad de gasolina en el depósito de Regular es: " + Math.Round(objDepositoRegular.cantCombustible, 2);
            }
            if (objDepositoSuper.disponible())
                strSuper = "\n  La cantidad de gasolina en el depósito de Super es:   " + Math.Round(objDepositoSuper.cantCombustible, 2);
            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }
        /// <summary>
        /// Método que muestra al usuario los precios de cada tipo de combustible por Galón.
        /// </summary>
        public void MostrarPrecios()
        {
            objFormato.pregunta("╔════════════════════════════════╗");
            objFormato.pregunta("║Precios por Galón de Combustible║");
            objFormato.pregunta("╚════════════════════════════════╝");
            string strDiesel = "║  El precio por galón del Diesel es:    Q." + string.Format("{0:0.00}", (Math.Round(objDepositoDiesel.precioPorGalon, 2)));
            string strRegular = "\n║  El precio por galón de Regular es:    Q." + string.Format("{0:0.00}", (Math.Round(objDepositoRegular.precioPorGalon, 2)));
            string strSuper = "\n║  El precio por galón de Súper es:      Q." + string.Format("{0:0.00}", (Math.Round(objDepositoSuper.precioPorGalon, 2)));

            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }
        /// <summary>
        /// Método que muestra ventas
        /// </summary>
        public void mostrarVentas()
        {
            calcularVentas(ref _combustibleConsumido, ref _dineroConsumido);
            objFormato.pregunta("╔══════════════════════════╗");
            objFormato.pregunta("║Ventas de la Gasolinera   ║");
            objFormato.pregunta("╚══════════════════════════╝");
            Console.WriteLine("╔═════════════════════════════════════════════════╗");
            Console.WriteLine("║Cantidad vendida en Galones:   " + Math.Round(_combustibleConsumido, 2));
            Console.WriteLine("║Cantidad vendida en Quetzales:  Q" + string.Format("{0:0.00}",( Math.Round(_dineroConsumido, 2))));
            Console.WriteLine("╚═════════════════════════════════════════════════╝");
            System.Threading.Thread.Sleep(500);
        }
        /// <summary>
        /// Método que muestra la información de las ventas realizadas en la gasolinera
        /// </summary>
        public void mostrarInformacionVentas()
        {
            // Muestra las ventas por Bomba
            Console.Clear();
            objFormato.escribirTitulo("Información de las Ventas Realizadas por Bomba");
            objBomba1.mostrarVentas();
            objBomba2.mostrarVentas();
            objBomba3.mostrarVentas();
            objBomba4.mostrarVentas();
            objBomba5.mostrarVentas();
            objBomba6.mostrarVentas();
            objBomba7.mostrarVentas();
            Console.WriteLine("Presione una tecla para pasar a las ventas realizadas por depósito");
            Console.ReadKey();
            // Muestra las ventas por Depósito
            Console.Clear();
            objFormato.escribirTitulo("Información de las ventas Realizadas por Depósito");
            objDepositoDiesel.mostrarVentas();
            objDepositoRegular.mostrarVentas();
            objDepositoSuper.mostrarVentas();
            Console.WriteLine("Presione una tecla para pasar a las ventas realizadas en la gasolinera");
            Console.ReadKey();
            // Muestra las ventas de la gasolinera
            Console.Clear();
            mostrarVentas();
            mostarComprasQ();
            mostrarGanancia();
        }
        /// <summary>
        /// Método que muestra la ganancia en la gasolinera
        /// </summary>
        public void mostrarGanancia()
        {
            calcularGanancias(ref _ganancia);
            objFormato.pregunta("╔══════════════════════════╗");
            objFormato.pregunta("║Ganancias en la Gasolinera║");
            objFormato.pregunta("╚══════════════════════════╝");
            if (_ganancia >= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║La ganancia ha sido de:  Q " + string.Format("{0:0.00}",(_ganancia)) );
                Console.WriteLine("╚══════════════════════════════════════════╝");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                objFormato.mensajeError("╔═════════════════════════════════════════════════════════════════╗");
                objFormato.mensajeError("No han habido ganancias, la pérdida ha sido de " + string.Format("{0:0.00}",(-_ganancia)));
                objFormato.mensajeError("╚═════════════════════════════════════════════════════════════════╝");
            }
            Console.ResetColor();
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }
        /// <summary>
        /// Método que muestra las compras de la gasolinera
        /// </summary>
        public void mostarComprasQ()
        {
            calcularComprasQ(ref _comprasQuetzales);
            objFormato.pregunta("╔═════════════════════════╗");
            objFormato.pregunta("║Compras de la Gasolinera ║");
            objFormato.pregunta("╚═════════════════════════╝");
            Console.WriteLine("╔═══════════════════════════════════════════════════╗");
            Console.WriteLine("║Cantidad comprada en Quetzales: " + string.Format("{0:0.00}",(Math.Round(_comprasQuetzales, 2))));
            Console.WriteLine("╚═══════════════════════════════════════════════════╝");
            System.Threading.Thread.Sleep(500);
        }
        #endregion
        
        // Métodos para cambiar información de los depósitos de combustible
        #region Métodos para cambiar información de los depósitos de combustible
        /// <summary>
        /// Método para agregar combustible
        /// </summary>
        /// <param name="deposito">Depósito al que se agregará combustible</param>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        internal void agregarCombustible(Deposito deposito, double cantidad, double costo)
        {
            if ((deposito.cantCombustible + cantidad) <= deposito.limit)
            {
                deposito.ingresarCombustible(cantidad, costo);
                objFormato.mensajeExito("Se agregaron correctamente " + cantidad + " galones de combustible con un costo de Q" + string.Format("{0:0.00}", costo));
                
                System.Threading.Thread.Sleep(1500);
            }
            else
            {
                objFormato.mensajeError("Operación inválida. La cantidad ingresada supera la capacidad del depósito");
                System.Threading.Thread.Sleep(1200);
            }
        }        
        /// <summary>
        /// Método para fijar el precio de un depósito de combustible
        /// </summary>
        /// <param name="deposito">Depósito al que se fijará combustible</param>
        /// <param name="precio">Precio nuevo del combustible</param>
        internal void fijarPrecioCombustible(Deposito deposito, double precio)
        {
            if (precio > deposito.costoPorGalon)
            {
                deposito.precioPorGalon = precio;
            }
            else
            {
                objFormato.mensajeError("El precio por galón indicado generará pérdidas a la gasolinera");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Método que permite al usuario definir el precio de cualquier tipo de Combustible
        /// </summary>
        /// <param name="unDeposito">TIpo de combustible cuyo precio se desea cambiar</param>
        internal void definirPrecio(Deposito unDeposito)
        {
            bool opcionValida = true;
            do
            {
                objFormato.escribirTitulo("   Definir precios por Combustible    ");
                MostrarPrecios();
                double precioNuevo = 0;
                bool precioValido = false;
                // Pregunta al usuario si desea ingresar nuevo precio para unDeposito
                objFormato.pregunta("╔══════════════════════════════════════════╗");
                objFormato.pregunta("║¿Desea Ingresar Nuevo Precio para " + unDeposito.label + "?");
                objFormato.pregunta("╚══════════════════════════════════════════╝");
                objMenu1.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            objFormato.escribirTitulo("   Definir precios por Combustible    ");
                            objFormato.escribirContenido("  El costo por galón actual del " + unDeposito.label+" es:    Q." + string.Format("{0:0.00}", (Math.Round(unDeposito.costoPorGalon, 2))));
                            objFormato.escribirContenido("  El precio por galón actual del " + unDeposito.label+" es:    Q." + string.Format("{0:0.00}", (Math.Round(unDeposito.precioPorGalon, 2))));
                            objFormato.pregunta("╔════════════════════════════════════════════╗");
                            objFormato.pregunta("║Ingrese el nuevo precio de " + unDeposito.label + " que desea");
                            objFormato.pregunta("╚════════════════════════════════════════════╝");
                            string strCantidad = Console.ReadLine();
                            // El usuario ingresa el nuevo precio para unDeposito
                            if (objValidador.esNumeroDouble(strCantidad))
                            {
                                precioNuevo = double.Parse(strCantidad);
                                precioValido = true;
                                if (objValidador.esPositivo(precioNuevo))
                                {
                                    if (precioNuevo > unDeposito.costoPorGalon)
                                    {
                                        // Si el precio Nuevo es mayor al precio por actual, se cambia el precio
                                        unDeposito.indicarNuevoPrecio(precioNuevo);
                                        objFormato.mensajeExito("Se ha fijado un nuevo precio para " + unDeposito.label + ".");
                                        objFormato.mensajeExito("El nuevo precio de " + unDeposito.label + " es de: Q" + string.Format("{0:0.00}", precioNuevo));
                                    }
                                    else
                                    {
                                        // Si el precio nuevo es menor al precio actual, se notifica que se generarán pérdidas
                                        objFormato.mensajeError("El número ingresado genera pérdidas");
                                        objFormato.mensajeError("La operación finaliza");
                                    }
                                }
                                else
                                {
                                    // Si el usuario no selecciona un número positivo, se cancela la operación
                                    objFormato.mensajeError("Ingresó un valor inválido");
                                    objFormato.mensajeError("La operación finaliza");
                                }
                            }
                        } while (!precioValido);
                        break;
                    case "2":
                        // Si el usuario selecciona 2, no desea fijar nuevo precio para el depósito de combustible
                        opcionValida = true;
                        break;
                    default:
                        // Solicita la usuario una opción válida en caso de que no la haya ingresado
                        Console.ResetColor();
                        opcionValida = false;
                        objFormato.mensajeError(" ***ERROR*** Opción no válida");
                        Console.Clear();
                        break;
                }

            } while (!opcionValida);
            // Restablece color y datos en consola
            Console.ResetColor();
            Console.Clear();
        }
        /// <summary>
        /// Solicita combustible diesel
        /// </summary>
        internal void solicitarCombustibleDeposito(Deposito unDeposito)
        {
            double dblCosto = 0;
            double dblCantidad = 0;
            bool costoValido = false;
            bool cantidadValida = false;
            bool continuar = true;

            do
            {
                MostrarCombustible();
                objFormato.pregunta("¿Desea Ingresar " + unDeposito.label + "?");
                objMenu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                // Comprueba que la opción ingresada por el usuario sea válida, de lo contrario repite la acción
                switch (opcion)
                {
                    // Si el usuario escribe 1, desea ingresar combustible a los depósitos
                    case "1":
                        bool cantidadPositiva = true;
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            objFormato.escribirTitulo("           Ingreso de " + unDeposito.label+"           ");
                            objFormato.escribirContenido("  La cantidad de gasolina en el depósito de " +unDeposito.label + " es:  " + Math.Round(unDeposito.cantCombustible, 2) + "/" + unDeposito.limit + ". Espacio libre: " + string.Format("{0:0.00}", (unDeposito.limit - unDeposito.cantCombustible)));
                            objFormato.pregunta("╔═══════════════════════════════════════════════════════════╗");
                            objFormato.pregunta("║Ingrese la cantidad de " + unDeposito.label + " en galones que desea ingresar");
                            objFormato.pregunta("╚═══════════════════════════════════════════════════════════╝");
                            string strCantidad = Console.ReadLine();
                            // Valida que la cantidad de galones ingresada sea un número real
                            if (objValidador.esNumeroDouble(strCantidad))
                            {
                                dblCantidad = double.Parse(strCantidad);
                                cantidadValida = true;
                            }
                        } while (!cantidadValida);
                        cantidadPositiva = dblCantidad >= 0;
                        if (!cantidadPositiva)
                        {
                            objFormato.mensajeError("Ingresó valores inválidos");
                            objFormato.mensajeError("La operación finaliza");
                        }
                        else {
                            do
                            {
                                Console.ResetColor();
                                Console.Clear();
                                objFormato.escribirTitulo("Ingreso de " + unDeposito.label);
                                objFormato.escribirContenido("  La cantidad de gasolina en el depósito de " + unDeposito.label + " es:  " + Math.Round(unDeposito.cantCombustible, 2) + "/" + unDeposito.limit + ". Espacio libre: " + string.Format("{0:0.00}", (Math.Round(unDeposito.limit - unDeposito.cantCombustible))));
                                objFormato.pregunta("╔══════════════════════════════════════════════════════╗");
                                objFormato.pregunta("║Ingrese el costo por galón del combustible de " + unDeposito.label);
                                objFormato.pregunta("╚══════════════════════════════════════════════════════╝");
                                string strCosto = Console.ReadLine();
                                // Valida que la cantidad ingresada de quetzales sea un número real
                                if (objValidador.esNumeroDouble(strCosto))
                                {
                                    dblCosto = double.Parse(strCosto);
                                    costoValido = true;
                                    if (objValidador.esPositivo(dblCosto) && objValidador.esPositivo(dblCantidad))
                                    {
                                        agregarCombustible(unDeposito, dblCantidad, dblCosto);
                                    }
                                    else
                                    {
                                        objFormato.mensajeError("Ingresó valores inválidos");
                                        objFormato.mensajeError("La operación finaliza");
                                    }
                                }
                                break;
                            } while (!costoValido);
                        }
                        continuar = false;
                        break;
                    case "2":
                        // Si el usuario escribe 2, no desea agregar combustible a los galones y finaliza el método
                        continuar = false;
                        break;
                    default:
                        // Muestra mensaje de error en caso de haber ingresado una opción no válida
                        objFormato.mensajeError(" ***ERROR*** Opción no válida");
                        Console.ResetColor();
                        Console.Clear();
                        break;
                }
            } while (continuar);
            // Limpia consola al finalizar el método
            Console.Clear();
        }
        #endregion

        // Métodos utilizados para la venta
        #region Métodos utilizados para la venta
        /// <summary>
        /// Método que solicita al usuario el tipo de venta que se realizará
        /// </summary>
        public void definirTipoDeVenta()
        {
            bool opcionValida = false;
            do
            {
                objFormato.mensajeBienvenida("Proceso de Ventas de Combustible");
                objFormato.pregunta("¿Qué método de venta desea utilizar?");
                objMenu2.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                Console.ResetColor();
                switch (opcion)
                {
                    case "1":
                        // Si el usuario selecciona 1, se hará venta manual y se indicará el número de venta y se pide seleccionar la bomba
                        int ventas = 1;
                        opcionValida = true;
                        for (int i = 4; i > 0; i--)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            VentaSeleccionarBomba();
                            ventas++;
                        }
                        bool continuarVentas = true;

                        // Se permite un máximo de 8 ventas
                        while (ventas <= 8 && continuarVentas)
                        {
                            bool opcionValida1 = false;
                            do
                            {
                                if ((objDepositoDiesel.disponible()) && (objDepositoRegular.disponible()) && (objDepositoSuper.disponible()))
                                {
                                    Console.ResetColor();
                                    // A partir de la cuara venta, se pregunta al operador si desea seguir vendiendo o ya no
                                    objFormato.pregunta("¿Desea continuar vendiendo?");
                                    objMenu1.EscribirMenuSecundario2ST();
                                    string opcion1 = Console.ReadLine();
                                    switch (opcion1)
                                    {
                                        case "1":
                                            // Si desea seguir lo haciendo, se selecciona nuevamente bomba
                                            opcionValida1 = true;
                                            VentaSeleccionarBomba();
                                            ventas++;
                                            break;
                                        case "2":
                                            // Si el usuario ya no desea vender, se cancela la operación
                                            opcionValida1 = true;
                                            continuarVentas = false;
                                            ventas++;
                                            break;
                                        default:
                                            // Si el usuario no selecciona una opción válida, le solicita ingresarlo nuevamente
                                            objFormato.mensajeError(" ***ERROR*** Opción no válida");
                                            break;
                                    }
                                }
                                else
                                {
                                    objFormato.mensajeError("Ya no queda combustible en ningún depósito");
                                    continuarVentas = false;
                                }
                                if(!(objDepositoDiesel.disponible() || objDepositoRegular.disponible() || objDepositoSuper.disponible()))
                                {
                                    continuarVentas = false;
                                }
                            } while (!opcionValida1 && continuarVentas);
                        }
                        break;
                    case "2":
                        // Si el usuario selecciona la opción 2, se realizará una venta automática con un archivo de texto
                        opcionValida = true;
                        ventaAutomatica();
                        break;
                    default:
                        // Si el usuario no selecciona la opción 1 o 2, se mostrará un mensaje de error y procederá a solicitar nuevamente el resultado
                        objFormato.mensajeError(" ***ERROR*** Opción no válida");
                        Console.Clear();
                        break;
                }
            } while (!opcionValida);
        }
        /// <summary>
        /// Método que permite realizar la venta de Gasolina
        /// </summary>
        internal void venderGasolina()
        {
            bool opcionValida = false;
            do
            {
                // Permite al usuario seleccionar si desea ingresar al proces de ventas
                objFormato.pregunta("╔═══════════════════════════════════╗");
                objFormato.pregunta("║¿Desea entrar al proceso de ventas?║");
                objFormato.pregunta("╚═══════════════════════════════════╝");
                objMenu1.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        // Si selecciona 1, se define el tipo de venta que se realizará
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        definirTipoDeVenta();
                        break;
                    case "2":
                        // Si selecciona 2, se procederá a realizar la venta automática
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    default:
                        Console.ResetColor();
                        objFormato.mensajeError("  ***ERROR*** Opción no válida");
                        break;
                }
                // Limpia la consola
                Console.ResetColor();
                Console.Clear();
            } while (!opcionValida);
        }
        /// <summary>
        /// Método que permite seleccionar la bomba que se utilizará para la venta
        /// </summary>
        public void VentaSeleccionarBomba()
        {
            bool opcionValida = false;
            do
            {
                Console.ResetColor();
                Console.Clear();
                opcionValida = false;
                MostrarCombustible();
                MostrarPrecios();
                objFormato.pregunta("╔══════════════════════════╗");
                objFormato.pregunta("║¿Qué bomba desea utilizar?║");
                objFormato.pregunta("╚══════════════════════════╝");
                objMenu3.EscribiRmenuSecundario7ST();
                string opcion = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                Deposito depositoAUsar = new Deposito();
                int tipoDeVenta;
                switch (opcion)
                {

                    case "1":
                    #region Venta con Bomba 1
                        opcionValida = true;
                        objFormato.escribirTitulo("Venta Manual de Combustible");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba1.combustibleConsumido), 2);
                        Console.WriteLine("   ║Total consumido de esta bomba en quetzales: Q" + string.Format("{0:0.00}", (objBomba1.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba1.Dispensar(depositoAUsar, tipoDeVenta);
                        Console.ReadLine();
                        break;
                    #endregion
                    case "2":
                    #region Venta con Bomba 2
                        opcionValida = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba2.combustibleConsumido, 2));
                        Console.WriteLine("   ║Quetzales Consumidos");
                        Console.WriteLine("   ║Total en quetzales consumidos de esta bomba: Q" + string.Format("{0:0.00}", (objBomba2.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba2.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    #endregion
                    case "3":
                    #region Venta con Bomba 3
                        opcionValida = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba3.combustibleConsumido, 2));
                        Console.WriteLine("   ║Quetzales Consumidos");
                        Console.WriteLine("   ║Total en quetzales consumidos de esta bomba: Q" + string.Format("{0:0.00}", (objBomba3.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba3.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    #endregion
                    case "4":
                    #region Venta con Bomba 4
                        opcionValida = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba4.combustibleConsumido, 2));
                        Console.WriteLine("   ║Quetzales Consumidos");
                        Console.WriteLine("   ║Total en quetzales consumidos de esta bomba: Q" + string.Format("{0:0.00}", (objBomba4.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba4.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                        #endregion
                    case "5":
                    #region Venta con Bomba 5
                        opcionValida = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba5.combustibleConsumido, 2));
                        Console.WriteLine("   ║Total en quetzales consumidos de esta bomba: Q" + string.Format("{0:0.00}", (objBomba5.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba5.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    #endregion
                    case "6":
                    #region Venta con Bomba 6
                        opcionValida = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba6.combustibleConsumido, 2));
                        Console.WriteLine("   ║Total en quetzales consumidos de esta bomba: Q" + string.Format("{0:0.00}", (objBomba6.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba6.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    #endregion
                    case "7":
                    #region Venta con Bomba 7
                        opcionValida = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("   ╔══════════════════════════════════════════════════════╗");
                        Console.WriteLine("   ║Total en galones consumidos de esta bomba: " + Math.Round(objBomba7.combustibleConsumido, 2));
                        Console.WriteLine("   ║Quetzales Consumidos");
                        Console.WriteLine("   ║Total en quetzales consumidos de esta bomba: Q" + string.Format("{0:0.00}", (objBomba7.dineroConsumido)));
                        Console.WriteLine("   ╚══════════════════════════════════════════════════════╝");
                        Console.ReadKey();
                        Console.Clear();
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba7.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    #endregion
                    default:
                        objFormato.mensajeError("  ***ERROR*** Opción no válida");
                        break;
                }
            } while (!opcionValida);
        }


        /// <summary>
        ///  Método que se utiliza para solicitar el tipo de combustible que se utilizará en la venta
        /// </summary>
        /// <returns></returns>
        internal Deposito solicitarTipoCombustibleVenta()
        {
            bool opcionValida = false;
            Deposito depositoSeleccionado = new Deposito();
            do
            {   
                MostrarCombustibleVenta();
                objFormato.pregunta("╔══════════════════════════════════════╗");
                objFormato.pregunta("║¿Qué tipo de combustible desea vender?║");
                objFormato.pregunta("╚══════════════════════════════════════╝");
                objMenu4.EscribirMenuSecundario3();
                string opcion = Console.ReadLine();
                Console.ResetColor();
                switch (opcion)
                {
                    case "1":
                        // Se utilizará el depósito de diesel
                        if (objDepositoDiesel.cantCombustible > 5)
                        {
                            depositoSeleccionado = objDepositoDiesel;
                            opcionValida = true;
                        }
                        else
                        {
                            objFormato.mensajeError("No puede seleccionar el depósito Diesel");
                            objFormato.mensajeError("El depósito alcanzó su inventario mínimo");
                        }
                        break;
                    case "2":
                        // Se utilizará el depósito de regular
                        if (objDepositoRegular.cantCombustible > 5)
                        {
                            depositoSeleccionado = objDepositoRegular;
                            opcionValida = true;
                        }
                        else
                        {
                            objFormato.mensajeError("No puede seleccionar el depósito Regular");
                            objFormato.mensajeError("El depósito alcanzó su inventario mínimo");
                        }
                        break;
                    case "3":
                        // Se utilizará el depósito de súper
                        if (objDepositoSuper.cantCombustible > 5)
                        {
                            depositoSeleccionado = objDepositoSuper;
                            opcionValida = true;
                        }
                        else
                        {
                            objFormato.mensajeError("No puede seleccionar el depósito Super");
                            objFormato.mensajeError("El depósito alcanzó su inventario mínimo");
                        }
                        break;
                    default:
                        // Si no seleccionan una opción válida, se borra la consola y solicita nuevamente
                        objFormato.mensajeError("  ***ERROR*** Opción no válida");
                        depositoSeleccionado = objDepositoDiesel;
                        break;
                }
                Console.Clear();

            } while (!opcionValida);
            return depositoSeleccionado;
        }
        /// <summary>
        /// Función que devuelve un entero que simboliza el tipo de venta que seleccionará el usuario
        /// </summary>
        /// <returns></returns>
        private int TipoDeVenta()
        {
            bool opcionValida = false;
            int tipoVenta = 0;
            do
            {
                Console.ResetColor();
                Console.Clear();
                objFormato.pregunta("¿Qué tipo de venta desea realizar?");
                objMenu5.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        // 1 indica por galón
                        opcionValida = true;
                        tipoVenta = 1;
                        break;
                    case "2":
                        // 2 indica por quetzales
                        opcionValida = true;
                        tipoVenta = 2;
                        break;
                    default:
                        objFormato.mensajeError(" ***ERROR*** Opción no válida");
                        break;
                }
            } while (!opcionValida);
            return tipoVenta;
        }
        /// <summary>
        /// Método que se utiliza para la venta Automática
        /// </summary>
        private void ventaAutomatica()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("> Por favor ingrese la dirección y nombre del archivo para realizar la venta:\n ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            try {
                objManejoDatos.CargaryEjecutarDatosArchivo(@"" + Console.ReadLine(), gasolineraVentas);
                Console.ResetColor();
            }
            catch
            {
                objFormato.mensajeError("Ocurrió un error al abrir el archivo.");
                objFormato.mensajeError("Por verifique que la dirección sea la indicada y que se encuentre escrita en el formato adecuado.");
                objFormato.mensajeError("Si el error persiste verifique que otra aplicación no tenga abierto el archivo.");
                System.Threading.Thread.Sleep(2800);
            }
        }
        /// <summary>
        /// Método utilizado para calcular las ventas de la gasolinera
        /// </summary>
        /// <param name="combustible"></param>
        /// <param name="dinero"></param>
        private void calcularVentas(ref double combustible, ref double dinero)
        {
            combustible = objDepositoDiesel.combustibleConsumido + objDepositoRegular.combustibleConsumido + objDepositoSuper.combustibleConsumido;
            dinero = objDepositoDiesel.combustibleConsumido * objDepositoDiesel.precioPorGalon + objDepositoRegular.combustibleConsumido * objDepositoRegular.precioPorGalon + objDepositoSuper.combustibleConsumido * objDepositoSuper.precioPorGalon;
        }
        #endregion

        // Métodos para el ingreso de combustible
        #region Métodos para el ingreso de combustible
        /// <summary>
        ///  Método que permite al usuario decidir si deseea ingresar diesel, regular o super
        /// </summary>
        public void solicitarCombustible()
        {
            bool opcionValida = false;
            do
            {
                Console.Clear();
                //Pregunta al usuario si desea ingresar combustible a los depósitos
                objFormato.escribirTitulo("  Ingreso de Gasolina a los depósitos  ");
                MostrarCombustible();
                objFormato.pregunta("╔════════════════════════════════════════════╗");
                objFormato.pregunta("║¿Desea ingresar combustible a los depósitos?║");
                objFormato.pregunta("╚════════════════════════════════════════════╝");
                objMenu1.EscribirMenuSecundario2ST();
                string strOpcion = Console.ReadLine();
                switch (strOpcion)
                {
                    case "1":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        solicitarCombustibleDeposito(objDepositoDiesel);
                        solicitarCombustibleDeposito(objDepositoRegular);
                        solicitarCombustibleDeposito(objDepositoSuper);
                        break;
                    case "2":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    default:
                        Console.ResetColor();
                        objFormato.mensajeError(" ***ERROR*** Opción no válida");
                        Console.Clear();
                        break;
                }
            } while (!opcionValida);
        }  
        /// <summary>
        ///  Método que precmite definir el precio de los tres depósitos de combustible
        /// </summary>
        public void definirPrecios()
        {
            bool opcionValida = false;
            do {
                // Preunta al usuario si desea cambiar el precio de algun depósito
                objFormato.escribirTitulo("Definir Precios de gasolina por depósitos");
                MostrarPrecios();
                objFormato.pregunta("¿Desea cambiar el precio por depósitos?");
                objMenu1.EscribirMenuSecundario2ST();
                string strOpcion = Console.ReadLine();
                switch (strOpcion) {
                    // En caso seleccione 1, se solicitará el nuevo precio para cada uno de los tres depósitos de combustible
                    case "1":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        definirPrecio(objDepositoDiesel);
                        definirPrecio(objDepositoRegular);
                        definirPrecio(objDepositoSuper);
                        MostrarPrecios();
                        Console.ReadLine();
                        break;
                    // En caso seleccione 2, finaliza el programa
                    case "2":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    default:
                        // Si no selecciona 1 o 2, se solicita de nuevo una opción
                        Console.ResetColor();
                        objFormato.mensajeError(" ***ERROR*** Opción no válida");
                        Console.Clear();
                        break;
                }
            } while (!opcionValida);
        }
        #endregion
        // Métodos para el análsis financiero de la gasolinera
        #region Métodos para el análisis financiero de la gasolinera
        /// <summary>
        /// Calcula las Compras en Quetzales de la Gasolinera
        /// </summary>
        /// <param name="comprasQuetzales"></param>
        public void calcularComprasQ(ref double comprasQuetzales)
        {
            comprasQuetzales = objDepositoDiesel.comprasQuetzales + objDepositoRegular.comprasQuetzales + objDepositoSuper.comprasQuetzales;
        }        
        /// <summary>
        /// Método que calcula la ganancia en la gasolinera
        /// </summary>
        /// <param name="ganancia"></param>
        public void calcularGanancias(ref double ganancia)
        {
            ganancia = dineroConsumido - _comprasQuetzales;
        }
        #endregion


    }
}