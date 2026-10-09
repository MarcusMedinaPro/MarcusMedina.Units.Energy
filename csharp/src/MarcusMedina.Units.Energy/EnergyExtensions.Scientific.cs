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
    extension(int v)
    {
        /// <summary>1 eV = 1.602176634e-19 J (exakt, SI 2019)</summary>
        public Energy Electronvolts() => new(v * 1.602176634e-19);
        public Energy Kiloelectronvolts() => new(v * 1.602176634e-16);
        public Energy Megaelectronvolts() => new(v * 1.602176634e-13);
        public Energy Gigaelectronvolts() => new(v * 1.602176634e-10);
        /// <summary>1 erg (CGS) = 1e-7 J</summary>
        public Energy Ergs() => new(v * 1e-7);
        /// <summary>1 termokemisk kalori = 4.184 J</summary>
        public Energy CaloriesThermo() => new(v * 4.184);
        /// <summary>1 International Table kalori = 4.1868 J</summary>
        public Energy CaloriesIT() => new(v * 4.1868);
        /// <summary>1 kcal = 4 184 J</summary>
        public Energy Kilocalories() => new(v * 4_184.0);
        /// <summary>1 ton TNT = 4.184 GJ</summary>
        public Energy TonsOfTNT() => new(v * 4_184_000_000.0);
    }

    extension(double v)
    {
        public Energy Electronvolts() => new(v * 1.602176634e-19);
        public Energy Kiloelectronvolts() => new(v * 1.602176634e-16);
        public Energy Megaelectronvolts() => new(v * 1.602176634e-13);
        public Energy Gigaelectronvolts() => new(v * 1.602176634e-10);
        public Energy Ergs() => new(v * 1e-7);
        public Energy CaloriesThermo() => new(v * 4.184);
        public Energy CaloriesIT() => new(v * 4.1868);
        public Energy Kilocalories() => new(v * 4_184.0);
        public Energy TonsOfTNT() => new(v * 4_184_000_000.0);
    }

    extension(Energy e)
    {
        public double ToElectronvolts() => e.Joules / 1.602176634e-19;
        public double ToKiloelectronvolts() => e.Joules / 1.602176634e-16;
        public double ToMegaelectronvolts() => e.Joules / 1.602176634e-13;
        public double ToGigaelectronvolts() => e.Joules / 1.602176634e-10;
        public double ToErgs() => e.Joules / 1e-7;
        public double ToCaloriesThermo() => e.Joules / 4.184;
        public double ToCaloriesIT() => e.Joules / 4.1868;
        public double ToKilocalories() => e.Joules / 4_184.0;
        public double ToTonsOfTNT() => e.Joules / 4_184_000_000.0;
    }
}
