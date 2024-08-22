namespace Homework10._5._1__HW_03_
{
    internal class CheckNumbers
    {
        private static double _theFirstNumber = 0,
                 _theSecondNumber = 0;

        private static string _check = "Проверка числа прошла успешно.";

        public static (double, double) ReturnNumbers()
        {
            do
            {
                Console.Write("Введите 1 число: ");
                string? stringFirstNumber = Console.ReadLine();
                try
                {
                    _theFirstNumber = double.Parse(stringFirstNumber);
                }
                catch
                {
                    Console.WriteLine("Попробуйте ввести еще раз 1 число");
                }
                finally
                {
                    Console.WriteLine(_check);
                }
            } while (_theFirstNumber == 0);
            do
            {
                Console.Write("Введите 2 число: ");
                string? secondNumber = Console.ReadLine();
                try
                {
                    _theSecondNumber = double.Parse(secondNumber);
                }
                catch
                {
                    Console.WriteLine("Попробуйте ввести еще раз 2 число");
                }
                finally
                {
                    Console.WriteLine(_check);
                }
            } while (_theSecondNumber == 0);
            return (_theFirstNumber, _theSecondNumber);
        }
    }
}