namespace EncapsulationWithTrafficLightAndLists.ClickerStuff
{
    internal class Clicker
    {
        private static int _countOfClickerObjects;
        private static int _totalClicks;
        public int Count { get; private set; }
        private string _name;

        public Clicker(string name)
        {
            Count = 0;
            _name = name;
            _countOfClickerObjects++; // hvor mange ganger er Clicker new-et
        }

        public void ClickAndShow()
        {
            Count++;
            _totalClicks++;
            Console.WriteLine($"{_name} => {Count} (totalt: {_totalClicks})");
        }

        /*
            Uten propertyen public int Count { get; private set; }
            kunne vi fått til det samme med en privat objektvariabel

                private int _count;

            og en public metode for å lese verdien utenfra:
                
                public int GetCount()
                {
                    return _count;
                }
         */

    }
}
