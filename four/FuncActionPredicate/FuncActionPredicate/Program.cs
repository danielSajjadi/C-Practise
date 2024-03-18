using System;

    class Program
    {
        static void Main(string[] args)
        {
        // MathSum sumCal = new MathSum();
        // Func<int, int, int> cal = sumCal.Sum;
        Func<int, int, int> calcu = delegate (int a, int b) { return a + b; };

        //Func<int, int, int> calcu = (x, y) => x + y;
            //int calcu = cal(20, 60);

            Console.WriteLine("result -> " + calcu(20, 40));

        }
    }

    class MathSum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        
    }


