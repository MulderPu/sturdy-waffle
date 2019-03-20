using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter[] myCounters = new Counter[3];
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            //Console.Write(myCounters);
            for (int i = 0; i < 4; i++)
            {
                myCounters[0].Increment();
            }

            for (int i = 0; i < 9; i++)
            {
                myCounters[1].Increment();
            }

            // print counters
            PrintCounters(myCounters);
            Console.WriteLine("---------------------------------------------");

            // reset counter 2
            myCounters[2].Reset();

            // check counter again
            PrintCounters(myCounters);

            Console.ReadLine();
        }

        private static void PrintCounters(Counter[] counters)
        {
            int a = 0;
            foreach (var item in counters)
            {
                Console.WriteLine("Counter[{0}]: Name {1} is {2}", a, item.Name, item.Value);
                a++;
            }
        }
    }

    public class Counter
    {
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count++;
        }

        public void Reset()
        {
            _count = 0;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Value
        {
            get
            {
                return _count;
            }
        }
    }
}
