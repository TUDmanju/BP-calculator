using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name = "Low Blood Pressure")] Low,
        [Display(Name = "Ideal Blood Pressure")] Ideal,
        [Display(Name = "Pre-High Blood Pressure")] PreHigh,
        [Display(Name = "High Blood Pressure")] High
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }

        public BPCategory Category
        {
            get
            {
                if (Systolic < 90 && Diastolic < 60)
                    return BPCategory.Low;

                if (Systolic >= 90 && Systolic <= 119 &&
                    Diastolic >= 60 && Diastolic <= 79)
                    return BPCategory.Ideal;

                if ((Systolic >= 120 && Systolic <= 139) ||
                    (Diastolic >= 80 && Diastolic <= 89))
                    return BPCategory.PreHigh;

                if (Systolic >= 140 || Diastolic >= 90)
                    return BPCategory.High;

                return BPCategory.Ideal;
            }
        }

        // ⭐ NEW FEATURE – EXACT messages matching your tests
        public string RiskMessage
        {
            get
            {
                return Category switch
                {
                    BPCategory.Low =>
                        "Your blood pressure is lower than normal. Monitor symptoms and consult a doctor if needed.",

                    BPCategory.Ideal =>
                        "Your blood pressure is in the healthy range. Maintain a balanced lifestyle.",

                    BPCategory.PreHigh =>
                        "Your blood pressure is slightly elevated. Review diet, exercise, and monitor regularly.",

                    BPCategory.High =>
                        "Your blood pressure is high. Please consult a healthcare professional.",

                    _ => ""
                };
            }
        }
    }
}
