
namespace MyList
{
    class Queue
    {
        private Box _head;
        private Box _tail;
        private Box _current;
        private int _count;

        public Queue()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public object Current
        {
            get
            {
                return _current.Value;
            }
        }
        public bool MoveNext()
        {
            if (_current == null)
            {
                return false;
            }

            _current = _current.Next;

            return _current != null;
        }


        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Enqueue(object value)
        {
            Box box = new Box(value);

            if (_head == null && _tail == null)
            {
                _head = box;
                _current = box;
                _tail = box;
            }
            else
            {
                _tail.Next = box;
                _tail = box;
            }
            _count++;
        }

        public object Dequeue()
        // сделать так , что бы хвост не оставался 

        {
            if (_head == null)
            {
                return  0;
            }

            object value = _head.Value;
            _head = _head.Next;
            _current = _head;
            _count--;

            if (_count == 0)
                _tail = null;
            
            return value;
        }


    }
}
