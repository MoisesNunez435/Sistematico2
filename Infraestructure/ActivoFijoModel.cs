using DoMain;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class ActivoFijoModel : IModel<ActivoFijo>
    {
        public ActivoFijo[] activoFijos;
        public void Add(ActivoFijo t, Array[] arr)
        {
            if (activoFijos == null)
            {
                activoFijos = new ActivoFijo[1];
                activoFijos[0] = t;
            }
            else
            {
                ActivoFijo[] temp = new ActivoFijo[activoFijos.Length + 1];
                Array.Copy(activoFijos, temp, activoFijos.Length);
                temp[temp.Length - 1] = t;
                activoFijos = temp;
            }
        }

        public void Create(ActivoFijo t)
        {
            
        }

        public ActivoFijo[] FindAll(ActivoFijo t)
        {
            return activoFijos;
        }
    }
}
