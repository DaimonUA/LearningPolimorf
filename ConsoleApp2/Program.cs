using System;

namespace TypeConversion
{
    //Есть следующий код:
//    В цикле foreach нужно написать код, который бы выполнял следующую логику:
//1. Вызывает метод Bite у всех объектов в массиве arrAnimal;
//2. Вызывает метод Purr только у тех объектов, которые являются экземплярами класса Cat(данный пункт необходимо реализовать 3 способами).

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] arrAnimal = new Animal[6];
            arrAnimal[0] = new Dog { Name = "Шарик" };
            arrAnimal[1] = new Cat { Name = "Кусака" };
            arrAnimal[2] = new Cat { Name = "Ленивец" };
            arrAnimal[3] = new Dog { Name = "Джек" };
            arrAnimal[4] = new Cat { Name = "Черныш" };
            arrAnimal[5] = new Dog { Name = "Арчи" };
            foreach (Animal a in arrAnimal)
            {
                // Ваш код
                a.Bite();
                if(a is Cat)
                {
                    ((Cat)a).Purr();
                }
                if ((a as Cat)!=null)
                {
                    ((Cat)a).Purr();
                }
                try
                {
                    ((Cat)a).Purr();
                }
                catch
                { }
            }
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Bite();
    }

    public class Dog : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Собака {0} кусает", Name);
        }
    }

    public class Cat : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Кошка {0} кусает", Name);
        }
        public void Purr()
        {
            Console.WriteLine("Кошка {0} мурчит", Name);
        }
    }

}
