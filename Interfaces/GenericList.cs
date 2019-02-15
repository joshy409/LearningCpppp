using System;

namespace Generics
{
    //  generic type constraints 
    //  where T : IComparable   : implements IComparable interface
    //  where T : Product       : T is children
    //  where T : struct        : T is value type
    //  where T : class         : T is reference type
    //  where T : new()         : T is object that has default constructor
    public class GenericList<T> where T: IComparable
    {
        private readonly T[] _numbers;

        public GenericList()
        {
            _numbers = new T[10];
        }

        public void Add(int index, T number)
        {
            _numbers[index] = number;
        }
        public T this[int index] => _numbers[index];
    }
}
