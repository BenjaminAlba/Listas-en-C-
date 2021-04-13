using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public interface Iterator<T>
    {
        bool hasNext();

        T next();
    }
}
