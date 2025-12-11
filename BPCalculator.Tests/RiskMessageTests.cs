using Xunit;
using BPCalculator;

public class RiskMessageTests
{
    [Fact]
    public void RiskMessage_ForLowBP_ReturnsCorrectMessage()
    {
        var bp = new BloodPressure { Systolic = 85, Diastolic = 55 };
        Assert.Equal(
            "Your blood pressure is lower than normal. Monitor symptoms and consult a doctor if needed.",
            bp.RiskMessage
        );
    }

    [Fact]
    public void RiskMessage_ForIdealBP_ReturnsCorrectMessage()
    {
        var bp = new BloodPressure { Systolic = 110, Diastolic = 70 };
        Assert.Equal(
            "Your blood pressure is in the healthy range. Maintain a balanced lifestyle.",
            bp.RiskMessage
        );
    }

    [Fact]
    public void RiskMessage_ForPreHigh_ReturnsCorrectMessage()
    {
        var bp = new BloodPressure { Systolic = 130, Diastolic = 85 };
        Assert.Equal(
            "Your blood pressure is slightly elevated. Review diet, exercise, and monitor regularly.",
            bp.RiskMessage
        );
    }

    [Fact]
    public void RiskMessage_ForHighBP_ReturnsCorrectMessage()
    {
        var bp = new BloodPressure { Systolic = 150, Diastolic = 95 };
        Assert.Equal(
            "Your blood pressure is high. Please consult a healthcare professional.",
            bp.RiskMessage
        );
    }
}
