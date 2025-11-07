using System;
using System.Collections.Generic;

namespace Statistics
{
    public static class StatsComputer
    {
        public static Stats CalculateStatistics(List<float> numbers)
        {
            ArgumentNullException.ThrowIfNull(numbers);

            if(numbers.Count == 0)
            {
                return new Stats
                {
                    Average = float.NaN,
                    Max = float.NaN,
                    Min = float.NaN
                };
            }

            float min = float.PositiveInfinity;
            float max = float.NegativeInfinity;
            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                float currentTemperature = numbers[i];
                if (currentTemperature < min) min = currentTemperature;
                if (currentTemperature > max) max = currentTemperature;
                sum += currentTemperature;
            }

            return new Stats
            {
                Average = (float)(sum / numbers.Count),
                Max = max,
                Min = min
            };
        }
    }


    public class Stats
    {
        public float Average { get; set; }

        public float Max { get; set; }

        public float Min { get; set; }
    }
}
