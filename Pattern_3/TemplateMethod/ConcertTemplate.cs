using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.TemplateMethod
{
    public class StackCollection<T> : TemplateCollection<T>
    {
        private Stack<T> _stack;
        public StackCollection()
        {
            _stack = new Stack<T>();
        }
        public override bool AddToBack(T item)
        {
            _stack.Push(item);
            return true;
        }
        public override bool RemoveFromBack()
        {
            if (_stack.Count > 0)
            {
                _stack.Pop();
                return true;
            }
            return false;
        }
        public override T GetFromBack()
        {
            return _stack.Peek();
        }

        public override bool IsEmpty()
        {
            return _stack.Count == 0;
        }
    }
    public class QueueCollection<T> : TemplateCollection<T>
    {
        private Queue<T> _queue;
        public QueueCollection()
        {
            _queue = new Queue<T>();
        }
        public override bool AddToBack(T item)
        {
            _queue.Enqueue(item);
            return true;
        }
        public override bool RemoveFromFront()
        {
            if (_queue.Count > 0)
            {
                _queue.Dequeue();
                return true;
            }
            return false;
        }
        public override T GetFromFront()
        {
            return _queue.Peek();
        }
        public override bool IsEmpty()
        {
            return _queue.Count == 0;
        }
    }

    public class ListCollection<T> : TemplateCollection<T>
    {
        private List<T> _list;
        public ListCollection()
        {
            _list = new List<T>();
        }
        public override bool AddToBack(T item)
        {
            _list.Add(item);
            return true;
        }
        public override bool RemoveFromBack()
        {
            if (_list.Count > 0)
            {
                _list.RemoveAt(_list.Count - 1);
                return true;
            }
            return false;
        }
        public override T GetFromBack()
        {
            return _list.Last();
        }
        public override T GetFromFront()
        {
            return _list.First();
        }
        public override bool IsEmpty()
        {
            return _list.Count == 0;
        }
    }
}
