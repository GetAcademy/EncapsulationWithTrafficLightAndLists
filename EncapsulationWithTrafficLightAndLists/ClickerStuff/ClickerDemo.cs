namespace EncapsulationWithTrafficLightAndLists.ClickerStuff
{
    internal class ClickerDemo
    {
        public static void Run()
        {
            var clickerA = new Clicker("A");
            var clickerB = new Clicker("B");
            var clickerC = new Clicker("C");
            clickerA.ClickAndShow();
            clickerA.ClickAndShow();
            clickerB.ClickAndShow();
            clickerA.ClickAndShow();
            clickerB.ClickAndShow();
        }
    }
}
