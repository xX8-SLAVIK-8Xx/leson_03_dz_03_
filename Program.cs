using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leson_03_dz_03_.Program;

namespace leson_03_dz_03_
{
    internal class Program
    {
        public interface IOutput
        {
            void Show();
            void Show(string info);
        }
        public interface IMath
        {
            int Max();
            int Min();
            float Avg();    
            bool Search(int valueToSearch); 

        }
        public interface ISort
        {
            void SortAsc();                // Сортировка по возрастанию
            void SortDesc();               // Сортировка по убыванию
            void SortByParam(bool isAsc);  // Сортировка по параметру ( trye false )
        }
        public class MyArray : IOutput, IMath , ISort
        {
            public int[] _my_array;
            public MyArray(int[] my_array)
            {
                _my_array = my_array;
            }
            //dz_1
            public void Show()           //IOutput
            {
                Console.WriteLine($"Элементы массива: " + string.Join(",", _my_array));
            }
            public void Show(string info)//IOutput 
            {
                Console.WriteLine(info);
                Console.WriteLine($"Элементы массива: " + string.Join(",", _my_array));
            }
            //dz_2
            public int Max() => _my_array.Max(); //IMath                       // Возвращает максимальный элемент массива
            public int Min() => _my_array.Min(); //IMath                       // Возвращает минимальный элемент массива
            public float Avg() => (float)_my_array.Average();//IMath           // Возвращает среднеарифметическое значение
            public bool Search(int valueToSearch) => _my_array.Contains(valueToSearch);//IMath  // Ищет значение в массиве
            //dz_3                                                                           
            public void SortAsc()  // Реализация метода SortAsc(), который сортирует массив по возрастанию
            {
                Array.Sort(_my_array);
            }
            public void SortDesc() // Реализация метода SortDesc(), который сортирует массив по убыванию
            {
                Array.Sort(_my_array);
                Array.Reverse(_my_array);
            }
            public void SortByParam(bool isAsc)// Реализация метода SortByParam(), который сортирует массив в зависимости от переданного параметра
            {
                if (isAsc)
                {
                    SortAsc();
                }
                else
                {
                    SortDesc();
                }
            }
        }
        public static void Line() => Console.WriteLine("==========================================================================================================");

        static void Main(string[] args)
        {
            //Задание 1
            //Создайте интерфейс IOutput.
            //В нем должны быть два метода:
            //■ void Show() – отображает информацию;
            //■ void Show(string info) — отображение информации и информационного сообщения, указанного в параметре info.
            //Создайте класс MyArray(массив целого типа) с необходимыми методами.
            //Этот класс должен имплементировать интерфейс IOutput.
            //Метод Show() – отображает на экран элементы массива.
            //Метод Show(string info) – отображает на экране элементы массива и информационное сообщение, указанное в параметре info.
            //Напишите код тестирования полученной функциональности.

            //Задание 2
            //Создайте интерфейс IMath.
            //В нем должно быть четыре метода:
            //■ int Max() — возвращает максимум;
            //■ int Min() — возвращает минимум;
            //■ float Avg() — возвращает среднеарифметическое;
            //■ bool Search(int valueToSearch) – ищет valueSearch внутри контейнера данных.
            //– Возвращает true, если значение найдено.
            //- Возвращает false, если значение не найдено.
            //Класс, созданный в первой задаче Array, должен имплементировать интерфейс IMath.
            //Метод Max – возвращает максимум среди элементов массива.
            //Метод Min – возвращает минимум среди элементов массива.
            //Метод Avg – возвращает среднеарифметическое среди элементов массива.
            //Метод Search – ищет значение внутри массива.
            //– Возвращает true, если значение найдено.
            //- Возвращает false, если значение не найдено.
            //Напишите код для тестирования полученной функциональности

            //Задание 3
            //Создайте интерфейс ISort.
            //В нем должно быть три метода:
            //■ void SortAsc() — сортировка по росту;
            //■ void SortDesc() — сортировка по убыванию;
            //■ void SortByParam(bool isAsc) — сортировка в зависимости от переданного параметра.
            //Если isAsc равен true, сортируем по возрастанию.
            //Если isAsc равен false, сортируем по убыванию
            //Класс, созданный в первой задаче Array, должен имплементировать интерфейс ISort.
            //Метод SortAsc – сортирует массив по росту.
            //Метод SortDesc – сортирует массив по убыванию.
            //Способ SortByParam – сортирует массив в зависимости от переданного параметра.
            //Если isAsc равен true, сортируем по возрастанию.
            //Если isAsc равен false, сортируем по убыванию.
            //Напишите код тестирования полученной функциональности.

            int[] array = { 5, 3, 8, 6, 1 };
            MyArray myArray = new MyArray(array);
            Line();
            myArray.Show();                          
            myArray.SortAsc();                       
            Line();
            myArray.Show("После сортировки по возрастанию:");
            myArray.SortDesc();                           
            Line();
            myArray.Show("После сортировки по убыванию:");
            Line();
            Console.WriteLine($"Максимум: {myArray.Max()}");
            Line();
            Console.WriteLine($"Минимум : {myArray.Min()}");
            Line();
            Console.WriteLine($"Среднее значение: {myArray.Avg()}");
            Line();
            int valueToSearch = 6;
            Console.WriteLine($"Значение {valueToSearch}    найдено: {myArray.Search(valueToSearch)}");
            Line();
            int valueToSearch_ = 9;
            Console.WriteLine($"Значение {valueToSearch_} не найдено: {myArray.Search(valueToSearch_)}");
            Line();
        }


    }
}
