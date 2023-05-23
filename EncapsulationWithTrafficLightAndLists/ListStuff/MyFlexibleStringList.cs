namespace EncapsulationWithTrafficLightAndLists.ListStuff
{
    internal class MyFlexibleStringList
    {
        private string[] _numbers;
        private int _count;

        public MyFlexibleStringList()
        {
            _numbers = new string[4];
        }

        public void Add(string text)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                Console.WriteLine("Lager ny array");
                var newNumbers = new string[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[index] = text;
            _count++;
        }

        public void Show()
        {
            Console.WriteLine($"Count={_count} Numbers={string.Join(',', _numbers)}");
        }
    }
}
