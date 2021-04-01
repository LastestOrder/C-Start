using System;

namespace MyArray
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

        public int MaxCount(int[] array, int multi)
        {
            return 1;
        }


    }
}
