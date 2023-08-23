namespace GildedRoseTests;

using FluentAssertions;
using GildedRoseKata;
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
        var gildedRose = new GildedRose(new[]
        {
            item
        });
        
        gildedRose.UpdateQuality();

        item.Quality.Should().Be(4);
        item.SellIn.Should().Be(4);
    }
}