using System;

namespace OOP_on_csharp
{
    public class Box<T>
    {
        private T _containingItem;
        public Box(T item) => _containingItem = item;

        public void Put(T item)
        {
            _containingItem = item;
        }
        public T Get()
        {
            return _containingItem;
        }
    }
}