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
        private class StackItem
        {
            public StackItem() 
            {
                string Current;
                StackItem Previous;
            }
        }

        List<string> _storage = new List<string>();

        public int Size 
        {
            get { return _storage.Count; }
        }

        public string Top
        {
            get 
            {
                if (_storage.Count > 0)
                {
                    return _storage[_storage.Count-1];

                }
                else
                {
                    return null;
                }           
            }
        }
        

        public Stack(params string[] strings) //конструктор для строк
        {
            
            foreach (var item in strings)
            {
                _storage.Add(item);
            }        
        }

        public void Add(string item) 
        {
            _storage.Add(item);
            Console.WriteLine($"В Stack добавлен новый элемент {item}");
        }

        public string Pop() 
        {
            if (_storage.Count>0)
            {
                string lastItem = _storage[_storage.Count - 1];
                //string lastItemCopy = lastItem;
                _storage.RemoveAt(_storage.Count - 1);
                return lastItem;
            }
            else 
            {

                throw new IndexOutOfRangeException("Стек пустой!");
                    
            }
        }
        

        public static Stack Concat(params Stack[] stackArray) 
        {
            var returnStack = new Stack();

            foreach (var itemStack in stackArray)
            {
                for (var i = itemStack.Size-1; i >= 0; i--)
                {
                    returnStack.Add(itemStack.Pop());
                }

            }

            return returnStack;
        
        }


        public void messageStorage()
        {
            string message = "";
            foreach (var item in _storage)
            {
                if (message != "")
                {
                    message += $",{item}";
                }
                else
                {
                    message += item;
                }


            }
            Console.WriteLine(message);
        }



    }
}
