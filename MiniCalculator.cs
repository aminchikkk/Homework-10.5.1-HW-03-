namespace Homework10._5._1__HW_03_
{
    public class MiniCalculator : IMiniCalculator
    {
        private static ILogger Logger { get; set; }

        public MiniCalculator(ILogger logger)
        {
            Logger = logger;
        }

        public void AddingNumbers(double firstNumber, double secondNumber)
        {
            Logger.Event("Mini-calculator начал свою работу.");
            Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber + secondNumber}");
            Logger.Event("Mini-calculator закончил свою работу.");
        }
    }
}