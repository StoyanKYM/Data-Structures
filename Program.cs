using System;

namespace CustomDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {


            //// QUEUE
            //CustomQueue<int> queue = new CustomQueue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(6);
            //queue.Enqueue(9);
            //queue.Enqueue(17);

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Contains(17));
            //Console.WriteLine(queue.Contains(53));

            //// STACK
            //CustomStack<int> stack = new CustomStack<int>();

            //stack.Push(3);
            //stack.Push(7);
            //stack.Push(10);
            //stack.Push(25);


            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Peek());

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Console.WriteLine(stack.Peek());

            //// DOUBLY LINKED LIST
            //CustomDoublyLinkedList<int> doublyList = new CustomDoublyLinkedList<int>();

            //doublyList.AddHead(1);
            //doublyList.AddHead(2);
            //doublyList.AddTail(3);
            //doublyList.AddTail(7);
            //doublyList.AddTail(9);

            //Console.WriteLine(doublyList.RemoveLast());

            //Console.WriteLine(doublyList.Remove(1));
            //Console.WriteLine(doublyList.Remove(170));
            //Console.WriteLine(doublyList.GetByIndex(1));

            //doublyList.DeleteByIndex(1);
            //doublyList.DeleteByIndex(20);

            //Console.WriteLine(doublyList.Contains(7));
            //Console.WriteLine(doublyList.Contains(100));


            //Console.WriteLine(doublyList.Find(1));
            //Console.WriteLine(doublyList.FindLast(1));


            //doublyList.RemoveFirst();

            //doublyList.RemoveLast();


            // SINGLY LINKED LIST
            CustomSinglyLinkedList<int> singlyList = new CustomSinglyLinkedList<int>();

            singlyList.AddFirst(5);

            singlyList.AddFirst(7);
            singlyList.AddFirst(8);
            singlyList.AddFirst(9);

            Console.WriteLine(singlyList.RemoveFirst());

            Console.WriteLine(singlyList.GetFirst());

            

            ;
            Console.WriteLine(singlyList.GetLast());
            Console.WriteLine(singlyList.RemoveLast());
            Console.WriteLine(singlyList.RemoveLast());

            ;


            //// LIST
            //CustomList<int> list = new CustomList<int>();

            //list.Add(5);
            //list.Add(12);
            //list.Add(13);


            //list.Add(12);
            //list.Add(13);


            //Console.WriteLine(list.Contains(5));
            //Console.WriteLine(list.Contains(7));

            //Console.WriteLine(list.IndexOf(5));
            //Console.WriteLine(list.IndexOf(7));


            //Console.WriteLine(list.Remove(5));
            //Console.WriteLine(list.Remove(7));

            //list.Add(5);

            ////Console.WriteLine(list.RemoveAt(7));
            //Console.WriteLine(list.RemoveAt(1));

            //list.Insert(1, 13);

            //list.Add(5);
            //list.Add(12);
            //list.Add(13);
            //list.Add(5);
            //list.Add(12);
            //list.Add(13);

            //Console.WriteLine(list.Count);

        }
    }
}
