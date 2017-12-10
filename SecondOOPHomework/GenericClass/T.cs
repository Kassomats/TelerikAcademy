using System;
using System.Collections.Generic;

namespace GenericClass
{
    class GenericList<T>
    {
        private List<T> elements;
        public GenericList(int capacity = 4)
        {
            this.elements = new List<T>(capacity);
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.elements.Count)
                {
                    throw new IndexOutOfRangeException($"Index {index} is invalid");
                }
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Count)
                {
                    throw new IndexOutOfRangeException($"Index {index} is invalid");
                }
                this.elements[index] = value;
            }
        }


        public void Add(T element)
        {
            this.elements.Add(element);
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= this.elements.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is invalid");
            }

            this.elements.Remove(elements[index]);
        }
        public void Clear()
        {
            foreach (var item in elements)
            {
                elements.Remove(item);
            }
        }
        public int FindElement(T value)
        {
            int x = -1;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Equals(value))
                {
                    x = i;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }
            return x;
        }

    }
}