using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaomiaomiao_Toint {
    class Program {
        static void Main(string[] args) {
            while (true) {
                string shuRu = Console.ReadLine();
                for (int i = 0; i < shuRu.Length; i++) {
                    int j = shuRu[i];
                    Console.Write("{0},", j);
                }
                Console.WriteLine();
            }
        }
    }
}
