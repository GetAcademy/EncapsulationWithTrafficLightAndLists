namespace EncapsulationWithTrafficLightAndLists.ListStuff
{
    internal class MyFlexibleIntList
    {
        private int[] _numbers;
        private int _count;

        public MyFlexibleIntList()
        {
            _numbers = new int[4];
        }

        public void Add(int number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                Console.WriteLine("Lager ny array");
                var newNumbers = new int[_numbers.Length * 2];
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
