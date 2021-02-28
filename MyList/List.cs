using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public class List
    {
        private Box _head;
        private Box _tail;
        private Box _current;
        private int _count;




        public List()
        {
            _head = null;
            _tail = null;
            _count = 0;
            
        }

        public int Count {
            get
            {
                return _count;
            }
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

        public void Add(object value)
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



                // удаление элемента
        public bool Remove(object value)
        {
            Box current = _head;
            Box previous = null;
 
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
 
                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            _tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        _head = _head.Next;
 
                        // если после удаления список пуст, сбрасываем tail
                        if (_head == null)
                            _tail = null;
                    }
                    _count--;
                    return true;
                }
 
                previous = current;
                current = current.Next;
            }
            return false;
        }


    }

}
