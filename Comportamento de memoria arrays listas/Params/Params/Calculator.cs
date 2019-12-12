

namespace Params {
    class Calculator {

        // Solução ruim usando sobrecarga:

        /* public static int Sum(int n1, int n2) {
              return n1 + n2;
          }

          public static int Sum(int n1, int n2, int n3) {
              return n1 + n2 + n3;
          }

          public static int Sum(int n1, int n2, int n3, int n4) {
              return n1 + n2 + n3 + n4;
          } */

        // Solucão com vetor

        /* public static int Sum(int[] numbers) {
             int sum = 0;
             for (int i = 0; i < numbers.Length; i++) {
                 sum += numbers[1];
             }
             return sum;
         } */

        // Solução com modificador params:

        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
