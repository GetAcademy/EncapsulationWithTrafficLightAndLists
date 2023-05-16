namespace EncapsulationWithTrafficLightAndLists.TrafficLightStuff
{
    internal class TrafficLight
    {
        private bool _isRed;
        private bool _isYellow;
        private bool _isGreen;

        public TrafficLight()
        {
            _isRed = true;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(_isRed ? ConsoleColor.Red : ConsoleColor.Gray);
            DrawLine(_isYellow ? ConsoleColor.Yellow : ConsoleColor.Gray);
            DrawLine(_isGreen ? ConsoleColor.Green : ConsoleColor.Gray);
            Console.WriteLine("┗━┛");
        }

        public void GoToNextPhase()
        {
            if (_isRed && !_isYellow && !_isGreen)
            {
                _isYellow = true;
            }
            else if (_isRed && _isYellow && !_isGreen) {
                _isRed = false;
                _isYellow = false;
                _isGreen = true;
            }
            else if (!_isRed && !_isYellow && _isGreen)
            {
                _isRed = false;
                _isYellow = true;
                _isGreen = false;
            }
            else 
            {
                _isRed = true;
                _isYellow = false;
                _isGreen = false;
            }
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
