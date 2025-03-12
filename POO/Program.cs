using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = " ";
            int idade1 = 0;
            bool fome1 = false;

            Program dados1 = new Program();
            Cachorro cachorro1 = new Cachorro();
           
            dados1.Cao(name1, idade1, fome1);
            cachorro1.dados(name1, idade1, fome1);

            Program dados2 = new Program();
            Cachorro cachorro2 = new Cachorro();

            dados2.Cao(name1, idade1, fome1);
            cachorro2.dados(name1, idade1, fome1);
        }

        public void Cao(string i, int ii, bool iii)
        {
            Console.Write("Digite o nome do cachorro: ");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.Write("Digite a idade do cachorro: ");
            int.TryParse(Console.ReadLine(), out int idade1);
            Console.Clear();
            Console.Write("Cachorro está com fome?: ");
            bool.TryParse(Console.ReadLine(), out bool fome1);
            Console.Clear();

            Console.Write("Nome do cachorro: " + name1 + "\nIdade do cachorro: " + idade1);
            if (fome1)
            {
                Console.WriteLine("\nO cachorro está com fome");
            }
            else
            {
                Console.WriteLine("\nO cachorro não está com fome");
            }
        }
    }

    public class Cachorro
    {
        public void dados(string name, int idade, bool fome)
        {
            // Console.WriteLine("Nome do cachorro: " + name + "\nIdade do cachorro:" + idade + fome);
        }
    }

}
