using System;

    class Program
    {
        static void Main(string[] args)
        {
            MathSum sumCal = new MathSum();
            Func<int, int, int> cal = sumCal.Sum;

            int calcu = cal(20, 60);

            Console.WriteLine("result -> " + calcu);

        }
    }

    class MathSum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        
    }


