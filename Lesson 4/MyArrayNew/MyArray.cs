using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayNew
{
    public class MyArray
    {
        private int[] array;


        public MyArray(int[] array)
        {
            this.array = array;
        }

        public MyArray(int size, int start, int delta)
        {
            int[] array;
            array = new int[size];
            array[0] = start;
            for (int i = 1; i < size; i++)
            {
                array[i] = array[i - 1] + delta;
            }
            this.array = array;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public int[] Inverse()
        {
            int[] arrayInverse;
            arrayInverse = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayInverse[i] = array[i] * -1;
            }

            return arrayInverse;
        }

        public int[] Multi(int multi)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multi;
            }

            return array;
        }
        private int maxCount;

        public int MaxCount
        {
            get
            {
                maxCount = 0;
                //int count = 0;
                int max = -10000;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (max == array[i])
                        maxCount++;
                }
                return maxCount;
            }

        }

        public int[] Remove()
        {
            int max = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    array[i] = 0;
            }
            return array;
        }

        public int Max
        {
            get
            {
                int max = -10000;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }
                return max;
            }
        }

    }
}
