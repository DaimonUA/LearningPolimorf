using System;

namespace ConsoleApp3
{

    class Program
    {
        public static void Main()
        {
            A a = new D();
            B b = new D();
            C c = new V(false);
            D d = new V(true);
            int x = d.Aa;
            V v = new V(true);

            a.Print(); //B
            b.Print(); //B
            c.Print(); //D
            d.Print(); //D
            v.Print(); //
            Console.WriteLine(x);
        }
        class A
        {
            private int aa;
            internal virtual int Aa { get => aa; set => aa = value; }
            public A(){
                
            }
            public virtual void Print()
            {
                Console.WriteLine("А");
            }
        }
        class B : A
        {
            internal sealed override int Aa { get => base.Aa; set => base.Aa = value; }

            public override void Print()
            {
                Console.WriteLine("B");
            }
        }
        class C : B
        {
            public new virtual void Print()
            {
                Console.WriteLine("C");
            }
        }
        class D : C
        {
            public override void Print()
            {
                Console.WriteLine("D");
            }
        }
        class V:D
        {
            private bool vip;
            public bool Vip { get => vip; set => value = vip; }
            public V(bool vp) {
                this.vip = vp;
            }
            public override void Print()
            {
                Console.WriteLine(vip);
            }
        }
    }

}
