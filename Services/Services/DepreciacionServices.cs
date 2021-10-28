using DoMain;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class DepreciacionServices : IDepreciacion<ActivoFijo>
    {
        private IDepreciacionModel Depreciacion;
        public DepreciacionServices(IDepreciacionModel Depreciacion)
        {
            this.Depreciacion = Depreciacion;
        }
        public decimal[] DepreciarLineaRecta(ActivoFijo t)
        {
            throw new NotImplementedException();
        }

        public decimal[] DepreciarSDA(ActivoFijo t)
        {
            throw new NotImplementedException();
        }
    }
}
