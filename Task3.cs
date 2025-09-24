using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__lab1 {
    internal class Task3 {
        public String listNums(int x) {
            if (x < 0) return "Ошибка: число меньше нуля";

            String res = "";
            for (int i = 0; i <= x; ++i) 
                res += Convert.ToString(i) + " ";

            return res;
        }

        public String chet (int x) {
            if (x < 0) return "Ошибка: число меньше нуля";

            String res = "";
            for (int i = 0; i <= x; i += 2)
                res += Convert.ToString(i) + " ";
            
            return res;
        }

        public int numLen (long x) {
            if (x >= 0 && x <= 9) return 1;

            int count = 0;
            while (x !=  0) {
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
            for (int i = 1; i <= x; ++i)  { 
                for (int j = 0; j < x; ++j) {
                    if (j >= x - i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
