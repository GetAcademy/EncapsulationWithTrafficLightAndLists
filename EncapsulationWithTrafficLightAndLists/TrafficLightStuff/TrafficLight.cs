namespace EncapsulationWithTrafficLightAndLists.TrafficLightStuff
{
    internal class TrafficLight
    {
        private int _phase;
        public bool IsRed => _phase is 1 or 2;
        public bool IsYellow => _phase is 2 or 4;
        public bool IsGreen => _phase == 3;


        public TrafficLight()
        {
            _phase = 1;
        }

        public void Show()
        {
            /*
            var isRed = _phase is 1 or 2;
            //var isRed = _phase < 3;
            var isYellow = _phase is 2 or 4;
            //var isYellow = _phase % 2 == 0;
            var isGreen = _phase == 3;
            */

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(IsRed ? ConsoleColor.Red : ConsoleColor.Gray);
            DrawLine(IsYellow ? ConsoleColor.Yellow : ConsoleColor.Gray);
            DrawLine(IsGreen ? ConsoleColor.Green : ConsoleColor.Gray);
            Console.WriteLine("┗━┛");
        }

        public void GoToNextPhase()
        {
            if (_phase == 4) _phase = 1;
            else _phase = _phase + 1;

            //_phase = _phase == 4 ? 1 : _phase + 1;

            //if (_isRed && !_isYellow && !_isGreen)
            //{
            //    _isYellow = true;
            //}
            //else if (_isRed && _isYellow && !_isGreen) {
            //    _isRed = false;
            //    _isYellow = false;
            //    _isGreen = true;
            //}
            //else if (!_isRed && !_isYellow && _isGreen)
            //{
            //    _isRed = false;
            //    _isYellow = true;
            //    _isGreen = false;
            //}
            //else 
            //{
            //    _isRed = true;
            //    _isYellow = false;
            //    _isGreen = false;
            //}
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
