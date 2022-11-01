using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB1

    {
        public class Program
        {
            public static bool EstPremier(int premie)
            {
                if (premie< 2)
                {
                    return true;
                }
                else
                {
                    for (int i = 2; i < premie; i++)
                    {
                        if (premie % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }


            }
            static void Main(string[] args)
            {


                int premie = 0;
                do
                {
                    Console.WriteLine("entrez un nombre");

                } while (!int.TryParse(Console.ReadLine(), out premie));

                if (EstPremier(premie))
                {
                    Console.WriteLine("est premier");
                }
                else
                {
                    Console.WriteLine("Pas premier");
                }





            }
        }
    }
