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
        public int CenterX { get => cX; set => value = cX; }
        public int CenterY { get => cY; set => value = cY; }
        public int Radius { get => radius; set => value = radius; }
        public Circle()
        {
            if (!(Dialog.GetCoordinates("Введите координаты центра X", out cX)
                && Dialog.GetCoordinates("Введите координаты центра Y", out cY)
                && Dialog.GetCoordinates("Enter radius", out radius)))
            {
                throw new Exception("you are cancel");
            }

        }
        public Circle(int centerX, int centerY, int radius)
        {
            cX = centerX;
            cY = centerY;
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return GetCircumference(this);
        }
        public double GetCircumference(Circle c)
        {
            return GetCircumference(c.radius);
        }
        public double GetCircumference(int radius)
        {
            return (double)2 * Math.PI * radius;
        }

        public bool CheckPoint(int x, int y)
        {
            //(x - x0) ^ 2 + (y - y0) ^ 2 <= R ^ 2
            return Math.Pow(x - CenterX, 2) + Math.Pow(y - CenterY, 2) <= Math.Pow(Radius, 2);
        }
        public override string ToString()
        {

            string str = "\nX={0} Y={1} R={2}";
            return String.Format(str, cX, cY, radius);
           
        }
    }
}
