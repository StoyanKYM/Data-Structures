using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomDoublyLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public CustomDoublyLinkedList()
        {

        }

        public T GetByIndex(int index) //working
        {
            Node<T> current = head;
            int currentIdx = 0;

            while (current != null)
            {
                if (currentIdx == index)
                {
                    return current.Value;
                }
                current = current.Next;
                currentIdx++;
            }

            return default; 
        }    

        public void DeleteByIndex(int index)
        {
            Node<T> current = head;
            int currentIdx = 0;

            while (current != null)
            {
                if (currentIdx == index)
                {
                    //var result = current.Value;
                    this.Remove(current.Value);
                    return;
                }
                current = current.Next;
                currentIdx++;
            }

            return;
        } //working

        public bool Remove(T value)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current.Next == null)
                    {
                        tail = current.Previous;
                    }
                    else
                    {
                        current.Next.Previous = current.Previous;
                    }

                    if (current.Previous == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                    }

                    current = null;
                    return true;
                }

                current = current.Next;
            }

            return false;
        } //working

        public void AddHead(T value)
        {
            Node<T> newNode = new Node<T>(value);

            newNode.Next = head;


            if (head == null)
            {
                tail = newNode;
            }
            else
            {
                head.Previous = newNode;
            }

            head = newNode;
        } //working

        public void AddTail(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
            }

            tail = newNode;

        } //working

        public bool Contains(T value) //working
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public Node<T> Find(T value)
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return null;
        } //working

        public Node<T> FindLast(T value)
        {
            Node<T> currentNode = tail;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Previous;
            }

            return null;
        } //working

        public T RemoveFirst()
        {
            Node<T> current = head;
            if (head != null)
            {
                head = head.Next;
                head.Previous = null;
                if (head == null)
                {
                    tail = null;
                }
            }

            return current.Value;
        } //working

        public T RemoveLast()
        {
            Node<T> current = tail;
            if (tail != null)
            {               
                tail = tail.Previous;
                if (tail == null)
                {
                    head = null;
                }
            }

            return current.Value;
        } //working



    }
}
