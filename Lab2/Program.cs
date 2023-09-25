using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        //116, 123, 142, 179, 30
        static void Task30()
        {
            /* Дана последовательность натуральных чисел а1, а2, ..., an. 
            * Создать массив из четных чисел этой последовательности.
            * Если таких чисел нет, то вывести сообщение об этом факте.*/

            Random random = new Random();

            int number;

            Console.WriteLine("Задание 30");
            Console.Write("Введите число: ");
            //Проверка на правильный ввод числа размерности массива
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1)
                    {
                        Console.WriteLine("Массив должен содержать минимум 1");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Число должно быть натуральным числом");
                }
            }
            int[] myArr = new int[number];

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = random.Next(1, 50);
                Console.Write(myArr[i] + " ");
            }

            Console.WriteLine();

            int count2 = 0;

            int[] array2 = new int[0];

            //В цикле есть if котрый проверяет четность элемента массива,если текущий элемент массива myArr четный,
            //то сначала изменяется размер массива array2 с использованием метода Array.Resize.
            //Затем значение четного элемента добавляется в массив array2 на позицию count2, и значение count2 увеличивается на 1.
            //Это позволяет найти и сохранить все четные числа из массива myArr в новом массиве array2

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    Array.Resize(ref array2, array2.Length + 1);
                    array2[count2] = myArr[i];
                    count2++;
                }

            }
            //Проверка на то,пуст ли массив или нет.Если в нем нет четных чисел то выводиться сообщение об этом.
            if (array2.Length != 0)
            {
                foreach (int value in array2)
                {
                    Console.Write(value + " ");
                }
            }
            else
            {
                Console.WriteLine("Нет четных чисел в массиве");
            }

            Console.WriteLine("\nЗадание 30 окончено");

        }

        static void Task116()
        {
            /*116.На k-e место одномерного массива целых чисел вставить элемент, 
            * равный разности двух введенных с клавиатуры элементов.*/
            Random random = new Random();
            int[] array = new int[random.Next(1, 15)];
            int k, first_num, second_num, div_result = 0;


            Console.WriteLine("\nЗадание 116");
            Console.WriteLine("Введите делитель и делимое");
            first_num = int.Parse(Console.ReadLine());
            second_num = int.Parse(Console.ReadLine());

            div_result = first_num / second_num;
            Console.WriteLine("Результат деления=" + div_result);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nВведите число на место которого будет вставлен элемент в массиве");
            while (true)
            {
                try
                {
                    k = int.Parse(Console.ReadLine());
                    if (k > array.Length || k < 0)
                    {
                        Console.WriteLine("Число превышает или меньше размерности массива");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Число должно быть натуральным числом");
                }
            }


            int[] newArray = new int[array.Length + 1];

            newArray[k] = div_result;

            //В данном цикле идет заполнение нового массива элементами из прошлого до введенного индекса k
            for (int i = 0; i < k; i++)
            {
                newArray[i] = array[i];
            }
            //В этом цикле начало с индекса по которому мы добовляли элемент в новый массив поэтому в квадратных скобках написан сдвиг на одну единицу для того чтобы не перезаписывать вставленный элемент
            for (int i = k; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;

            Console.WriteLine("\n");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nЗадание 116 окончено");

        }


        static void Task123()
        {
            /*Дана последовательность целых положительных чисел.
            Найти произведение только тех из них, которые больше заданного числа М.
            Если таких чисел нет, то выдать сообщение об этом.*/

            Random random = new Random();
            int[] array = new int[random.Next(1, 15)];
            int M = random.Next(1, 30), multi = 1;

            Console.WriteLine("\nЗадание 123");
            Console.WriteLine("Ваше число м: " + M);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > M)
                {
                    multi *= array[i];
                }
            }

            if (multi == 1)
            {
                Console.WriteLine("Чисел больше M не существует");
            }
            else
            {
                Console.Write(multi);
            }
            Console.WriteLine("\nЗадание 123 окончено");


        }
        static void Task142()
        {
            /*Дана последовательность вещественных чисел а1, а2, ..., an.
            * Требуется умножить все члены последовательности а1, а2, ..., 
            * an на квадрат ее наименьшего члена,если аk ≥ 0,
            * и на квадрат ее наибольшего члена, если аk < 0(1 ≤ k ≤ n).
            */

            Random random = new Random();
            double[] array = new double[random.Next(1, 15)];
           
            Console.WriteLine("\nЗадание 142");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * 20 - 10, 2);
                Console.Write(array[i] + " ");
            }

            double min = array[0];
            double max = array[0];
            foreach (int element in array)
            {
                if (element < min)
                    min = element;
                if (element > max)
                    max = element;
            }

            int k = random.Next(0, array.Length);
            Console.WriteLine("\nМаксимальный элемент массива= " + max + " Минимальный элемент массива= " + min + " k= " + k);
            //Если аk ≥ 0, элементы массива умножаются на квадрат наименьшего члена,если аk < 0 на квадрат ее наибольшего члена
            if (array[k] >= 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] * (int)Math.Pow(min, 2);
                }

            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] * (int)Math.Pow(max, 2);
                }
            }

            Console.WriteLine("Перемноженная последовательность:");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nЗадание 142 окончено");


        }
        static void Task179()
        {
            /*Задан массив вещественных чисел и натуральные числа R и H<R. 
             * Создать и заполнить массив номеров таких чисел исходного массива, 
             * которые отличаются от R не более чем на Н.*/

            Random random = new Random();
            double[] array = new double[random.Next(1, 15)];


            int R = random.Next(1, 10);

            int H = random.Next(0, R);

            Console.WriteLine("\nЗадание 179");

            Console.WriteLine("R=" + R + " H=" + H);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * 20 - 10, 2);
                Console.Write(array[i] + " ");
            }

            int[] newArr = new int[array.Length];
            int count = 0;
            //Цикл for перебирает элементы массива array, и если значение элемента находится в интервале то его индекс добавляется в массив newArr, и счетчик count увеличивается
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] >= R - H && array[i] <= R + H)
                {
                    newArr[count] = i;
                    count++;
                }
            }
            Console.WriteLine("\nМассив номеров которые отличаются от R не более чем на Н:");
            for (int i = 0; i < count; i++)
            {

                Console.Write(newArr[i] + " ");
            }

            Console.WriteLine("\nЗадание 179 окончено");

        }
        static void Main(string[] args)
        {

            Task30();
            Task116();
            Task123();
            Task142();
            Task179();
            Console.ReadLine();

        }
    }
}
