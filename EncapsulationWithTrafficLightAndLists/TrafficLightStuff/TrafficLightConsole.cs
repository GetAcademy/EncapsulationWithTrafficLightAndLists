using System.Text;

namespace EncapsulationWithTrafficLightAndLists.TrafficLightStuff
{
    internal class TrafficLightConsole
    {
        public static void Write(bool isRedOn, bool isYellowOn, bool isGreenOn)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(isRedOn ? ConsoleColor.Red : ConsoleColor.Gray);
            DrawLine(isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray);
            DrawLine(isGreenOn ? ConsoleColor.Green : ConsoleColor.Gray);
            Console.WriteLine("┗━┛");
        }

        private static void DrawLine(ConsoleColor color)
        {
            var foregroundColor = Console.ForegroundColor;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("●");
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine("┃");
        }
    }
}
