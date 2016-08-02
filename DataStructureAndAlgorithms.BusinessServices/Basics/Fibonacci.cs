using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class Fibonacci
    {
        public int N { get; set; }

        public Fibonacci(int n)
        {
            N = n;
        }

        public double RecursiveSolution()
        {
            double number = Fib(N);
            return number;
        }

        private double Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        public double NonRecursive()
        {
            if (N == 0 || N == 1)
            {
                return N;
            }

            double[] arr = new double[N + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= N; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[N];
        }
    }
}
