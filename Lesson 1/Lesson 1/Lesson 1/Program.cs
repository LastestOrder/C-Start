using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Дудин Николай */

            #region Task 1

            /* Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.*/

            Console.WriteLine("Программа <Анкета>\n");
            Console.Write("Введите Имя: ");
            string firsname = Console.ReadLine();
            Console.Write("Введите Фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите Рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите Вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine();
            // Склеивание строк
            string all = firsname + " " + lastname + " " + age + " " + height + " " + weight;
            Console.WriteLine(all);

            // Склеивание строк через форматирование
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", firsname, lastname, age, height, weight);

            // Интерполяция строк
            Console.WriteLine($"Анкета : {firsname} {lastname} {age} {height} {weight}");

            Console.WriteLine("\nДля перехода к следующей программе нажмите любую кнопку");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Task 2 

            /* Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. */

            Console.WriteLine("Программа <Индекс массы тела ИМТ>\n");

            Console.Write("Введите Массу (в кг.): ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите Рост (в м.): ");
            double h = double.Parse(Console.ReadLine());

            double i = m / (h * h);
            Console.WriteLine("\nИндекс массы телав = " + i);

            Console.WriteLine("\nДля перехода к следующей программе нажмите любую кнопку");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Task 3

            /* 
            а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            */

            Console.WriteLine("Программа <Расстояние между точками>\n");

            Console.Write("Введите координату x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("\nРасстояние между двумя точками = {0:F2}", r);
            Console.WriteLine("Расстояние между двумя точками = {0:F2}", Path(x1,x2,y1,y2));
            Console.WriteLine("\nДля перехода к следующей программе нажмите любую кнопку");
            Console.ReadLine();
            Console.Clear();


            #endregion

            #region Task 4

            /* 
            Написать программу обмена значениями двух переменных:
            а) с использованием третьей переменной;
	        б) *без использования третьей переменной.
            */

            Console.WriteLine("Программа <Обмен переменных>\n");

            Console.Write("Введите первую переменную: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую переменную: ");
            x2 = double.Parse(Console.ReadLine());

            double x3 = x1;
            x1 = x2;
            x2 = x3;
            
            Console.WriteLine("\nПосле смены. Первая переменная: " + x1 + " Вторая переменная: " + x2);

            x1 = x1 + x2;
            x2 = x1 - x2;
            x1 = x1 - x2;
            Console.WriteLine("После смены. Первая переменная: " + x1 + " Вторая переменная: " + x2);
            Console.WriteLine("\nДля перехода к следующей программе нажмите любую кнопку");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Task 5

            /* 
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) *Сделать задание, только вывод организовать в центре экрана.
            в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
            */

            Console.WriteLine("Программа <Вывод на экран>\n");

            Console.Write("Введите Имя: ");
            firsname = Console.ReadLine();
            Console.Write("Введите Фамилию: ");
            lastname = Console.ReadLine();
            Console.Write("Введите Город проживания: ");
            string town = Console.ReadLine();
           
            Console.WriteLine("\nИмя: " + firsname + " Фамилия: " + lastname + " Город проживания: " + town);
            all = firsname + lastname + town;
            int centerX = (Console.WindowWidth / 2) - (all.Length / 2) - 31;
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine("Имя: " + firsname + " Фамилия: " + lastname + " Город проживания: " + town);
            Console.WriteLine("\nДля перехода к следующей программе нажмите любую кнопку");
            Console.ReadLine();
            Console.Clear();

            #endregion

        }

        static double Path(double x1, double x2, double y1, double y2)

            {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
}
}
