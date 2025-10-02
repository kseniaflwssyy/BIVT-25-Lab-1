namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double a = Math.Abs(d);
            answer = a >= 1.0;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double average = (d + f) / 2.0;
            answer = average > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int sum = a + b;
            double averageModulus = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            answer = sum > averageModulus;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = a;
            if (b > answer) answer = b;
            if (c > answer) answer = c;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y < 0)
            {
                answer = false;
            }
            else if ((x < 0) & (y <= (x + 1)))
            {
                answer = true;
            }
            else if ((x >= 0) & (y <= (1 - x)))
            {
                answer = true;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
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
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int SumY = 0;
            if (X >= 7)
            {
                for (int i = 0; i < X; i++)
                {
                    if ((i % 2) == 0) { SumY += Y; }

                }
                if ((SumY >= 4 * 60) && (SumY <= 6 * 60))
                    answer = true;
            }
            // end

            return answer;
        }
    }
}

