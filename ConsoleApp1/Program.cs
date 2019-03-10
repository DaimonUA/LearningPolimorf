using System;

//Задание №2. Перегрузка методов
//Создайте класс Круг и реализуйте следующий функционал:

//1. Перегрузите конструктор:
//– Пустой конструктор;
//– Запрашивает координаты центра круга, его радиус и инициализирует объект;
//2. Перегрузите метод получения длины окружности(L = 2 * π * R) :
//– Метод без параметров возвращает длину окружности для текущего объекта;
//– Метод принимает радиус и возвращает длину окружности для заданного радиуса;
//3. Перегрузите метод получения объекта-круга:
//– Метод без параметров возвращает копию текущего объекта круга;
//– Метод принимает координаты центра круг, его радиус и возвращает объект круга с заданными параметрами;
//4. Метод проверки попадания точки в круг;
//5. Метод преобразования текущего состояния объекта в символьную строку.

namespace HomeWork.MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mode = GetMode();
            if (mode == 2) return;
            Circle circ0 = (Circle)null;
            if (mode == 0)
            {

                try
                {
                    circ0 = new Circle();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
            else
                circ0 = new Circle(0, 0, 10);
            // finally { }
            //длина окружности
            if (circ0.Radius > 0)
            {
                Console.WriteLine(circ0.GetCircumference());
                Console.WriteLine(circ0.GetCircumference(circ0.Radius));
                Console.WriteLine(circ0.GetCircumference(circ0));
            };
            //попадание произвольной точки в окружность
            int x; int y;
            if (Dialog.GetCoordinates("Введите координату X произвольной точки:", out x,false)
                && Dialog.GetCoordinates("Введите координату Y произвольной точки:", out y,false))
            {
                if (circ0.CheckPoint(x, y))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("Noooo");
            }
            //override ToString()
            Console.WriteLine(circ0.ToString());
        }
        static byte GetMode()
        {
            Console.WriteLine("Выберите режим работы с кругом (0-произвольный,1-дефолтный,другое - выход):");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            if (key.KeyChar =='0')
            return  0;
            if (key.KeyChar == '1')
                return 1;
            return 2;
        }
    }



}
