namespace EncapsulationWithTrafficLightAndLists.ListStuff
{
    internal class InflexibleArrayDemo
    {
        /*
         */
        public static void Run()
        {

            var list = new List<string>();
            while (true)
            {
                var text = Console.ReadLine();
                list.Add(text);
                Console.WriteLine(string.Join(',', list));
            }


            var myFlexibleList = new MyFlexibleList<string>();
            while (true)
            {
                var text = Console.ReadLine();
                myFlexibleList.Add(text);
                myFlexibleList.Show();
            }

            var myFlexibleList2 = new MyFlexibleList<int>();
            while (true)
            {
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                myFlexibleList2.Add(number);
                myFlexibleList2.Show();
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
