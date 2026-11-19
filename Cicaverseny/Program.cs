namespace Cicaverseny
{
    internal class Program
    {

        static int[,] cicakPontjai;

        static Random rnd = new Random();

        static void Feltolt(int cicakSzama)
        {

       


            for (int i = 0; i < cicakSzama; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Hany cica versenyzik: ");
            int cicakSzama = Convert.ToInt32(Console.ReadLine());
            Feltolt(cicakSzama);
        }
    }
}
