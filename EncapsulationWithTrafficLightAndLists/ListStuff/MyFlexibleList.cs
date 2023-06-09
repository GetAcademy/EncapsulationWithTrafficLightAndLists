﻿namespace EncapsulationWithTrafficLightAndLists.ListStuff
{
    internal class MyFlexibleList<T>
    {
        private T[] _numbers;
        private int _count;

        public MyFlexibleList()
        {
            _numbers = new T[4];
        }

        public void Add(T number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                Console.WriteLine("Lager ny array");
                var newNumbers = new T[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[index] = number;
            _count++;
        }

        public void Show()
        {
            Console.WriteLine($"Count={_count} Numbers={string.Join(',', _numbers)}");
        }
    }
}
