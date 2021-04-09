using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    delegate double DoOparation(double x, double y);

    delegate double Function(double x, double a, double b, double c);

    class Students
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Institute { get; set; }
        public string Faculty { get; set; }
        public string Direction { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public string Town { get; set; }

    }
    class Program
    {
        #region Function Task2

        //a * x + b
        public static double Func1(double x, double a, double b, double c)
        {
            Console.Write($"{a} * {x} + {b} = {(a * x + b):F2}\n");
            return a * x + b;
        }

        //a * x^2 + b * x + c
        public static double Func2(double x, double a, double b, double c)
        {
            Console.Write($"{a} * {x} ^ 2 + {b} * {x} + {c} = {(a * x * x + b * x + c):F2}\n");
            return a * x * x + b * x + c;
        }

        //a * sin(x) + b * cos(x)
        public static double Func3(double x, double a, double b, double c)
        {
            Console.Write($"{a} * sin({x}) + {b} * cos({x}) = {(a * Math.Sin(x) + b * Math.Cos(x)):F2}\n");
            return a * Math.Sin(x) + b * Math.Cos(x);
        }

        //a * sqrt(x) + b * log(x)
        public static double Func4(double x, double a, double b, double c)
        {
            Console.Write($"{a} * sqrt({x}) + {b} * log({x}) = {(a * Math.Sqrt(x) + b * Math.Log(x)):F2}\n");
            return a * Math.Sqrt(x) + b * Math.Log(x);

        }

        #endregion

        public static double Quad(double a, double b)
        {
            Console.Write($"{a} * {b} ^ 2");
            return Math.Pow(a * b, 2);
        }

        public static double Sin(double a, double b)
        {
            Console.Write($"{a} * sin({b})");
            return a * Math.Sin(b);
        }

        public static void Process(DoOparation oparation, double a, double b)
        {
            Console.WriteLine($" = \t{oparation(a, b):F2}");
        }

        #region Task1

        static void Task1()
        {
            bool res = false, res1 = false;
            double parametr1, parametr2;
            Console.Clear();
            Console.WriteLine("Задача 1 продемонстрировать работу делегата");

            Console.Write("\nВведите параметр 'A': ");

            do
            {
                parametr1 = Check(ref res);

            } while (!res);

            Console.Write("\nВведите параметр 'B': ");

            do
            {
                parametr2 = Check(ref res1);

            } while (!res1);

            Console.WriteLine();
            Process(Quad, parametr1, parametr2);
            Process(Sin, parametr1, parametr2);

            Continue();
        }

        #endregion

        #region Task2

        public static Dictionary<double, Function> function = new Dictionary<double, Function>()
                {
                    {1,Func1 },
                    {2,Func2 },
                    {3,Func3 },
                    {4,Func4 },

                };

        static void Task2()
        {

            bool res = false;
            double number = 1;
            double a, b, c, start, end, delta;
            double min;
            int counter;
            Console.Clear();
            Console.WriteLine("Задача 2 Нахождение минимума функции");

            #region Ввод параметров

            Console.Write("\nВведите параметр 'A': ");

            do
            {
                a = Check(ref res);

            } while (!res);

            Console.Write("\nВведите параметр 'B': ");

            do
            {
                b = Check(ref res);

            } while (!res);

            Console.Write("\nВведите параметр 'C': ");

            do
            {
                c = Check(ref res);

            } while (!res);

            Console.Write("\nВведите параметр 'Начало отсчета': ");

            do
            {
                start = Check(ref res);

            } while (!res);

            Console.Write("\nВведите параметр 'Конец отсчета': ");

            do
            {
                end = Check(ref res);

            } while (!res);

            Console.Write("\nВведите параметр 'Дельту изменения': ");

            do
            {
                delta = Check(ref res);
                if (start < end && delta <= 0)
                {
                    Console.Write("Вы ввели неправильную дельта, повторите ввода: ");
                    res = false;
                }
            } while (!res);

            #endregion

            Console.WriteLine("\nФункция 1: a * x + b");
            Console.WriteLine("Функция 2: a * x ^ 2 + b * x + c");
            Console.WriteLine("Функция 3: a * sin(x) + b * cos(x)");
            Console.WriteLine("Функция 4: a * sqrt(x) + b * log(x)");

            Console.WriteLine("\nЗадача 0: Выход из программы");

            Console.Write("\nДля продолжения выберите номер Функции с которой хотите ознакомиться ");

            number = Check(ref res);




            //function[number];
            //if ()
            try
            {

                function.ContainsKey(number);
                //Console.WriteLine(function[number]);
            }
            catch
            {
                Console.WriteLine("function {0} is invalid", number);
                //  throw new ArgumentException(string.Format("function {0} is invalid", number), "number");
            }

            for (double i = start; i < end; i += delta)
            {

            }
            Console.WriteLine();
            SaveFunc(AppDomain.CurrentDomain.BaseDirectory + "TestData.txt", a, b, c, start, end, delta, number, out counter);
            Console.WriteLine($"\n{LoadFunc(AppDomain.CurrentDomain.BaseDirectory + "TestData.txt", out min, counter)} - минимальное значение функции ");

            Continue();

        }


        #endregion

        #region Task3

        static void Task3()
        {

            bool res = false;
            double number = 1;
            double a, b, c, start, end, delta;
            double min;
            int counter=0;

            List<Students> claass = new List<Students>();
            Students students;
            StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Student.txt");
            {
                while (!reader.EndOfStream)
                {
                    string[] userString = reader.ReadLine().Split(';');
                    students = new Students()
                    {
                        Name = userString[0],
                        SurName = userString[1],
                        Institute = userString[2],
                        Faculty = userString[3],
                        Direction = userString[4],
                        Age = int.Parse(userString[5]),
                        Course = int.Parse(userString[6]),
                        Group = userString[7],
                        Town = userString[8]
                    };
                    claass.Add(students);
                }
            }
            Console.Clear();
            Console.WriteLine("Задача 3 Работа с коллекцией");

            //Console.WriteLine("Студенты 5-го и 6-го курса: ");

            List<Students> found2 = claass.FindAll((item) => item.Course == 6 || item.Course == 5);


            //foreach (var item in found2)
            //{
            //    //Console.WriteLine($"{item.Name} {item.SurName} {item.Institute} {item.Faculty} {item.Direction} {item.Age} {item.Course} {item.Group} {item.Town}");
            //    counter++;
            //}

            Console.WriteLine($"\nКоличество студентов 5-го и 6-го курса: {found2.Count}\n");

            Console.WriteLine("Студенты в возрасте от 18 до 20 ");

            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();

            foreach (var item in claass)
            {
                if(item.Age>=18 && item.Age<=20)
                {
                    if (cousreFrequency.ContainsKey(item.Course))
                        cousreFrequency[item.Course] += 1;
                    else
                        cousreFrequency.Add((item.Course), 1);
                }
            }

            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
            foreach (int key in cousreFrequency.Keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, cousreFrequency[key]);
            Console.WriteLine($"\n{result}");

            List<Students> found4 = claass.OrderBy(o => o.Course).ThenBy(o => o.Age).ToList();
            //List<Students> found5 = claass.OrderBy(o => o.Age).ToList();
            foreach (var item in found4)
            {
                Console.WriteLine($"{item.Name} {item.SurName} {item.Institute} {item.Faculty} {item.Direction} {item.Age} {item.Course} {item.Group} {item.Town}");
                counter++;
            }

            List<Students> found3 = claass.FindAll((item) => item.Age == 18 || item.Age == 19 || item.Age == 20);
            counter = 0;

            

            Continue();

        }


        #endregion

        public static void SaveFunc(string fileName, double a, double b, double c, double start, double end, double delta, double number, out int counter)
        {
            counter = 0;
            if (File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);
                double x = start;
                while (x <= end)
                {
                    writer.WriteLine($"{(function[number](x, a, b, c)):F2}");
                    x += delta;
                    counter++;
                }
                writer.Close();
            }
        }

        public static double LoadFunc(string fileName, out double min, int counter)
        {
            StreamReader reader = new StreamReader(fileName);
            double d;
            min = double.MaxValue;

            for (int i = 0; i < counter; i++)
            {
                d = double.Parse(reader.ReadLine());
                if (d < min) min = d;
            }

            reader.Close();
            return min;

        }

        //public static void LoadSCV(string filename)
        //{
        //    StreamReader reader = new StreamReader(filename);


        //    return;
        //}

        static double Check(ref bool res)
        {

            res = double.TryParse(Console.ReadLine(), out double result);
            if (res)
            {
                return result;
            }
            else
            {
                Console.Write("\nВы ввели некорректное число\nПовторите ввода: ");
                return -1;
            }

        }

        static void Continue()
        {
            Console.Write("\nДля продолжения нажмите кнопку ");
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            bool res = false;
            double number = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Программа ученика Дудина Николая\n");

                Console.WriteLine("Задача 1: Продемонстрировать работу делегата");
                Console.WriteLine("Задача 2: Программа нахождения минимума функции");
                Console.WriteLine("Задача 3: Работа с коллекцией");

                Console.WriteLine("\nЗадача 0: Выход из программы");

                Console.Write("\nДля продолжения выберите номер задания с которым хотите ознакомиться ");

                number = Check(ref res);

                //bool res = int.TryParse(Console.ReadLine(), out number);


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
