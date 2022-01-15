using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomStack<T>
    {

        private Node<T> top;

        //private CustomDoublyLinkedList<T> linkedList;
        public CustomStack()
        {
            //linkedList = new CustomDoublyLinkedList<T>();
        }

        public int Count { get; private set; }

        //public void Push(T value)
        //{
        //    linkedList.AddHead(value);
        //    this.Count++;
        //}

        //public T Peek()
        //{
        //    return linkedList.head.Value;
        //}

        //public T Pop()
        //{
        //    this.Count--;
        //    return linkedList.RemoveFirst();
        //}



        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.Count == 0)
            {
                top = newNode;
                this.Count++;
                return;
            }

            newNode.Previous = top;
            top.Next = newNode;
            top = newNode;
            this.Count++;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.Value;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            Node<T> currentTop = top;

            top = top.Previous;
            top.Next = null;

            return currentTop.Value;

            

        }
    }


}



//var newTop = top.Next; // null

//while (currentTop != null)
//{
//    if (currentTop.Next == null)
//    {
//        top = currentTop;
//    }
//    newTop.Next = currentTop.Next;
//    currentTop = currentTop.Next;
//}

//top.Next = null;

//top = newTop;
//this.Count--;