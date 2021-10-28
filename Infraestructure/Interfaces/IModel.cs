using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Interfaces
{
    public interface IModel<T>
    {
        void Add(T t, Array[] arr);
        void Create(T t);
        T[] FindAll(T t);
    }
}
