using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5
{
    class Messege
    {
        #region Поля

        private string[] text;

        public int Lenght
        {
            get { return text.Length; }
        }

        public string this[int index]
        {
            get { return text[index]; }
            set { text[index] = value; }
        }
        #endregion

        public string[] Text
        {
            get { return text; }
            set { this.text = value; }
        }

        private static string[] separators = { ", ", ". ", "! ", "? ", "; ", ": ", " ", ";", ":" };

        public Messege(string[] text)
        {
            this.text = text;


        }

        public static string[] LoadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                var messege2 = reader.ReadToEnd();
                var text = messege2.Split(separators, StringSplitOptions.None);

                reader.Close();
                return text;
            }
            else
            {
                Console.WriteLine("Файл не найден");
                return null;
            }

        }
    }

    class Program
    {
        #region Task1 

        //        1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только
        //        буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //        а) без использования регулярных выражений;
        //        б) *с использованием регулярных выражений.
        static void Task1()
        {

            bool res = false, res1 = false;
            int check = 0;
            char c;
            int number = 0;

            do
            {

                int counter = 0;
                Console.Clear();

                Console.WriteLine("Программа 1: Проверка ввода логина\n");

                Console.Write("Логин должен содержать от 2 до 10 символов. \nСостоять только из букв Латинского алфавита и Цифр, причем Цифра не может быть первой!\n");
                Console.Write("\nВведите логин: ");
                string login = Console.ReadLine();

                char[] serch;
                serch = new char[login.Length];

                serch = login.ToCharArray();

                Console.Clear();
                Console.WriteLine($"Введенный логин: {login}");
                Console.WriteLine("\nУ вас две возможности");
                Console.WriteLine("\nВозможность 1: Проверка ввода логина обычным способом");
                Console.WriteLine("Возможность 2: Проверка ввода логина регулярными выражениям");

                Console.Write("\nВведите номер возможности: ");
                res1 = int.TryParse(Console.ReadLine(), out number);

                do
                {
                    if (res1)
                    {
                        switch (number)
                        {
                            #region case 1
                            case 1:


                                string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

                                for (int i = 0; i < serch.Length; i++)
                                {
                                    check = 1;
                                    foreach (var item in Alphabet)
                                    {
                                        c = serch[i];
                                        if (c.Equals(item))
                                        {
                                            check = 2;
                                        }
                                    }
                                }
                                switch (check)
                                {
                                    case 1:
                                        if (char.GetUnicodeCategory(serch[0]) != System.Globalization.UnicodeCategory.DecimalDigitNumber && 2 <= login.Length && login.Length <= 10)
                                        {

                                            for (int j = 1; j < login.Length; j++)
                                            {

                                                var category = char.GetUnicodeCategory(serch[j]);


                                                switch (category)
                                                {
                                                    case System.Globalization.UnicodeCategory.UppercaseLetter:
                                                        break;
                                                    case System.Globalization.UnicodeCategory.LowercaseLetter:
                                                        break;
                                                    case System.Globalization.UnicodeCategory.DecimalDigitNumber:
                                                        break;
                                                    default:
                                                        counter++;
                                                        break;
                                                }
                                            }
                                            if (counter == 0)
                                            {
                                                Console.WriteLine("\nЛогин введен по всем правилам");
                                                res = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nНеправильно введен логин. Присутсвуют лишние символы");
                                                Console.WriteLine("\nПовторите ввода");
                                                Continue();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nНеправильно введен логин. \nПервый символ не может быть Цифрой или Превышено количество символов");
                                            Console.WriteLine("\nПовторите ввода");
                                            Continue();
                                        }
                                        break;
                                    default: Console.WriteLine("\nВ логине имеются русские буквы"); Continue(); break;
                                }
                                break;

                            #endregion

                            case 2:
                                Regex regex = new Regex(@"^[^0-9]?=*[a-zA-Z].{2,8}$");
                                if (regex.IsMatch(login))
                                {
                                    Console.WriteLine("\nЛогин введен по всем правилам");
                                    res = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nНеправильно введен логин. \nПервый символ не может быть Цифрой или Превышено количество символов");
                                    Console.WriteLine("\nПовторите ввода");
                                    Continue();
                                }
                                break;
                            default: break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное число");

                    }
                } while (!res1);


            } while (!res);
            Continue();
        }
        #endregion

        #region Task2

        //2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //Продемонстрируйте работу программы на текстовом файле с вашей программой.
        static void Task2()
        {
            int max = 0;
            int num;
            bool res = false;
            Console.Clear();
            Console.WriteLine("Программа 2: Считывание из фала строки с текстом, и работа над этой строкой\n");
            Messege messege = new Messege(Messege.LoadFromFile(AppDomain.CurrentDomain.BaseDirectory + "TextMessege.txt"));

            Console.WriteLine("Получившийся текст");
            for (int i = 0; i < messege.Lenght; i++)
            {
                Console.Write($"{messege[i]} ");
            }
            Console.WriteLine();

            do
            {
                Console.Write("\nВведите число букв, не более которых должно содержаться в словах: ");
                num = Check(ref res);

            } while (!res);

            Console.Write("Задача 1: ");

            for (int i = 0; i < messege.Lenght; i++)
            {
                if (messege[i].Length <= num)
                    Console.Write($"{messege[i]} ");
            }
            Console.WriteLine();

            Console.Write("\nЗадача 2: Введите символ, на который должны заканчиваться слова, они будут удалены: ");

            string symbol = Console.ReadLine();
            char[] name;
            string name2;
            Regex regex = new Regex(@".$");
            for (int i = 0; i < messege.Lenght; i++)
            {
                name2 = messege[i];
                //name2.LastIndexOf;
                name2 = messege[i].Substring(messege[i].Length - 1);
                if (name2 != symbol)
                    Console.Write($"{messege[i]} ");
                //if (messege[i].)
                //if (string.Compare(name[messege[i].Length-1],symbol))
                //if (regex.IsMatch(messege[i].Last(symbol), symbol))
                //if(messege[i].Length.CompareTo(symbol))

            }
            Console.WriteLine();

            Console.Write("\nЗадача 3: Найти самое длинное слово сообщения: \n");

            max = messege[0].Length;
            for (int i = 0; i < messege.Lenght; i++)
            {
                if (max < messege[i].Length)
                    max = messege[i].Length;
            }

            for (int i = 0; i < messege.Lenght; i++)
            {
                if (messege[i].Length == max)
                    Console.Write($"Самое длинное слово сообщений: {messege[i]} ");
            }

            Console.WriteLine();

            StringBuilder newtext = new StringBuilder();
            Console.Write("\nЗадача 4: Сформировать строку с помощью StringBuilder из самых длинных слов сообщения: \n");
            max = max - 8;
            for (int i = 0; i < messege.Lenght; i++)
            {
                if (messege[i].Length >= max)
                {
                    newtext.Append(messege[i]);
                    newtext.Append(" ");
                }
            }

            Console.WriteLine(newtext);

            Console.WriteLine();

            Dictionary<string, int> counter = new Dictionary<string, int>();



            for (int j = 0; j < messege.Lenght; j++)
            {
                int count = 0;
                if (messege[j] != "0")
                {
                    name2 = messege[j];
                    for (int i = 0; i < messege.Lenght; i++)
                    {

                        if (messege[i] == name2)
                        {
                            messege[i] = "0";
                            count++;
                        }
                    }
                    counter.Add(name2, count);
                }
            }

            foreach (var keys1 in counter)
            {
                Console.WriteLine($" {keys1.Value} \t {keys1.Key}  ");
            }
            Continue();


        }

        #endregion

        #region Task3

        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Программа 3: Является ли одна строка перестановкой другой\n");

            string stroka1, stroka2;
            int result = 0;

            Console.Write("Введите первую строку ");
            stroka1 = Console.ReadLine();
            Console.Write("\nВведите вторую строку ");
            stroka2 = Console.ReadLine();

            stroka1 = stroka1.ToLower();
            stroka2 = stroka2.ToLower();

            result = Reshuffle(stroka1, stroka2);

            switch (result)
            {
                case 0: Console.WriteLine($"Строка {stroka2} Является перестановкой строки {stroka1}"); break;
                default: Console.WriteLine($"Строка {stroka2} НЕ Является перестановкой строки {stroka1}"); break;
            }

            Continue();
        }

        static int Reshuffle(string stroka1, string stroka2)
        {
            char[] stroka11;
            char[] stroka22;
            int count;
            char el;


            Dictionary<char, int> counter = new Dictionary<char, int>();
            Dictionary<char, int> counter2 = new Dictionary<char, int>();

            stroka11 = stroka1.ToCharArray();

            for (int j = 0; j < stroka11.Length; j++)
            {
                count = 0;
                if (stroka11[j] != '0')
                {
                    el = stroka11[j];

                    for (int i = 0; i < stroka11.Length; i++)
                    {


                        if (el == stroka11[i])
                        {
                            count++;
                            stroka11[i] = '0';

                        }

                    }
                    counter.Add(el, count);
                }
            }

            stroka22 = stroka2.ToCharArray();



            for (int j = 0; j < stroka22.Length; j++)
            {
                count = 0;
                if (stroka22[j] != '0')
                {
                    el = stroka22[j];

                    for (int i = 0; i < stroka22.Length; i++)
                    {


                        if (el == stroka22[i])
                        {
                            count++;
                            stroka22[i] = '0';
                        }

                    }
                    counter2.Add(el, count);
                }
            }

            //foreach (var keys1 in counter)
            //{
            //    Console.WriteLine($" {keys1.Key} \t {keys1.Value} ");
            //}

            //Console.WriteLine("Hello");

            //foreach (var keys2 in counter2)
            //{
            //    Console.WriteLine($" {keys2.Key} \t {keys2.Value} ");
            //}

            int result = counter.Count;

            foreach (var keys1 in counter)
            {
                foreach (var keys2 in counter2)
                {
                    if (keys1.Key == keys2.Key && keys1.Value == keys2.Value)
                        result--;
                }

            }
            return result;

        }

        #endregion

        #region Task4

        struct Element
        {
            public string FIO;
            public string N;
            public double B;
        }

        static void Task4()
        {

            int count = 0;
            double min = 5;

            Console.Clear();
            Console.WriteLine("Задача 4: Вывод трех учеников с худшим средним баллом, из файла\n");
            
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "StudentData.txt");
            int N = int.Parse(sr.ReadLine());
            Element[] a = new Element[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].FIO = s[0] + " " + s[1];
                a[i].N = s[2] + " " + s[3] + " " + s[4];
                a[i].B = Math.Round((double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3, 1);
            }

            sr.Close();

            for (int i = 0; i < N; i++)
            {
                if (a[i].B < min)
                    min = a[i].B;
            }
            do
            {

                for (int i = 0; i < N; i++)
                {
                    if (a[i].B == min)
                    {
                        count++;
                        Console.WriteLine($"Студенты с худшим средним баллом равным {min}: {a[i].FIO} {a[i].N}");
                    }
                }
                min += 0.1;
            } while (count <= 3);

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
            Console.Write("\nДля продолжения нажмите кнопку ");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Программа ученика Дудина Николая\n");

                Console.WriteLine("Задача 1: Проверка ввода логина");
                Console.WriteLine("Задача 2: Класс Messege");
                Console.WriteLine("Задача 3: Является ли одна строка перестановкой другой");
                Console.WriteLine("Задача 4: Вывод трех учеников с худшим средним баллом, из файла");

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
                        case 4: Task4(); break;
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
