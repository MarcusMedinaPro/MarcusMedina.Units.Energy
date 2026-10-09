namespace MarcusMedina.Units.Energy.US;

/// <summary>
/// Amerikanska/brittiska energienheter.
/// <code>
/// 1.BTUs().ToJoules()       // ≈ 1055.06
/// 1.FootPounds().ToJoules() // ≈ 1.356
/// </code>
/// </summary>
public static class USEnergyExtensions
{
    extension(int v)
    {
        /// <summary>1 BTU (International Table) = 1 055.05585262 J</summary>
        public Energy BTUs() => new(v * 1_055.05585262);
        /// <summary>1 foot-pound force = 1.3558179483 J</summary>
        public Energy FootPounds() => new(v * 1.3558179483);
        /// <summary>1 foot-poundal = 0.0421401100938 J</summary>
        public Energy FootPoundals() => new(v * 0.0421401100938);
        /// <summary>1 US therm = 105 480 400 J</summary>
        public Energy Therms() => new(v * 105_480_400.0);
    }

    extension(double v)
    {
        public Energy BTUs() => new(v * 1_055.05585262);
        public Energy FootPounds() => new(v * 1.3558179483);
        public Energy FootPoundals() => new(v * 0.0421401100938);
        public Energy Therms() => new(v * 105_480_400.0);
    }

    extension(Energy e)
    {
        public double ToBTUs() => e.Joules / 1_055.05585262;
        public double ToFootPounds() => e.Joules / 1.3558179483;
        public double ToFootPoundals() => e.Joules / 0.0421401100938;
        public double ToTherms() => e.Joules / 105_480_400.0;
    }
}
