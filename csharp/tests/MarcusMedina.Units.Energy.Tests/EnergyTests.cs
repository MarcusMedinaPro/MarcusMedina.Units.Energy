using MarcusMedina.Units.Energy;
using MarcusMedina.Units.Energy.Metric;
using MarcusMedina.Units.Energy.Scientific;
using MarcusMedina.Units.Energy.US;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Energy.Tests;

public class EnergyStructTests
{
    [Fact] public void Energy_StoresJoules() => new Energy(100).Joules.Should().Be(100);
    [Fact] public void Energy_Addition() => (new Energy(100) + new Energy(50)).Joules.Should().Be(150);
    [Fact] public void Energy_Subtraction() => (new Energy(100) - new Energy(30)).Joules.Should().Be(70);
    [Fact] public void Energy_Multiplication() => (new Energy(100) * 3).Joules.Should().Be(300);
    [Fact] public void Energy_Division() => (new Energy(100) / 4).Joules.Should().Be(25);
    [Fact] public void Energy_Comparison() => new Energy(100).Should().BeGreaterThan(new Energy(50));
}

public class MetricEnergyTests
{
    [Fact] public void Joules_RoundTrip() => 42.0.Joules().ToJoules().Should().BeApproximately(42, 1e-9);
    [Fact] public void Kilowatthour_ToJoules() => 1.Kilowatthours().ToJoules().Should().BeApproximately(3_600_000, 1e-3);
    [Fact] public void Megajoules_ToKilojoules() => 1.Megajoules().ToKilojoules().Should().BeApproximately(1000, 1e-6);
    [Fact] public void Millijoules_ToJoules() => 500.Millijoules().ToJoules().Should().BeApproximately(0.5, 1e-9);
    [Fact] public void Watthours_ToKilojoules() => 1.Watthours().ToKilojoules().Should().BeApproximately(3.6, 1e-9);
    [Fact] public void Terajoules_ToGigajoules() => 1.Terajoules().ToGigajoules().Should().BeApproximately(1000, 1e-6);
}

public class ScientificEnergyTests
{
    [Fact] public void Electronvolt_ToJoules() => 1.0.Electronvolts().Joules.Should().BeApproximately(1.602176634e-19, 1e-30);
    [Fact] public void Megaelectronvolt_ToJoules() => 1.0.Megaelectronvolts().Joules.Should().BeApproximately(1.602176634e-13, 1e-24);
    [Fact] public void Erg_ToJoules() => 1.0.Ergs().Joules.Should().BeApproximately(1e-7, 1e-18);
    [Fact] public void Kilocalorie_ToKilojoules() => 1.Kilocalories().ToKilojoules().Should().BeApproximately(4.184, 1e-6);
    [Fact] public void CalorieThermo_ToJoules() => 1.0.CaloriesThermo().ToJoules().Should().BeApproximately(4.184, 1e-6);
    [Fact] public void TonOfTNT_ToGigajoules() => 1.TonsOfTNT().ToGigajoules().Should().BeApproximately(4.184, 1e-6);
}

public class USEnergyTests
{
    [Fact] public void BTU_ToJoules() => 1.0.BTUs().ToJoules().Should().BeApproximately(1055.05585262, 1e-6);
    [Fact] public void FootPound_ToJoules() => 1.0.FootPounds().ToJoules().Should().BeApproximately(1.3558179483, 1e-9);
    [Fact] public void Therm_ToMegajoules() => 1.Therms().ToMegajoules().Should().BeApproximately(105.4804, 1e-3);
}

public class CrossSystemEnergyTests
{
    [Fact] public void Kilocalorie_ToBTU() => 1.Kilocalories().ToBTUs().Should().BeApproximately(3.96567, 1e-4);
    [Fact] public void KiloWatthour_ToMegajoules() => 1.Kilowatthours().ToMegajoules().Should().BeApproximately(3.6, 1e-9);
}
