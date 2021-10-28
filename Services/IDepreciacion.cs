using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore
{
    public interface IDepreciacion<T>
    {
        decimal[] DepreciarLineaRecta(T t);
        decimal[] DepreciarSDA(T t);
    }
}
