namespace EncapsulationWithTrafficLightAndLists.ClickerStuff
{
    internal class Clicker
    {
        private static int _countOfClickerObjects;
        private static int _totalClicks;
        private int _count;
        private string _name;

        public Clicker(string name)
        {
            _name = name;
            _countOfClickerObjects++; // hvor mange ganger er Clicker new-et
        }

        public void ClickAndShow()
        {
            _count++;
            _totalClicks++;
            Console.WriteLine($"{_name} => {_count} (totalt: {_totalClicks})");
        }
    }
}
