using System;
using System.Collections;
using System.Collections.Generic;

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
            //Animal[] arrAnimal = new Animal[6];
            //arrAnimal[0] = new Dog { Name = "Шарик" };
            //arrAnimal[1] = new Cat { Name = "Кусака" };
            //arrAnimal[2] = new Cat { Name = "Ленивец" };
            //arrAnimal[3] = new Dog { Name = "Джек" };
            //arrAnimal[4] = new Cat { Name = "Черныш" };
            //arrAnimal[5] = new Dog { Name = "Арчи" };

            //ArrayList arrAnimal = new ArrayList();
            //arrAnimal.Add(new Dog { Name = "Шарик" });
            //arrAnimal.Add(new Cat { Name = "Кусака" });
            //arrAnimal.Add(new Cat { Name = "Ленивец" });
            //arrAnimal.Add(new Dog { Name = "Джек" });
            //arrAnimal.Add(new Cat { Name = "Черныш" });
            //arrAnimal.Add(new Dog { Name = "Арчи" });

            //List<Animal> arrAnimal = new List<Animal>();
            //arrAnimal.Add(new Dog { Name = "Шарик" });
            //arrAnimal.Add(new Cat { Name = "Кусака" });
            //arrAnimal.Add(new Cat { Name = "Ленивец" });
            //arrAnimal.Add(new Dog { Name = "Джек" });
            //arrAnimal.Add(new Cat { Name = "Черныш" });
            //arrAnimal.Add(new Dog { Name = "Арчи" });

            //LinkedList<Animal> arrAnimal = new LinkedList<Animal>();
            //arrAnimal.AddFirst(new Dog { Name = "Шарик" });
            //arrAnimal.AddLast(new Cat { Name = "Кусака" });
            //arrAnimal.AddLast(new Cat { Name = "Ленивец" });
            //arrAnimal.AddLast(new Dog { Name = "Джек" });
            //arrAnimal.AddLast(new Cat { Name = "Черныш" });
            //arrAnimal.AddLast(new Dog { Name = "Арчи" });

            Dictionary<string,Animal> arrAnimal = new Dictionary<string,Animal>();
            arrAnimal.Add("dog_0",new Dog { Name = "Шарик" });
            arrAnimal.Add("cat_0", new Cat { Name = "Кусака" });
            arrAnimal.Add("cat_1", new Cat { Name = "Ленивец" });
            arrAnimal.Add("dog_1", new Dog { Name = "Джек" });
            arrAnimal.Add("cat_2", new Cat { Name = "Черныш" });
            arrAnimal.Add("dog_2", new Dog { Name = "Арчи" });


            foreach (KeyValuePair<string,Animal> a0 in arrAnimal)
            {
                // Ваш код
                Animal a = a0.Value;
                Console.Write(a0.Key);
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
