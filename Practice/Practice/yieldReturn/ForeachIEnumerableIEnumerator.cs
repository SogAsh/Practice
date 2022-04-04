using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice.yieldReturn
{
    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

    public class Queue<T> : IEnumerable<T>
    {
        QueueItem<T> head; //экземпляр класса QueueItem
        QueueItem<T> tail; //экземпляр класса QueueItem

        private IEnumerable<T> _enumerableImplementation;

        public bool IsEmpty => head == null;

        #region MyRegion

        public void EnqueueGeneric(T value)
        {
            if (head == null) //пустой список (изначально), то следующее действие (EnqueueGeneric) добавление первого элемента
                //тут и tail = null
                //если всего 1 item
                head = tail = new QueueItem<T>
                {
                    Value = value,
                    Next = null
                };

            else //если уже появился 2 item
            {
                var item = new QueueItem<T>
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

        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class QueueEnumerator<T> : IEnumerator<T>
        {
            Queue<T> queue;
            QueueItem<T> iteam;

            public QueueEnumerator(Queue<T> queue)
            {
                this.queue = this.queue;
                iteam = null;
            }

            public T Current => iteam.Value;

            public bool MoveNext()
            {
                if (iteam == null)
                    iteam = queue.head;
                else
                    iteam = iteam.Next;
                return iteam != null;
            }

            #region MyRegion

            public void Dispose()
            {
            }

            public void Reset()
            {
            }

            object IEnumerator.Current => Current;

            #endregion
        }
    }

    public class Programc1234Generic
    {
        public static void Mainc1234()
        {
            var myIntQueue = new Queue<int>();
            myIntQueue.EnqueueGeneric(1);
            myIntQueue.EnqueueGeneric(2);
            myIntQueue.EnqueueGeneric(3);

            foreach (var value in myIntQueue)
            {
                Console.WriteLine(value);
            }
        }
    }
}