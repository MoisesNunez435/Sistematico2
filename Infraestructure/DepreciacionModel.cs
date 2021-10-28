using DoMain;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class DepreciacionModel : IDepreciacionModel<ActivoFijo>
    {

        public decimal[] DepreciarLineaRecta(ActivoFijo af)
        {
            decimal[] LineaRecta = new decimal[af.VidaUtil];
            for (int i = 0; i < af.VidaUtil; i++)
            {
                decimal a = (af.ValorActivo - af.ValorResidual) / af.VidaUtil;
                LineaRecta[i] = a;
            }
            return LineaRecta;
        }
    

        public decimal[] DepreciarSDA(ActivoFijo af)
        {
            int Suma = 0;
            decimal[] depreciacion = new decimal[af.VidaUtil];

            for (int i = 1; i <= af.VidaUtil; i++)
            {
                Suma += i;
            }
            for (int i = 0; i < af.VidaUtil; i++)
            {
                decimal a = (i + 1) * (af.ValorActivo - af.ValorResidual);

                decimal total = a / Suma;

                depreciacion[i] = total;
            }
            return depreciacion;
        }
    }
}
