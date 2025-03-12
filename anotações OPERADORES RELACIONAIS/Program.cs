namespace anotações_OPERADORES_RELACIONAIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = 10 == 10;// true, pois 10 é igual a 10
            bool b2 = 5 == 10;// false, pois 5 não é igual a 10

            bool b3 = 2 < 5; // true, pois 2 é menor que 5
            bool b4 = 5 < 2; // false, pois 5 não é menor que 2
            bool b5 = 5 < 5; // false, pois 5 não é menor que 5

            bool b6 = 5 <= 5; // true, pois 5 é menor ou igual a 5
            bool b7 = 2 <= 5; // true, pois 2 é menor ou igual a 5

            bool b8 = 2 > 5; // false, pois 2 não é maior que 5
            bool b9 = 5 > 2; // true, pois 5 é maior que 2
            bool b10 = 5 > 5; // false, pois 5 não é maior que 5

            bool b11 = 8 >= 5; // true, pois 8 é maior ou igual a 5
            bool b12 = 5 >= 5; // true, pois 5 é maior ou igual a 5
            bool b13 = 2 >= 5; // false, pois 2 não é maior ou igual a 5

            bool b14 = 55 != 5; // true, pois 55 é diferente de 5
            bool b15 = 5 != 5; // false, pois 5 não é diferente de 5

        }
    }
}
