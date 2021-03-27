using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void MinValue(int a, int b, int c)
        {
            if (b < a)
            {
                if (b < c)
                    Console.WriteLine("Минимальное число: {0}", b);
                else if (a < c)
                    Console.WriteLine("Минимальное число: {0}", a);
            }
            else Console.WriteLine("Минимальное число: {0}", c);

            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }

        static void Numbers(int a, int counter)
        {
            while (a != 0)
            {
                a = a / 10;
                counter++;
            }
            Console.WriteLine("Количество цифр в числе: {0}", counter);
            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }

        static bool Enter(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")

                return true;
            else
                return false;

        }

        static void AtoB(int a, int b, int sum)
        {

            if (a < b)
            {
                sum += a;
                Console.WriteLine(a);
                a++;
                AtoB(a, b, sum);
            }

            else
            {
                Console.WriteLine(sum);
            }
        }
        static void Task1()
        {
            //1.Написать метод, возвращающий минимальное из трёх чисел.
            Console.Clear();

            Console.WriteLine("Программа: Написания метода, возвращающий минимальное из трех чисел\n");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            MinValue(a, b, c);

        }
        static void Task2()
        {
            // 2. Написать метод подсчета количества цифр числа.
            Console.Clear();

            Console.WriteLine("Программа: Написать метод подсчета цифр числа\n");
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            Numbers(a, 0);
        }
        static void Task3()
        {
            // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.Clear();

            Console.WriteLine("Программа: Подсчет нечетных положительных чисел вводимых с клавиатуры.\n");
            Console.Write("Введите числа (0 - конец ввода): ");
            int a = 1;
            int sum = 0;
            do
            {

                a = int.Parse(Console.ReadLine());

                if (a % 2 == 1 && a >= 0)
                    sum += a;

            } while (a != 0);
            Console.WriteLine("Сумма нечетных положительных чисел равна: {0}", sum);
            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }
        static void Task4()
        {
            // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.Clear();

            Console.WriteLine("Программа: Реализовать метод проверки логина и пароля.\n");
            string login, password;
            int counter = 3;
            do
            {
                Console.Write("Введите логин ");
                login = Console.ReadLine();
                Console.Write("Введите пароль ");
                password = Console.ReadLine();
                if (Enter(login, password))
                {
                    Console.WriteLine("\nВход успешно выполнен");
                    break;
                }
                counter--;
                Console.WriteLine("\nПопыток осталось: " + counter);

            } while (counter != 0);
            if (counter == 0)
                Console.WriteLine("Попытки кончились");
            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }
        static void Task5()
        {
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            Console.Clear();

            Console.WriteLine("Программа: Рассчитывает индекс массы тела.\n");

            Console.Write("Введите свой рост (в м.): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите свой вес (в кг.): ");
            double weight = double.Parse(Console.ReadLine());
            double imt = weight / (height * height);
            if (imt < 16.5)
            {
                Console.WriteLine("\nВыраженный дефицит массы");
                double needweight = 19 * height * height - weight;
                Console.WriteLine("Нужно добрать " + needweight + " кг.");
            }

            if (imt >= 16.5 && imt < 18.49)
            {
                Console.WriteLine("\nНедостаточная (дефицит) масса тела");
                double needweight = 19 * height * height - weight;
                Console.WriteLine("Нужно добрать " + needweight + " кг.");
            }

            if (imt >= 18.5 && imt < 24.99)
            {
                Console.WriteLine("\nНорма");
                Console.WriteLine("У Вас отличный вес так держать");
            }

            if (imt >= 25 && imt < 29.99)
            {
                Console.WriteLine("\nИзбыточная масса тела (предожирение)");
                double needweight = weight - 24.9 * height * height;
                Console.WriteLine("Нужно сбросить " + needweight + " кг.");
            }

            if (imt >= 30 && imt < 34.99)
            {
                Console.WriteLine("\nОжирение первой степени");
                double needweight = weight - 24.9 * height * height;
                Console.WriteLine("Нужно сбросить " + needweight + " кг.");
            }

            if (imt >= 35 && imt < 39.99)
            {
                Console.WriteLine("\nОжирение второй степени");
                double needweight = weight - 24.9 * height * height;
                Console.WriteLine("Нужно сбросить " + needweight + " кг.");
            }

            if (imt >= 40)
            {
                Console.WriteLine("\nОжирение третьей степени (морбидное)");
                double needweight = weight - 24.9 * height * height;
                Console.WriteLine("Нужно сбросить " + needweight + " кг.");
            }

            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }
        static void Task6()
        {
            //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //«Хорошим» называется число, которое делится на сумму своих цифр.
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            Console.Clear();

            Console.WriteLine("Программа: Подсчет <Хороших> чисел от 1 до 1 000 000 000.\n");
            DateTime time = DateTime.Now;
            int a = 0;
            int counter = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                a = i;
                int sum = 0;
                do
                {
                    sum = sum + a % 10;
                    a /= 10;
                }
                while (a != 0);
                if (i % sum == 0)
                {
                    counter++;
                }

            }

            DateTime time2 = DateTime.Now;
            TimeSpan duration = time2 - time;
            // Console.WriteLine(DateTime.Now);
            Console.WriteLine("Количество чисел = " + counter);
            Console.WriteLine("На выполнение задачи потребовалось столько: " + duration + " секунд");
            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }
        static void Task7()
        {
            // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            Console.Clear();

            Console.WriteLine("Программа: Вывода чисел от числа A до числа B.\n");
            Console.Write("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            AtoB(a, b, 0);

            //Console.WriteLine("Сумма нечетных положительных чисел равна: {0}", sum);
            Console.WriteLine("\nДля продолжения нажмите любую кнопку");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int no = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в мою программу");
                Console.WriteLine("Выберу задачу из списка ниже\n");
                Console.WriteLine("Задача номер 1 Минимальное из трех чисел");
                Console.WriteLine("Задача номер 2 Подсчет цифр в числе");
                Console.WriteLine("Задача номер 3 Подсчет суммы всех нечетных чисел");
                Console.WriteLine("Задача номер 4 Проверка ввода логина и пароля");
                Console.WriteLine("Задача номер 5 Программа расчета Индекса массы тела");
                Console.WriteLine("Задача номер 6 Программа подсчета <Хороших> чисел");
                Console.WriteLine("Задача номер 7 Программа вывода числа от A до B");
                Console.Write("\nВведите номер задачи (0 - завершение работы программы): ");
                no = int.Parse(Console.ReadLine());
                switch (no)
                {
                    case 0: break;
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    case 6: Task6(); break;
                    case 7: Task7(); break;
                    default:
                        Console.WriteLine("Номер задачи введен некорректно. Пожалуйста, повторите попытку ввода.");
                        break;
                }

            }
            while (no != 0);
        }
    }
}
