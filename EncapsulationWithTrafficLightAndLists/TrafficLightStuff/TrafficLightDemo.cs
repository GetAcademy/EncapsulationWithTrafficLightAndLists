namespace EncapsulationWithTrafficLightAndLists.TrafficLightStuff
{
    internal class TrafficLightDemo
    {
        public static void Run()
        {
            // let trafficLight = { isRed: true, isYellow: false, isGreen: false };

            var trafficLight = new TrafficLight();
            trafficLight.Show();
            trafficLight.GoToNextPhase();
            trafficLight.Show();
            trafficLight.GoToNextPhase();
            trafficLight.Show();
            trafficLight.GoToNextPhase(); 
            trafficLight.Show();
            trafficLight.GoToNextPhase();
            trafficLight.Show();

            // Refactoring
            // 1. variabel
            // 2. funksjon/metode
            // 3. klasse
        }
    }
}
