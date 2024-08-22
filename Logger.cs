namespace Homework10._5._1__HW_03_
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
           Console.BackgroundColor = ConsoleColor.Red;
           Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black; 
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
