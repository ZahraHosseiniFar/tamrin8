using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class csl
    {
        private int A;
        private int B;
        private int C;
        private int D;

        public int a
        {
            get { return A; }
            set { A = value; }
        }
        public int b
        {
            get { return B; }
            set { B = value; }
        }
        public int c
        {
            get { return C; }
            set { C = value; }
        }
        public int d
        {
            get { return D; }
            set { D = value; }

        }
        public void cal() { }
        public bool cal(int a, int b, int c, int d)

        {
            if (b != 0 && d != 0)
            {
                A = a;
                B = b;
                C = c;
                D = d;

                return true;
            }
            else
            {
                return false;
            }
        }
        public double mlt()
        {
            return ((A / B) * (C/D));
        }
        public double min()
        {
            return ((A/B) - (C/D));
        }
        public double sum()
        {
            return ((A / B) + (C / D));
        }
    }
}
