using Xunit;
using Trojkat.Services;

namespace Trojkat.UnitTests.Services
{
public class TrojkatLiczTests
{
    [Fact]
    public void Trojkat_Spr_ValidSides_ReturnsTrue()
    {
        // wartości do testów
        double bokA = 3.0;
        double bokB = 4.0;
        double bokC = 2.0;

        bool result = TrojkatLicz.Trojkat_Spr(bokA, bokB, bokC);

        // klasa Assert
        Assert.True(result,"Z podanych wartości uda się stworzyć trójkąt");
    }

    [Fact]
    public void Trojkat_Spr_InvalidSides_ReturnsFalse()
    {
        // wartości do testów
        double bokA = 1.0;
        double bokB = 2.0;
        double bokC = 4.0;

        bool result = TrojkatLicz.Trojkat_Spr(bokA, bokB, bokC);

        // klasa Assert
        Assert.False(result, "Z podanych wartości nie wyjdzie trójkąt");
    }

    [Fact]
    public void Trojkat_Spr_NegativeSides_ReturnsFalse()
    {
        // wartości do testów
        double bokA = -6.0;
        double bokB = 1.0;
        double bokC = 4.0;

        bool result = TrojkatLicz.Trojkat_Spr(bokA, bokB, bokC);

        // klasa Assert
        Assert.False(result, "Z podanych wartości nie wyjdzie trójkąt");
    }
    
}
}