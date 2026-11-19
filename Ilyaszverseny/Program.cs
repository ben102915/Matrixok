
using System.Runtime.InteropServices;

namespace Ilyaszverseny
{
    internal class Program
    {

        static int[,] jatekosokPontjai;
        static Random rnd = new Random();

        static string[] Jatekosnevek(int jatekosokSzama)
        {
            string[] nevek = { "Anna", "Bence", "Csaba", "Dóra", "Eszter", "Ferenc", "Gábor", "Hanna", "István", "Judit", "Katalin", "László", "Márk", "Nóra", "Orsolya",
                "Péter", "Réka", "Sándor", "Tamás", "Viktória", "Zoltán", "Ádám", "Balázs", "Cecília", "Dávid", "Emese", "Flóra", "György", "Levente", "Mihály" };
            string[] jatekosok = new string[jatekosokSzama];
            for (int i = 0; i < jatekosokSzama; i++)
            {
                int index = rnd.Next(0, nevek.Length);
                jatekosok[i] = nevek[index];
            }
            return jatekosok;
        }
        private static int[,] Feltolt(int jatekosokSzama)
        {
            int[,] matrix = new int[jatekosokSzama, 5];
            for (int i = 0; i < jatekosokSzama; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(0, 25 + 1);
                }
            }



            return matrix;
        }



        static int Nyertes()
        {
            int maxpont = 0;
            int nyertesindex = 0;

            for (int i = 0; i < jatekosokPontjai.GetLength(0); i++)
            {
                int ossz = 0;
                for (int j = 0; j < jatekosokPontjai.GetLength(1); j++)
                {
                    ossz += jatekosokPontjai[i, j];
                }
                if (ossz > maxpont)
                {
                    maxpont = ossz;
                    nyertesindex = i;
                }
            }



            return nyertesindex;
        }


        static void Kiiras()
        {
            Console.Write("Játékosok szama: ");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());
            jatekosokPontjai = Feltolt(jatekosokSzama);


            string[] jatekosok = Jatekosnevek(jatekosokSzama);
            for (int i = 0; i < jatekosokSzama; i++)
            {
                Console.Write($"A {i + 1,-2} játékos: {jatekosok[i],-8}\t pontjai: ");
                for (int j = 0; j < jatekosokPontjai.GetLength(1); j++)
                {
                    Console.Write($"{jatekosokPontjai[i, j],-4}");
                }
                Console.WriteLine();
            }
            int nyertesindex = Nyertes();

            Console.WriteLine($"A nyertes: {jatekosok[nyertesindex]}");


        }



        static void Main(string[] args)
        {

            Kiiras();


        }


    }
}
