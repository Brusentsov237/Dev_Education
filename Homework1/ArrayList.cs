using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class ArrayList
    {

        private int[] arr;
        private int realLength;
        public int[] Arr
        {
            get
            {
                int[] newArr = new int[realLength];
                for(int i = 0; i< realLength; i++)
                {
                    newArr[i] = arr[i];
                }
                return newArr;
            }
            set
            {
                arr = value;
            }
        }
        public ArrayList()
        {
            arr = new int[10];
            realLength = 0;
        }
        public ArrayList(int[] arr)
        {
            this.arr = arr;
            realLength = arr.Length;
        }
        
        private void Enlarge() // расширяет массив
        {

            int[] temp = new int[(arr.Length * 3) / 2 + 1];

            // Array.Copy(arr, temp, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }

            // Заменяем массив
            arr = temp;
        }

        private void Reduce() // сокращает массив
        {

            int[] temp = new int[(arr.Length)*3/2+5];

            // Array.Copy(arr, temp, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }

            // Заменяем массив
            arr = temp;
        }

        public void AddEnd(int val) //добавляет элемент в конец массива
        {
            if (realLength == arr.Length)
                Enlarge();

            arr[realLength] = val;
            realLength++;
        }

        public void AddByIdx(int idx, int val) //добавляет элемент под индексом и сдвигает массив
        {
            if (realLength >= arr.Length)
                Enlarge();

            for (int i = realLength - 1; i >= idx; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[idx] = val;

            realLength++;
        }

        public void AddAllEnd(int[] vals)//добаваляет элементы из введённого массива в текущий 
        {
            var temp = new int[arr.Length + vals.Length];

            // Копируем старый массив
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp[j] = arr[i];
                j++;
            }

            // Копируем добавочный массив в конец
            for (int i = 0; i < vals.Length; i++)
            {
                temp[j] = vals[i];
                j++;
            }

            // Заменяем массив на новый.
            arr = temp;

            realLength += vals.Length;
        }

        public void AddAllByIdx1(int idx, int[] vals)
        {
            int indexModifier = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                AddByIdx(idx + indexModifier, vals[i]);
                indexModifier++;
            }
        }

        public void AddAllByIdx(int idx, int[] vals)//добавляет элементы под индексом и сдвигает массив
        {
            // Создаем новый массив
            var temp = new int[arr.Length + vals.Length];

            // Копируем в новый массив два исходных. Используем два индекса i и j.
            int j = 0;
            for (int i = 0; i < temp.Length; )
            {
                if (i == idx)
                {
                    // Если дошли до места куда вставляем vals, то копируем vals
                    for (var k = 0; k < vals.Length; k++)
                    {
                        // Копируем элемент из vals
                        temp[i] = vals[k];
                        // Сдвигаем i на один
                        i++;
                    }
                }
                else
                {
                    // Иначе копируем элемент из старого массива и сдвигаем i и j на
                    // один.
                    temp[i] = arr[j];
                    j++;
                    i++;
                }
            }

            // Заменяем массив на новый.
            arr = temp;
            realLength += vals.Length;
        }

        public void RemoveIdx(int idx) //удаляет элемент массива по индексу
        {
            int[] temp = new int[arr.Length - 1];

            int j = 0;
            for (int i = 0; i <= temp.Length; i++)
            {
                if (i != idx)
                {
                    temp[j] = arr[i];
                    j++;
                }


            }

            // Заменяем массив на новый.
            arr = temp;

            realLength--;

            if (realLength < 2 * (arr.Length - 1) / 3)
                Reduce();

        }

        public void RemoveVal(int val) //удаляет все элементы с введённым значением
        {
            int[] temp = new int[arr.Length];

            int j = 0, counter = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (arr[i] == val)
                {
                    counter++;
                }
                else
                {
                    temp[j] = arr[i];
                    j++;
                }
            }

            // Заменяем массив на новый.
            arr = temp;

            realLength -= counter;

            if (realLength < 2 * (arr.Length - 1) / 3)
                Reduce();

        }

        public void Set(int idx, int val) //заменяет значение по индексу
        {
            for (int i = 0; i < realLength; i++)
            {
                if (i == idx)
                    arr[i] = val;
            }
        }

        public int Get(int idx) //возвращает значение элемента по индексу
        {
            if (idx > realLength - 1)
                throw new ArgumentException("нет такого индекса");
            int val = 0;
            for (int i = 0; i < realLength; i++)
            {
                if (i == idx)
                    val = arr[i];
            }
            return val;
        }

        public int Size() // фактический размер массива
        {
            return realLength;
        }

        public bool Contains(int val) //проверка на наличие элемента в массиве
        {
            return IndexOf(val) > -1;
        }

        public int IndexOf(int val) //возвращает индекс первого подходящего элемента по заданному значению
        {
            for (int i = 0; i < realLength; i++)
            {
                if (arr[i] == val)
                    return i;
            }
            return -1;
        }

        public int[] Search(int val)//возвращает массив индексов по заданному значению
        {
            int k = 0;
            int[] tempArr = new int[realLength];
            for (int i = 0; i < realLength; i++)
            {
                if (arr[i] == val)
                {
                    tempArr[k] = i;
                    k++;
                }
            }
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = tempArr[i];
            }
            return res;
        }

    }
}
