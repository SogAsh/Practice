using System;

namespace Practice.QueuesStacksGenerics
{
    public class QueueItemGeneric<T>
    {
        public T Value { get; set; }
        public QueueItemGeneric<T> Next { get; set; }
    }

    public class NewQueueGeneric<T> //<T> - тип или generic параметр
    {
        QueueItemGeneric<T> head; //экземпляр класса QueueItem
        QueueItemGeneric<T> tail; //экземпляр класса QueueItem

        public bool IsEmpty
        {
            get { return head == null; }
        }

        public void EnqueueGeneric(T value)
        {
            if (head == null) //пустой список (изначально), то следующее действие (EnqueueGeneric) добавление первого элемента
                             //тут и tail = null
                //если всего 1 item
                head = tail = new QueueItemGeneric<T>
                {
                    Value = value,
                    Next = null
                };

            else //если уже появился 2 item
            {
                var item = new QueueItemGeneric<T>
                {
                    Value = value, 
                    Next = null
                };
                tail.Next = item; //кто стоит за мной в очереди
                tail = item; //очередь QueueItem начинает указывать на последнего (2го Iteam)
            }
        }

        public T DequeueGeneric()
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

    public class Program1234Generic
    {
        public static void Main1234()
        {
            var myIntQueue = new NewQueueGeneric<int>();
            myIntQueue.EnqueueGeneric(1);
            myIntQueue.EnqueueGeneric(2);
            myIntQueue.EnqueueGeneric(3);
            myIntQueue.DequeueGeneric();
            myIntQueue.DequeueGeneric();
            myIntQueue.DequeueGeneric();
            //myIntQueue.EnqueueGeneric("Ooops");

            var sum = 0;
            while (!myIntQueue.IsEmpty)
            {
                sum += myIntQueue.DequeueGeneric();
            }

            Console.WriteLine(sum);
        }
    }
}