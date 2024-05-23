using GildedRose;

namespace GildedRoseTests;

using FluentAssertions;
using Xunit;

public class GildedRoseTest
{
    [Fact]
    public void AgedBrieShouldAgeAndUgradesQuality()
    {
        var item = new Item()
        {
            Name = "Aged Brie",
            Quality = 3,
            SellIn = 5
        };
        var gildedRose = new GildedRose.GildedRose(new[]
        {
            item
        });
        
        gildedRose.UpdateQuality();

        item.Quality.Should().Be(4);
        item.SellIn.Should().Be(4);
    }
}