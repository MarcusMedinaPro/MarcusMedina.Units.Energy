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
    extension(int v)
    {
        public Energy Nanojoules() => new(v * 1e-9);
        public Energy Microjoules() => new(v * 1e-6);
        public Energy Millijoules() => new(v * 0.001);
        public Energy Joules() => new(v);
        public Energy Kilojoules() => new(v * 1_000.0);
        public Energy Megajoules() => new(v * 1_000_000.0);
        public Energy Gigajoules() => new(v * 1_000_000_000.0);
        public Energy Terajoules() => new(v * 1_000_000_000_000.0);
        public Energy Watthours() => new(v * 3_600.0);
        public Energy Kilowatthours() => new(v * 3_600_000.0);
        public Energy Megawatthours() => new(v * 3_600_000_000.0);
        public Energy Gigawatthours() => new(v * 3_600_000_000_000.0);
    }

    extension(double v)
    {
        public Energy Nanojoules() => new(v * 1e-9);
        public Energy Microjoules() => new(v * 1e-6);
        public Energy Millijoules() => new(v * 0.001);
        public Energy Joules() => new(v);
        public Energy Kilojoules() => new(v * 1_000.0);
        public Energy Megajoules() => new(v * 1_000_000.0);
        public Energy Gigajoules() => new(v * 1_000_000_000.0);
        public Energy Terajoules() => new(v * 1_000_000_000_000.0);
        public Energy Watthours() => new(v * 3_600.0);
        public Energy Kilowatthours() => new(v * 3_600_000.0);
        public Energy Megawatthours() => new(v * 3_600_000_000.0);
        public Energy Gigawatthours() => new(v * 3_600_000_000_000.0);
    }

    extension(Energy e)
    {
        public double ToNanojoules() => e.Joules / 1e-9;
        public double ToMicrojoules() => e.Joules / 1e-6;
        public double ToMillijoules() => e.Joules / 0.001;
        public double ToJoules() => e.Joules;
        public double ToKilojoules() => e.Joules / 1_000.0;
        public double ToMegajoules() => e.Joules / 1_000_000.0;
        public double ToGigajoules() => e.Joules / 1_000_000_000.0;
        public double ToTerajoules() => e.Joules / 1_000_000_000_000.0;
        public double ToWatthours() => e.Joules / 3_600.0;
        public double ToKilowatthours() => e.Joules / 3_600_000.0;
        public double ToMegawatthours() => e.Joules / 3_600_000_000.0;
        public double ToGigawatthours() => e.Joules / 3_600_000_000_000.0;
    }
}
