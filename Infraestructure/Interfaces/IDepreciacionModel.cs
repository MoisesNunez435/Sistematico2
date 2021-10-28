using DoMain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Interfaces
{
    public interface IDepreciacionModel<T> : IModel<ActivoFijo>
    {
        decimal[] DepreciarLineaRecta(T t);
        decimal[] DepreciarSDA(T t);
    }
}
