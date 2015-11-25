using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchGeneric
{
    public static class OrderedArray 
    {
        //private T[] arr;
        //private int nElems;

        //public OrderedArray(int max)
        //{
        //    arr = new T[max];
        //    nElems = 0;
        //}
        //public int Size()
        //{
        //    return nElems;
        //}
        public static int BinaryFind<T>( T[] arr, T searchKey, IComparer<T> comparer) 
        {
            if (arr == null)
                throw new ArgumentNullException("arr is empty");
            if (comparer == null)
                throw new ArgumentException("comparer is null");
            comparer = comparer !=null ? comparer : Comparer<T>.Default;
            int lowerBound = 0;
            int upperBound = arr.Length  ;
            int curIn;
            while(true)
            {
                curIn = (lowerBound + upperBound) / 2;
                if (comparer.Compare(arr[curIn], searchKey) == 0)
                    return curIn;
                else if (lowerBound > upperBound)
                    return arr.Length;
                else
                {
                    if (comparer.Compare(arr[curIn], searchKey) == -1)
                        lowerBound = curIn + 1;
                    else
                        upperBound = curIn - 1;
                }
            }
        }
    }
}
