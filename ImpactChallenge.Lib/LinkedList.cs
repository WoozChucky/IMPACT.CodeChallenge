using System;

namespace ImpactChallenge.Lib
{
    public class LinkedList<T> : ILinkedList<T> where T : IEquatable<T>
    {
        private Node<T> _head;

        public LinkedList()
        {
            _head = null;
        }

        public void AddFirst(T obj) 
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            _head = new Node<T>
            {
                Data = obj,
                Next = _head
            };
        }

        public void AddLast(T obj) 
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            if (_head == null)
            {
                _head = new Node<T> {Data = obj, Next = null};
            }
            else
            {
                var newNode = new Node<T> {Data = obj};

                var current = _head;
                
                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void AddAfter(T after, T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            var current = _head;
                
            while(current != null)
            {
                if (Equals(current.Data, after))
                {
                    current.Next = new Node<T>
                    {
                        Data = obj,
                        Next = current.Next
                    };
                    break;
                }
                current = current.Next;
            }
        }

        public void AddBefore(T before, T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            var current = _head;
            var previous = current;
                
            while(current != null)
            {
                if (Equals(current.Data, before))
                {
                    previous.Next = new Node<T>
                    {
                        Data = obj,
                        Next = previous.Next
                    };
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }

        public T Find(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            throw new NotImplementedException();
            
            return default(T);
        }

        public T FindLast(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            throw new NotImplementedException();
            
            return default(T);
        }

        public bool Contains(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            var current = _head;

            while (current != null)
            {
                if (Equals(obj, current.Data))
                    return true;

                current = current.Next;
            }
            
            return false;
        }

        public T GetFirst()
        {
            return _head != null 
                ? _head.Data 
                : default(T);
        }

        public T GetLast()
        {
            var current = _head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            return current.Data != null 
                ? current.Data 
                : default(T);
        }

        public T this[uint index] => FindByIndex(index);

        private T FindByIndex(uint index)
        {
            var current = _head;
            var i = 0;
                
            while(current != null)
            {
                if (i == index)
                    return current.Data;
                
                current = current.Next;

                i++;
            }

            return default(T);
        }
    }
}