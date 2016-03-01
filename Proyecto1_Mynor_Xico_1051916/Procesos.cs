using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto1_Mynor_Xico_1051916
{
    public class Procesos
    {
        // Definición de atributos de clas Procesos
        double _combustibleConsumido;
        double _dineroConsumido;
        double _comprasQuetzales;
        double _ganancia;

        // Instanciación de los 7 objetos Bomba que operarán en la gasolinera
        Bomba objBomba1 = new Bomba("Bomba 1");
        Bomba objBomba2 = new Bomba("Bomba 2");
        Bomba objBomba3 = new Bomba("Bomba 3");
        Bomba objBomba4 = new Bomba("Bomba 4");
        Bomba objBomba5 = new Bomba("Bomba 5");
        Bomba objBomba6 = new Bomba("Bomba 6");
        Bomba objBomba7 = new Bomba("Bomba 7");

        // Instanciación de los 3 objetos Depósito que operarán en la gasolinera
        Deposito objDepositoDiesel = new Deposito(50, 11, 13.5, "Diesel");
        Deposito objDepositoRegular = new Deposito(30, 12.5, 17, "Regular");
        Deposito objDepositoSuper = new Deposito(30, 14.5, 19, "Super");

        // Instanciación de objeto Validador
        Validador objValidador = new Validador();

        // Instanciación de objeto Formato
        Formato objFormato = new Formato();

        Gasolinera gasolineraVentas = new Gasolinera();
        ManejoDatos objManejoDatos = new ManejoDatos();

        // Instanciación de menus que se utilizarán durante la ejecución del programa
        MenuSecundario objMenu1 = new MenuSecundario("", "Si", "No");
        MenuSecundario objMenu2 = new MenuSecundario("", "Manual", "Automática");
        MenuSecundario objMenu3 = new MenuSecundario("","Bomba 1", "Bomba 2", "Bomba 3", "Bomba 4", "Bomba 5", "Bomba 6", "Bomba 7");
        MenuSecundario objMenu4 = new MenuSecundario("Tipos de Combustible", "Diesel", "Regular", "Super");
        MenuSecundario objMenu5 = new MenuSecundario("", "Por Gálón", "Por Quetzales");

        /// <summary>
        /// Método que muestra al usuario la cantidad de combustible en cada uno de los tres depósitos
        /// </summary>
        public void MostrarCombustible()
        {
            objFormato.pregunta("Cantidad de Gasolina en los Depósitos");
            string strDiesel = "  La cantidad de gasolina en el depósito de Diesel es:  " + Math.Round(objDepositoDiesel.cantCombustible, 2);
            string strRegular = "\n  La cantidad de gasolina en el depósito de Regular es: " + Math.Round(objDepositoRegular.cantCombustible, 2);
            string strSuper = "\n  La cantidad de gasolina en el depósito de Super es:   " + Math.Round(objDepositoSuper.cantCombustible, 2);

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
            if(objDepositoSuper.disponible())
            strSuper = "\n  La cantidad de gasolina en el depósito de Super es:   " + Math.Round(objDepositoSuper.cantCombustible, 2);
            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }

        /// <summary>
        /// Método que muestra al usuario los precios de cada tipo de combustible por Galón.
        /// </summary>
        public void MostrarPrecios()
        {
            objFormato.pregunta("Precios por Galón de Combustible");
            string strDiesel = "  El precio por galón del Diesel es:    Q." + Math.Round(objDepositoDiesel.precioPorGalon, 2);
            string strRegular = "\n  El precio por galón de Regular es:    Q." + Math.Round(objDepositoRegular.precioPorGalon, 2);
            string strSuper = "\n  El precio por galón de Súper es:      Q." + Math.Round(objDepositoSuper.precioPorGalon, 2);

            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }

        /// <summary>
        /// Método para agregar Diesel
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        public void agregarDiesel(double cantidad, double costo)
        {
            if ((objDepositoDiesel.cantCombustible + cantidad) <= objDepositoDiesel.limit)
            {
                objDepositoDiesel.ingresarCombustible(cantidad, costo);
                objFormato.mensajeExito("El Diesel se agregó correctamente");
                System.Threading.Thread.Sleep(1200);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operación inválida. La cantidad ingresada supera la capacidad del depósito.");
                System.Threading.Thread.Sleep(1200);
            }
        }
        /// <summary>
        /// Método para agregar Regular
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        public void agregarRegular(double cantidad, double costo)
        {
            if ((objDepositoRegular.cantCombustible + cantidad) <= objDepositoRegular.limit)
            {
                objDepositoRegular.ingresarCombustible(cantidad, costo);
                objFormato.mensajeExito("El Regular se agregó correctamente");
                System.Threading.Thread.Sleep(1200);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operación inválida. La cantidad ingresada supera la capacidad del depósito.");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Método para agregar Super
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="costo"></param>
        public void agregarSuper(double cantidad, double costo)
        {
            if ((objDepositoSuper.cantCombustible + cantidad) <= objDepositoSuper.limit)
            {
                objDepositoSuper.ingresarCombustible(cantidad, costo);
                objFormato.mensajeExito("El súper se agregó correctamente");
                System.Threading.Thread.Sleep(1200);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operación inválida. La cantidad ingresada supera la capacidad del depósito");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Método que se utiliza para fijar el precio del diesel
        /// </summary>
        /// <param name="precio"></param>
        public void fijarPrecioDiesel(double precio)
        {
            if (precio > objDepositoDiesel.costoPorGalon)
            {
                objDepositoDiesel.precioPorGalon = precio;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El precio por galón indicado generará pérdidas a la gasolinera.");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Método que se utiliza para fijar el precio del depósito de regular
        /// </summary>
        /// <param name="precio"></param>
        public void fijarPrecioRegular(double precio)
        {
            if (precio > objDepositoRegular.costoPorGalon)
            {
                objDepositoRegular.precioPorGalon = precio;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El precio por galón indicado generará pérdidas a la gasolinera");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Método que se utiliza para fijar el precio del depósito de súper
        /// </summary>
        /// <param name="precio"></param>
        public void fijarPrecioSuper(double precio)
        {
            if (precio > objDepositoSuper.costoPorGalon)
            {
                objDepositoSuper.precioPorGalon = precio;
            }
            objDepositoSuper.precioPorGalon = precio;
        }
         
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

        /// <summary>
        /// Método que solicita al usuario si desea ingresar diesel a los depósitos
        /// </summary>
        public void solicitarCombustibleDiesel()
        {
            double dblCosto=0;
            double dblCantidad=0;
            bool costoValido = false;
            bool cantidadValida = false;
            bool continuar = true;

            do {
                MostrarCombustible();
                objFormato.pregunta("¿Desea Ingresar Diesel?");
                objMenu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                // Comprueba que la opción ingresada por el usuario sea válida, de lo contrario repite la acción
                switch (opcion)
                {
                    // Si el usuario escribe 1, desea ingresar combustible a los depósitos
                    case "1":
                        do {
                                Console.ResetColor();
                                Console.Clear();
                                Console.WriteLine("Ingrese la cantidad de " + objDepositoDiesel.label + " en galones que desea ingresar:");
                                string strCantidad = Console.ReadLine();
                                // Valida que la cantidad de galones ingresada sea un número real
                                if (objValidador.esNumeroDouble(strCantidad))
                                {
                                    dblCantidad = double.Parse(strCantidad);
                                    cantidadValida = true;
                                }
                            } while (!cantidadValida);
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese el costo por galón del combustible");
                            string strCosto = Console.ReadLine();
                            // Valida que la cantidad ingresada de quetzales sea un número real
                            if (objValidador.esNumeroDouble(strCosto))
                            {
                                dblCosto = double.Parse(strCosto);
                                costoValido = true;
                                if (objValidador.esPositivo(dblCosto) && objValidador.esPositivo(dblCantidad)){
                                    agregarDiesel(dblCantidad, dblCosto);
                                }
                                else
                                {
                                    objFormato.mensajeError("Ingresó valores inválidos");
                                    objFormato.mensajeError("La operación finaliza");
                                }
                            }
                            break;
                        } while (!costoValido);
                        continuar = false;
                        break;
                    case "2":
                        // Si el usuario escribe 2, no desea agregar combustible a los galones y finaliza el método
                        continuar = false;
                        break;
                    default:
                        // Muestra mensaje de error en caso de haber ingresado una opción no válida
                        objFormato.mensajeError("Opción inválida");
                        Console.ResetColor();
                        Console.Clear();
                        break;
                }
            } while (continuar);
            // Limpia consola al finalizar el método
            Console.Clear();
        }

        /// <summary>
        /// Método que solicita al usuario si desea ingresar regular a los depósitos
        /// </summary>
        public void solicitarCombustibleRegular()
        {
            double dblCosto = 0;
            double dblCantidad = 0;
            bool costoValido = false;
            bool cantidadValida = false;
            bool continuar = true;

            do
            {
                MostrarCombustible();
                objFormato.pregunta("¿Desea Ingresar Regular?");
                objMenu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese la cantidad de "+objDepositoRegular.label + " en galones que desea ingresar:");
                            string strCantidad = Console.ReadLine();
                            if (objValidador.esNumeroDouble(strCantidad))
                            {
                                dblCantidad = double.Parse(strCantidad);
                                cantidadValida = true;
                            }
                            else
                            {
                                objFormato.mensajeError("Cantidad no válida");
                            }
                        } while (!cantidadValida);
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese el costo por galón del combustible");
                            string strCosto = Console.ReadLine();
                            if (objValidador.esNumeroDouble(strCosto))
                            {
                                dblCosto = double.Parse(strCosto);
                                costoValido = true; if (objValidador.esPositivo(dblCosto) && objValidador.esPositivo(dblCantidad))
                                {
                                    agregarRegular(dblCantidad, dblCosto);
                                }
                                else
                                {
                                    objFormato.mensajeError("Ingresó valores inválidos");
                                    objFormato.mensajeError("La operación finaliza");
                                }
                            }
                            break;
                        } while (!costoValido);
                        continuar = false;
                        break;
                    case "2":
                        continuar = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese un número válido");
                        System.Threading.Thread.Sleep(1200);
                        Console.ResetColor();
                        Console.Clear();
                        break;
                }
            } while (continuar);
            Console.Clear();
        }

        /// <summary>
        /// Método que solicita al usuario si desea ingresar súper a los depósitos
        /// </summary>
        public void solicitarCombustibleSuper()
        {
            double dblCosto = 0;
            double dblCantidad = 0;
            bool costoValido = false;
            bool cantidadValida = false;
            bool continuar = true;

            do
            {
                MostrarCombustible();
                objFormato.pregunta("¿Desea Ingresar Super?");
                objMenu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese la cantidad de " + objDepositoSuper.label + " en galones que desea ingresar:");
                            string strCantidad = Console.ReadLine();
                            if (objValidador.esNumeroDouble(strCantidad))
                            {
                                dblCantidad = double.Parse(strCantidad);
                                cantidadValida = true;
                            }
                        } while (!cantidadValida);
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese el costo por galón del combustible");
                            string strCosto = Console.ReadLine();
                            if (objValidador.esNumeroDouble(strCosto))
                            {
                                dblCosto = double.Parse(strCosto);
                                costoValido = true;
                                if (objValidador.esPositivo(dblCosto) && objValidador.esPositivo(dblCantidad))
                                {
                                    agregarSuper(dblCantidad, dblCosto);
                                }
                                else
                                {
                                    objFormato.mensajeError("Ingresó valores inválidos");
                                    objFormato.mensajeError("La operación finaliza");
                                }
                            }
                            break;
                        } while (!costoValido);
                        continuar = false;
                        break;
                    case "2":
                        continuar = false;
                        break;
                    default:
                        objFormato.mensajeError("Ingrese un número válido");
                        Console.Clear();
                        break;
                }
            } while (continuar);
            Console.Clear();
        }
        
        /// <summary>
        ///  Método que permite al usuario decidir si deseea ingresar diesel, regular o super
        /// </summary>
        public void solicitarCombustible()
        {
            solicitarCombustibleDiesel();
            solicitarCombustibleRegular();
            solicitarCombustibleSuper();
        }

        /// <summary>
        /// Método que permite al usuario definir el precio de cualquier tipo de Combustible
        /// </summary>
        /// <param name="unDeposito">TIpo de combustible cuyo precio se desea cambiar</param>
        private void definirPrecio(Deposito unDeposito)
        {
            bool opcionValida = true;
            do
            {
                MostrarPrecios();
                double precioNuevo = 0;
                bool precioValido = false;
                // Pregunta al usuario si desea ingresar nuevo precio para unDeposito
                objFormato.pregunta("¿Desea Ingresar Nuevo Precio para " + unDeposito.label + "?");
                objMenu1.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese el nuevo precio de " + unDeposito.label + " que desea.");
                            string strCantidad = Console.ReadLine();
                            // El usuario ingresa el nuevo precio para unDeposito
                            if (objValidador.esNumeroDouble(strCantidad))
                            {
                                precioNuevo = double.Parse(strCantidad);
                                precioValido = true;
                                if (objValidador.esPositivo(precioNuevo))
                                {
                                    if (precioNuevo > unDeposito.precioPorGalon)
                                    {
                                        // Si el precio Nuevo es mayor al precio por actual, se cambia el precio
                                        unDeposito.indicarNuevoPrecio(precioNuevo);
                                        objFormato.mensajeExito("Se ha fijado un nuevo precio para " + unDeposito.label + ".");
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
                        objFormato.mensajeError("Ingrese un número válido");
                        Console.Clear();
                        break;
                }

            } while (!opcionValida);
            // Restablece color y datos en consola
            Console.ResetColor();
            Console.Clear();
        }

        /// <summary>
        ///  Método que precmite definir el precio de los tres depósitos de combustible
        /// </summary>
        public void definirPrecios()
        {
            bool opcionValida = false;
            do {
                // Preunta al usuario si desea cambiar el precio de algun depósito
                objFormato.escribirTitulo("Precios de gasolina por depósitos");
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
                        objFormato.mensajeError("Ingrese una opción válida");
                        Console.Clear();
                        break;
                }
            } while (!opcionValida);
        }

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
                                        objFormato.mensajeError("Debe ingresar una opción válida");
                                        break;
                                }
                            } while (!opcionValida1 && continuarVentas);
                        }
                        break;
                    case "2":
                        // Si el usuario selecciona la opción 2, se realizará una venta automática con un archivo de texto
                        opcionValida = true;
                        ventaAutomatica();
                        Console.WriteLine("Programar venta automática de combustible");
                        break;
                    default:
                        // Si el usuario no selecciona la opción 1 o 2, se mostrará un mensaje de error y procederá a solicitar nuevamente el resultado
                        objFormato.mensajeError("Debe seleccionar una opción válida");
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
                objFormato.pregunta("¿Desea entrar al proceso de ventas?");
                objMenu1.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                switch(opcion) {
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
                        ventaAutomatica();
                        Console.Clear();
                        break;
                    default:
                        Console.ResetColor();
                        objFormato.mensajeError("Opción Inválida");
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
                objFormato.pregunta("¿Qué bomba desea utilizar?");
                objMenu3.EscribiRmenuSecundario7ST();
                string opcion = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                Deposito depositoAUsar = new Deposito();
                int tipoDeVenta;
                MostrarPrecios();
                MostrarCombustibleVenta();
                switch (opcion)
                {
                    case "1":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba1.Dispensar(depositoAUsar, tipoDeVenta);
                        Console.ReadLine();
                        break;
                    case "2":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba2.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    case "3":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba3.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    case "4":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba4.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    case "5":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba5.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    case "6":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba6.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    case "7":
                        opcionValida = true;
                        depositoAUsar = solicitarTipoCombustibleVenta();
                        tipoDeVenta = TipoDeVenta();
                        objBomba7.Dispensar(depositoAUsar, tipoDeVenta);
                        break;
                    default:
                        objFormato.mensajeError("Debe ingresar una opción válida!");
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
                objFormato.pregunta("¿Qué tipo de combustible desea vender?");
                objMenu4.EscribirMenuSecundario3();
                string opcion = Console.ReadLine();
                Console.ResetColor();
                switch (opcion)
                {
                    case "1":
                        // Se utilizará el depósito de diesel
                        depositoSeleccionado = objDepositoDiesel;
                        opcionValida = true;                        
                        break;
                    case "2":
                        // Se utilizará el depósito de regular
                        depositoSeleccionado = objDepositoRegular;
                        opcionValida = true;
                        break;
                    case "3":
                        // Se utilizará el depósito de 
                        depositoSeleccionado = objDepositoSuper;
                        opcionValida = true;
                        break;
                    default:
                        // Si no seleccionan una opción válida, se borra la consola y solicita nuevamente
                        objFormato.mensajeError("No seleccionó un tipo de combustible válido!");
                        Console.Clear();
                        depositoSeleccionado = objDepositoDiesel;
                        break;
                }
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
                        objFormato.mensajeError("Por favor seleccione una opción válida");
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
            objManejoDatos.CargaryEjecutarDatosArchivo(@"C:\Ejemplo.txt", gasolineraVentas);

            gasolineraVentas.EjecutarAccion(4, 5, 6, 7);
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

        /// <summary>
        /// Método que muestra ventas
        /// </summary>
        public void mostrarVentas()
        {
            calcularVentas(ref _combustibleConsumido, ref _dineroConsumido);
            objFormato.pregunta("Ventas de la Gasolinera");
            Console.WriteLine("Cantidad vendida en Galones:   " + Math.Round(_combustibleConsumido, 2));
            Console.WriteLine("Cantidad vendida en Quetzales: " + Math.Round(_dineroConsumido, 2));
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }

        /// <summary>
        /// Calcula las Compras en Quetzales de la Gasolinera
        /// </summary>
        /// <param name="comprasQuetzales"></param>
        public void calcularComprasQ(ref double comprasQuetzales)
        {
            comprasQuetzales = objDepositoDiesel.comprasQuetzales + objDepositoRegular.comprasQuetzales + objDepositoSuper.comprasQuetzales;
        }

        /// <summary>
        /// Método que muestra las compras de la gasolinera
        /// </summary>
        public void mostarComprasQ()
        {
            calcularComprasQ(ref _comprasQuetzales);
            objFormato.pregunta("Compras de la Gasolinera");
            Console.WriteLine("Cantidad comprada en Quetzales: " + Math.Round(_comprasQuetzales, 2));
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }

        /// <summary>
        /// Método que calcula la ganancia en la gasolinera
        /// </summary>
        /// <param name="ganancia"></param>
        public void calcularGanancias(ref double ganancia)
        {
            ganancia = dineroConsumido - _comprasQuetzales;
        }

        /// <summary>
        /// Método que muestra la ganancia en la gasolinera
        /// </summary>
        public void mostrarGanancia()
        {
            calcularGanancias(ref _ganancia);
            objFormato.pregunta("Ganancias en la Gasolinera");
            if (_ganancia >= 0)
            {
                Console.WriteLine("La ganancia ha sido de:  Q " + _ganancia);
            }
            else
            {
                objFormato.mensajeError("No han habido ganancias, la pérdida ha sido de " + -_ganancia);
            }
        }

        /// <summary>
        /// Método que muestra la información de las ventas realizadas en la gasolinera
        /// </summary>
        public void mostrarInformacionVentas()
        {
            // Muestra las ventas por Bomba
            Console.Clear();
            objFormato.pregunta("Información de las Ventas Realizadas por Bomba");
            objBomba1.mostrarVentas();
            objBomba2.mostrarVentas();
            objBomba3.mostrarVentas();
            objBomba4.mostrarVentas();
            objBomba5.mostrarVentas();
            objBomba6.mostrarVentas();
            objBomba7.mostrarVentas();
            // Muestra las ventas por Depósito
            Console.Clear();
            objFormato.pregunta("Información de las ventas Realizadas por Depósito");
            objDepositoDiesel.mostrarVentas();
            objDepositoRegular.mostrarVentas();
            objDepositoSuper.mostrarVentas();
            // Muestra las ventas de la gasolinera
            Console.Clear();
            mostrarVentas();
            mostarComprasQ();
            mostrarGanancia();
        }

    }
}