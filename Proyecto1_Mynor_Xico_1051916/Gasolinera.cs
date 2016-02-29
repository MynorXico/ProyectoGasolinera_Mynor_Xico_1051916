using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    public class Gasolinera
    {
        double _combustibleConsumido;
        double _dineroConsumido;

        Bomba bomba1 = new Bomba("Bomba 1");
        Bomba bomba2 = new Bomba("Bomba 2");
        Bomba bomba3 = new Bomba("Bomba 3");
        Bomba bomba4 = new Bomba("Bomba 4");
        Bomba bomba5 = new Bomba("Bomba 5");
        Bomba bomba6 = new Bomba("Bomba 6");
        Bomba bomba7 = new Bomba("Bomba 7");

        Deposito diesel = new Deposito(50, 11, 13.5, "Diesel");
        Deposito regular = new Deposito(30, 12.5, 17, "Regular");
        Deposito super = new Deposito(30, 14.5, 19, "Super");

        Validador objValidador = new Validador();
        Formato objFormato = new Formato();

        MenuSecundario menu1 = new MenuSecundario("", "Si", "No");
        MenuSecundario menu2 = new MenuSecundario("", "Manual", "Automática");
        MenuSecundario menu3 = new MenuSecundario("","Bomba 1", "Bomba 2", "Bomba 3", "Bomba 4", "Bomba 5", "Bomba 6", "Bomba 7");

        public void MostrarCombustible()
        {
            objFormato.pregunta("Cantidad de Gasolina en los Depósitos");
            string strDiesel = "  La cantidad de gasolina en el depósito de Diesel es:  " + diesel.cantCombustible;
            string strRegular = "\n  La cantidad de gasolina en el depósito de Regular es: " + regular.cantCombustible;
            string strSuper = "\n  La cantidad de gasolina en el depósito de Super es:   " + super.cantCombustible;

            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }
        public void MostrarCombustibleVenta()
        {
            string strDiesel = null;
            string strRegular = null;
            string strSuper = null;

            objFormato.pregunta("Cantidad de Gasolina en los Depósitos");
            if (diesel.disponible())
            {
                strDiesel = "  La cantidad de gasolina en el depósito de Diesel es:  " + diesel.cantCombustible;
            }
            if (regular.disponible())
            {
                strRegular = "\n  La cantidad de gasolina en el depósito de Regular es: " + regular.cantCombustible;
            }
            if(super.disponible())
            strSuper = "\n  La cantidad de gasolina en el depósito de Super es:   " + super.cantCombustible;

            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }

        public void MostrarPrecios()
        {
            objFormato.pregunta("Precios por Galón de Combustible");
            string strDiesel = "  El precio por galón del Diesel es: " + diesel.precioPorGalon;
            string strRegular = "\n  El precio por galón de Regular es: " + regular.precioPorGalon;
            string strSuper = "\n  El precio por galón de Súper es:   " + super.precioPorGalon;

            string output = strDiesel + strRegular + strSuper;
            objFormato.escribirContenido(output);
        }

        public void agregarDiesel(double cantidad, double costo)
        {
            if ((diesel.cantCombustible + cantidad) <= diesel.limit)
            {
                diesel.ingresarCombustible(cantidad, costo);
                objFormato.mensajeExito("El diesel se agregó correctamente");
                System.Threading.Thread.Sleep(1200);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operación inválida. La cantidad ingresada supera la capacidad del depósito.");
                System.Threading.Thread.Sleep(1200);
            }
        }

        

        public void agregarRegular(double cantidad, double costo)
        {
            if ((regular.cantCombustible + cantidad) <= regular.limit)
            {
                regular.ingresarCombustible(cantidad, costo);
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
        public void agregarSuper(double cantidad, double costo)
        {
            if ((super.cantCombustible + cantidad) <= super.limit)
            {
                super.ingresarCombustible(cantidad, costo);
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

        public void fijarPrecioDiesel(double precio)
        {
            if (precio > diesel.costoPorGalon)
            {
                diesel.precioPorGalon = precio;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El precio por galón indicado generará pérdidas a la gasolinera.");
                Console.ReadLine();
            }
        }
        public void fijarPrecioRegular(double precio)
        {
            if (precio > regular.costoPorGalon)
            {
                regular.precioPorGalon = precio;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El precio por galón indicado generará pérdidas a la gasolinera");
                Console.ReadLine();
            }
        }
        public void fijarPrecioSuper(double precio)
        {
            if (precio > super.costoPorGalon)
            {
                super.precioPorGalon = precio;
            }
            super.precioPorGalon = precio;
        }

        public double cantDiesel
        {
            get
            {
                return diesel.cantCombustible;
            }
        }
        public double cantRegular
        {
            get
            {
                return regular.cantCombustible;
            }
        }
        public double cantSuper
        {
            get
            {
                return super.cantCombustible;
            }
        }
        public double limite
        {
            get
            {
                return diesel.limit;
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
                menu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do {
                                Console.ResetColor();
                                Console.Clear();
                                Console.WriteLine("Ingrese la cantidad de diesel en galones que desea ingresar:");
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
                menu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese la cantidad de regular en galones que desea ingresar:");
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
                                costoValido = true; if (objValidador.esPositivo(dblCosto) && objValidador.esPositivo(dblCantidad))
                                {
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
                menu1.EscribirMenuSecundario2ST();
                Console.ResetColor();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("Ingrese la cantidad de super en galones que desea ingresar:");
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

        public void solicitarCombustible()
        {
            solicitarCombustibleDiesel();
            solicitarCombustibleRegular();
            solicitarCombustibleSuper();
        }
        private void definirPrecio(Deposito unDeposito)
        {
            bool opcionValida = true;
            do
            {
                MostrarPrecios();
                double precioNuevo = 0;
                bool precioValido = false;

                objFormato.pregunta("¿Desea Ingresar Nuevo Precio para " + unDeposito.label + "?");
                menu1.EscribirMenuSecundario2ST();
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
                            if (objValidador.esNumeroDouble(strCantidad))
                            {
                                precioNuevo = double.Parse(strCantidad);
                                precioValido = true;
                                if (objValidador.esPositivo(precioNuevo))
                                {
                                    if (precioNuevo > unDeposito.precioPorGalon)
                                    {
                                        unDeposito.indicarNuevoPrecio(precioNuevo);
                                        objFormato.mensajeExito("Se ha fijado un nuevo precio para " + unDeposito.label + ".");
                                    }
                                    else
                                    {
                                        objFormato.mensajeError("El número ingresado genera pérdidas");
                                        objFormato.mensajeError("La operación finaliza");
                                    }
                                }
                                else
                                {
                                    objFormato.mensajeError("Ingresó un valor inválido");
                                    objFormato.mensajeError("La operación finaliza");
                                }
                            }
                        } while (!precioValido);
                        break;
                    case "2":
                        opcionValida = true;
                        break;
                    default:
                        Console.ResetColor();
                        opcionValida = false;
                        objFormato.mensajeError("Ingrese un número válido");
                        Console.Clear();
                        break;
                }

            } while (!opcionValida);
            Console.ResetColor();
            Console.Clear();
        }
        public void definirPrecios()
        {
            bool opcionValida = false;
            do {
                objFormato.escribirTitulo("Precios de gasolina por depósitos");
                MostrarPrecios();
                objFormato.pregunta("¿Desea cambiar el precio por depósitos?");
                menu1.EscribirMenuSecundario2ST();
                string strOpcion = Console.ReadLine();
                switch (strOpcion) {
                    case "1":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        definirPrecio(diesel);
                        definirPrecio(regular);
                        definirPrecio(super);
                        MostrarPrecios();
                        Console.ReadLine();
                        break;
                    case "2":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            } while (!opcionValida);
        }

        public void tipoDeVenta()
        {
            bool opcionValida = false;
            do
            {
                objFormato.mensajeBienvenida("Proceso de Ventas de Combustible");
                objFormato.pregunta("¿Qué método de venta desea utilizar?");
                menu2.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        opcionValida = true;
                        Console.ResetColor();
                        SeleccionarBomba();
                        break;
                    case "2":
                        opcionValida = true;
                        Console.WriteLine("Programar venta automática de combustible");
                        break;
                    default:
                        objFormato.mensajeError("Debe seleccionar una opción válida");
                        break;
                }
            } while (!opcionValida);
        }

        internal void venderGasolina()
        {
            bool opcionValida = false;
            do
            {
                objFormato.pregunta("¿Desea entrar al proceso de ventas?");
                menu1.EscribirMenuSecundario2ST();
                string opcion = Console.ReadLine();
                switch(opcion) {
                    case "1":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        tipoDeVenta();
                        break;
                    case "2":
                        opcionValida = true;
                        Console.ResetColor();
                        Console.Clear();
                        break;
                }
                Console.ResetColor();
                Console.Clear();
            } while (!opcionValida);
        }
        
        public void SeleccionarBomba()
        {
            bool opcionValida = false;
            do
            {
                Console.ResetColor();
                Console.Clear();
                opcionValida = false;
                objFormato.pregunta("¿Qué bomba desea utilizar?");
                menu3.EscribiRmenuSecundario7ST();
                string opcion = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                MostrarPrecios();
                MostrarCombustibleVenta();
                switch (opcion)
                {
                    case "1":
                        opcionValida = true;
                        bomba1.Dispensar();
                        Console.ReadLine();
                        break;
                    case "2":
                        opcionValida = true;
                        bomba2.Dispensar();
                        break;
                    case "3":
                        opcionValida = true;
                        bomba3.Dispensar();
                        break;
                    case "4":
                        opcionValida = true;
                        bomba4.Dispensar();
                        break;
                    case "5":
                        opcionValida = true;
                        bomba5.Dispensar();
                        break;
                    case "6":
                        opcionValida = true;
                        bomba6.Dispensar();
                        break;
                    case "7":
                        opcionValida = true;
                        bomba7.Dispensar();
                        break;
                    default:
                        objFormato.mensajeError("Debe ingresar una opción válida!");
                        break;
                }

            } while (!opcionValida);
        }

    }
}