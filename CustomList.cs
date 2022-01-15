using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomList<T> where T : IComparable<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private int index = 0;
        private T[] array;

        public CustomList()
        {
            array = new T[INITIAL_CAPACITY];
        }

        public int Count { get { return index; } }

        public void Add(T element)
        {
            if(index == array.Length)
            {
                array = GrowArraySize(array);
            }
            array[index] = element;
            index++;

        }

        public bool Contains(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return true;
                }

                //if (array[i].CompareTo(element) > 0)
                //{
                //    return true;
                //}
            }

            return false;
        }

        public int IndexOf(T element)
        {
            int currentIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    currentIndex = i;
                }
            }

            return currentIndex;

        }

        public bool Remove(T element)
        {
            int idx = this.IndexOf(element);
            if(idx == -1)
            {
                return false;
            }

            array[idx] = default;

            for (int i = idx; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            this.index--;

            return true;
        }

        public T RemoveAt(int index)
        {
            if(index < 0 || index >= this.index)
            {
                throw new ArgumentOutOfRangeException("Index out of Range");
            }

            T item = array[index];
            array[index] = default;

            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            this.index--;

            return item;
        }

        public void Insert(int index, T item)
        {
            if(index < 0 || index >= this.index)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = item;
            this.index++;
        }

        public T this[int i] 
        {
            get 
            {
                return array[i];
            }

            set 
            {
                array[i] = value;
            }
        }

        private T[] GrowArraySize(T[] array)
        {
            T[] newArray = new T[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }
    }
}
