using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Lab_01_Console
{
    public static class TaskSolution
    {
        //Знайти максимальне за модулем число 
        public static int RunTaskA(int a, int b, int c)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            if (a > b && a > c) return a;
            else if (b > c) return b;
            else return c;
        }

        //Знайти значення виразу a*2+b*3+c*4 
        public static int RunTaskB(int a, int b, int c)
        {

            return a*2+b*3+c*4;
        }

        //Знайти площу трикутника зі сторонами a,b,c
        public static int RunTaskC(int a, int b, int c)
        {

            //gerona
            double p = ((double)(a + b + c) / 2);
            double S= Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return (int)S;
        }
    }
}
