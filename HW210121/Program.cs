using System;

namespace HW210121
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
        }

        static void Exercise1()
        {
            /*
             * Point class yazilsin
                1.x,y fieldleri olsun ve her bir field uchun yazilsin,
                constructor parametric , default 
                ShowData method yazilsin
             */
            var p1 = new Point(10, 15);

            p1.ShowData();
        }

        static void Exercise2()
        {
            var counter = new Counter {Min = 0, Max = 100};

            for (int i = 0; i < 100; i++)
            {
                counter.Increment();
                Console.WriteLine(counter.GetCurrent());
            }

        }

        static void Exercise3()
        {

        }

        static void Exercise4()
        {
            var car1 = new Car("F10", "BMW", 100, new DateTime(2010, 11, 1));

            car1.Show();
            Console.WriteLine("Age: {0}", car1.GetAge());
        }
    }
}