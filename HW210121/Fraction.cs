using System;

namespace HW210121
{
    public class Fraction
    {
        public double Numerator { get; set; }

        private double denominator;

        public double Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                    throw new ArgumentNullException("Denominator", "Denominator can not be zero!");

                denominator = value;
            }
        }


        private Fraction()
        {
        }

        public Fraction(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public static Fraction Add(Fraction first, Fraction second)
        {
            var result = new Fraction();

            if (first.Denominator == second.Denominator)
            {
                result.Numerator = first.Numerator + second.Numerator;
                result.Denominator = first.Denominator;
            }
            else
            {
                result.Denominator = first.Denominator * second.Denominator;
                var firstNumerator = first.Numerator * second.Denominator;
                var secondNumerator = second.Numerator * first.Denominator;
                result.Numerator = firstNumerator + secondNumerator;
            }

            return result;
        }

        public static Fraction Sub(Fraction first, Fraction second)
        {
            var result = new Fraction();
            if (first.Denominator == second.Denominator)
            {
                result.Numerator = first.Numerator - second.Numerator;
                result.Denominator = first.Denominator;
            }
            else
            {
                result.Denominator = first.Denominator * second.Denominator;
                var firstNumerator = first.Numerator * second.Denominator;
                var secondNumerator = second.Numerator * first.Denominator;
                result.Numerator = firstNumerator - secondNumerator;
            }

            return result;
        }

        public static Fraction Mult(Fraction first, Fraction second)
        {
            return new Fraction
            {
                Numerator = first.Numerator * second.Numerator,
                Denominator = first.Denominator * second.Denominator
            };
        }

        public static Fraction Div(Fraction first, Fraction second)
        {
            return new Fraction
            {
                Numerator = first.Numerator * second.Denominator,
                Denominator = first.Denominator * second.Numerator
            };
        }


        public void Show()
        {
            Reduce();

            if (Denominator != 1)
            {
                Console.WriteLine("{0}/{1}", Numerator, Denominator);
            }
            else
            {
                Console.WriteLine(Numerator);
            }
        }


        private void Reduce()
        {
            int numerator = (int)(this.Numerator * GetTens(GetFloatingLength((this.Numerator))));
            int denominator = (int)(this.Denominator * GetTens(GetFloatingLength((this.Denominator))));


            int divisor = GCD(numerator, denominator);

            if (divisor != 1)
            {
                Numerator = Numerator / divisor;
                Denominator = Denominator / divisor;
            }
        }

        private long GetTens(int size)
        {
            long tens = 1;

            while (size != 0)
            {
                tens *= 10;
                size--;
            }

            return tens;
        }

        private int GetFloatingLength(double num)
        {
            int counter = 0;
            int precision = 2;

            while (num - (int) num > 0.01 && counter < precision)
            {
                num *= 10;
                counter++;
            }

            return counter;
        }

        private int GCD(int num1, int num2)
        {
            if (num1 == 0)
                return num2;

            var remainder = 0;
            var result = 0;
            var second = 0;

            if (num1 < num2)
            {
                result = num2 / num1;
                remainder = num2 - (result * num1);
                second = num1;
            }
            else
            {
                result = num1 / num2;
                remainder = num1 - (result * num2);
                second = num2;
            }

            return GCD(remainder, second);
        }

    }
}