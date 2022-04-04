using System;
using System.Collections;

namespace Practice.QueuesStacksGenerics
{
    public class QueueItem
    {
        public object Value { get; set; }
        public QueueItem Next { get; set; } //Next это следующий элемент с наличием Value и Next
    }

    public class NewQueue
    {
        QueueItem head; //экземпляр класса QueueItem
        QueueItem tail; //экземпляр класса QueueItem
        
        public bool IsEmpty { get { return head == null; } }

        public void Enqueue1(object value)
        {
            if (head == null) //пустой список (изначально), то следующее действие (EnqueueGeneric) добавление первого элемента
                        //тут и tail = null
           //если всего 1 item
                head = tail = new QueueItem
                {
                    Value = value,
                    Next = null
                };
            
            else //если уже появился 2 item
            {
                var item = new QueueItem
                {
                    Value = value, 
                    Next = null
                };
                tail.Next = item; //кто стоит за мной в очереди
                tail = item; //очередь QueueItem начинает указывать на последнего (2го Iteam)
                //head не меняем, т.к. он остается указывать на 1 item 
            }
        }

        public object Dequeue1()
        {
            if (head == null) 
                throw new InvalidOperationException(); //т.е. нечего удалять
            
            var result = head.Value;
            head = head.Next;
            
            if (head == null) //при удалении последнего в очереди
                tail = null;
            
            return result;
        }
    }
    
    public class Program1234
    {
        public static void Main1234()
        {
            var queue = new NewQueue();
            
            //для int
            queue.Enqueue1(1);
            queue.Enqueue1(2);
            queue.Enqueue1(3);
            queue.Dequeue1();
            queue.Dequeue1();
            queue.Dequeue1();
            
            //string
            queue.Enqueue1("A");
            queue.Enqueue1("B");
            queue.Enqueue1("C");
            queue.Dequeue1();
            queue.Dequeue1();
            queue.Dequeue1();
            
            //int
            var myIntQueue = new NewQueue();
            myIntQueue.Enqueue1(1);
            myIntQueue.Enqueue1(2);
            myIntQueue.Enqueue1(3);
            var sum = 0;
            while (!myIntQueue.IsEmpty)
            {
                sum += (int)myIntQueue.Dequeue1(); //даункаст object к int
            }
            Console.WriteLine(sum);
        }
    }
}