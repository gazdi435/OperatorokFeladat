using System.Text;

namespace OperatorokFeladat
{
    internal class Program
    {
        public static List<Kifejezes> lista = new List<Kifejezes>();
        static void Main(string[] args)
        {
            Beolvasas("kifejezesek.txt");
            AllomanyHanyKifejezes(lista);
            MaradekosOsztasOperandusai(lista);
            VanETizzelOszthato(lista);
        }

        private static void VanETizzelOszthato(List<Kifejezes> lista)
        {
            Console.WriteLine("4. feladat:");
            if (lista.Any(x => x.ElsoOperandus % 10 == 0 && x.MasodikOperandus % 10 == 0))
            {
                Console.WriteLine("Van!");
            }
            else
            {
                Console.WriteLine("Nincs!");
            };
        }

        private static void MaradekosOsztasOperandusai(List<Kifejezes> lista)
        {
            Console.WriteLine("3.feladat:");
            lista.ForEach(x =>
            {
                if (x.OperatorValtozo == "mod")
                {
                    Console.WriteLine($"{x.ElsoOperandus};{x.MasodikOperandus}");
                }
            });
        }

        private static void AllomanyHanyKifejezes(List<Kifejezes> lista)
        {
            Console.WriteLine($"2. feladat:\n Az állomány {lista.Count} db kifejezést tartlmaz");
        }

        private static void Beolvasas(string eleresiUt)
        {
            File.ReadAllLines(eleresiUt, Encoding.UTF8).ToList().ForEach(x => { lista.Add(new Kifejezes(x)); });
        }
    }
}