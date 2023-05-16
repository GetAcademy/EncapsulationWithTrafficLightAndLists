namespace EncapsulationWithTrafficLightAndLists.TrafficLightStuff
{
    internal class TrafficLightDemo
    {
        public static void Run()
        {
            // Pause 10:33

            // let trafficLight = { isRed: true, isYellow: false, isGreen: false };

            var trafficLight = new TrafficLight();

            TrafficLightConsole.Write(trafficLight.isRed, trafficLight.isYellow, trafficLight.isGreen);

            if (trafficLight.isRed && !trafficLight.isYellow && !trafficLight.isGreen)
            {
                trafficLight.isYellow = true;
            }

            TrafficLightConsole.Write(trafficLight.isRed, trafficLight.isYellow, trafficLight.isGreen);


            // Refactoring
            // 1. variabel
            // 2. funksjon/metode
            // 3. klasse
        }
    }
}
