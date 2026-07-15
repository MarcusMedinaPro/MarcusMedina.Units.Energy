namespace MarcusMedina.Units.Energy.Metric;

/// <summary>
/// Metriska energienheter — SI-standard och elektriska enheter.
/// <code>
/// 1.Kilowatthour().ToJoules()   // 3_600_000
/// 500.Millijoules().ToJoules()  // 0.5
/// </code>
/// </summary>
public static class MetricEnergyExtensions
{
    public static Energy Nanojoules(this int v) => new(v * 1e-9);
    public static Energy Nanojoules(this double v) => new(v * 1e-9);
    public static Energy Microjoules(this int v) => new(v * 1e-6);
    public static Energy Microjoules(this double v) => new(v * 1e-6);
    public static Energy Millijoules(this int v) => new(v * 0.001);
    public static Energy Millijoules(this double v) => new(v * 0.001);
    public static Energy Joules(this int v) => new(v);
    public static Energy Joules(this double v) => new(v);
    public static Energy Kilojoules(this int v) => new(v * 1_000.0);
    public static Energy Kilojoules(this double v) => new(v * 1_000.0);
    public static Energy Megajoules(this int v) => new(v * 1_000_000.0);
    public static Energy Megajoules(this double v) => new(v * 1_000_000.0);
    public static Energy Gigajoules(this int v) => new(v * 1_000_000_000.0);
    public static Energy Gigajoules(this double v) => new(v * 1_000_000_000.0);
    public static Energy Terajoules(this int v) => new(v * 1_000_000_000_000.0);
    public static Energy Terajoules(this double v) => new(v * 1_000_000_000_000.0);
    public static Energy Watthours(this int v) => new(v * 3_600.0);
    public static Energy Watthours(this double v) => new(v * 3_600.0);
    public static Energy Kilowatthours(this int v) => new(v * 3_600_000.0);
    public static Energy Kilowatthours(this double v) => new(v * 3_600_000.0);
    public static Energy Megawatthours(this int v) => new(v * 3_600_000_000.0);
    public static Energy Megawatthours(this double v) => new(v * 3_600_000_000.0);
    public static Energy Gigawatthours(this int v) => new(v * 3_600_000_000_000.0);
    public static Energy Gigawatthours(this double v) => new(v * 3_600_000_000_000.0);

    public static double ToNanojoules(this Energy e) => e.Joules / 1e-9;
    public static double ToMicrojoules(this Energy e) => e.Joules / 1e-6;
    public static double ToMillijoules(this Energy e) => e.Joules / 0.001;
    public static double ToJoules(this Energy e) => e.Joules;
    public static double ToKilojoules(this Energy e) => e.Joules / 1_000.0;
    public static double ToMegajoules(this Energy e) => e.Joules / 1_000_000.0;
    public static double ToGigajoules(this Energy e) => e.Joules / 1_000_000_000.0;
    public static double ToTerajoules(this Energy e) => e.Joules / 1_000_000_000_000.0;
    public static double ToWatthours(this Energy e) => e.Joules / 3_600.0;
    public static double ToKilowatthours(this Energy e) => e.Joules / 3_600_000.0;
    public static double ToMegawatthours(this Energy e) => e.Joules / 3_600_000_000.0;
    public static double ToGigawatthours(this Energy e) => e.Joules / 3_600_000_000_000.0;
}
