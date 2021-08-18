using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class ArrTasks
    {
        //Для заданий по тестированию
        public int Test34arr(int[] array) 
        {
            //Дан массив вещественных чисел, размер которого N.
            //Подсчитать, сколько в нем отрицательных, положительных и нулевых элементов.
            //public Tuple <int, int, int> Test34arr(int[] array)


            //int sumZ = 0;
            int sumPos = 0;
            //int sumNeg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                //if (array[i] == 0)
                //{
                //    sumZ++;
                //}
                //else if (array[i] < 0)
                //{
                //    sumNeg++;
                //}
                if (array[i] > 0)
                {
                    sumPos++;
                }

            }
            //return Tuple.Create(sumPos, sumNeg, sumZ);
            return sumPos;
        }

    }
}
