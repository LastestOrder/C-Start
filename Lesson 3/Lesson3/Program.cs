using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    struct Complex
    {

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        public Complex Addition(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;

            return y;
        }

        public Complex Subtraction(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public Complex Multiplication(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = x.re * im + re * x.im;
            return y;
        }

        public Complex Division(Complex x)
        {
            Complex y;
            y.re = (re * x.re + im * x.im) / (x.re * x.re + x.im * x.im);
            y.im = (x.re * im - re * x.im) / (x.re * x.re + x.im * x.im);
            return y;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

    }

    class Fraction
    {
        #region Поля

        /// <summary>
        /// Числитель дроби numerator
        /// </summary>
        private double num;

        /// <summary>
        /// Знаменатель дроби denominator
        /// </summary>
        private double den;

        #endregion

        #region Свойства

        public double Den
        {

            get { return den; }
            set
            {
                if (value == 0)
                    throw new Exception("Знаменатель не может быть равен нулю");
                den = value;
            }

        }

        public double Num
        {
            get { return num; }
            set { num = value; }
        }

        #endregion

        #region Конструктор

        public Fraction()
        {

        }

        //public Fraction(double num, double den)
        //{
        //    if (den == 0)
        //        throw new Exception("Знаменатель не может быть равен нулю");

        //    this.num = num;
        //    this.den = den;
        //}

        #endregion

        #region Публичные методы

        public override string ToString()
        {
            return $"{num} / {den}";
        }

        private Fraction Reduction(Fraction x)
        {

            Fraction y = new Fraction();
            double max = x.num > x.den ? x.num : x.den;

            for (double i = 2; i < max; i++)
            {
                if (x.num % i == 0 && x.den % i == 0)
                {
                    
                    x.num /= i;
                    x.den /= i;
                    i = 1;
                }
            }
            return x;
        }
        public Fraction Addition(Fraction x)
        {

            Fraction y = new Fraction();

            y.Num = num * x.den + x.num * den;
            y.Den = den * x.den;

            y = Reduction(y);
            return y;
        }

        public Fraction Subtraction(Fraction x)
        {
            Fraction y = new Fraction();
            y.Num = num * x.den - x.num * den;
            y.Den = den * x.den;

            y = Reduction(y);

            return y;
        }

        public Fraction Multiplication(Fraction x)
        {
            Fraction y = new Fraction();
            y.Num = num * x.num;
            y.Den = den * x.den;

            y = Reduction(y);

            return y;
        }

        public Fraction Division(Fraction x)
        {
            Fraction y = new Fraction();
            y.Num = num * x.den;
            y.Den = den * x.num;

            y = Reduction(y);

            return y;
        }
        #endregion


    }
    class Program
    {
        static void Continue()
        {
            Console.Write("\nДля продолжения нажмите кнопку ");
            Console.ReadLine();
        }

        static int Check(ref bool res1)
        {

            res1 = int.TryParse(Console.ReadLine(), out int result);
            if (res1)
            {
                return result;
            }
            else
            {
                Console.WriteLine("\nВы ввели некорректное число\n");
                return -1;
            }

        }

        static void Task1()
        {

            Console.Clear();

            int number;
            bool res1 = false, res2 = false, res3 = false, res4 = false;

            Console.WriteLine("Программа 1: Работа с комплексными числами\n");

            Complex complex01;
            Complex complex02;

            complex01.re = 0;
            complex01.im = 0;
            complex02.re = 0;
            complex02.im = 0;

            #region Ввод комплексных чисел

            do
            {

                Console.Write("Введите Действительную часть первого комплексного числа: ");

                complex01.re = Check(ref res1);
                //res1 = int.TryParse(Console.ReadLine(), out int re1);

                //if (res1)
                //{
                //    complex01.re = re1;
                //}
                //else
                //{
                //    Console.WriteLine("\nВы ввели некорректное число\n");
                //}


            } while (!res1);

            do
            {
                Console.Write("Введите Мнимую часть первого комплексного числа: ");
                complex01.im = Check(ref res2);
                // res2 = int.TryParse(Console.ReadLine(), out int im1);

                //if (res2)
                //{
                //    complex01.im = im1;
                //}
                //else
                //{
                //    Console.WriteLine("\nВы ввели некорректное число\n");
                //}

            } while (!res2);

            do
            {

                Console.Write("Введите Действительную часть второго комплексного числа: ");
                complex02.re = Check(ref res3);
                //res3 = int.TryParse(Console.ReadLine(), out int re2);

                //if (res3)
                //{
                //    complex02.re = re2;
                //}
                //else
                //{
                //    Console.WriteLine("\nВы ввели некорректное число\n");
                //}

            } while (!res3);

            do
            {
                Console.Write("Введите Мнимую часть второго комплексного числа: ");
                complex02.im = Check(ref res4);
                //res4 = int.TryParse(Console.ReadLine(), out int im2);

                //if (res4)
                //{
                //    complex02.im = im2;
                //}
                //else
                //{
                //    Console.WriteLine("\nВы ввели некорректное число\n");
                //}

            } while (!res4);

            #endregion

            #region Выполнение задачи
            do
            {
                Console.Clear();
                Console.WriteLine("Первое комплексное число: {0}", complex01);
                Console.WriteLine($"Второе комплексное число: {complex02}\n");
                Console.WriteLine("Действие 1 Сложение");
                Console.WriteLine("Действие 2 Вычитание");
                Console.WriteLine("Действие 3 Умножение");
                Console.WriteLine("Действие 4 Деление\n");
                Console.WriteLine("Действие 5 Повторить ввод\n");

                Console.WriteLine("Задача 0: Выход из Задачи");
                Console.Write("\nДля продолжения выберите номер задания с которым хотите ознакомиться: ");

                bool res = int.TryParse(Console.ReadLine(), out number);

                if (res)
                {
                    switch (number)
                    {
                        case 0: break;
                        case 1:
                            Complex complex03 = complex01.Addition(complex02);
                            Console.WriteLine($"\n({complex01}) + ({complex02}) = ({complex03})");
                            Continue();
                            break;
                        case 2:
                            complex03 = complex01.Subtraction(complex02);
                            Console.WriteLine($"\n({complex01}) - ({complex02}) = ({complex03})");
                            Continue();
                            break;
                        case 3:
                            complex03 = complex01.Multiplication(complex02);
                            Console.WriteLine($"\n({complex01}) * ({complex02}) = ({complex03})");
                            Continue();
                            break;
                        case 4:
                            complex03 = complex01.Division(complex02);
                            Console.WriteLine($"\n({complex01}) / ({complex02}) = ({complex03})");
                            Continue();
                            break;
                        case 5: Task3(); break;
                        default:
                            Console.WriteLine("Номер действия введен некорректно. Пожалуйста, повторите попытку ввода.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число");
                }

            } while (number != 0);

            #endregion

        }

        static void Task2()
        {

            Console.Clear();

            Console.WriteLine("Программа 2: Подсчет нечетных положительны чисел\n");

            int resultat, sum = 0;
            bool res;

            do
            {

                do
                {

                    Console.Write("Введите числа (0 - конец ввода): ");
                    res = int.TryParse(Console.ReadLine(), out resultat);

                    if (res)
                    {
                        if (resultat % 2 == 1 && resultat > 0)
                        {
                            sum += resultat;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВы ввели некорректное число\n");
                    }

                } while (!res);
            } while (resultat != 0);

            Console.WriteLine($"\nСумма нечетных положительных чисел = {sum}");
            Continue();
        }


        static void Task3()
        {

            Console.Clear();

            int number;
            bool res1 = false, res2 = false, res3 = false, res4 = false;

            Console.WriteLine("Программа 1: Работа с дробями\n");

            Fraction fraction01 = new Fraction();
            Fraction fraction02 = new Fraction();

            fraction01.Num = 1;
            fraction01.Den = 1;
            fraction02.Num = 1;
            fraction02.Den = 1;

            #region Ввод дробных чисел

            do
            {
                Console.Write("Введите Числитель первой дроби: ");
                fraction01.Num = Check(ref res1);

            } while (!res1);

            do
            {
                Console.Write("Введите Знаменатель первой дроби: ");
                fraction01.Den = Check(ref res2);

            } while (!res2);

            do
            {
                Console.Write("Введите Числитель второй дроби: ");
                fraction02.Num = Check(ref res3);

            } while (!res3);

            do
            {
                Console.Write("Введите Знаменатель второй дроби: ");
                fraction02.Den = Check(ref res4);

            } while (!res4);

            #endregion

            #region Работа с дробями

            do
            {
                Console.Clear();
                Console.WriteLine("Первое дробное число: {0}", fraction01);
                Console.WriteLine($"Второе дробное число: {fraction02}\n");
                Console.WriteLine("Действие 1 Сложение");
                Console.WriteLine("Действие 2 Вычитание");
                Console.WriteLine("Действие 3 Умножение");
                Console.WriteLine("Действие 4 Деление\n");
                Console.WriteLine("Действие 5 Повторить ввод\n");

                Console.WriteLine("Задача 0: Выход из Задачи");
                Console.Write("\nДля продолжения выберите номер задания с которым хотите ознакомиться: ");

                bool res = int.TryParse(Console.ReadLine(), out number);

                if (res)
                {
                    switch (number)
                    {
                        case 0: break;
                        case 1:
                            Fraction fraction03 = fraction01.Addition(fraction02);
                            Console.WriteLine($"\n({fraction01}) + ({fraction02}) = ({fraction03})");
                            Continue();
                            break;
                        case 2:
                            fraction03 = fraction01.Subtraction(fraction02);
                            Console.WriteLine($"\n({fraction01}) - ({fraction02}) = ({fraction03})");
                            Continue();
                            break;
                        case 3:
                            fraction03 = fraction01.Multiplication(fraction02);
                            Console.WriteLine($"\n({fraction01}) * ({fraction02}) = ({fraction03})");
                            Continue();
                            break;
                        case 4:
                            fraction03 = fraction01.Division(fraction02);
                            Console.WriteLine($"\n({fraction01}) / ({fraction02}) = ({fraction03})");
                            Continue();
                            break;
                        case 5: Task3(); break;
                        default:
                            Console.WriteLine("Номер действия введен некорректно. Пожалуйста, повторите попытку ввода.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число");
                }

            } while (number != 0);

            #endregion
        }
        static void Main(string[] args)
        {

            int number = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Программа ученика Дудина Николая\n");

                Console.WriteLine("Задача 1: Структура и комплексные числа");
                Console.WriteLine("Задача 2: Подсчет нечетных положительны чисел");
                Console.WriteLine("Задача 3: Класс и дроби");

                Console.WriteLine("\nЗадача 0: Выход из программы");

                Console.Write("\nДля продолжения выберите номер задания с которым хотите ознакомиться ");

                bool res = int.TryParse(Console.ReadLine(), out number);

                if (res)
                {
                    switch (number)
                    {
                        case 0: break;
                        case 1: Task1(); break;
                        case 2: Task2(); break;
                        case 3: Task3(); break;
                        default:
                            Console.WriteLine("Номер задачи введен некорректно. Пожалуйста, повторите попытку ввода.");
                            Continue();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число");
                }

            } while (number != 0);

        }
    }
}
