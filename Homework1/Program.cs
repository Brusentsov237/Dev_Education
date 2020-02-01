using System;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            //Task1(); //задача с расчётом кредита
            //Task2(); //катеты
            //Task3(); //Вывести уравнение прямой по координатам двух точек
            //Task4(); //Найти корни квадратного уровнения. (ax2 + bx + c)
            //Task5(); //Посчитать выражение (max(a*b*c, a+b+c) + 3). Параметры a, b и c 
            //Task6(); //Вводятся два целых числа. Проверить, делится ли первое на второе. Вывести на экран сообщение об этом, а также остаток (если он есть) и частное (в любом случае). 
            //Task7(); //Определить, какой четверти принадлежит точка с координатами (x, y)
            //Task8(); //Определение принадлежности точки кругу с центром в начале координат
            //Task9(); //Вычислить факториал числа n. 
            //Task10();//Вывести таблицу значений функции y = -0.23x2 + x. Значения аргумента (x) задаются минимумом, максимумом и шагом.
            //Task11();//Найти сумму и произведение цифр введенного натурального числа.
            // Task12();//Докажите, что для множества натуральных чисел верно 1+2+...+n = n(n+1)/2

            //Task2_1(); // Реверс числа
            //Task2_2(); // Задан массив из 20 элементов (рандом от -100 до 100). Найти наибольший элемент массива и его индекс
            // Task2_3(); // калькулятор
            //Task2_4(); // Фибоначчи
            //Task2_5(); //реверс массива
            //Task2_6(); //Найти в массиве те элементы, значение которых меньше среднего арифметического, взятого от всех элементов массива.
            //Task2_7(); // В массиве найти сумму элементов, находящихся между минимальным и максимальным элементами. Сами минимальный и максимальный элементы в сумму не включать.
            // Task2_8();    // Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2. 
            //Task2_9();  // Проверить корректность работы генератора псевдослучайных чисел языка программирования
            // Task2_10();   //Угадать случайное число.

            //Task3_1(); // В квадратной матрице 10x10 обменять значения элементов в каждой строке, расположенные на главной и побочной диагоналях.
            //Task3_2(); // Найти количество элементов массива, которые больше своих левого, правого, верхнего и нижнего соседа одновременно.
            //Task3_3(); // КРЕСТИКИ-НОЛИКИ c ИИ
            //Task3_4(); // КРЕСТИКИ-НОЛИКИ  spectator-mod
            //Task3_5(); // В введенном промежутке натуральных чисел найти те, количество делителей у которых не меньше введенного значения. 
            //Task3_6(); // Вывести на экран "прямоугольник", образованный из двух видов символов.
            //Task3_7(); // Посчитать, сколько раз встречается определенная цифра в введенной последовательности чисел. 

            //Task3_8(); // перебор массива от большего к меньшему
        }

        #region ПЕРВАЯ ДОМАШКА
        static void Task1()
        {

            Console.WriteLine("Введите сумму кредита");
            int creditAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во лет");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ставку");
            int loanRate = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();


            double[] res = hw.CalcCreditSum(creditAmount, year, loanRate);
            Console.WriteLine($"Кредит на сумму {creditAmount} рублей выдан на {year} лет под {loanRate} процентов");

            Console.WriteLine($"Ежемесячная выплата по кредиту  составит {res[0]} рублей");
            Console.WriteLine($"Суммарная выплата по кредиту составит {res[1]} рублей");
        }
        static void Task2()
        {
            //Homework1 hw = new Homework1();

            Console.Write("Введите величину катета 1 : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите величину катета 2 : ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Длина гипотенузы:{Math.Round(c, 2)}");
            Console.ReadLine();
        }
        static void Task3()
        {
            int x1, y1, x2, y2;


            Console.WriteLine("Введите  x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();


            Console.WriteLine(hw.Equation(x1, y1, x2, y2));
        }
        static void Task4()
        {
            double a, b, c;

            Console.WriteLine("Формула квадратного уравнения: ax2 + bx + c");
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine());

            Homework1 hw = new Homework1();
            
            double[] arr = hw.QuadraticEquation(a, b, c);
            PrintDoubleArray(arr);
        }
        static void Task5()
        {

            int a, b, c;
            Homework1 hw = new Homework1();

            Console.WriteLine("Введите a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToInt32(Console.ReadLine());

            int mult = hw.Mult(a, b, c), add = hw.Add(a, b, c);

            Console.WriteLine($"Multiplication result: {mult}");
            Console.WriteLine($"Sum result: {add}");

            if (mult > add)
            {
                Console.WriteLine($"Multiplication result > sum result: {mult} + 3 = {mult + 3}");
            }
            else if (mult < add)
            {
                Console.WriteLine($"Sum result > multiplication result: {add} + 3 = {add + 3}");
            }
            else Console.WriteLine($"Sum result = multiplication result");

        }
        static void Task6()
        {

            Console.WriteLine("Введите a1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите a2");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();


            if (a2 != 0)
            {
                if (hw.DivideOrNotDivide(a1, a2) == false)
                {
                    Console.WriteLine($"a1 / a2 = {a1} / {a2} = {(double)a1 / a2}");
                    Console.WriteLine($"Остаток от деления: {a1 % a2}");
                }
                else Console.WriteLine($"a1 / a2 = {a1} / {a2} = {(double)a1 / a2}");
            }
            else Console.WriteLine("На ноль делить нельзя");
        }
        static void Task7()
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"x = {x}, y = {y}");

            Homework1 hw = new Homework1();

            Console.WriteLine(hw.WhichQuadrant(x, y));

        }
        static void Task8()
        {


            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите r");
            int r = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"x = {x}, y = {y}, r = {r}");

            Homework1 hw = new Homework1();
            if (r <= 0)
            {
                Console.WriteLine("Radius of a circle can't be negative or zero");
            }
            else if(hw.DotAndCircle(x, y, r) == true)
            {
                Console.WriteLine("The point is in the circle");
            }
            else Console.WriteLine("The point isn't in the circle");
        }
        static void Task9()
        {
            Console.WriteLine("Введите x");
            int n = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();

            int res = hw.Factorial(n);


            Console.WriteLine($"{n}! = {res}");
        }
        static void Task10()
        {
            Console.WriteLine("Введите минимальное значение X");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение X");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            int step = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();

            for (int i = min; i <= max; i += step)
            {
                Console.WriteLine($"x = {i}, y = {hw.FunctionValue(i)}");
            }
        }
        static void Task11()
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();

            Console.WriteLine($"Sum = {hw.SumRes(n)}");
            Console.WriteLine($"Mult = {hw.MultRes(n)}");
        }
        static void Task12()
        {
            Console.Write("Введите число \n n=");
            int n = Convert.ToInt32(Console.ReadLine());

            Homework1 hw = new Homework1();

            if (hw.Evidence(n) == true)
            {
                Console.WriteLine("1+2+...+n = n(n+1)/2");
            }
            else
            {
                Console.WriteLine("1+2+...+n = n(n+1)/2");
            }
        }
        #endregion

        #region ВТОРАЯ ДОМАШКА
        static void Task2_1()
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            Homework2 hw = new Homework2();

            Console.WriteLine(hw.ReversChisla(n));
        }
        static void Task2_2()
        {
            Console.Write("Введите кол-во элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = GetRandomIntArray(n, 1, 100);
            PrintIntArray(arr);

            Homework2 hw = new Homework2();
            int maxElem = hw.MaxElem(arr);
            int index = hw.MaxElemIndex(arr);
            Console.WriteLine($"макс число:{maxElem}, а его индекс:{index}");
        }
        static void Task2_3()
        {
            // Написать программу, которая будет складывать, вычитать, умножать или делить два числа. Числа и знак операции вводятся пользователем.
            //После выполнения вычисления программа не должна завершаться, а должна запрашивать новые данные для вычислений.
            //Завершение программы должно выполняться при вводе символа '0' в качестве знака операции. Если пользователь вводит неверный знак(не '0', '+', '-', '*', '/'), 
            //то программа должна сообщать ему об ошибке и снова запрашивать знак операции. 
            //Также сообщать пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя.

            Console.WriteLine("Введите певрое число:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите знак:");
            string sign = Console.ReadLine();

            if (sign != "0")
            {
                Console.WriteLine("Введите второе число:");
                double b = double.Parse(Console.ReadLine());

                Homework2 hw = new Homework2();

                Console.WriteLine(hw.Calc(a, sign, b));
            }

        }
        static void Task2_4()
        {
            do
            {
                Console.Write("Введите колличество чисел \n в последовательности: ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Ошибка");
                    break;
                }
                else
                {
                    Homework2 hw = new Homework2();

                    int[] arr = hw.Fibonacci(n);
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }

                    break;
                }
            } while (true);


        }
        static void Task2_5()
        {
            // реверс массива
            Console.Write("Введите кол-во элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = GetRandomIntArray(n, 1, 100);
            PrintIntArray(arr);

            Homework2 hw = new Homework2();

            int[] rev = hw.ReversArr(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,3} ", rev[i]);
            }

        }
        static void Task2_6()
        {
            //Найти в массиве те элементы, значение которых меньше среднего арифметического, взятого от всех элементов массива.

            Console.Write("Введите кол-во элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = GetRandomIntArray(n, 1, 100);
            PrintIntArray(arr);            

            Homework2 hw = new Homework2();

            int[] a = hw.Average(arr, ref n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "  ");
            }

            Console.Write(" \n");
        }
        static void Task2_7()
        {
            //  В массиве найти сумму элементов, находящихся между минимальным и максимальным элементами. Сами минимальный и максимальный элементы в сумму не включать.

            Console.Write("Введите кол-во элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = GetRandomIntArray(n, 1, 100);
            PrintIntArray(arr);

            Homework2 hw = new Homework2();

            int min = hw.MinElem(arr), max = hw.MaxElem(arr);
            
            Console.Write(" \n");
            Console.WriteLine($"минимальное значение:{min}");
            Console.WriteLine($"максимальное значение:{max}");
            Console.Write(" \n");

            int sum = hw.SumBetweenMinAndMax(arr);

            Console.WriteLine($"Ответ:{sum}");

        }
        static void Task2_8()
        {

            // Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
            //Если в массиве кол - во элементов нечётное(1 2 3 4 5),  “средний” элемент оставить на своём месте: 4 5 3 1 2
            Console.Write("Введите кол-во элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = GetRandomIntArray(n, 1, 100);
            PrintIntArray(arr);

            Console.Write(" \n");
            Homework2 hw = new Homework2();

            int[] res = hw.SwapHalf(arr);
            Console.Write(" \n");
            PrintIntArray(res);
        }
        static void Task2_9()
        {
            // Проверить корректность работы генератора псевдослучайных чисел языка программирования
            //  с помощью оценки вероятности выпадения четных чисел на выборке не меньше 1000 случайных чисел. 
            //    (Программа должна выдать около 50%. Можно увеличить число генераций, например до 10 тысяч.
            //  В таком случае отклонение от 50% будет меньше)
            Console.Write("Введите кол-во элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = GetRandomIntArray(n, 1, 100);
            PrintIntArray(arr);

            Homework2 hw = new Homework2();

            Console.WriteLine($" {hw.CheckRandom(arr)}%");
        }
        static void Task2_10()
        {
            //Угадать случайное число.
            // В программе генерируется случайное целое число от 0 до 100.Пользователь должен его отгадать не более чем за 10 попыток.
            // После каждой неудачной попытки должно сообщаться больше или меньше введенное пользователем число, чем то, что загадано. 
            //Если за 10 попыток число не отгадано, то вывести загаданное число.
            Console.WriteLine("Игра началась!");

            Random rnd = new Random();
            int a = rnd.Next(0, 100);

            int trycount = 0;
            do
            {
                Console.WriteLine("Введите число от 0 до 100");

                int b = int.Parse(Console.ReadLine());

                Homework2 hw = new Homework2();

                hw.CompareForEquality(a, b);

                trycount += 1;
            }
            while (trycount < 10);
            Console.WriteLine("Попытки кончились!!!");
        }
        #endregion

        #region ТРЕТЬЯ ДОМАШКА
        static void Task3_1()
        {
            // В квадратной матрице 10x10 обменять значения элементов в каждой строке, расположенные на главной и побочной диагоналях.
            Console.Write("Введите размеры двумерного массива. Ширина=");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота=");
            int h = Convert.ToInt32(Console.ReadLine());

            Homework3 hw = new Homework3();

            
            int[,] arr = GetRandomIntArray2(h,w, 1,100);
            PrintIntArray2(arr);

            int[,] res = hw.SwapDiagonals(arr);


            PrintIntArray2(res);
        }
        static void Task3_2()
        {
            //Найти количество элементов массива, которые больше своих левого, правого, верхнего и нижнего соседа одновременно.

            Console.Write("Введите размеры таблицы. Ширина=");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота=");
            int h = Convert.ToInt32(Console.ReadLine());

            Homework3 hw = new Homework3();


            int[,] arr = GetRandomIntArray2(h, w, 1, 100);
            PrintIntArray2(arr);

            int count = hw.GetCountOfGreaterX(arr);
            Console.Write($"кол-во чисел, которые больше верхнего, нижнего, правого и левого числа в таблице:{count}");

        }
        static void Task3_3()
        {
            #region Создание игрового поля
            //создаётся массив
            Console.Write("Введите размеры поля. Ширина=");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота=");
            int h = Convert.ToInt32(Console.ReadLine());

            string[,] arr = GetStringArray2(h, w, "+");
            PrintStringArray2(arr);

            Console.WriteLine();
            #endregion
            int markedCellsCount = 0; // создаётся переменная (счётчик заполненных клеток) 
            do
            {
                #region Ввод координат хода r, c
                int r, c; //создаются переменные для координат 
                if (markedCellsCount % 2 == 0)
                {

                    Console.WriteLine("Введите номер строки");
                    try
                    {
                        r = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Неверно задано значение строки");
                        continue;
                    }
                    Console.WriteLine("Введите номер столбца");
                    try
                    {
                        c = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Неверно задано значение столбца");
                        continue;
                    }
                }
                else
                {
                    Random rnd = new Random();
                    r = rnd.Next(0, h);
                    c = rnd.Next(0, w);
                }

                #endregion
                #region Код для ходов игроков по очереди
                string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                if (arr[r, c] != "+")
                {
                    Console.WriteLine("Увы! Эта клетка занята!");
                    continue;
                }// если клетка заполнена, то заново ввод. Если нет, то дальше
                arr[r, c] = currentMarker;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.Write("\n");
                }//создание нового массива с ходом игрока 

                int markersCount = 0; //счётчик трёх маркеров подряд(победа)
                #region Все условия трёх маркеров 
                if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                {
                    markersCount = 2;

                    if (r - 2 >= 0 && arr[r - 2, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r + 1 < h && arr[r + 1, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r - 1 >= 0 && c + 1 < w && markersCount != 3 && arr[r - 1, c + 1] == currentMarker)
                {
                    markersCount = 2;

                    if (r - 2 >= 0 && c + 2 < w && arr[r - 2, c + 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r + 1 < h && c - 1 >= 0 && arr[r + 1, c - 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (c + 1 < w && markersCount != 3 && arr[r, c + 1] == currentMarker)
                {
                    markersCount = 2;

                    if (c + 2 < w && arr[r, c + 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (c - 1 >= 0 && arr[r, c - 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r + 1 < h && c + 1 < w && markersCount != 3 && arr[r + 1, c + 1] == currentMarker)
                {
                    markersCount = 2;

                    if (r + 2 < h && c + 2 < w && arr[r + 2, c + 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r - 1 >= 0 && c - 1 >= 0 && arr[r - 1, c - 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r + 1 < h && markersCount != 3 && arr[r + 1, c] == currentMarker)
                {
                    markersCount = 2;

                    if (r + 2 < h && arr[r + 2, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r + 1 < h && c - 1 >= 0 && markersCount != 3 && arr[r + 1, c - 1] == currentMarker)
                {
                    markersCount = 2;

                    if (r + 2 < h && c - 2 >= 0 && arr[r + 2, c - 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r - 1 >= 0 && c + 1 < w && arr[r - 1, c + 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (c - 1 >= 0 && markersCount != 3 && arr[r, c - 1] == currentMarker)
                {
                    markersCount = 2;

                    if (c - 2 >= 0 && arr[r, c - 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (c + 1 < w && arr[r, c + 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (c - 1 >= 0 && r - 1 >= 0 && markersCount != 3 && arr[r - 1, c - 1] == currentMarker)
                {
                    markersCount = 2;

                    if (c - 2 >= 0 && r - 2 >= 0 && arr[r - 2, c - 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (c + 1 < w && r + 1 >= 0 && arr[r + 1, c + 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }
                #endregion
                if (markersCount == 3)
                {
                    Console.WriteLine($"Игрок {currentMarker} победил!");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine();
                markedCellsCount++;
                #endregion
            }
            while (markedCellsCount <= w * h); //условия ничьи 

            Console.WriteLine("Однако, ничья!");

            Console.ReadLine();
        }
        static void Task3_4()
        {
            #region Создание игрового поля
            //создаётся массив
            Console.Write("Введите размеры поля. Ширина=");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота=");
            int h = Convert.ToInt32(Console.ReadLine());

            string[,] arr = GetStringArray2(h, w, "+");
            PrintStringArray2(arr);

            Console.WriteLine();
            #endregion
            int markedCellsCount = 0; // создаётся переменная (счётчик заполненных клеток) 
            do
            {
                #region  2 ии: Ввод координат хода r, c
                if (markedCellsCount == 0)
                {
                    Console.WriteLine("Игра компьютера с самим собой." +
                        "Чтобы начать, нажмите любую клавишу");
                }
                else
                {
                    Console.WriteLine("Чтобы сделать ход, нажмите Enter");
                }
                int r, c; //создаются переменные для координат 
                Console.ReadLine();
                Random rnd = new Random();
                r = rnd.Next(0, h);
                c = rnd.Next(0, w);
                #endregion

                #region Код для ходов игроков по очереди
                string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                if (arr[r, c] != "+")
                {

                    Console.WriteLine("Увы! Эта клетка занята!");
                    continue;
                }// если клетка заполнена, то заново ввод. Если нет, то дальше
                arr[r, c] = currentMarker;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.Write("\n");
                }//создание нового массива с ходом игрока 

                int markersCount = 0; //счётчик трёх маркеров подряд(победа)
                #region Все условия трёх маркеров 
                if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                {
                    markersCount = 2;

                    if (r - 2 >= 0 && arr[r - 2, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r + 1 < h && arr[r + 1, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r - 1 >= 0 && c + 1 < w && markersCount != 3 && arr[r - 1, c + 1] == currentMarker)
                {
                    markersCount = 2;

                    if (r - 2 >= 0 && c + 2 < w && arr[r - 2, c + 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r + 1 < h && c - 1 >= 0 && arr[r + 1, c - 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (c + 1 < w && markersCount != 3 && arr[r, c + 1] == currentMarker)
                {
                    markersCount = 2;

                    if (c + 2 < w && arr[r, c + 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (c - 1 >= 0 && arr[r, c - 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r + 1 < h && c + 1 < w && markersCount != 3 && arr[r + 1, c + 1] == currentMarker)
                {
                    markersCount = 2;

                    if (r + 2 < h && c + 2 < w && arr[r + 2, c + 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r - 1 >= 0 && c - 1 >= 0 && arr[r - 1, c - 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r + 1 < h && markersCount != 3 && arr[r + 1, c] == currentMarker)
                {
                    markersCount = 2;

                    if (r + 2 < h && arr[r + 2, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r - 1 >= 0 && arr[r - 1, c] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (r + 1 < h && c - 1 >= 0 && markersCount != 3 && arr[r + 1, c - 1] == currentMarker)
                {
                    markersCount = 2;

                    if (r + 2 < h && c - 2 >= 0 && arr[r + 2, c - 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (r - 1 >= 0 && c + 1 < w && arr[r - 1, c + 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (c - 1 >= 0 && markersCount != 3 && arr[r, c - 1] == currentMarker)
                {
                    markersCount = 2;

                    if (c - 2 >= 0 && arr[r, c - 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (c + 1 < w && arr[r, c + 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }

                if (c - 1 >= 0 && r - 1 >= 0 && markersCount != 3 && arr[r - 1, c - 1] == currentMarker)
                {
                    markersCount = 2;

                    if (c - 2 >= 0 && r - 2 >= 0 && arr[r - 2, c - 2] == currentMarker)
                    {
                        markersCount = 3;
                    }
                    else if (c + 1 < w && r + 1 >= 0 && arr[r + 1, c + 1] == currentMarker)
                    {
                        markersCount = 3;
                    }
                }
                #endregion
                if (markersCount == 3)
                {
                    Console.WriteLine($"Игрок {currentMarker} победил!");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine();
                markedCellsCount++;
                #endregion
            }
            while (markedCellsCount <= w * h); //условия ничьи 

            Console.WriteLine("Однако, ничья!");

            Console.ReadLine();
        }
        static void Task3_5()
        {
            // В введенном промежутке натуральных чисел найти те, количество делителей у которых не меньше введенного значения. Для найденных чисел вывести на экран количество делителей и все делители.

            Console.WriteLine("Введите первое число промежутка");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последнее число промежутка");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во делитей");
            int c = Convert.ToInt32(Console.ReadLine());

            Homework3 hw = new Homework3();
            
            Console.WriteLine(hw.SearchDividersAndCount(a,b,c));
                
            
        }
        static void Task3_6()
        {
            //Вывести на экран "прямоугольник", образованный из двух видов символов. Контур прямоугольника должен состоять из одного символа, а в "заливка" - из другого. 
            // Размеры прямоугольника, а также используемые символы задаются вводом с клавиатуры.

            Console.Write("Введите размеры поля. Ширина=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота=");
            int y = Convert.ToInt32(Console.ReadLine());
            string[,] arr = new string[y, x];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = "0";
                    if (j == 0 || j == arr.GetLength(1) - 1)
                    {
                        arr[i, j] = "|";
                    }
                    if (i == 0 || i == arr.GetLength(0) - 1)
                    {
                        arr[i, j] = "--";
                    }

                    Console.Write("{0,2}", arr[i, j]);
                }
                Console.Write("\n");
            }

        }
        static void Task3_7()
        {
            

            Console.Write("Введите кол-во чисел");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Введите цифру");
            int y = Convert.ToInt32(Console.ReadLine());

            int[] arr = GetRandomIntArray(x, 1, 100);
            PrintIntArray(arr);
            Homework3 hw = new Homework3();
            int count = hw.CountNumeralInArray(arr, y);
            Console.WriteLine($"количество цифр в случайной последовательности: {count}");
        }
        static void Task3_8()
        {
            Console.Write("Введите кол-во чисел массива:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            int[] arr = GetRandomIntArray(x, 1, 100);
            PrintIntArray(arr);

            Console.Write("\n");
            Console.Write("Массив из тех же чисел, отсортированный по возрастанию: \n");

            Homework3 hw = new Homework3();
            int[] res = hw.RearrangeInAscendingOrder(arr);

            PrintIntArray(res);
        }
        #endregion

        #region МЕТОДЫ ДЛЯ СОЗДАНИЯ И ВЫВОДА МАССИВОВ
        static int[] GetRandomIntArray(int length, int minRandom, int maxRandom)
        {
            int[] arr = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(minRandom, maxRandom);
            }

            return arr;
        }
        static void PrintIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {               
                Console.Write("{0,3} ", arr[i]);
            }
            Console.Write(" \n");
        } 
        static void PrintDoubleArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {               
                Console.Write("{0,3} ", arr[i]);
            }
            Console.Write(" \n");
        }
        static int[,] GetRandomIntArray2(int h, int w, int minRandom, int maxRandom)
        {
            int[,] arr = new int[h, w];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(minRandom, maxRandom);
                }
            }
            return arr;
        }
        static void PrintIntArray2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.Write("\n");
            }
        }
        static string[,] GetStringArray2(int h, int w, string symbol)
        {
            string[,] arr = new string[h, w];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = symbol;
                }
            }
            return arr;
        }
        static void PrintStringArray2(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.Write("\n");
            }
        }
        #endregion
    }
}
