using System;

namespace Practice.QueuesStacksGenerics
{
    public class QueueItem
    {
        public object Value { get; set; }
        public QueueItem Next { get; set; }
    }

    public class NewQueue
    {
        QueueItem head; //экземпляр класса QueueItem
        QueueItem tail; //экземпляр класса QueueItem

        public void Enqueue1(object value)
        {
            var item = new QueueItem
            {
                Value = value 
            };

            if (head == null) //??
                tail = head = item; //если всего 1 item
            
            else //если уже появился 2 item
            {
                tail.Next = item; //кто стоит за мной в очереди
                tail = item; //очередь QueueItem начинает указывать на последнего (2го Iteam)
            }
        }

        public object Dequeue1()
        {
            if (head == null) 
                throw new InvalidOperationException();
            
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
            // for (int i = 0; i < 3; i++)
            // {
            //     queue.Enqueue1(i);
            // }
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine(queue.Dequeue1());
            // }
            
            queue.Enqueue1("A");
            queue.Enqueue1("B");
            queue.Enqueue1("C");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(queue.Dequeue1());
            }
        }
    }
}