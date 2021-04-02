using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MyArrayNew;
using MyTwoArray;

namespace Lesson_4
{
    public static class StaticClass
    {
        public static int Pair(ref int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 ^ array[i + 1] % 3 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int[] LoadFromFile(string fileName, ref int size)
        {
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                size = int.Parse(reader.ReadLine());
                var array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    if (int.TryParse(reader.ReadLine(), out int num))
                        array[i] = num;
                }
                reader.Close();
                return array;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public static void SaveToFile(int[] array, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i]);
            }
            writer.Close();
        }
    }

    struct Account
    {
        /// <summary>
        /// Логин
        /// </summary>
        private string login;

        /// <summary>
        /// Пароль
        /// </summary>
        private string password;

        public static bool LoadFromFileAccount(string fileName, string login, string password)
        {
            string loginfile, passwordfile;
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);

                loginfile = reader.ReadLine();
                passwordfile = reader.ReadLine();

            }
            else
            {
                throw new FileNotFoundException();
            }

            if (loginfile == login && passwordfile == password)
                return true;
            else
                return false;
        }

    }

    class Program
    {
        #region Task 1
        //1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения
        //от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать программу, позволяющую
        //найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
        //В данной задаче под парой подразумевается два подряд идущих элемента массива.
        //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
        //2. Реализуйте задачу 1 в виде статического класса StaticClass;
        //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        //б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        //в)*Добавьте обработку ситуации отсутствия файла на диске.
        static void Task1(int parametr)
        {
            int counter = 0;
            int number = 0;
            int n;
            int[] array;
            bool res = false;


            Console.Clear();
            Console.WriteLine("Программа подсчета пар элементов в массиве\n");

            do
            {
                Console.Write("Введите размерность массива: ");
                n = Check(ref res);

            } while (!res);

            Console.Clear();
            Console.WriteLine($"Количество элементов массива {n}\n");

            array = new int[n];

            Console.WriteLine("У вас три возможности\n");
            Console.WriteLine("Возможность 1: Ввести массив с клавиатуры");
            Console.WriteLine("Возможность 2: Массив заполнится сам случайными числами");
            Console.WriteLine("Возможность 3: Считать массив из файла");

            Console.Write("\nДля продолжения выберите номер возможности: ");

            res = int.TryParse(Console.ReadLine(), out number);
            if (res)
            {
                switch (number)
                {
                    case 0: break;
                    case 1: Task11(ref array, n); break;
                    case 2: Task12(ref array); break;
                    case 3:
                        var array2 = StaticClass.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + "ArrayList.txt", ref n);
                        array = new int[n];
                        array = array2;

                        break;

                    default:
                        Console.WriteLine("Номер возможности введен некорректно. Пожалуйста, повторите попытку ввода.");
                        Continue();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
            }

            switch (parametr)
            {
                case 1: counter = Pair(ref array); break;
                case 2: counter = StaticClass.Pair(ref array); break;

            }


            Console.Clear();

            Result(array, n);

            Console.WriteLine($"\n\nКоличество пар в массиве, в которых только одно число делится на 3 = {counter}");

            Continue();

        }

        static void Task11(ref int[] array, int n)
        {
            Console.Clear();

            bool res = false;
            Console.WriteLine($"Размерность массива {n}\n");
            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    Console.Write($"Введите {i} элемент массива ");
                    array[i] = Check(ref res);

                } while (!res);
            }

        }

        static void Task12(ref int[] array)
        {
            var rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10000, 10000);
            }
        }

        static int Pair(ref int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 ^ array[i + 1] % 3 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        #endregion

        static void Result(int[] array, int n)
        {
            Console.WriteLine($"Количество элементов массива {n}\n");
            Console.Write("Получившийся массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        #region Task3
        //        а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий
        //        массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод
        //        Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), метод
        //        Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных
        //        элементов.
        //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
        //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        static void Task3()
        {
            int delta;
            int start;
            int multi;
            int n;
            bool res = false;

            Console.Clear();
            Console.WriteLine("Реализация работы с Классом MyArray\n");

            do
            {
                Console.Write("Введите размерность массива: ");
                n = Check(ref res);

            } while (!res);

            Console.Clear();
            Console.WriteLine($"Количество элементов массива {n}\n");

            do
            {
                Console.Write("Введите начальное число с которого начинается массив: ");
                start = Check(ref res);

            } while (!res);

            do
            {
                Console.Write("Введите шаг с которым изменяются значения элементов массива: ");
                delta = Check(ref res);

            } while (!res);

            do
            {
                Console.Write("Введите число на которые будут умножаться элементы массива (для метода Multi): ");
                multi = Check(ref res);

            } while (!res);
            MyArray array = new MyArray(n, start, delta);

            Console.Write("\nЭлементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine($"\n\nСумма элементов {array.Sum()}");

            Console.Write("Получившийся массив (после Inverse): ");

            int[] arrayInverse;
            arrayInverse = new int[array.Length];
            arrayInverse = array.Inverse();

            for (int i = 0; i < arrayInverse.Length; i++)
            {
                Console.Write($"{arrayInverse[i]} ");
            }

            int[] arrayMulti;
            arrayMulti = new int[array.Length];
            arrayMulti = array.Multi(multi);

            Console.Write("\nПолучившийся массив (после Multi): ");
            for (int i = 0; i < arrayInverse.Length; i++)
            {
                Console.Write($"{arrayMulti[i]} ");
            }

            Dictionary<int, int> counter = new Dictionary<int, int>();


            for (int i = 0; i < array.Length; i++)
            {
                counter.Add(array.Max, array.MaxCount);
                array.Remove();
            }

            Console.WriteLine();
            foreach (var keys1 in counter)
            {
                Console.WriteLine($" {keys1.Key} {keys1.Value}");
            }

            Continue();
        }

        #endregion

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

        static void Continue()
        {
            Console.Write("\n\nДля продолжения нажмите кнопку ");
            Console.ReadLine();
        }

        #region Task4

        //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account,
        //содержащую Login и Password.
        static void Task4()
        {
            string login, password;
            bool res = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Реализация проверки логина и пароля считанных из файла\n");

                Console.Write("Введите логин ");
                login = Console.ReadLine();
                Console.Write("Введите пароль ");
                password = Console.ReadLine();
                res = Account.LoadFromFileAccount(AppDomain.CurrentDomain.BaseDirectory + "Password.txt", login, password);
                if (!res)
                {
                    Console.WriteLine("\nНеправильный ввод логина или пароля");
                    Console.WriteLine("Повторите ввод");
                    Continue();
                }
            } while (!res);
            Continue();
        }

        #endregion

        #region Task5

        //        а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными
        //        числами.Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
        //        возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер
        //        максимального
        //        элемента массива(через параметры, используя модификатор ref или out).
        //*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        //** в) Обработать возможные исключительные ситуации при работе с файлами.
        static void Task5()
        {

            int x, y, num, X = 0, Y = 0;
            bool res = false;


            Console.Clear();
            Console.WriteLine("Программа работы с двумерным массивом\n");
            MyTwoDimensionArray array;
            MyTwoDimensionArray array2;


            Console.WriteLine("У вас две возможности\n");
            Console.WriteLine("Возможность 1: Ввести массив с клавиатуры");
            Console.WriteLine("Возможность 2: Массив заполнится сам из файла");

            Console.Write("\nДля продолжения выберите номер возможности: ");
            res = int.TryParse(Console.ReadLine(), out int number);
            if (res)
            {
                switch (number)
                {
                    case 1:
                        do
                        {
                            Console.Write("Введите количество строк: ");
                            x = Check(ref res);

                        } while (!res);

                        do
                        {
                            Console.Write("Введите количество столбцов: ");
                            y = Check(ref res);

                        } while (!res);
                        do
                        {
                            Console.Write("Введите число выше которого будет считаться сумма: ");
                            num = Check(ref res);

                        } while (!res);
                        Console.Clear();
                        Console.WriteLine($"Количество строк массива {x} и количество столбцов {y}\n");

                        array = new MyTwoDimensionArray(x, y);
                        Console.WriteLine("Элементы двумерного массива:");

                        for (int j = 0; j < array.GetLengthY; j++)
                        {
                            for (int i = 0; i < array.GetLengthX; i++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }
                            Console.WriteLine();
                        }

                        array.Index(ref X, ref Y);
                        Console.WriteLine($"\n\nСумма элементов = {array.Sum()} ");
                        Console.WriteLine($"\nСумма элементов больше {num} = {array.SumOver(num)}");
                        Console.WriteLine($"\nМинимальный элемент {array.Min}");
                        Console.WriteLine($"\nМаксимальный  элемент {array.Max} и его индекс {Y},{X}");
                        MyTwoDimensionArray.SaveToFile(array.Elements, AppDomain.CurrentDomain.BaseDirectory + "TwoArrayList.txt");

                        break;
                    case 2:
                        do
                        {
                            Console.Write("Введите число выше которого будет считаться сумма: ");
                            num = Check(ref res);

                        } while (!res);
                        array2 = new MyTwoDimensionArray(MyTwoDimensionArray.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + "TwoArrayList.txt"));
                        Console.WriteLine();
                        for (int j = 0; j < array2.GetLengthY; j++)
                        {
                            for (int i = 0; i < array2.GetLengthX; i++)
                            {
                                Console.Write($"{array2[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        array2.Index(ref X, ref Y);
                        Console.WriteLine($"\n\nСумма элементов = {array2.Sum()} ");
                        Console.WriteLine($"\nСумма элементов больше {num} = {array2.SumOver(num)}");
                        Console.WriteLine($"\nМинимальный элемент {array2.Min}");
                        Console.WriteLine($"\nМаксимальный  элемент {array2.Max} и его индекс {Y},{X}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            
            Continue();
        }

        #endregion

        static void Main(string[] args)
        {

            int number = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Программа ученика Дудина Николая\n");

                Console.WriteLine("Задача 1: Написать программу, позволяющую найти и вывести количество пар элементов массива");
                Console.WriteLine("Задача 2: Написать программу, позволяющую найти и вывести количество пар элементов массива через Класс");
                Console.WriteLine("Задача 3: Реализован Класс работы с массивом");
                Console.WriteLine("Задача 4: Реализация проверки логина и пароля считанных из файла");
                Console.WriteLine("Задача 5: Реализация библиотеку для работы с двумерным массивом");

                Console.WriteLine("\nЗадача 0: Выход из программы");

                Console.Write("\nДля продолжения выберите номер задания с которым хотите ознакомиться ");

                bool res = int.TryParse(Console.ReadLine(), out number);

                if (res)
                {
                    switch (number)
                    {
                        case 0: break;
                        case 1: Task1(number); break;
                        case 2: Task1(number); break;
                        case 3: Task3(); break;
                        case 4: Task4(); break;
                        case 5: Task5(); break;
                        default:
                            Console.WriteLine("\nНомер задачи введен некорректно. Пожалуйста, повторите попытку ввода.");
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
