namespace anotações_ARITMÉTICOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 10 + 2;// soma
            float n2 = 10 - 2;// subtração
            float n3 = 10 * 2;// multiplicação
            float n4 = 10 / 2;// divisão, 10 dividido por 2 é 5...MAS!
            float n5 = 10 % 2; // resto da divisão, resto de 10 dividido por 2 é 0
            float n6 = 10 % 3;// resto da divisão, resto de 10 dividido por 3 é 1

            testes();
            exemplosTernario();

        }

        static void testes()
        {
            int n7 = 0;

            n7 = n7 + 1;// n7 = 1
            Console.WriteLine(n7);
            n7 = n7 += 1;// n7 = 2
            Console.WriteLine(n7);
            n7++;       // n7 = 3
            Console.WriteLine(n7);

            n7 = n7 - 1;// n7 = 2
            Console.WriteLine(n7);
            n7 = n7 -= 1;// n7 = 1
            Console.WriteLine(n7);
            n7--;       // n7 = 0
            Console.WriteLine(n7);

            n7 = 10;
            n7 *= 2;    // n7 = 20
            Console.WriteLine(n7);
            n7 = 10;
            n7 /= 2;    // n7 = 5, pois 10 dividido por 2 é 5
            Console.WriteLine(n7);
            n7 = 10;
            n7 %= 2;    // n7 = 0, pois 10 dividido por 2 é 0
            Console.WriteLine(n7);

            n7 = 1 + 2 + 3 * 5;// n7 = 18, pois a precedência é SEMPRE da multiplicação
            Console.WriteLine(n7);
            n7 = (1 + 2 + 3) * 5;// n7 = 30, pois a precedência é SEMPRE dos parênteses
            Console.WriteLine(n7);

            Console.WriteLine(n7 == 30 ? "lol" : "uau"); //  operaçao ternária, se n7 for igual a 30, imprime lol, senão imprime uau
        }

        static void exemplosTernario()
        {
            int a = 5, b = 10;
            string resultado;

            // Exemplo 1
            resultado = a > b ? "a é maior que b" : "a não é maior que b";
            Console.WriteLine(resultado);

            // Exemplo 2
            resultado = a < b ? "a é menor que b" : "a não é menor que b";
            Console.WriteLine(resultado);

            // Exemplo 3
            resultado = a == b ? "a é igual a b" : "a não é igual a b";
            Console.WriteLine(resultado);

            // Exemplo 4
            resultado = a != b ? "a é diferente de b" : "a não é diferente de b";
            Console.WriteLine(resultado);

            // Exemplo 5
            bool isEven = a % 2 == 0 ? true : false;
            Console.WriteLine(isEven ? "a é par" : "a é ímpar");
        }
    }
}
