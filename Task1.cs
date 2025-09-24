using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__lab1 {
    internal class Task1 {
        public double fraction(double x) {
            if (x < 0) x = -x;

            return x - Math.Truncate(x);
        }

        public int charToNum(char x) {
            while (x > '9' || x < '0') {
                Console.Write("Повторите ввод (допускаются только символы 0, 1, 2, 3, 4, 5, 6, 7, 8, 9): ");
                x = Convert.ToChar(Console.Read());
                Console.Clear();
                
            }
            return x - '0';
        }

        public bool is2Digits(int x) {
            return (x >= 10 && x <= 99) || (x <= -10 && x >= -99);
        }

        public bool isInRange(int a,  int b, int num) {
            return (num >= a && num <= b) || (num >= b && num <= a);
        }

        public bool isEqual(int a, int b, int c) {
            return a == b && b == c;
        }
    }
}
