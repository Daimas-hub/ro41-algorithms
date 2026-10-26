using System;
using System.Globalization;

namespace t01_srsp
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Блок «Ввод»: строка s
            Console.Write("Введите количество секунд (целое число, не меньше 0): ");
            string? s = Console.ReadLine();

            // Блок «Решение»: s — целое число?
            if (!long.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out long n))
            {
                // Ветка «Нет» -> «Вывод» ошибки -> «Конец»
                Console.WriteLine("Ошибка: нужно ввести целое число, например 3725.");
                return;
            }

            // Блок «Решение»: n < 0?
            if (n < 0)
            {
                // Ветка «Да» -> «Вывод» ошибки -> «Конец»
                Console.WriteLine("Ошибка: число секунд не может быть отрицательным.");
                return;
            }

            // Блоки «Процесс»
            long h = n / 3600;
            long r = n % 3600;
            long m = r / 60;
            long sec = r % 60;

            // Блок «Вывод»
            Console.WriteLine($"{n} с = {h} ч {m} мин {sec} с");
        }
    }
}
