using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__lab1 {
    internal class Task2 {
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

        public int sum2 (int x, int y) {
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
    }
}
