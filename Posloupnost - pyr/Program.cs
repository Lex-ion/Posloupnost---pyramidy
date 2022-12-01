using System.Security.Cryptography.X509Certificates;


namespace Posloupnost___pyr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Start();

        }


        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Zadej výšku");
            int vyska = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Šířku");
            int sirka = Convert.ToInt32(Console.ReadLine());


            CtyrUhelnik(vyska, sirka);
            Console.WriteLine();
            PravTrojUh(vyska, sirka);
            Console.WriteLine();
            RovStrTroj(vyska, sirka);
            Console.ReadKey();
            Console.WriteLine();
            Anim(vyska, sirka);
        }


        public static void CtyrUhelnik(int vyska,int sirka)
        {
            for (int j = 0; j < vyska; j++) //obdelnik
            {
                for (int i = 0; i < sirka - 1; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");

            }
            

        }
        public static void PravTrojUh(int vyska, int sirka)
        {


            for (int j = 0; j < vyska; j++)//pravouhly
            {

                double procenta = (double)j / vyska;

                for (double i = 0; i < procenta * sirka; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");
            }
        }
        public static void RovStrTroj(int vyska, int sirka)
        {

            for (int j = 0; j < vyska; j++)//rovnoram
            {

                double procenta = (double)j / vyska;

                for (int i = 0; i < sirka - procenta * sirka; i++)
                {
                    Console.Write(" ");

                }
                for (int i = 0; i < procenta * sirka; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");
            }
        }



        public static void Anim(int vyska, int sirka)
        {
            for (int k = 0; k < vyska; k++)
            {
              

                for (int a = 0; a < vyska - k; a++)
                {
                    Console.WriteLine(  );
                }
                


                for (int j = 0; j < k; j++)//rovnoram
                {


                    double procenta = (double)j / k;

                    for (int i = 0; i < sirka - procenta * sirka; i++)
                    {
                        Console.Write(" ");

                    }
                    for (int i = 0; i < procenta * sirka; i++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("* ");
                }
                


                Thread.Sleep(10);

                if (k != vyska - 1)
                {
                    Console.Clear();
                }
               
            }

            Start();
        }

    }
}