using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class ArrayList<H> : List<H>
    {
        private Object[] array;
        private int size;

        public ArrayList()
        {
            this.array = new Object[4];
        }

        public void add(H data)
        {
            this.array[size++] = data;
        }

        public H get(int index)
        {
            return (H)this.array[index];
        }

        public void delete(int index) { }

        public int getSize()
        {
            return size;
        }

        public Iterator<H> getForwardIterator()
        {
            return new ForwardIterator(this);
        }


        public class ForwardIterator : Iterator<H>
        {
            private ArrayList<H> arrayList;
            private int currentIndex;

            public ForwardIterator(ArrayList<H> arrayList)
            {
                this.arrayList = arrayList;
                this.currentIndex = 0;
            }

            public bool hasNext()
            {
                return currentIndex < arrayList.size;
            }

            public H next()
            {
                H data = (H)arrayList.array[currentIndex];
                currentIndex++;
                return data;
            }
        }

        public Iterator<H> getReverseIterator()
        {
            return new ReverseIterator(this);
        }

        public class ReverseIterator : Iterator<H>
        {
            private ArrayList<H> arrayList;
            private int currentIndex;

            public ReverseIterator(ArrayList<H> arrayList)
            {
                this.arrayList = arrayList;
                this.currentIndex = arrayList.size - 1;
            }

            public bool hasNext()
            {
                return currentIndex >= 0;
            }

            public H next()
            {
                H data = (H)arrayList.array[currentIndex];
                currentIndex--;
                return data;
            }
        }
    }
}
