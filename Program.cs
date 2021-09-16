using System;

namespace testetecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            int banana = 89;
            int frango = 700;
            int quarteirao = 523;
            int morango = 130;
            int totalDeCalorias = banana + frango + quarteirao + morango;

            switch(totalDeCalorias) {
                case 0:
                    Console.WriteLine(banana);
                    break;
                case 1:
                    Console.WriteLine(frango);
                    break;
                case 2:
                    Console.WriteLine(quarteirao);
                    break;
                case 3:
                    Console.WriteLine($"morango para sair {morango}");
                    break;
                default:
                    Console.WriteLine($"Você consumiu {totalDeCalorias} calorias");
                    break;
            }

            if(totalDeCalorias < 2000) {
                Console.WriteLine($"Você consumiu {totalDeCalorias} calorias e ficou abaixo da meta");
            }
        }
    }
}
