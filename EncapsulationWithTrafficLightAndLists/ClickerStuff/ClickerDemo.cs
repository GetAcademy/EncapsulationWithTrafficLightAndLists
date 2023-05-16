namespace EncapsulationWithTrafficLightAndLists.ClickerStuff
{
    internal class ClickerDemo
    {
        public static void Run()
        {
            var clickerA = new Clicker("A");
            var clickerB = new Clicker("B");
            var clickerC = new Clicker("C");
            while (true)
            {
                var character = Console.ReadLine();
                Clicker clicker = null;
                if (character == "A") clicker = clickerA;
                else if (character == "B") clicker = clickerB;
                else clicker = clickerC;

                // var clicker =
                // character == "A" ? clickerA :
                // character == "B" ? clickerB :
                // clickerC;
                clicker.ClickAndShow();
                var count = clicker.Count;
                //clicker.Count = -17;
                if (count == 10)
                {
                    break;
                }
            }
        }
    }
}
