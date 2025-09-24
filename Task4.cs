using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С__lab1 {
    internal class Task4 {
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
            for (int i = 0, j = arr.Length - 1; i < j;  ++i, --j)
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
