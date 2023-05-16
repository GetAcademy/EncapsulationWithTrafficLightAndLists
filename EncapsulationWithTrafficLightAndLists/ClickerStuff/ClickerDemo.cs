namespace EncapsulationWithTrafficLightAndLists.ClickerStuff
{
    internal class ClickerDemo
    {
        public static void Run()
        {
            var clickerA = new Clicker("A");
            var clickerB = new Clicker("B");
            clickerA.Click();
            clickerA.Click();
            clickerB.Click();
            clickerA.Click();
            clickerB.Click();
        }
    }
}
