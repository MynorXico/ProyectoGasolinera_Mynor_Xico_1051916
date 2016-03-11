using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    /// <summary>
    /// Clase plantilla que deberá implementar el estudiante
    /// </summary>
    class Gasolinera
    {
        // Instanciación de objetos Deposito
        Deposito diesel, regular, super;
        //Instanciación de objetos Bomba
        Bomba bomba1, bomba2, bomba3, bomba4, bomba5, bomba6, bomba7;


        public Gasolinera(Deposito d1, Deposito d2, Deposito d3, Bomba b1, Bomba b2, Bomba b3, Bomba b4, Bomba b5, Bomba b6, Bomba b7)
        {
            diesel = d1;
            regular = d2;
            super = d3;
            bomba1 = b1;
            bomba2 = b2;
            bomba3 = b3;
            bomba4 = b4;
            bomba5 = b5;
            bomba6 = b6;
            bomba7 = b7;
        }


        ManejoDatos objManejoDatos = new ManejoDatos();
        /// <summary>
        /// Función plantilla escrita sólo con el propósito que ManejoDatos no presente errores de compilación en este proyecto
        /// </summary>
        /// <param name="intTipoCombustible">Número entero que representa el tipo de combustible de la venta a realizar</param>
        /// <param name="intBomba">Número de bomba escogida para realizar la venta</param>
        /// <param name="dblCantidadCombustible">Cantidad de combustible en galones de la venta a realziar. Si no se escoge por galones de combustible se enviará -1.</param>
        /// <param name="dblDineroVenta">Monto de dinero en quetzales de la venta a realizar. Si no se escoge venta por cantidad de dinero se enviará -1.</param>
        /// <returns>Retornará siempre falso pues esta plantilla no realiza acción alguna.</returns>
        /// 
        public bool EjecutarAccion(int intTipoCombustible, int intBomba, double dblCantidadCombustible, double dblDineroVenta)
        {
            try
            {
                if ((intTipoCombustible >= 0 && intTipoCombustible <= 3) && (intBomba >= 0 && intBomba <= 7))
                {
                    // Selecciona el tipo de combustible que se utilizará para la venta
                    #region Selección de tipo de combustible
                    switch (intTipoCombustible)
                    {
                        case 1:
                            bomba1._depositoAUsar = diesel;
                            bomba2._depositoAUsar = diesel;
                            bomba3._depositoAUsar = diesel;
                            bomba4._depositoAUsar = diesel;
                            bomba5._depositoAUsar = diesel;
                            bomba6._depositoAUsar = diesel;
                            bomba7._depositoAUsar = diesel;

                            break;
                        case 2:
                            bomba1._depositoAUsar = regular;
                            bomba2._depositoAUsar = regular;
                            bomba3._depositoAUsar = regular;
                            bomba4._depositoAUsar = regular;
                            bomba5._depositoAUsar = regular;
                            bomba6._depositoAUsar = regular;
                            bomba7._depositoAUsar = regular;
                            break;
                        case 3:
                            bomba1._depositoAUsar = super;
                            bomba2._depositoAUsar = super;
                            bomba3._depositoAUsar = super;
                            bomba4._depositoAUsar = super;
                            bomba5._depositoAUsar = super;
                            bomba6._depositoAUsar = super;
                            bomba7._depositoAUsar = super;
                            break;
                            #endregion

                    }
                    // Realiza la venta por combustible
                    #region Venta por cantidad de Combustible
                    if (dblCantidadCombustible != -1)
                    {
                        switch (intBomba)
                        {
                            case 1:
                                bomba1.venderPorGalones(dblCantidadCombustible);
                                break;
                            case 2:
                                bomba2.venderPorGalones(dblCantidadCombustible);
                                break;
                            case 3:
                                bomba3.venderPorGalones(dblCantidadCombustible);
                                break;
                            case 4:
                                bomba4.venderPorGalones(dblCantidadCombustible);
                                break;
                            case 5:
                                bomba5.venderPorGalones(dblCantidadCombustible);
                                break;
                            case 6:
                                bomba6.venderPorGalones(dblCantidadCombustible);
                                break;
                            case 7:
                                bomba7.venderPorGalones(dblCantidadCombustible);
                                break;
                        }
                    }
                    #endregion

                    // Realiza la venta por dinero de venta
                    #region Venta por cantidad de quetzales
                    if (dblDineroVenta != -1)
                    {
                        switch (intBomba)
                        {
                            case 1:
                                bomba1.venderPorQuetzales(dblDineroVenta);
                                break;
                            case 2:
                                bomba2.venderPorQuetzales(dblDineroVenta);
                                break;
                            case 3:
                                bomba3.venderPorQuetzales(dblDineroVenta);
                                break;
                            case 4:
                                bomba4.venderPorQuetzales(dblDineroVenta);
                                break;
                            case 5:
                                bomba5.venderPorQuetzales(dblDineroVenta);
                                break;
                            case 6:
                                bomba6.venderPorQuetzales(dblDineroVenta);
                                break;
                            case 7:
                                bomba7.venderPorQuetzales(dblDineroVenta);
                                break;
                        }
                        #endregion
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
