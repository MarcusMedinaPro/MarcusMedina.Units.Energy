namespace MarcusMedina.Units.Energy.Scientific;

/// <summary>
/// Vetenskapliga energienheter — atomfysik, CGS och termokemi.
/// <code>
/// 1.Megaelectronvolts().ToJoules()  // ≈ 1.602e-13
/// 1.Kilocalories().ToKilojoules()   // 4.184
/// </code>
/// </summary>
public static class ScientificEnergyExtensions
{
    /// <summary>1 eV = 1.602176634e-19 J (exakt, SI 2019)</summary>
    public static Energy Electronvolts(this int v) => new(v * 1.602176634e-19);
    public static Energy Electronvolts(this double v) => new(v * 1.602176634e-19);
    public static Energy Kiloelectronvolts(this int v) => new(v * 1.602176634e-16);
    public static Energy Kiloelectronvolts(this double v) => new(v * 1.602176634e-16);
    public static Energy Megaelectronvolts(this int v) => new(v * 1.602176634e-13);
    public static Energy Megaelectronvolts(this double v) => new(v * 1.602176634e-13);
    public static Energy Gigaelectronvolts(this int v) => new(v * 1.602176634e-10);
    public static Energy Gigaelectronvolts(this double v) => new(v * 1.602176634e-10);

    /// <summary>1 erg (CGS) = 1e-7 J</summary>
    public static Energy Ergs(this int v) => new(v * 1e-7);
    public static Energy Ergs(this double v) => new(v * 1e-7);

    /// <summary>1 termokemisk kalori = 4.184 J</summary>
    public static Energy CaloriesThermo(this int v) => new(v * 4.184);
    public static Energy CaloriesThermo(this double v) => new(v * 4.184);

    /// <summary>1 International Table kalori = 4.1868 J</summary>
    public static Energy CaloriesIT(this int v) => new(v * 4.1868);
    public static Energy CaloriesIT(this double v) => new(v * 4.1868);

    /// <summary>1 kcal = 4 184 J</summary>
    public static Energy Kilocalories(this int v) => new(v * 4_184.0);
    public static Energy Kilocalories(this double v) => new(v * 4_184.0);

    /// <summary>1 ton TNT = 4.184 GJ</summary>
    public static Energy TonsOfTNT(this int v) => new(v * 4_184_000_000.0);
    public static Energy TonsOfTNT(this double v) => new(v * 4_184_000_000.0);

    public static double ToElectronvolts(this Energy e) => e.Joules / 1.602176634e-19;
    public static double ToKiloelectronvolts(this Energy e) => e.Joules / 1.602176634e-16;
    public static double ToMegaelectronvolts(this Energy e) => e.Joules / 1.602176634e-13;
    public static double ToGigaelectronvolts(this Energy e) => e.Joules / 1.602176634e-10;
    public static double ToErgs(this Energy e) => e.Joules / 1e-7;
    public static double ToCaloriesThermo(this Energy e) => e.Joules / 4.184;
    public static double ToCaloriesIT(this Energy e) => e.Joules / 4.1868;
    public static double ToKilocalories(this Energy e) => e.Joules / 4_184.0;
    public static double ToTonsOfTNT(this Energy e) => e.Joules / 4_184_000_000.0;
}
