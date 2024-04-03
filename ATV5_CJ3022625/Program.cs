using System.Threading.Channels;

namespace ATV5_CJ3022625
{
    internal class program
    {
        static void Main(string[] args)
        {

            int temp, soma = 0;
            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Digite um valor: ");
                temp = int.Parse(Console.ReadLine());
                if (temp < 9)
                {
                    soma = soma + temp;
                    break;

                }
                else
                {
                    Console.WriteLine("A média é {0}", temp / 3);
                }
            }




            Console.WriteLine("<<EX.1>>");
            int n, c = 0;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            for (c = 0; c <= n; c++)
            {
                Console.WriteLine(c);

            }





            Console.WriteLine("<<EX.2>>");
            int nm, p;
            Console.WriteLine("Digite um número: ");
            nm = int.Parse(Console.ReadLine());

            for (p = 0; p <= nm; p++)
            {
                if (p % 2 == 0)
                {
                    Console.WriteLine(p);
                }






                Console.WriteLine("<<EX.3>>");
                int num, d;
                Console.WriteLine("Digite um número menor que 1000: ");
                num = int.Parse(Console.ReadLine());

                for (d = 1000; d >= num; d--)
                {
                    if (d % 2 == 0)
                    {
                        Console.WriteLine(d);
                    }



                    Console.WriteLine("<<EX.4>>");
                    int n1, n2, n3, n4;
                    Console.WriteLine("Digite um número inteiro: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro: ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro: ");
                    n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro: ");
                    n4 = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}



 