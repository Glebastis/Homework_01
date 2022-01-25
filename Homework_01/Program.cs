using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_01.Methods;

namespace Homework_01
{
    internal class Program
    {
        /// <summary>
        /// Входная точка в программу
        /// </summary>
        /// <param name="args"></param>
        /// 
        /* trying make pool request */
         
        static void Main(string[] args)
        {
            Application();
            Imt();
            Distance();
            ChangeValuesOfTwoVariables();
            CentralPrint();
            Methods cl1 = new Methods();
            cl1.Print();

        }

        //Метод, который принимает из консоли ввод, компанует вывод в трех вариантах кода и сразу выводит их
        static void Application()
        {
            Console.Title = "Анкета";
            Console.WriteLine("Добро пожаловать в заполнение анкеты!");
            System.Console.Write("Введите свое имя: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Введите свою фамилию: ");
            string surname = System.Console.ReadLine();
            System.Console.Write("Сколько Вам лет? ");
            string age = System.Console.ReadLine();
            System.Console.Write("Какой у Вас рост? (в сантиметрах) ");
            string tall = System.Console.ReadLine();
            System.Console.Write("Какой у Вас вес? (в килограммах) ");
            string weight = System.Console.ReadLine();
            System.Console.WriteLine("Данные из анкеты:");

            // Самый простой и стандартный метод
            System.Console.WriteLine(name + " " + surname + ", возраст " + age + ", рост " +
                tall + " сантиметров, вес " + weight + " кг");

            //Та же самая строка с форматированием
            System.Console.WriteLine("{0} {1}, возраст {2}, рост {3} сантиметров, вес {4} кг",
                name, surname, age, tall, weight);

            // И инкапсуляция
            System.Console.WriteLine($"{name} {surname}, возраст {age}, рост {tall} сантиметров, вес {weight} кг");
            System.Console.Write("Нажмите Enter для завершения работы подпрограммы");
            System.Console.ReadLine();
            System.Console.Clear();
        }

        //Метод, который рассчитывает индекс массы тела, на основании вводимых данных (ожидаются числа)
        static void Imt()
        {
            Console.Title = "Индекс массы тела";
            System.Console.Write("Введите свой вес (в килограммах) ");
            double weight = double.Parse(System.Console.ReadLine());
            System.Console.Write("Какой у Вас рост? (в сантиметрах) ");
            double tall = double.Parse(System.Console.ReadLine());
            double imt = weight / (tall / 100 * tall / 100);

            System.Console.WriteLine($"Ваш индекс массы тела равен {imt:F2}");
            System.Console.WriteLine("Нажмите Enter для завершения работы подпрограммы");
            System.Console.ReadLine();
            System.Console.Clear();

        }

        //Метод, который расчитывает расстояние между точками по их координатам с помощью теоремы Пифагора
        //Координаты нужно вводить вручную
        static void Distance()
        {
            Console.Title = "Расчет дистанции между точками";
            System.Console.Write("Введите координату х первой точки: ");
            double x1 = double.Parse(System.Console.ReadLine());
            System.Console.Write("Введите координату y первой точки: ");
            double y1 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Введите координату х второй точки: ");
            double x2 = double.Parse(System.Console.ReadLine());
            System.Console.Write("Введите координату y второй точки: ");
            double y2 = double.Parse(System.Console.ReadLine());

            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            System.Console.WriteLine($"Расстояние между точками равно: {dist:F2}");

            System.Console.WriteLine("Нажмите Enter для завершения работы подпрограммы");
            System.Console.ReadLine();
            System.Console.Clear();

        }

        //Метод, который меняет значения переменных друг на друга двумя способами
        static void ChangeValuesOfTwoVariables()
        {
            Console.Title = "Обмен значениями";
            System.Console.Write("Введите значение первой переменной: ");
            string first = System.Console.ReadLine();
            System.Console.Write("Введите значение второй переменной: ");
            string second = System.Console.ReadLine();

            System.Console.WriteLine($"Вы ввели значения: первой переменной - {first}, второй переменной - {second}");

            string temp = first;
            first = second;
            second = temp;


            System.Console.WriteLine("Теперь переменные обменялись значениями (использовалась третья переменная): ");
            System.Console.WriteLine("Значение первой переменной теперь равно {0}, а значение второй переменной - {1}", first, second);
            System.Console.WriteLine("Поменять значения переменных можно также с помощью кортежей");

            (first, second) = (second, first);

            System.Console.WriteLine("Значение первой переменной снова равно {0}, а значение второй переменной - снова {1}", first, second);


            System.Console.WriteLine("Нажмите Enter для завершения работы подпрограммы");
            System.Console.ReadLine();
            System.Console.Clear();
        }

        static void CentralPrint()
        {
            Console.Title = "Сообщение по центру";
            System.Console.Write("Введите свое имя: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Введите свою фамилию: ");
            string surname = System.Console.ReadLine();
            System.Console.Write("Введите город проживания: ");
            string citi = System.Console.ReadLine();
            System.Console.Clear();

            string centerText = name + " " + surname + " " + citi;

            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(centerText);

            //Ждём нажатия клавиши перед выходом
            Console.ReadKey();
            System.Console.Clear();

        }
        
    }

}
