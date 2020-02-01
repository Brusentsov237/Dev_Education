using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class ArrayList
    {

       private int[] arr = new int[0];

        int realLength = 0;

        public int[] GetValues() 
        {
            int[] result = new int[realLength];
            for(int i =0; i<realLength; i++)
            {
                result[i] = arr[i]; 
            }
            return result;
        }
        private void EnsureLength(int len) // метод проверяет, что в массиве етсь не менее len ячеек и при необходимости
                                           // расширяет массив
        {
            if (arr.Length < len)
            {
                // По классике наращиваем массив в два раза
                var newItems = new int[arr.Length * 2];

                // Здесь можно и циклом скопировать
                Array.Copy(arr, newItems, arr.Length);
                for(int i = 0; i < realLength; i++)
                {

                }
                // Заменяем массив
                arr = newItems;
            }
        }
            public void Add(int val) //добавляет элемент в конец массива
        {
            int[] res = new int[arr.Length + 1];

            for (int i = 0; i < res.Length; i++)
            {
                if (i < arr.Length)
                {
                    res[i] = arr[i];
                }
                else if (i == res.Length)
                {
                    res[i] = val;
                }
            }
            realLength++;
            if (realLength > arr.Length)
            {
                arr = new int[arr.Length + 3];
                for (int i = 0; i < res.Length; i++)
                {
                    arr[i] = res[i];
                }
            }
            else
            {
                for (int i = 0; i < realLength; i++)
                {
                    arr[i] = res[i];
                }
            }
        }
        public void Add(int idx, int val) //добавляет элемент под индексом и сдвигает массив
        {
            int[] res = new int[arr.Length + 1];
            for (int i = 0; i < res.Length; i++)
            {

                if (i < idx)
                {
                    res[i] = arr[i];
                }
                else if (i == idx)
                {
                    res[i] = val;
                }
                else
                {
                    res[i] = arr[i - 1];
                }
            }
            realLength++;
            if (realLength > arr.Length)
            {
                arr = new int[arr.Length + 3];
                for (int i = 0; i < res.Length; i++)
                {
                    arr[i] = res[i];
                }
            }
            else
            {
                for (int i = 0; i < res.Length; i++)
                {
                    arr[i] = res[i];
                }
            }
        }
        public void AddAll(int[] vals)//добаваляет элементы из введённого массива в текущий 
        {
            int[] res = new int[arr.Length + vals.Length];
            for (int i = 0; i < arr.Length + vals.Length; i++)
            {
                if (i < arr.Length)
                {
                    res[i] = arr[i];
                }
                else
                {
                    res[i] = vals[i];
                }
            }

        }
        public void AddAll(int idx, int[] vals)//добавляет элементы под индексом и сдвигает массив
        {
            int[] res = new int[arr.Length + vals.Length];
            int k = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (i < idx)
                {
                    res[i] = arr[i];
                }
                else if (idx <= i && i <= idx + vals.Length)
                {
                    res[i] = vals[k];
                    k++;
                }
                else
                {
                    res[i] = arr[i - vals.Length];
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                arr[i] = res[i];
            }
        }
        public void RemoveIdx(int idx) //удаляет элемент массива по индексу
        {
            int[] res = new int[arr.Length - 1];
            for (int i = 0; i < res.Length; i++)
            {
                if (i < idx)
                {
                    res[i] = arr[i];
                }
                else if (i > idx)
                {
                    res[i] = arr[i + 1];
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                arr[i] = res[i];
            }
        }
        public void RemoveVal(int val) //удаляет первый попавшийся элемент с введённым значением
        {

            
        }
        public void RemoveAll(int val) //удаляет все элементы с введённым значением
        {
            
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
            int count = 0;
            for (int i = 0; i < realLength; i++)
            {
                count++;
            }

            return count;
        }
        public bool Contains(int val) //проверка на наличие элемента в массиве
        {
            for (int i = 0; i < realLength; i++)
            {
                if (arr[i] == val)
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(int val) //возвращает индекс первого подходящего элемента по заданному значению
        {
            int idx = 0;
            for (int i = 0; i < realLength; i++)
            {
                if(arr[i] == val)
                idx =  i;
            }
            return idx;
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
