namespace Calculator
{
    internal class RoutedEventArgs
    {
        private object clickEvent;

        public RoutedEventArgs(object clickEvent)
        {
            this.clickEvent = clickEvent;
        }
    }
}