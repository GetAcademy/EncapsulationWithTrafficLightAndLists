namespace EncapsulationWithTrafficLightAndLists.ClickerStuff
{
    internal class Clicker
    {
        private int _count;
        private string _name;

        public Clicker(string name)
        {
            _name = name;
        }

        public void Click()
        {
            _count++;
            Console.WriteLine($"{_name} => {_count}");
        }
    }
}
