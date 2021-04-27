using Microsoft.CodeAnalysis;

namespace CustomStack
{
    public class SinglyLinkedStack<T>
    {
        private Node<T> last;

        public Optional<T> Last { 
            get 
            {
                if (last == null)
                {
                    return new Optional<T>();
                }
                return new Optional<T>(last.Value); 
            } 
        }
        public int Count { get; private set; }
        public SinglyLinkedStack()
        {
            last = null;
            Count = 0;
        }
        
        public void Push(T value)
        {
            var node = new Node<T>
            {
                Value = value,
                Next = last
            };
            last = node;
            Count++;
        }
        public bool Pop()
        {
            if (last != null)
            {
                last = last.Next;
                Count--;
                return true;
            }
            return false;
        }
        public void Clear()
        {
            last = null;
        }
    }
}
