using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore
{
    public interface IActivoFijo<T>
    {
        void Add(T t, Array[] arr);
        void Create(T t);
        T[] FindAll(T t);
    }
}
