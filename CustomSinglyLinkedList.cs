using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomSinglyLinkedList<T>
    {
        private Node<T> head;

        public CustomSinglyLinkedList()
        {

        }

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            Node<T> newHead = new Node<T>(item);

            if(head != null)
            {
                //head.Previous = newHead;
                newHead.Next = head;
            }
            
            head = newHead;
            this.Count++;

        }

        public T RemoveFirst()
        {
            if(head == null)
            {
                throw new InvalidOperationException("No elements to remove.");
            }
            
            Node<T> currentHead = head;

            head = head.Next;
            //head.Previous = null;
            this.Count--;
            return currentHead.Value;

        }

        public T GetFirst()
        {
            return head.Value;
        }

        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if(head == null)
            {
                head = newNode;
                this.Count++;
                return;
            }

            Node<T> current = head;

            while(current != null)
            {
                current = current.Next;
                if(current.Next == null)
                {
                    //newNode.Previous = current;
                    current.Next = newNode;
                    break;
                }
            }

            this.Count++;
        }

        public T RemoveLast()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }

            Node<T> current = head;
            Node<T> result = null;
            while(current != null)
            {
                current = current.Next;
                if(current.Next == null)
                {
                    result = current;
                    current = null;
                }
            }

            return result.Value;
        } //not finished

        public T GetLast() //not finished
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }

            Node<T> current = head;
            Node<T> last = null;

            while (current != null)
            {
                current = current.Next;
                if (current.Next == null)
                {
                    last = current;
                    break;
                }
            }

            return last.Value;
        }



    }
}


//Node<T> current = head;
//Node<T> valueToFind = null;

//while (current != null)
//{
//    valueToFind = current;
//    if (current.Next == null)
//    {
//        break;
//    }
//    current = current.Next;
//}
//current = null;

//return valueToFind.Value;