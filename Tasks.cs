using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__lab1 {
    internal class Tasks {
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

        public int abs(int x) {
            if (x < 0) x = -x;
            return x;
        }

        public bool is35(int x) {
            if (x % 3 == 0 && x % 5 == 0) return false;
            if (x % 3 == 0 || x % 5 == 0) return true;
            return false;
        }

        public int max3(int x, int y, int z) {
            if (x >= y && x >= z) return x;
            if (y >= z && y >= z) return y;
            return z;
        }

        public int sum2(int x, int y) {
            if (x + y >= 10 && x + y < 20) return 20;
            return x + y;
        }

        public String day(int x) {
            switch (x) {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суботта";
                case 7:
                    return "Воскресенье";
                default:
                    return "это не день недели";
            }
        }

        public String listNums(int x) {
            if (x < 0) return "Ошибка: число меньше нуля";

            String res = "";
            for (int i = 0; i <= x; ++i)
                res += Convert.ToString(i) + " ";

            return res;
        }

        public String chet(int x) {
            if (x < 0) return "Ошибка: число меньше нуля";

            String res = "";
            for (int i = 0; i <= x; i += 2)
                res += Convert.ToString(i) + " ";

            return res;
        }

        public int numLen(long x) {
            if (x >= 0 && x <= 9) return 1;

            int count = 0;
            while (x != 0) {
                ++count;
                x /= 10;
            }

            return count;
        }

        public void square(int x) {
            if (x <= 0) return;

            for (int i = 0; i < x; ++i) {
                for (int j = 0; j < x; ++j)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public void rightTriangle(int x) {
            for (int i = 1; i <= x; ++i) {
                for (int j = 0; j < x; ++j) {
                    if (j >= x - i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public int findFirst(int[] arr, int x) {
            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] == x) return i;

            return -1;
        }

        public int maxAbs(int[] arr) {
            if (arr == null || arr.Length == 0)
                return 0;


            int result = arr[0];
            for (int i = 1; i < arr.Length; ++i)
                if (Math.Abs(arr[i]) > Math.Abs(result))
                    result = arr[i];

            return result;
        }

        public int[] add(int[] arr, int[] ins, int pos) {
            int[] res = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; ++i)
                res[i] = arr[i];

            for (int i = 0; i < ins.Length; ++i)
                res[pos + i] = ins[i];

            for (int i = pos; i < arr.Length; ++i)
                res[ins.Length + i] = arr[i];

            return res;
        }

        public int[] reverseBack(int[] arr) {
            for (int i = 0, j = arr.Length - 1; i < j; ++i, --j)
                (arr[i], arr[j]) = (arr[j], arr[i]);

            return arr;
        }

        public int[] findAll(int[] arr, int x) {
            int[] res = new int[arr.Length];

            for (int i = 0, j = 0; x < arr.Length; ++i)
                if (arr[i] == x) {
                    res[j] = arr[i];
                    ++j;
                }

            return res;
        }
    }
}
