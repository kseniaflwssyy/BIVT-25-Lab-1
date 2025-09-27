using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer;
            //code here
            double a = Math.Abs(d);
            answer = a >= 1.0;
            //end
            return answer;
        }

        public bool Task2(double d, double f)
        {
            bool answer = false;
            //code here
            double average = (d + f) / 2;
            answer = average > 0;
            //end
            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;
            //code here
            int sum = a + b;
            double averageModulus = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            answer = sum > averageModulus;
            //end
            return answer;
        }

        public int Task4(int a, int b, int c)
        {
            int answer = 0;
            //code here
            answer = a;
            if (b > answer) answer = b;
            if (c > answer) answer = c;
            //end
            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;
            //code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }
            //end
            return answer;
        }

        public bool Task6(double x, double y)
        {
            bool answer = false;
            //code here
            if (y > 0)
            {
                if (x < 0)
                {
                    answer = y <= 1 + x;
                }
                else
                {
                    answer = y <= 1 - x;
                }
            }
            //end
            //алгоритм возвращает false в том случае, если точка не прошла все проверки условий, значит
            //она не принадлежит треугольнику, а если же она удовлетворяет всем условиям, то false меняется на true<
            //и точка принадлежит треугольнику 
            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;
            //code here
            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
            //end
            return answer;
        }

        public bool Task8(int X, int Y)
        {
            bool answer = false;
            //code here
            int days = X;
            int wakeup = 14; 
            int sleep = 4;   

            for (int day = 0; day <= days; day++)
            {
                wakeup -= 1;
                if (day % 2 == 0)
                {
                    sleep -= Y / 60;
                }
                int sleepDuration = wakeup - sleep;
                if (sleepDuration >= 7 && sleepDuration <= 9 && wakeup == 7)
                {
                    answer = true;
                    break;
                }
                if (sleep < 0) sleep += 24;
                if (wakeup < 0) wakeup += 24;
            }
            //end
            return answer;
        }
    }
}