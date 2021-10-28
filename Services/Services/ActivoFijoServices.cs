using DoMain;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class ActivoFijoServices : IActivoFijo<ActivoFijo>
    {
        private IActivoFijoModel Activo;
        public ActivoFijoServices(IActivoFijoModel activo)
        {
            this.Activo = activo;
        }
        public void Add(ActivoFijo t, Array[] arr)
        {
            Activo.Add(t, arr);
        }

        public void Create(ActivoFijo t)
        {
            throw new NotImplementedException();
        }

        public ActivoFijo[] FindAll(ActivoFijo t)
        {
            return Activo.FindAll(t);
        }
    }
}
