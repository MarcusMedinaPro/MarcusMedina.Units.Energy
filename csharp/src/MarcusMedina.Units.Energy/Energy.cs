using System.Globalization;

namespace MarcusMedina.Units.Energy;

/// <summary>
/// Representerar energi med Joule som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera Joule-värdet.
/// </summary>
public readonly struct Energy : IComparable<Energy>, IEquatable<Energy>
{
    /// <summary>Värdet i Joule (basenhet).</summary>
    public double Joules { get; }

    public Energy(double joules) { Joules = joules; }

    public int CompareTo(Energy other) => Joules.CompareTo(other.Joules);
    public bool Equals(Energy other) => Joules.Equals(other.Joules);
    public override bool Equals(object? obj) => obj is Energy e && Equals(e);
    public override int GetHashCode() => HashCode.Combine(Joules);
    public override string ToString() => $"{Joules.ToString("G", CultureInfo.InvariantCulture)} J";

    public static bool operator ==(Energy a, Energy b) => a.Equals(b);
    public static bool operator !=(Energy a, Energy b) => !(a == b);
    public static bool operator <(Energy a, Energy b) => a.Joules < b.Joules;
    public static bool operator >(Energy a, Energy b) => a.Joules > b.Joules;
    public static bool operator <=(Energy a, Energy b) => a.Joules <= b.Joules;
    public static bool operator >=(Energy a, Energy b) => a.Joules >= b.Joules;
    public static Energy operator +(Energy a, Energy b) => new(a.Joules + b.Joules);
    public static Energy operator -(Energy a, Energy b) => new(a.Joules - b.Joules);
    public static Energy operator *(Energy e, double factor) => new(e.Joules * factor);
    public static Energy operator /(Energy e, double divisor) => new(e.Joules / divisor);
    public static double operator /(Energy a, Energy b) => a.Joules / b.Joules;
}
