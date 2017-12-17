using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_FP_Workshop
{
    public class PureList<T>
    {
        private readonly T[] initItems;

        public int Length { get; }

        [Pure]
        public PureList(params T[] items)
        {
            initItems = items;
            Length = items.Length;
        }

        public T this[int index]
        {
            get
            {
                return initItems[index];
            }
        }
    }
}