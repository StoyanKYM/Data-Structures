using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        //CustomDoublyLinkedList<T> linkedList;
        public CustomQueue()
        {
            //linkedList = new CustomDoublyLinkedList<T>();
        }

        public int Count { get; private set; }


        //public void Enqueue(T item)
        //{
        //    linkedList.AddTail(item);
        //    this.Count++;
        //}

        //public T Peek()
        //{
        //    return linkedList.head.Value;
        //}

        //public T Dequeue()
        //{
        //    this.Count--;
        //    return linkedList.RemoveFirst();
        //}

        public void Enqueue(T item)
        {
            Node<T> current = new Node<T>(item);

            if (this.Count == 0)
            {
                this.head = current;
                this.tail = current;
                this.Count++;
                return;
            }

            this.tail.Next = current;
            this.tail = current;

            this.Count++;

        }

        public T Peek()
        {
            return this.head.Value;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            Node<T> oldHead = head;

            head = head.Next;
            this.Count--;

            return oldHead.Value;

        }

        public bool Contains(T item)
        {
            var current = head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    var current = this.head;
        //    while (current != null)
        //    {
        //        yield return current.Value;
        //        current = current.Next;
        //    }
        //}

        //IEnumerator<T> IEnumerable.GetEnumerator()
        //    => this.GetEnumerator();

    }
}
