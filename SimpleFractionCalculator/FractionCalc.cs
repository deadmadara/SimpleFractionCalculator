using System;

namespace SimpleFractionCalculator
{
    class Fraction
    {
        private int top;
        private int bottom;

        public Fraction() { }
        private Fraction(int a, int b)
        {
            if (a == 0) a = 1;
            if (b == 0) b = 1;
            top = a; bottom = b;
        }
        private Fraction (string s)
        {
            string[] elems = s.Split('/');
            int a = Convert.ToInt32(elems[0]);
            int b = Convert.ToInt32(elems[1]);
            if (a == 0) a = 1;
            if (b == 0) b = 1;
            top = a; bottom = b;
        }
        private void reducate()
        {
            int a = top;
            int b = bottom;

            while (b % a != 0)
            {
                a = b - a * (b / a);
            }

            top /= a;
            bottom /= a;
        }
        private string show()
        {
            return top.ToString() + "/" + bottom.ToString();
        }
        private Fraction add(Fraction a, Fraction b)
        {
            return new Fraction(a.top*b.bottom + b.top*a.bottom, a.bottom * b.bottom);
        }
        private Fraction substract(Fraction a, Fraction b)
        {
            return new Fraction(a.top * b.bottom - b.top * a.bottom, a.bottom * b.bottom);
        }
        private Fraction multiply(Fraction a, Fraction b)
        {
            return new Fraction(a.top * b.top, a.bottom * b.bottom);
        }
        private Fraction divide(Fraction a, Fraction b)
        {
            return new Fraction(a.top * b.bottom, a.bottom * b.top);
        }
        public string handle(string s)
        {
            char[] operators = new char[] { '+', '-', ':', '*' };
            string[] temp = s.Split(operators);

            Fraction f1 = new Fraction(temp[0]);
            Fraction f2 = new Fraction(temp[1]);
            Fraction res = new Fraction(1, 1);

            char op = ' ';
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+' || s[i] == '-' || s[i] == ':' || s[i] == '*') op = s[i];
            }

            switch (op)
            {
                case '+': res = add(f1, f2); break;
                case '-': res = substract(f1, f2); break;
                case '*': res = multiply(f1, f2); break;
                case ':': res = divide(f1, f2); break;
            }

            res.reducate();
            return res.show();
        }
    }
}
