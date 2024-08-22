namespace Homework10._5._1__HW_03_
{
    internal class Program
    {
        private static ILogger Logger { get; set; }

        private static void Main(string[] args)
        {
            Logger = new Logger();
            var numbers = CheckNumbers.ReturnNumbers();
            MiniCalculator miniCalculator = new(Logger);
            miniCalculator.AddingNumbers(numbers.Item1, numbers.Item1);
        }
    }
}