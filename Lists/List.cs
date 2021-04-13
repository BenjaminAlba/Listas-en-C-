using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    interface List<T>
    {
        void add(T data);

        T get(int index);

        void delete(int index);

        int getSize();

        Iterator<T> getForwardIterator();

        Iterator<T> getReverseIterator();
    }
}
