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

            return new Stats
            {
                Min = numbers.Min(),
                Max = numbers.Max(),
                Average = numbers.Average()
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
