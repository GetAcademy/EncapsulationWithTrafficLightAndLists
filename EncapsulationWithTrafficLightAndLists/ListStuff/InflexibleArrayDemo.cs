namespace EncapsulationWithTrafficLightAndLists.ListStuff
{
    internal class InflexibleArrayDemo
    {
        /*
            Pause til 11:07
         */
        public static void Run()
        {
            var myFlexibleList = new MyFlexibleList();
            while (true)
            {
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                myFlexibleList.Add(number);
                myFlexibleList.Show();
            }
            //var numbers = new int[4];
            //var count = 0;
            //while (true)
            //{
            //    var numberStr = Console.ReadLine();
            //    var number = Convert.ToInt32(numberStr);
            //    var index = count;
            //    if (index >= numbers.Length)
            //    {
            //        Console.WriteLine("Lager ny array");
            //        var newNumbers = new int[numbers.Length * 2];
            //        Array.Copy(numbers, newNumbers, numbers.Length);
            //        numbers = newNumbers;
            //    }
            //    numbers[index] = number;
            //    count++;

            //    Console.WriteLine($"Count={count} Numbers={string.Join(',', numbers)}");
            //}
        }
    }
}
