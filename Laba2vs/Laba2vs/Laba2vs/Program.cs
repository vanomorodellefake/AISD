using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2vs
{
    class Program
    {
        static double var9(int n, double x, bool flag, double result=1)
        {
            if (n > 1) return Math.Sqrt(x + (x - 4) * var9(n - 1, x + 1, flag));
            else
            {
                if (flag == true)
                    return Math.Sqrt(x + x - 4);
                else
                    return result;
            }
                
        }
        static void Main(string[] args)
        {
            double result=1, x=6;
            Console.Write("Введите глубину:");
            int n = Convert.ToInt32(Console.ReadLine());
            int init = n;
            if (n > 5000)
            {
                while (n > 0)
                {
                    if (n==init)
                    {
                        x = 6 + init - n;
                        result = var9(5000, x, true);
                        n -= 5000;
                    }
                    else if (n > 5000)
                    {
                        x = 6 + init - n;
                        result = var9(5000, x, false, result);
                        n -= 5000;
                    }
                    else
                    {
                        x = 6;
                        result = var9(n, x, false, result);
                        break;
                    }
                }
            }
            else
            {
                result = var9(n, x, true);
            }
                
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
