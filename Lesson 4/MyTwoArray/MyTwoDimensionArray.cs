using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MyTwoArray
{
    public class MyTwoDimensionArray
    {
        private int[,] array;

        public MyTwoDimensionArray(int[,] array)
        {
            this.array = array;
        }

        public MyTwoDimensionArray(int sizeX, int sizeY)
        {
            int[,] array;
            array = new int[sizeX, sizeY];

            var rand = new Random();
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    array[j, i] = rand.Next(-10000, 10000);
                }
            }
            this.array = array;
        }

        public int this[int indexX, int indexY]
        {
            get { return array[indexX, indexY]; }
            set { array[indexX, indexY] = value; }
        }

        public int[,] Elements
        {
            get
            {
                return array;
                //
                //for (int j = 0; j < array.GetLength(0); j++)
                //{
                //    for (int i = 0; i < array.GetLength(1); i++)
                //    {
                //        return array[i, j];
                //    }
                //}
                //return -1;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
        public int GetLengthX
        {
            get { return array.GetLength(1); }
        }
        public int GetLengthY
        {
            get { return array.GetLength(0); }
        }

        public int Sum()
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    sum += array[j, i];
                }
            return sum;
        }
        public int SumOver(int over)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[j, i] > over)
                        sum += array[j,i];
                }
            return sum;
        }

        public int Max
        {
            get
            {
                int max = -20000;
                for (int j = 0; j < array.GetLength(0); j++)
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        if (array[j, i] > max)
                            max = array[i, j];
                    }
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = 20000;
                for (int j = 0; j < array.GetLength(0); j++)
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        if (array[j, i] < min)
                            min = array[i, j];
                    }
                return min;
            }
        }

        public void Index(ref int X, ref int Y)
        {
            int maxElem;
            maxElem = Max;
            for (int j = 0; j < array.GetLength(0); j++)
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[j, i] == maxElem)
                    {
                        maxElem = array[i, j];
                        X = i;
                        Y = j;
                    }

                }

        }

        public static int[,] LoadFromFile(string fileName)
        {
            int sizeX, sizeY;
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                sizeX = int.Parse(reader.ReadLine());
                sizeY = int.Parse(reader.ReadLine());

                var array = new int[sizeX, sizeY];
                for (int j = 0; j < array.GetLength(0); j++)
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        if (int.TryParse(reader.ReadLine(), out int num))
                            array[j, i] = num;
                    }
                reader.Close();
                return array;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public static void SaveToFile(int[,] array, string fileName)
        //public void SaveToFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine(array.GetLength(0));
                writer.WriteLine(array.GetLength(1));
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        writer.WriteLine($"{array[j, i]} ");
                    }

                }
                writer.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }


    }
}
