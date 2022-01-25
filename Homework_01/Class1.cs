using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    public class Methods
    {
        public void Print(string str = "some string")
        {
            Console.Title = "Сообщение по центру";

            int centerX = (Console.WindowWidth / 2) - (str.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(str);

            //Ждём нажатия клавиши перед выходом
            Console.ReadKey();
        }
    }
}