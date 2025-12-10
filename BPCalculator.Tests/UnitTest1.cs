using BPCalculator;
using Xunit;

namespace BPCalculator.Tests
{
    public class BloodPressureTests
    {
        [Fact]
        public void LowBloodPressure_When_Sys85_Dia55()
        {
            var bp = new BloodPressure { Systolic = 85, Diastolic = 55 };
            Assert.Equal(BPCategory.Low, bp.Category);
        }

        [Fact]
        public void IdealBloodPressure_When_Sys110_Dia70()
        {
            var bp = new BloodPressure { Systolic = 110, Diastolic = 70 };
            Assert.Equal(BPCategory.Ideal, bp.Category);
        }

        [Fact]
        public void PreHighBloodPressure_When_Sys130_Dia85()
        {
            var bp = new BloodPressure { Systolic = 130, Diastolic = 85 };
            Assert.Equal(BPCategory.PreHigh, bp.Category);
        }

        [Fact]
        public void HighBloodPressure_When_Sys150_Dia95()
        {
            var bp = new BloodPressure { Systolic = 150, Diastolic = 95 };
            Assert.Equal(BPCategory.High, bp.Category);
        }
    }
}
