using System;

namespace HomeWork.Abstraction
{
//    Создайте абстрактный класс Человек, определите свойство Name и абстрактный метод SayHello().
//От этого класса создайте несколько наследников, которые представляют национальность(украинец, американец...). Должно получиться так, что при вызове метода SayHello() выводилось приветствие на языке соответствующему национальности(Привіт, Hi...).

    class Program
    {
        static void Main(string[] args)
        {
            Human[] international = new Human[3];
            international[0] = new Ukrainian("Taras");
            international[1] = new American("Bob");
            international[2] = new Italian("Luiggi");
            foreach (Human p in international)
            {
                Console.Write(p.ToString()+" ");
                p.SayHello();
            }
        }
    }
}
