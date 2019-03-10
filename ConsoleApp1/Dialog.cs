using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.MethodOverloading
{
    static class Dialog
    {
        public static bool GetCoordinates(string strRequest, out int x, bool clearscreen=true)
        {
            return RequestCoordinates(strRequest, out x, clearscreen);
        }

        private static bool RequestCoordinates(string strRequest, out int coord, bool clearscreen)
        {
            bool res = false;
            coord = 0;
            string strRequestFull = strRequest + " (q-выход)";
            do
            {
                if (clearscreen)
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
