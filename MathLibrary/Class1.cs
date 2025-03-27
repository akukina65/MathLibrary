using System;

namespace MathLibrary
{
    /// <summary>
    /// Предоставляет набор логических операций.
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Выполняет операцию AND над двумя логическими значениями.
        /// </summary>
        /// <param name="a">Первое логическое значение.</param>
        /// <param name="b">Второе логическое значение.</param>
        /// <returns>Результат операции AND.</returns>
        public bool AndOperation(bool a, bool b)
        {
            return a && b;
        }

        /// <summary>
        /// Выполняет операцию OR над двумя логическими значениями.
        /// </summary>
        /// <param name="a">Первое логическое значение.</param>
        /// <param name="b">Второе логическое значение.</param>
        /// <returns>Результат операции OR.</returns>
        public bool OrOperation(bool a, bool b)
        {
            return a || b;
        }

        /// <summary>
        /// Выполняет операцию NOT над логическим значением.
        /// </summary>
        /// <param name="a">Логическое значение.</param>
        /// <returns>Результат операции NOT.</returns>
        public bool NotOperation(bool a)
        {
            return !a;
        }

        /// <summary>
        /// Выполняет операцию XOR (Conjunction) над двумя логическими значениями.
        /// </summary>
        /// <param name="a">Первое логическое значение.</param>
        /// <param name="b">Второе логическое значение.</param>
        /// <returns>Результат операции XOR.</returns>
        public bool ConOperation(bool a, bool b)
        {
            return a ^ b;
        }

        /// <summary>
        /// Вычисляет логическое выражение в виде строки ("TRUE" или "FALSE").
        /// </summary>
        /// <param name="ex">Логическое выражение ("TRUE" или "FALSE").</param>
        /// <returns>Результат вычисления (true или false).</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если выражение не является "TRUE" или "FALSE", или если строка пуста.</exception>
        public bool Evaluate(string ex)
        {
            try
            {
                if (string.IsNullOrEmpty(ex))
                {
                    throw new ArgumentException("Выражение не должно быть пустым ");
                }
                ex = ex.ToUpper();
                if (ex == "TRUE")
                {
                    return true;
                }
                else if (ex == "FALSE")
                {
                    return false;
                }
                else
                {
                    throw new ArgumentException("Неподдерживаемое выражение.Используйте TRUE или FALSE ");
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Ошибка при вычислении логического выражения " + e);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Class1
            Class1 logic = new Class1();

            // Объявляем и инициализируем переменные a и b
            bool a = true;
            bool b = false;

            // Вызываем методы библиотеки и выводим результаты в консоль
            Console.WriteLine("AND: " + logic.AndOperation(a, b));
            Console.WriteLine("OR: " + logic.OrOperation(a, b));
            Console.WriteLine("NOT a: " + logic.NotOperation(a));
            Console.WriteLine("XOR: " + logic.ConOperation(a, b));

            // Обрабатываем возможные исключения при вызове метода Evaluate
            try
            {
                Console.WriteLine("Evaluate TRUE: " + logic.Evaluate("TRUE"));
                Console.WriteLine("Evaluate FALSE: " + logic.Evaluate("FALSE"));
                Console.WriteLine("Evaluate INVALID: " + logic.Evaluate("INVALID")); // Вызовет исключение
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }

}
