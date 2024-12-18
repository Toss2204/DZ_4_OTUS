using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_OTUS
{


    public class Stack
    {

        ////**через коллекцию лист все работает, просто эти методы закомментил, когда придумал как через класс делать.

        //List<string> _storage = new List<string>();

        //public int size
        //{
        //    get { return _storage.Count; }
        //}

        //public string Top
        //{
        //    get
        //    {
        //        if (_storage.Count > 0)
        //        {
        //            return _storage[_storage.Count - 1];

        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}


        //public Stack(params string[] strings) //конструктор для строк
        //{

        //    foreach (var item in strings)
        //    {
        //        _storage.Add(item);
        //    }
        //}

        //public void Add(string item)
        //{
        //    _storage.Add(item);
        //    Console.WriteLine($"В Stack добавлен новый элемент {item}");
        //}

        //public string Pop()
        //{
        //    if (_storage.Count > 0)
        //    {
        //        string lastItem = _storage[_storage.Count - 1];
        //        //string lastItemCopy = lastItem;
        //        _storage.RemoveAt(_storage.Count - 1);
        //        return lastItem;
        //    }
        //    else
        //    {

        //        throw new IndexOutOfRangeException("Стек пустой!");

        //    }
        //}

        //public void messageStorage()
        //{
        //    string message = "";
        //    foreach (var item in _storage)
        //    {
        //        if (message != "")
        //        {
        //            message += $",{item}";
        //        }
        //        else
        //        {
        //            message += item;
        //        }


        //    }
        //    Console.WriteLine(message);
        //}


        ////**через класс СтекИтем
        public int size = 0;
        private StackItem item = null;

        public Stack(params string[] values)
        {
            if (values != null && values.Length > 0)
            {
                foreach (string value in values)
                {
                    Add(value);
                }
            }
        }

        public string Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Стек пустой!");
            }

            string value = item.value;
            item = item.previousItem;

            size--;
            return value;
        }


        public string Top
        {
            get { return item == null ? null : item.value; }
        }

        public void Add(string value)
        {
            StackItem newItem = new StackItem();
            if (item != null)
            {
                newItem.previousItem = item;
            }

            newItem.value = value;
            item = newItem;

            size++;
        }

        class StackItem
        {
            public string value { get; set; }
            public StackItem previousItem { get; set; }
        }

        public void messageStorage()
        {
            string message = "";
            StackItem item_new = item;

            for (int i = 0; i < size; i++)
            {
                if (message != "")
                {
                    message += $",{item_new.value}";
                }
                else
                {
                    message += item_new.value;
                }
                item_new = item_new.previousItem;

            }
            char[] charArr = message.ToCharArray();
            Array.Reverse(charArr);

            message = new string(charArr);
            Console.WriteLine(message);
        }
        //\через класс СтекИтем

        public static Stack Concat(params Stack[] stackArray)
        {
            var returnStack = new Stack();

            foreach (Stack itemStack in stackArray)
            {
                for (var i = itemStack.size - 1; i >= 0; i--)
                {
                    returnStack.Add(itemStack.Pop());
                }

            }

            return returnStack;

        }


 



    }
}
