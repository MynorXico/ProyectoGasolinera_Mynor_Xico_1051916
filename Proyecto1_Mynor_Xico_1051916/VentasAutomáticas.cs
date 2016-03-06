using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class VentasAutomáticas
    {
        Deposito Deposito = new Deposito();
        Bomba Bomba = new Bomba();

        double dblDeposito;
        double dblBomba;
        double dblCantidad;
        double dblQuetzales;

        public void venderGasolinaGalón(Deposito unDeposito, Bomba unaBomba, double dblCantidadCombustible)
        {
            Deposito = unDeposito;
            Bomba = unaBomba;

            Bomba.seleccionarCombustible(ref Deposito);
            Bomba.venderPorGalones(dblCantidadCombustible);
        }


        public void recibirGasolinaGalon(double unDeposito, double unaBomba, double unaCantidad)
        {
            dblDeposito = unDeposito;
            dblBomba = unaBomba;
            dblCantidad = unaCantidad;
        }
        public void recibirGasolinaQuetzal(double unDeposito, double unaBomba, double unaCantidad)
        {
            dblDeposito = unDeposito;
            dblBomba = unaBomba;
        }
        
    }
}
