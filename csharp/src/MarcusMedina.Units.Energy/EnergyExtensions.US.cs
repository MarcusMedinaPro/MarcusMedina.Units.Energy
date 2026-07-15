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
    /// <summary>1 BTU (International Table) = 1 055.05585262 J</summary>
    public static Energy BTUs(this int v) => new(v * 1_055.05585262);
    public static Energy BTUs(this double v) => new(v * 1_055.05585262);

    /// <summary>1 foot-pound force = 1.3558179483 J</summary>
    public static Energy FootPounds(this int v) => new(v * 1.3558179483);
    public static Energy FootPounds(this double v) => new(v * 1.3558179483);

    /// <summary>1 foot-poundal = 0.0421401100938 J</summary>
    public static Energy FootPoundals(this int v) => new(v * 0.0421401100938);
    public static Energy FootPoundals(this double v) => new(v * 0.0421401100938);

    /// <summary>1 US therm = 105 480 400 J</summary>
    public static Energy Therms(this int v) => new(v * 105_480_400.0);
    public static Energy Therms(this double v) => new(v * 105_480_400.0);

    public static double ToBTUs(this Energy e) => e.Joules / 1_055.05585262;
    public static double ToFootPounds(this Energy e) => e.Joules / 1.3558179483;
    public static double ToFootPoundals(this Energy e) => e.Joules / 0.0421401100938;
    public static double ToTherms(this Energy e) => e.Joules / 105_480_400.0;
}
