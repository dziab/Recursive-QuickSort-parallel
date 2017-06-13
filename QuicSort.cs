using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14 {
    class QuicSort {

        // Call DoSort Method, it takes values in list
        //

        public List<int> DoSort(List<int> list) {

            return QuickSort(list, 0, list.Count - 1);
        }

        public static List<int> QuickSort(List<int> list, int left, int right) {

            if (left < right) {
                int q = Partition(list, left, right);
                
                Parallel.Invoke(
                () => QuickSort(list, left, q - 1),
                () => QuickSort(list, q + 1, right));

            }
            return list;
        }

        private static int Partition(List<int> list, int left, int right) {
            int pivot = list[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j) {
                if (list[j] <= pivot) {
                    temp = list[j];
                    list[j] = list[i];
                    list[i] = temp;
                    i++;
                }
            }

            list[right] = list[i];
            list[i] = pivot;

            return i;
        }
    }
}
