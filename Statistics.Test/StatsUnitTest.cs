using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {           
            var computedStats = StatsComputer.CalculateStatistics(
                new List<float> { 98.6f, 98.2f, 97.8f, 102.2f });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 99.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 102.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 97.8) <= epsilon);
        }

        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var computedStats = StatsComputer.CalculateStatistics(
                new List<float>());
            Assert.True(float.IsNaN(computedStats.Average));
            Assert.True(float.IsNaN(computedStats.Max));
            Assert.True(float.IsNaN(computedStats.Min));
        }

        [Fact]
        public void ReportsAllValuesIdentical()
        {
            var computed = StatsComputer.CalculateStatistics(new List<float> { 99f, 99f, 99f });

            Assert.Equal(99f, computed.Average);
            Assert.Equal(99f, computed.Max);
            Assert.Equal(99f, computed.Min);
        }
    }
}
