using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.MethodOverloading
{
    class Circle
    {
        private int cX;
        private int cY;
        private int radius;
        public int CenterX { get => cX; }
        public int CenterY { get => cY; }
        public int Radius { get; }
        public Circle()
        {
            if ((RequestCoordinates("Введите координаты центра X", out cX))
                && (RequestCoordinates("Введите координаты центра Y", out cY))
                && (RequestCoordinates("Enter radius", out radius)))
                { }
            else
            {
                throw new Exception("you are cancel");
            }

        }
        public Circle(int centerX, int centerY, int radius)
        {
            this.cX = centerX;
            this.cY = centerY;
            this.radius = radius;
        }

        private static bool RequestCoordinates(string strRequest, out int coord)
        {
            bool res = false;
            coord = 0;
            string strRequestFull = strRequest + " (q-выход)";
            do
            {
                Console.Clear();
                Console.Write(strRequestFull);
                string str = Console.ReadLine();
                if (str == "q") break;
                if (int.TryParse(str, out coord))
                {
                    res = true;
                }
                    
            } while (!res);

            return res;
        }
    }
}
