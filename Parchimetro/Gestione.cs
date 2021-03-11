using System;

namespace Parchimetro
{
    public class Gestione
    {
        public static double TariffaA(int ore,double costoTariffa)
        {
            double costotot = 15;
            return costotot;
        }
        public static double TariffaB(int ore,double costoTariffa)
        {
            double costoTot = ore * costoTariffa;
            return costoTot;
        }
        public static double TariffaC(int ore, double costoTariffa)
        {
            double costotot = 0;
            if(ore==1)
            {
                costotot = 0;
            }
            else
            {
                costotot = (ore-1)*costoTariffa;
            }
            return costotot;
        }
    }
}
