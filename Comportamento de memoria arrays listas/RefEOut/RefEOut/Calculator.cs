

namespace RefEOut {
    class Calculator {

        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void Triple2(int origin, out int result) {
            result = origin * 3;
        }

        // ambos são considerados "code smells" (design ruim) e devem ser evitados.

    }
}
