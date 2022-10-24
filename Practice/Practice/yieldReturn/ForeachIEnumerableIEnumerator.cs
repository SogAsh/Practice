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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            // return new QueueEnumerator<T>(this); //передав в QueueEnumerator<T> - this, т.е. передав тот объект их которого
            //вызывается (данамически) метод QueueEnumerator<T> 

            var current = head;
            while (current != null)
            {
                yield return current.Value; //yield - метод из которого можно выйти с какимто значением
                                            //а потом вернуться и продолжить
                current = current.Next;
            }
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