using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;

namespace Monopoly.TrofimovAS.InventoryControl.Tests.Models;
public class PalletTests
{
    [Test]
    public void CalculateExpirationDate_MinimumBoxExpirationDate()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));

        var box1 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("21.06.2023"));
        var box2 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("22.06.2023"));
        var box3 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("23.06.2023"),null);

        pallet.Boxes.Add(box1); 
        pallet.Boxes.Add(box2);
        pallet.Boxes.Add(box3);

        Assert.True(pallet.ExpirationDate == DateTime.Parse("23.06.2023"));
    }

    [Test]
    public void CalculateVolumeDate_SumVolumeBoxesPlusPalletVolume()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));

        var box1 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("21.06.2023"));
        var box2 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("22.06.2023"));
        var box3 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("23.06.2023"), null);

        pallet.Boxes.Add(box1);
        pallet.Boxes.Add(box2);
        pallet.Boxes.Add(box3);

        var actual = pallet.Dimensions.Volume;
        foreach (var box in pallet.Boxes) 
        {
            actual += box.Dimensions.Volume;
        }
        Assert.True(pallet.SummaryVolume == actual);
    }

    [Test]
    public void CalculateWeightDate_SumWeightBoxesPlusPalletVolume()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));

        var box1 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("21.06.2023"));
        var box2 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("22.06.2023"));
        var box3 = new Box(new Dimensions(10, 10, 10), 10, DateTime.Parse("23.06.2023"), null);

        var actual = 30.0d;
        foreach (var box in pallet.Boxes)
        {
            actual += box.Weight;
        }
        Assert.True(pallet.Weight == actual);
    }
}