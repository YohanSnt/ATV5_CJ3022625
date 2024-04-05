using System.Threading.Channels;

namespace ATV5_CJ3022625
{
    internal class program
    {
        static void Main(string[] args)
        {

            //int temp, soma = 0;
            //for (int a = 0; a < 3; a++)
            //{
            //    Console.WriteLine("Digite um valor: ");
            //    temp = int.Parse(Console.ReadLine());
            //    if (temp < 9)
            //    {
            //        soma = soma + temp;
            //        break;

            //    }
            //    else
            //    {
            //        Console.WriteLine("A média por 3 é {0}", temp / 3);
            //        break;
            //    }
            //}




            //Console.WriteLine("\n<<EX.1>>");
            //int n, c = 0;

            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());
            //for (c = 0; c <= n; c++)
            //{
            //    Console.WriteLine(c);

            //}





            //Console.WriteLine("\n<<EX.2>>");
            //int nm, p;
            //Console.WriteLine("Digite um número: ");
            //nm = int.Parse(Console.ReadLine());

            //for (p = 1; p <= nm; p++)
            //{
            //    if (p % 2 == 0)
            //    {
            //        Console.WriteLine(p);
            //    }

            //}





            //Console.WriteLine("\n<<EX.3>>");
            //int num, d;
            //Console.WriteLine("Digite um número menor que 1000: ");
            //num = int.Parse(Console.ReadLine());

            //for (d = 1000; d >= num; d--)
            //{
            //    if (d % 2 == 0)
            //    {
            //        Console.WriteLine(d);
            //    }

            //}


            //Console.WriteLine("Exercicio 4");
            //int ps; int ww = 0;
            //while (ww < 200)
            //{
            //    Console.WriteLine("Digite uma sequência de números inteiros: ");
            //    ps = int.Parse(Console.ReadLine());
            //    if (ps > 0)
            //    {
            //        ww += ps;
            //    }

            //    Console.WriteLine(ww);
            //}
                
            
            Console.WriteLine("\n<<EX.5>>");
            int a, d;
            Console.WriteLine("Digite um número: ");
            a = int.Parse(Console.ReadLine());

            for (d = 1; d <= a; d++)
            {
                if (a % d == 0)
                {
                    Console.WriteLine(d);
                }

            }
        }
            }
        }
    




 