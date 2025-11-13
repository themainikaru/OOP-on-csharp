using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_on_csharp
{
    internal class Pair<T1, T2>
    {
        private T1 _containingItem1;
        private T2 _containingItem2;
        public Pair(T1 item1, T2 item2) { _containingItem1 = item1; _containingItem2 = item2; }

        public T1 GetFirstItem()
        {
            return _containingItem1;
        }
        public T2 GetSecondItem()
        {
            return _containingItem2;
        }
    }
}