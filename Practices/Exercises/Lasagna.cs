using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Exercises
{
    public class Lasagna
    {
        static void LasagnaV1()
        {
            int ExpectedMinutesInOven() => 40;
            int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;
            int PreparationTimeInMinutes(int layers) => layers * 2;
            int ElapsedTimeInMinutes(int layers, int minutesInOven) =>
                PreparationTimeInMinutes(layers) + minutesInOven;

            Console.WriteLine($"Esperado no forno: {ExpectedMinutesInOven()}");
            Console.WriteLine($"Restante no forno: {RemainingMinutesInOven(20)}");
            Console.WriteLine($"Tempo preparo: {PreparationTimeInMinutes(3)}");
            Console.WriteLine($"Tempo decorrido: {ElapsedTimeInMinutes(3, 20)}");
        }

        static string LasagnaV2()
        {
            // int ExpectedMinutesInOven() => 40;

            // int RemainingMinutesInOven(int minutesInOven)
            // {
            //     return ExpectedMinutesInOven() - minutesInOven;
            // }

            // int PreparationTimeInMinutes(int numberOfLayers, int minutesPerLayer = 2)
            // {
            //     return numberOfLayers * minutesPerLayer;
            // }

            // int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven, int minutesPerLayer = 2)
            // {
            //     return PreparationTimeInMinutes(numberOfLayers, minutesPerLayer) + minutesInOven;
            // }

            return true.ToString();
        }
    }
}